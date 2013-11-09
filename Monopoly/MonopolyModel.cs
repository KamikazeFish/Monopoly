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
    class MonopolyModel
    {
        private Dobbelsteen steen1;
        private Dobbelsteen steen2;
        private Vakjes bordVakjes;

        public MonopolyModel()
        {
            steen1 = new Dobbelsteen();
            steen2 = new Dobbelsteen();
            bordVakjes = new Vakjes();
        }
    }
}
