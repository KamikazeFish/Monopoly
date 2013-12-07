using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Spelers
    {
        private List<Speler> spelers;
        private int spelerIndex;

        public Spelers()
        {
            this.spelers = new List<Speler>();
            this.spelerIndex = 0;
        }

        public int GetAantalSpelers()
        {
            return spelers.Count;
        }

        public Speler HuidigeSpeler
        {
            get
            {
                if (spelerIndex >= spelers.Count)
                    return null;
                return this.spelers[this.spelerIndex];
            }
        }

        public void Volgende()
        {
            spelerIndex++;
            if (this.spelerIndex > (this.spelers.Count - 1) )
            {
                this.spelerIndex = 0;
            }
        }

        /**
         *  Spelersvolgorde schudden
         */
        public void Shuffle()
        {
            Random rnd = new Random();
            List<Speler> tempSpelers = new List<Speler>();
            tempSpelers.AddRange(this.spelers);
            this.spelers.Clear();

            int n = tempSpelers.Count;
            for (int i = 0; i < n; i++)
			{
                Speler speler = tempSpelers[rnd.Next(0, tempSpelers.Count)];
                tempSpelers.Remove(speler);
                this.spelers.Add(speler);
			}
        }

        public void Add(Speler nieuweSpeler) 
        {
            if (nieuweSpeler != null)
            {
                this.spelers.Add(nieuweSpeler);
            }
        }

        public void Remove(Speler speler)
        {
            if( this.spelers.Contains(speler) )
            {
                this.spelers.Remove(speler);
            }
        }

        public void Clear()
        {
            this.spelers.Clear();
        }

        // overload operator []

        public Speler this[int i]
        {
            get
            {
                return spelers[i];
            }
            set
            {
                spelers[i] = value;
            }
        }

    }
}
