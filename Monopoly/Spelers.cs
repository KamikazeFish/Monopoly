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
            this.currentIndex = 0;
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
            this.spelers.OrderBy(item => rnd.Next());
        }

        public void Add(Speler speler) 
        {
            this.spelers.Add(speler);
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
    }
}
