﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Monopoly
{
    // de volgende vakjes zijn er op een nederlands spel:
    // "Start",
    // "Dorpsstraat Ons Dorp",
    // "Algemeen fonds",
    // "Brink Ons Dorp",
    // "Inkomstenbelasting",
    // "Station Zuid",
    // "Steenstraat Arnhem",
    // "Kans",
    // "Ketelstraat Arnhem",
    // "Velperplein Arnhem",
    // "Gevangenis",
    // "Barteljorisstraat Haarlem",
    // "Elektriciteitsbedrijf",
    // "Zijlweg Haarlem",
    // "Houtstraat Haarlem",
    // "Station West",
    // "Neude Utrecht",
    // "Algemeen fonds",
    // "Biltstraat Utrecht",
    // "Vreeburg Utrecht",
    // "Vrij parkeren",
    // "A Kerkhof Groningen",
    // "Kans",
    // "Grote Markt Groningen",
    // "Heerestraat Groningen",
    // "Station Noord",
    // "Spui 's-Gravenhage",
    // "Plein 's-Gravenhage",
    // "Waterleiding",
    // "Lange Poten 's-Gravenhage",
    // "Naar de gevangenis",
    // "Hofplein Rotterdam",
    // "Blaak Rotterdam",
    // "Algemeen fonds",
    // "Coolsingel Rotterdam",
    // "Station Oost",
    // "Kans",
    // "Leidschestraat Amsterdam",
    // "Extra belasting",
    // "Kalverstraat Amsterdam"
    //
    public class Vakje
    {
        public enum VakType
        {
            START,
            STRAAT,
            STATION,
            KANS,
            ALGEMEENFONDS,
            GEVANGENIS,
            NAARGEVANGENIS,
            BELASTING,
            NUTSBEDRIJF,
            VRIJPARKEREN
        }

        private VakType tp;
        private string straatNaam;
        private string stadNaam;
        private int waarde;                             // hoeveel kost dit vakje? 0 betekent 'niet te koop', denk aan gevangenis
        private System.Drawing.Color kleur;
        private Actie landingsActie;
        private Speler eigenaar;

        public Vakje(VakType tp, string straatNaam, string stadNaam, int waarde, Color kleur, Actie landingsActie)
        {
            this.tp = tp;
            this.straatNaam = straatNaam;
            this.stadNaam = stadNaam;
            this.waarde = waarde;
            this.kleur = kleur;
            this.landingsActie = landingsActie;
            eigenaar = null; // In het begin is niemand eigenaar.
        }

        public string StraatNaam
        {
            get { return straatNaam; }
        }
        public string StadNaam
        {
            get { return stadNaam; }
        }
        public Color Kleur
        {
            get { return kleur; }
        }
        public Actie LandingsActie
        {
            get
            {
                if (landingsActie == null)
                {
                    return new LegeActie();
                }
                return landingsActie;
            }
        }

        public Speler Eigenaar
        {
            set { eigenaar = value; }
            get { return eigenaar; }
        }

        public override String ToString()
        {
            if (stadNaam.Length > 0)
                return straatNaam + " (" + stadNaam + ")";
            else
                return straatNaam;
        }
    }

    /*public class Straat : Vakje
    {

    }*/

}
