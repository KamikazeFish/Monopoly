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

        private Vakjes bordVakjes;              // een aparte klasse die alle vakjes beheert.

        private Spelers spelers;           // een lijst van alle spelers
        private Speler actieveSpeler;

        private AlgemeenFondsKaarten algemeenFondsKaarten;

        private KansKaarten kansKaarten;

        public MonopolyModel()
        {
            steen1 = new Dobbelsteen();
            steen2 = new Dobbelsteen();
            bordVakjes = new Vakjes();
            spelers = new Spelers();
            algemeenFondsKaarten = new AlgemeenFondsKaarten();
            kansKaarten = new KansKaarten();
        }

        public Spelers Spelers
        {
            get { return spelers; }
        }
        public Vakjes Vakjes
        {
            get { return bordVakjes; }
        }

        public Speler ActieveSpeler { get { return actieveSpeler; } set { this.actieveSpeler = value; } }
    }
}
