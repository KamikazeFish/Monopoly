using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    // een superklasse van de (kans, algemeen fonds) kaarten.
    //
    public class Kaart
    {
        private String tekst;
        private Actie actie;
        private bool bewaren; // als deze true is wordt de kaart aan de huidige speler gegeven (default: false)

        public Kaart(String tekst, Actie actie, bool bewaren = false)
        {
            this.tekst = tekst;
            this.actie = actie;
            this.bewaren = bewaren;
        }

        public override string ToString() {return tekst;}
        public Actie Actie { get { return actie; } }
        public bool Bewaren { get { return bewaren; } }
    }

}
