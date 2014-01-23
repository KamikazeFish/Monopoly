using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    /**
     * kaarten en vakjes kunnen acties hebben, deze actie worden dan uitgevoerd als de speler een kaart pakt of op een vakje komt.
     */
    public abstract class Actie
    {
        public abstract void VoerUit(MonopolyModel model, MonopolyView view);
    }

    public class LegeActie : Actie
    {
        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            // niks te doen
        }
    }

    public class BetaalOntvangActie : Actie
    {
        // de huidige speler krijgt een bedrag of moet dit betalen.
        // bedrag kan dus ook negatief zijn
        private int bedrag;

        public BetaalOntvangActie(int bedrag)
        {
            this.bedrag = bedrag;
        }

        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            model.Spelers.HuidigeSpeler.KrijgInkomsten(bedrag);
            if (bedrag > 0)
            {
                view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' ontvangt ƒ" + bedrag);
            }
            else
            {
                view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' betaalt ƒ" + -bedrag);
            }
        }
    }

    public class PakKansKaartActie : Actie
    {
        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            Kaart kaart = model.KansKaarten.PakKaart();
            if (kaart.Bewaren)
            {
                model.Spelers.HuidigeSpeler.AddKaart(kaart);

                view.AddMessageToLog( "Speler '" + model.Spelers.HuidigeSpeler.Naam + "' pakt de kans kaart '" + kaart.ToString() + "' en bewaart deze." );
            }
            else
            {
                view.AddMessageToLog( "Speler '" + model.Spelers.HuidigeSpeler.Naam + "' pakt de kans kaart '" + kaart.ToString() );
                kaart.Actie.VoerUit(model, view);
            }
        }
    }

    public class PakAlgemeenFondsKaartActie : Actie
    {
        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            Kaart kaart = model.AlgemeenFondsKaarten.PakKaart();
            if (kaart.Bewaren)
            {
                model.Spelers.HuidigeSpeler.AddKaart(kaart);

                view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' pakt de algemeenfonds kaart '" + kaart.ToString() + "' en bewaart deze.");
            }
            else
            {
                view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' pakt de algemeenfonds kaart '" + kaart.ToString() + "'");
                kaart.Actie.VoerUit(model, view);
            }
        }
    }

    // speler land op een 'normaal' vakje.
    public class LandingsActie : Actie
    {
        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            // is het vakje van een andere speler? betalen!
            Vakje landingsVakje = model.Vakjes[model.Spelers.HuidigeSpeler.Positie];
            if (landingsVakje.Eigenaar != null)
            {
                int kosten = model.Vakjes.GetBezoekerPrijs(model.Spelers.HuidigeSpeler);
                model.Spelers.HuidigeSpeler.DoeUitgave(kosten);
                landingsVakje.Eigenaar.KrijgInkomsten(kosten);

                // en log die actie
                view.AddMessageToLog("Speler '" + landingsVakje.Eigenaar.Naam + "' krijgt ƒ" + kosten + " van speler '" + model.Spelers.HuidigeSpeler.Naam + "'");
            }

        }
    }

    // inkomstenbelasting is een apart geval, heeft eigen actie
    public class BelastingActie: Actie
    {
        private string naam;
        private int bedrag;

        public BelastingActie(string naam, int bedrag)
        {
            this.naam = naam;
            this.bedrag = bedrag;
        }

        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            int bedrag = 200;
            model.Spelers.HuidigeSpeler.KrijgInkomsten(-bedrag);
            view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' betaalt ƒ" + bedrag + " aan " + naam);
        }
    }

    // nutsbedrijf: 4x of 10x het aantal gegooide ogen aan huur
    public class NutsBedrijfActie : Actie
    {
        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            Vakje landingsVakje = model.Vakjes[model.Spelers.HuidigeSpeler.Positie];
            if (landingsVakje.Eigenaar != null)
            {
                int gegooid = (model.Steen1.LaatsteWaarde + model.Steen2.LaatsteWaarde);
                int kosten = model.Vakjes.GetBezoekerPrijs(model.Spelers.HuidigeSpeler);
                int huur = gegooid * kosten;

                model.Spelers.HuidigeSpeler.DoeUitgave(huur);
                landingsVakje.Eigenaar.KrijgInkomsten(huur);

                // en log die actie
                view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' gooide " + gegooid + " dus de huur is " + gegooid + " keer ƒ" + kosten + " = ƒ" + huur);
                view.AddMessageToLog("Speler '" + landingsVakje.Eigenaar.Naam + "' krijgt ƒ" + huur + " van speler '" + model.Spelers.HuidigeSpeler.Naam + "'");
            }
        }
    }

    // speler betaal x per huis en x per hotel
    public class BetaalOntvangPerHuisHotelActie : Actie
    {
        private int perHuis;
        private int perHotel;

        public BetaalOntvangPerHuisHotelActie(int perHuis, int perHotel)
        {
            this.perHuis = perHuis;
            this.perHotel = perHotel;
        }

        public override void VoerUit(MonopolyModel model, MonopolyView view) 
        {
            int huizen = model.Vakjes.GetAantalHuizenVan(model.Spelers.HuidigeSpeler);
            int hotels = model.Vakjes.GetAantalHotelsVan(model.Spelers.HuidigeSpeler);

            int bedrag = huizen * perHuis + hotels * perHotel;
            model.Spelers.HuidigeSpeler.DoeUitgave( bedrag );

            view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + " heeft " + huizen + " huizen en " + hotels + " hotels, dus betaalt ƒ" + bedrag);
        }
    }

    public class GaNaarActie : Actie
    {
        private string naam;
        private bool geldVoorLangsStart;

        public GaNaarActie(string naam, bool geldVoorLangsStart)
        {
            this.naam = naam;
            this.geldVoorLangsStart = geldVoorLangsStart;
        }

        public override void VoerUit(MonopolyModel model, MonopolyView view) 
        {
            int notFound = 0;

            do
            {
                model.VerplaatsHuidigeSpeler(1);
                if (geldVoorLangsStart && model.Spelers.HuidigeSpeler.Positie == 0)
                {
                    // speler ging langs start, krijgt knaken.
                    int bedrag = 200;
                    model.Spelers.HuidigeSpeler.KrijgInkomsten(bedrag);

                    view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + " ging langs start en ontvangt ƒ" + bedrag);
                }

                // controleer op niet gevonden vakje.
                notFound++;
                if (notFound > model.Vakjes.GetAantalVakjes())
                {
                    throw new Exception("Vakje '" + naam + "' niet gevonden!");
                }
            } while (model.Vakjes[model.Spelers.HuidigeSpeler.Positie].StraatNaam != naam);

            // vanuit deze actie, voer de landingsactie voor het vakje uit.
            //
            Actie ac = model.Vakjes[model.Spelers.HuidigeSpeler.Positie].LandingsActie;
            if (ac != null)
                ac.VoerUit(model, view);
        }
    }

    //public class GooiActie : Actie
    //{
    //    public GooiActie(string tekst = "De volgende speler mag gooien")
    //    {
    //    }

    //    public override void VoerUit(MonopolyModel model) 
    //    {

    //    }
    //}

    //public class BetaalOntvangPerHuisHotelActie : Actie
    //{
    //    public BetaalOntvangPerHuisHotelActie(string tekst) : base(tekst)
    //    {
    //    }

    //    public override void VoerUit(MonopolyModel model) 
    //    {

    //    }
    //}

    //public class GaNaarActie : Actie
    //{
    //    public GaNaarActie(string tekst) : base(tekst)
    //    {
    //    }

    //    public override void VoerUit(MonopolyModel model) 
    //    {

    //    }
    //}

    //public class VerlaatDeGevangenisActie : Actie
    //{
    //    public VerlaatDeGevangenisActie(string tekst)
    //        : base(tekst)
    //    {
    //    }

    //    public override void VoerUit(MonopolyModel model) 
    //    {

    //    }
    //}

    //public class KeuzeActie : Actie
    //{
    //    Actie actie1;
    //    Actie actie2;
    //    string vraag;

    //    public KeuzeActie(string tekst, string vraag, Actie actie1, Actie actie2)
    //        : base(tekst)
    //    {
    //        this.actie1 = actie1;
    //        this.actie2 = actie2;
    //        this.vraag = vraag;
    //    }

    //    public override void VoerUit(MonopolyModel model) 
    //    {
    //        // TODO: Custom dialog maken om meteen actie 1 of actie 2 te kunnen selecteren. (of andere buttons)
    //        DialogResult result = MessageBox.Show(this.vraag, "Wat wilt u doen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    //        if (result == DialogResult.Yes)
    //        {
    //            this.actie1.VoerUit(model);
    //        }
    //        else //if( result == DialogResult.No) // Als de dialoogbox weggedrukt wordt altijd actie 2 uitvoeren
    //        {
    //            this.actie2.VoerUit(model);
    //        }

    //    }
    //}
}
