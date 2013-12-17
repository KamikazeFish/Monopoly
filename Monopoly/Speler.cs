using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Speler
    {
        private string naam;        // hoe heet deze speler?
        private int saldo;          // hoeveel geld heeft deze speler?
        private int positie;        // wat is de huidige positie van de speler
        private System.Drawing.Color kleur;
        private List<Kaart> kaarten; // lijst van kaarten in bezit (bv. get out of jail-kaart)

        public Speler(string naam, int saldo, System.Drawing.Color kleur, int positie = 0)
        {
            this.naam = naam;
            this.saldo = saldo;
            this.positie = positie;
            this.kleur = kleur;
        }

        public string Naam
        {
            get { return naam; }
        }

        public int Saldo
        {
            get { return saldo; }
        }

        public System.Drawing.Color Kleur
        {
            get { return kleur; }
        }

        public int Positie
        {
            get { return positie; }
            set { positie = value; }
        }

        public List<Kaart> Kaarten { get { return kaarten; } }

        public void AddKaart(Kaart krt)
        {
            kaarten.Add(krt);
        }

        public override string ToString()
        {
            return Naam + " " + "( ƒ" + Saldo + " )";
        }
    }
}
