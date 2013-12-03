using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Spelers
    {
        private List<Speler> spelers;
        private int currentIndex;

        public Spelers()
        {
            this.spelers = new List<Speler>();
            this.currentIndex = 0;
        }

        public int GetAantalSpelers()
        {
            return spelers.Count;
        }

        public Speler GetCurrent()
        {
            return this.spelers[this.currentIndex];
        }

        public void Next()
        {
            this.NextIndex();
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

        public void Add(Speler speler) 
        {
            if (speler != null)
            {
                this.spelers.Add(speler);
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

        private void NextIndex()
        {
            this.currentIndex++;
            if (this.currentIndex > (this.spelers.Count - 1) )
            {
                this.currentIndex = 0;
            }
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
