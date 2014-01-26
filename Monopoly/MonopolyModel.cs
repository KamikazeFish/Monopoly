using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    // Deze klasse is het 'model' uit het MVC design pattern.
    // Het bevat alle 'state' binnen een monopolyspel,
    // dat betekent alle gegevens, een soort van database voor het spel.
    //
    public class MonopolyModel
    {
        private Dobbelsteen steen1;

        private Dobbelsteen steen2;

        private bool huidigeSpelerMagGooien;    // true als de huidige speler nog mag gooien, anders false
        
        private bool nieuweBeurt;               // Nodig omdat een speler zijn huidige vakje niet mag kopen als hij nog moet gooien

        private Vakjes bordVakjes;              // een aparte klasse die alle vakjes beheert.

        private Spelers spelers;           // een lijst van alle spelers

        private AlgemeenFondsKaarten algemeenFondsKaarten;

        private KansKaarten kansKaarten;

        public MonopolyModel()
        {
            steen1 = new Dobbelsteen();
            steen2 = new Dobbelsteen();
            huidigeSpelerMagGooien = true;
            bordVakjes = new Vakjes();
            spelers = new Spelers();
            algemeenFondsKaarten = new AlgemeenFondsKaarten();
            kansKaarten = new KansKaarten();
        }

        public Vakjes Vakjes
        {
            get { return bordVakjes; }
        }
        public Dobbelsteen Steen1
        {
            get { return steen1; }
        }
        public Dobbelsteen Steen2
        {
            get { return steen2; }
        }
        public bool HuidigeSpelerMagGooien 
        {
            get { return huidigeSpelerMagGooien; }
            set { huidigeSpelerMagGooien = value; }
        }
        public bool NieuweBeurt 
        {
            get { return nieuweBeurt; }
            set { nieuweBeurt = value; }
        }
        public AlgemeenFondsKaarten AlgemeenFondsKaarten { get { return algemeenFondsKaarten; } }
        public KansKaarten KansKaarten { get { return kansKaarten; } }

        // spelers code

        public Spelers Spelers
        {
            get { return spelers; }
        }

        public void VerplaatsHuidigeSpeler(int verschil)
        {
            spelers.HuidigeSpeler.Positie += verschil;
            while (spelers.HuidigeSpeler.Positie < 0)
            {
                spelers.HuidigeSpeler.Positie += Vakjes.GetAantalVakjes();
            }
            while (spelers.HuidigeSpeler.Positie >= Vakjes.GetAantalVakjes())
            {
                spelers.HuidigeSpeler.Positie -= Vakjes.GetAantalVakjes();
            }
        }

        public bool HuidigVakjeIsKoopbaar() 
        { // Is het vakje waar de huidige speler op staat van niemand?
            Vakje huidigeVakje = bordVakjes[spelers.HuidigeSpeler.Positie];
            return (huidigeVakje.Eigenaar == null &&
                (huidigeVakje.Vaktype == Vakje.VakType.STRAAT || huidigeVakje.Vaktype == Vakje.VakType.STATION || huidigeVakje.Vaktype == Vakje.VakType.NUTSBEDRIJF ));
        }

        public List<string> GetStraatnamenVolledigeStedenHuidigeSpeler()
        {
            List<string> straatnamen = new List<string>();

            List<Vakje> stedenHuidigeSpeler = Vakjes.GetStratenVolledigeStedenVan(spelers.HuidigeSpeler);

            foreach (Vakje vakje in stedenHuidigeSpeler)
	        {
                straatnamen.Add(vakje.StraatNaam);
	        }

            return straatnamen;
        }
    }
}
