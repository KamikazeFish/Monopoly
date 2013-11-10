using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Speler
    {
        private string naam;        // hoe heet deze speler?
        private int saldo;          // heveel geld heeft deze speler?

        public Speler(string naam, int saldo)
        {
            this.naam = naam;
            this.saldo = saldo;
        }

        public string Naam
        {
            get { return naam; }
        }

        public int Saldo
        {
            get { return saldo; }
        }
    }
}
