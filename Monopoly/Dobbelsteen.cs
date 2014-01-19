using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    // class Dobbelsteen
    // Gebruik:
    // - Maak een object van het type Dobbelsteen aan
    // - Roep Gooi() aan voor een nieuwe waarde.
    // - LaatsteWaarde retourneert de worp.
    public class Dobbelsteen
    {
        static Random rnd = new Random();
        private int laatsteWaarde;

        public Dobbelsteen()
        {
 
            // gooi 1x voor initialisatie, anders
            // kan een gebruiker er eentje aanmaken en direct
            // LaatsteWaarde aanspreken
            Gooi();
        }

        public int Gooi()
        {
            laatsteWaarde = rnd.Next(1, 7);
            return LaatsteWaarde;
        }

        public int LaatsteWaarde
        {
            get { return laatsteWaarde; }
            set { laatsteWaarde = value; }
        }
    }
}
