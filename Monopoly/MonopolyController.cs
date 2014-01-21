using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

// 1> Knopjes:
//
// - koop vakje
// - koop huis op: <dropdown>
// - gooi
// - einde beurt.
// 
// 2> Kaartje: 
// - we gaan de vakjes naar subklasses uitsplitsen.
// 
// 3> Designbeslissingen:
// - De controller krijgt alle logica en eventuele foutmeldingen en vragen.
// -

// Gamestates
// 1. Speler komt aan beurt
// 2. Speler gooit
// 3. Speler wordt verzet --> actie: speler verzetten
// 4. Speler komt op een vakje --> actie van vakje wordt afgehandeld
// 5. Speler kan huizen kopen
//
// Alternatief: in de gevangenis
// 1a. Speler komt aan beurt
// 2a. Speler gooit
// 3a. Speler gooit dubbel --> 
//        (quote wikipedia: Door dubbel te gooien. Hij speelt dan meteen het aantal ogen van de worp. Hierna mag hij nog een keer gooien (zoals normaal bij een dubbele worp).)
// 4a. Normale flow vanaf 4
// 
// 3b. Speler gooit niet dubbel
// 4b. Check of speler al 3 beurten in de gevangenis zit --> Als dat zo is verplicht betalen
//
// 4c. Speler betaald of levert de verlaat de gevangenis kaart in.


namespace Monopoly
{
    // in deze klasse gaan we de business logic implementeren..
    //
    class MonopolyController
    {
        // enkele definities
        private const int beginSaldo = 1500;
        private List<Color> beschikbareKleuren = new List<Color>
        {
            Color.Blue,
            Color.Red,
            Color.Green,
            Color.Yellow
        };

        MonopolyModel model;
        MonopolyView view;

        public MonopolyController(MonopolyModel model, MonopolyView view)
        {
            this.model = model;
            this.view = view;
        }

        // business logic

        public void StartNewSpel()
        {
            // voorlopig voegen we hardcoded twee spelers toe...
            // todo: een dialoog die de aantallen en namen vraagt.
            //
            model.Spelers.Clear();
            model.Spelers.Add(new Speler("Pieter", beginSaldo, this.PickColor()));
            model.Spelers.Add(new Speler("Ilja", beginSaldo, this.PickColor()));

            model.HuidigeSpelerMagGooien = true;
            view.AddMessageToLog( "Nieuw spel gestart met " + model.Spelers.GetAantalSpelers() + " spelers.");
            view.Refresh();
        }

        public void HuidigeSpelerkliktOpGooi()
        {
            // Opmerkingen: 
            /*
             *  - Als een speler OVER start komt krijgt hij geld
             *  - De actie van een vakje veranderd als iemand een vakje koopt
             */

            // 1> gooi de stenen
            model.Steen1.Gooi();
            model.Steen2.Gooi();

            // definieer dit in het project om te kunnen testen;
            // Je vindt dit onder:
            // Rechtsklik Monopoly( het project )
            // properties->Build -> Conditional Compilation symbols.
            // Vul daar in GOOI_ALTIJD_1 om de dobbelsteen op 1 te zetten
#if GOOI_ALTIJD_1
            model.Steen1.LaatsteWaarde = 1;
            model.Steen2.LaatsteWaarde = 0;

#endif


            // hoeveel is er gegooid?
            int gegooidTotaal = model.Steen1.LaatsteWaarde + model.Steen2.LaatsteWaarde;

            // log de gooi
            view.AddMessageToLog("Speler " + model.Spelers.HuidigeSpeler.Naam +
                                 " gooit " + model.Steen1.LaatsteWaarde + " en " + model.Steen2.LaatsteWaarde + "  (=" + gegooidTotaal + ")");

            // verschuif de speler
            model.VerplaatsHuidigeSpeler(gegooidTotaal);

            // log de verschuiving
            view.AddMessageToLog("Speler " + model.Spelers.HuidigeSpeler.Naam +
                                 " land op vakje '" + model.Vakjes[model.Spelers.HuidigeSpeler.Positie].ToString() + "'");

            // haal de actie van het huidige vakje op en voer die uit.
            Actie ac = model.Vakjes[ model.Spelers.HuidigeSpeler.Positie ].LandingsActie;
            if (ac != null)
            {
                ac.VoerUit(model, view);
            }

            // is het vakje van een andere speler? betalen!
            Vakje landingsVakje = model.Vakjes[model.Spelers.HuidigeSpeler.Positie];
            if (landingsVakje.Eigenaar != null)
            {
                int kosten = landingsVakje.LandingsKosten();
                model.Spelers.HuidigeSpeler.DoeUitgave(kosten);
                landingsVakje.Eigenaar.KrijgInkomsten(kosten);

                // en log die actie
                view.AddMessageToLog("Speler '" + landingsVakje.Eigenaar.Naam + "' krijgt ƒ" + kosten + " van speler '" + model.Spelers.HuidigeSpeler.Naam + "'");
            }


            // huidige speler mag opnieuw gooien indien hij dubbel gooide
            if (model.Steen1.LaatsteWaarde != model.Steen2.LaatsteWaarde)
            {
                model.HuidigeSpelerMagGooien = false;
            }
            else
            {
                // speler mag nog een keer gooien
                view.AddMessageToLog("Speler " + model.Spelers.HuidigeSpeler.Naam + " gooide dubbel en mag nog eens gooien.");
            }

            // geef het view een schop
            view.Refresh();

        }

        public void HuidigeSpelerKliktOpKoopHuidigVakje()
        {
            Vakje huidigeVakje = model.Vakjes[model.Spelers.HuidigeSpeler.Positie];
            if (huidigeVakje.Eigenaar == null)
            {
                if (model.Spelers.HuidigeSpeler.Saldo >= huidigeVakje.Waarde)
                {
                    if (model.Spelers.HuidigeSpeler.DoeUitgave(huidigeVakje.Waarde))
                    {
                        huidigeVakje.Eigenaar = model.Spelers.HuidigeSpeler;
                        view.AddMessageToLog("Speler " + model.Spelers.HuidigeSpeler.Naam +
                                             " koopt " + huidigeVakje.StraatNaam +
                                             " voor ƒ" + huidigeVakje.Waarde );
                    }
                    view.Refresh(); 
                }
            }
        }

        public void HuidigeSpelerKliktOpKoopHuisHotel(string straatnaam)
        {
            if (straatnaam != string.Empty)
            {
                Vakje straat = model.Vakjes.GetVakjeMetStraatnaam(straatnaam);

                if (model.Spelers.HuidigeSpeler.Saldo >= straat.PrijsPerHuis)
                {
                    if (straat.AddHuis())
                    {
                        model.Spelers.HuidigeSpeler.DoeUitgave(straat.PrijsPerHuis);
                        string huisOfHotel = straat.AantalHuizen == 5 ? "1 hotel" : straat.AantalHuizen == 1 ? "1 huis" : straat.AantalHuizen + " huizen";
                        view.AddMessageToLog("Speler " + model.Spelers.HuidigeSpeler.Naam +
                                                " koopt 1 huis en heeft nu op " + straat.StraatNaam + " " + huisOfHotel);

                    }
                    else
                    {
                        // !--- AANPASSEN geen viewcode in de controller ---! //
                        if (straat.AantalHuizen == 5)
                        {
                            System.Windows.Forms.MessageBox.Show("De straat heeft al een hotel en kan niet meer uitgebreid worden.");
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Op de straat kunnen geen huizen gebouwd worden!");
                        }
                    }
                }
            }

            view.Refresh();
        }

        public void HuidigeSpelerKliktOpEindeBeurt()
        {
            // verhoog spelerindex
            model.Spelers.Volgende();

            // reset 'speler mag gooien'
            model.HuidigeSpelerMagGooien = true;

            // ververs het view
            view.Refresh();
        }

        private Color PickColor()
        {
            Random rnd = new Random();
            Color kleur = this.beschikbareKleuren[rnd.Next(0, this.beschikbareKleuren.Count - 1)];
            this.beschikbareKleuren.Remove(kleur);
            return kleur;
        }
    }
}
