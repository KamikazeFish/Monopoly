using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Monopoly
{
 
    // de basisklasse voor AlgemeenFondsKaarten en KansKaarten
    //
    public class Kaarten
    {
        private List<Kaart> kaarten;

        public Kaarten()
        {
            kaarten = new List<Kaart>();
        }

        protected void VoegToe(Kaart krt)
        {
            kaarten.Add(krt);
        }

        // schud alle kaarten door elkaar, anders krijgen we
        // iedere keer dezelfde volgorde.
        protected void SchudKaarten()
        {
            Random rnd = new Random();
            List<Kaart> kaartenGeschud = new List<Kaart>();

            // trek een willekeurige kaart uit kaarten, en stop die
            // in kaartenGeschud totdat kaarten leeg is.
            while (kaarten.Count > 0)
            {
                int index = rnd.Next( kaarten.Count );
                kaartenGeschud.Add( kaarten[index] );
                kaarten.RemoveAt(index);
            }

            kaarten = kaartenGeschud;
        }

        public Kaart PakKaart()
        {
            //Kaart eersteKaart = kaarten.First();
            //kaarten.Remove(eersteKaart);

            return null;// eersteKaart;
        }
    }
  
    // Kanskaarten: een van de twee stapels kaarten in het spel.
    //
    public class KansKaarten : Kaarten
    {
        // De teksten van de kanskaarten, in de versie voor Nederland met de oorspronkelijke bedragen in guldens:
        //
        // Boete voor te snel rijden ƒ 15
        // Betaal schoolgeld ƒ 150
        // Ga verder naar Barteljorisstraat. Indien u langs "Start" komt, ontvangt u ƒ 200
        // Reis naar station "West" en indien u langs "Start" komt, ontvangt u ƒ 200
        // Ga verder naar "Start"
        // Ga drie plaatsen terug
        // Ga direct naar de gevangenis. Ga niet langs "Start". U ontvangt geen ƒ 200
        // Ga verder naar de Herestraat. Indien u langs "Start" komt ontvangt u ƒ 200
        // De bank betaalt u ƒ 50 dividend
        // Verlaat de gevangenis zonder te betalen
        // Repareer uw huizen. Betaal voor elk huis ƒ 25, betaal voor elk hotel ƒ 100
        // U wordt aangeslagen voor straatgeld. ƒ 40 per huis, ƒ 115 per hotel
        // Uw bouwverzekering vervalt, u ontvangt ƒ 150
        // Aangehouden wegens dronkenschap ƒ 20 boete
        // Ga verder naar Kalverstraat
        // U hebt een kruiswoordpuzzel gewonnen en ontvangt ƒ 100

        public KansKaarten()
        {
            /*VoegToe(new Kaart("Boete voor te snel rijden ƒ 15", -15));
            VoegToe(new BetaalOntvangKaart("Betaal schoolgeld ƒ 150", -150));
            VoegToe(new GaNaarKaart("Ga verder naar Barteljorisstraat. Indien u langs 'Start' komt, ontvangt u ƒ 200", new Vakje(Vakje.VakType.STRAAT, "Barteljorisstraat", "Haarlem", 140, Color.FromArgb(238, 68, 221)), true));
            VoegToe(new GaNaarKaart("Reis naar station 'West' en indien u langs 'Start' komt, ontvangt u ƒ 200", new Vakje(Vakje.VakType.STATION, "Station West", "", 200, Color.White), true));
            VoegToe(new GaNaarKaart("Ga verder naar 'Start'", new Vakje(Vakje.VakType.START, "Start", "", 0, Color.White), true));
            VoegToe(new GaNaarKaart("Ga drie plaatsen terug", 3, true, true));
            VoegToe(new GaNaarKaart("Ga direct naar de gevangenis. Ga niet langs 'Start'. U ontvangt geen ƒ 200", new Vakje(Vakje.VakType.GEVANGENIS, "Gevangenis", "", 0, Color.White), false));
            VoegToe(new GaNaarKaart("Ga verder naar de Heerestraat. Indien u langs 'Start' komt ontvangt u ƒ 200", new Vakje(Vakje.VakType.STRAAT, "Heerestraat", "Groningen", 160, Color.FromArgb(238, 68, 221)), true));
            VoegToe(new BetaalOntvangKaart("De bank betaalt u ƒ 50 dividend", +50));
            VoegToe(new VerlaatDeGevangenisKaart("Verlaat de gevangenis zonder te betalen"));
            VoegToe(new BetaalOntvangPerHuisHotel("Repareer uw huizen. Betaal voor elk huis ƒ 25, betaal voor elk hotel ƒ 100", -25, -100));
            VoegToe(new BetaalOntvangPerHuisHotel("U wordt aangeslagen voor straatgeld. ƒ 40 per huis, ƒ 115 per hotel", -40, -115));
            VoegToe(new BetaalOntvangKaart("Uw bouwverzekering vervalt, u ontvangt ƒ 150", +150));
            VoegToe(new BetaalOntvangKaart("Aangehouden wegens dronkenschap ƒ 20 boete", -20));
            VoegToe(new GaNaarKaart("Ga verder naar Kalverstraat", new Vakje(Vakje.VakType.STRAAT, "Kalverstraat", "Amsterdam", 400, Color.FromArgb(51, 51, 255)), true));
            VoegToe(new BetaalOntvangKaart("U hebt een kruiswoordpuzzel gewonnen en ontvangt ƒ 100", +100));
            */
            SchudKaarten();
        }
    }


    public class AlgemeenFondsKaarten : Kaarten
    {
        // De teksten van de Algemeen Fonds-kaarten, in de versie voor Nederland met de oorspronkelijke bedragen in guldens:
        //
        // U erft ƒ 100
        // U ontvangt rente van 7% preferente aandelen ƒ 25
        // Een vergissing van de bank in uw voordeel, u ontvangt ƒ 200
        // Ga terug naar Dorpsstraat (Ons Dorp)
        // Ga direct naar de gevangenis. Ga niet door "Start", u ontvangt geen ƒ 200
        // U bent jarig en ontvangt van iedere speler ƒ 10
        // U hebt de tweede prijs in een schoonheidswedstrijd gewonnen en ontvangt ƒ 10
        // Betaal uw doktersrekening ƒ 50
        // Betaal uw verzekeringspremie ƒ 50
        // Door verkoop van effecten ontvangt u ƒ 50
        // Verlaat de gevangenis zonder betalen
        // Restitutie inkomstenbelasting, u ontvangt ƒ 20
        // Lijfrente vervalt, u ontvangt ƒ 100
        // Betaal het hospitaal ƒ 100
        // Ga verder naar "Start"
        // Betaal ƒ 10 boete of neem een Kanskaart
        //
        public AlgemeenFondsKaarten()
        {/*
            VoegToe(new BetaalOntvangKaart("U erft ƒ 100", +100));
            VoegToe(new BetaalOntvangKaart("U ontvangt rente van 7% preferente aandelen ƒ 25", +25));
            VoegToe(new BetaalOntvangKaart("Een vergissing van de bank in uw voordeel, u ontvangt ƒ 200", +200));
            VoegToe(new GaNaarKaart("Ga terug naar Dorpsstraat (Ons Dorp)", new Vakje(Vakje.VakType.STRAAT, "Dorpsstraat", "Ons Dorp", 60, Color.FromArgb(153, 51, 153)), true, true));
            VoegToe(new GaNaarKaart("Ga direct naar de gevangenis. Ga niet door 'Start', u ontvangt geen ƒ 200", new Vakje(Vakje.VakType.GEVANGENIS, "Gevangenis", "", 0, Color.White), true));
            VoegToe(new BetaalOntvangKaart("U bent jarig en ontvangt van iedere speler ƒ 10", +10, BetaalOntvangKaart.Ontvanger.Tegenspelers));
            VoegToe(new BetaalOntvangKaart("U hebt de tweede prijs in een schoonheidswedstrijd gewonnen en ontvangt ƒ 10", +10));
            VoegToe(new BetaalOntvangKaart("Betaal uw doktersrekening ƒ 50", -50));
            VoegToe(new BetaalOntvangKaart("Betaal uw verzekeringspremie ƒ 50", -50));
            VoegToe(new BetaalOntvangKaart("Door verkoop van effecten ontvangt u ƒ 50", +50));
            VoegToe(new VerlaatDeGevangenisKaart("Verlaat de gevangenis zonder betalen"));
            VoegToe(new BetaalOntvangKaart("Restitutie inkomstenbelasting, u ontvangt ƒ 20", +20));
            VoegToe(new BetaalOntvangKaart("Lijfrente vervalt, u ontvangt ƒ 100", +100));
            VoegToe(new BetaalOntvangKaart("Betaal het hospitaal ƒ 100", +100));
            VoegToe(new GaNaarKaart("Ga verder naar 'Start'", new Vakje(Vakje.VakType.START, "Start", "", 0, Color.White), true));
            */ // Betaal ƒ 10 boete of neem een Kanskaart

            SchudKaarten();
        }
    }
}
