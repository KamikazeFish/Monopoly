﻿using System;
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
        Random rnd;
        private int laatsteWaarde;
        private static int seed = System.Environment.TickCount;

        public Dobbelsteen()
        {
            rnd = new Random(seed);
            seed += 94367;

            // gooi 1x voor initialisatie, anders
            // kan een gebruiker er eentje aanmaken en direct
            // LaatsteWaarde aanspreken
            Gooi();
        }

        public int Gooi()
        {
            laatsteWaarde = rnd.Next(1, 6);
            return LaatsteWaarde;
        }

        public int LaatsteWaarde
        {
            get { return laatsteWaarde; }
        }
    }
}
