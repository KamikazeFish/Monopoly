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
        private bool uitgeschakeld; // Doet de speler nog mee met het spel of heeft deze al verloren (bankroet)

        public Speler(string naam, int saldo, System.Drawing.Color kleur, int positie = 0)
        {
            this.naam = naam;
            this.saldo = saldo;
            this.positie = positie;
            this.kleur = kleur;
            this.kaarten = new List<Kaart>();
            uitgeschakeld = false;
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
        public bool Uitgeschakeld { get { return uitgeschakeld; } }

        public void AddKaart(Kaart krt)
        {
            kaarten.Add(krt);
        }

        public bool DoeUitgave(int bedrag, bool verplicht = false)
        {
            if (saldo > bedrag)
            {
                saldo -= bedrag;
                return true;
            }
            else
            {
                if (verplicht)
                {
                    IsUitgeschakeld();
                }
                return false;
            }
        }

        public void KrijgInkomsten(int bedrag)
        {
            saldo += bedrag;
        }

        public void IsUitgeschakeld()
        {
            uitgeschakeld = true;
            // Nog zorgen dat alle huizen, kaarten en vakjes weer terugkeren naar de "bank"
        }

        public override string ToString()
        {
            return Naam + " " + "( ƒ" + Saldo + " )";
        }
    }
}
