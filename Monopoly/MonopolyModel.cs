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

        private List<Speler> spelers;           // een lijst van alle spelers

        public MonopolyModel()
        {
            steen1 = new Dobbelsteen();
            steen2 = new Dobbelsteen();
            bordVakjes = new Vakjes();
            spelers = new List<Speler>();
        }

        public List<Speler> Spelers
        {
            get { return spelers; }
        }
        public Vakjes Vakjes
        {
            get { return bordVakjes; }
        }
    }
}
