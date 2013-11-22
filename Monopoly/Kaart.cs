﻿using System;
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
        public enum Ontvanger
        {
            Bank,
            Tegenspelers,
            Pot
        }

        private Ontvanger ontvanger;

        int bedrag;

        public BetaalOntvangKaart(string tekst, int bedrag, Ontvanger ontvanger = Ontvanger.Bank) : base(tekst)
        {
            this.bedrag = bedrag;
            this.ontvanger = ontvanger;
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

    public class GaNaarKaart : Kaart
    {
        private bool gaLangsStart;
        private Vakje vakje;
        private int aantalVakjes;
        private bool loopTerug;

        public GaNaarKaart(string tekst, Vakje vakje, bool gaLangsStart, bool loopTerug = false) : base(tekst)
        {
            this.vakje = vakje;
            this.gaLangsStart = gaLangsStart;
            this.loopTerug = loopTerug;
        }

        public GaNaarKaart(string tekst, int aantalVakjes, bool gaLangsStart, bool loopTerug = false)
            : base(tekst)
        {
            this.aantalVakjes = aantalVakjes;
            this.gaLangsStart = gaLangsStart;
            this.loopTerug = loopTerug;
        }

        // In de uitvoer methode wordt de huidige positie meegegeven waarmee met de positieVerschuiving het Vakje beredeneerd kan worden.
    }

    public class VerlaatDeGevangenisKaart : Kaart
    {
        public VerlaatDeGevangenisKaart(string tekst) : base(tekst)
        {

        }
    }

}
