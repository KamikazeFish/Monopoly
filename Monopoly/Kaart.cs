using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    // een superklasse van de (kans, algemeen fonds) kaarten.
    //
    public abstract class Kaart
    {
        private String tekst;

        public Kaart(String tekst)
        {
            this.tekst = tekst;
        }

        public string Tekst
        {
            get { return tekst; }
        }

    }

    // een financiele kaart: u ontvangt x of betaalt x (dan is x negatief)
    public class BetaalOntvangKaart : Kaart
    {
        int bedrag;

        public BetaalOntvangKaart(string tekst, int bedrag) : base(tekst)
        {
            this.bedrag = bedrag;
        }
    }

    public class BetaalOntvangPerHuisHotel : Kaart
    {
        int bedragPerHuis;
        int bedragPerHotel;

        public BetaalOntvangPerHuisHotel(string tekst, int bedragPerHuis, int bedragPerHotel) : base(tekst)
        {
            this.bedragPerHuis = bedragPerHuis;
            this.bedragPerHotel = bedragPerHotel;
        }
    }

}
