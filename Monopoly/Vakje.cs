using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Vakje(VakType tp, string straatNaam, string stadNaam)
        {
            this.tp = tp;
            this.straatNaam = straatNaam;
            this.stadNaam = stadNaam;
        }

        public string StraatNaam
        {
            get { return straatNaam; }
        }
        public string StadNaam
        {
            get { return stadNaam; }
        }

    }

}
