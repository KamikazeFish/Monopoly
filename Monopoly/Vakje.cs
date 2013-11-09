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
        enum VakType
        {
            START,
            STRAAT,
            KANS,
            ALGEMEENFONDS
        }

        private string straatNaam;
        private string stadNaam;

        public Vakje(string straatNaam, string stadNaam)
        {
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

    public class Vakjes
    {
        private List<Vakje> bord;

        public Vakjes()
        {
            bord = new List<Vakje>();
            Add(new Vakje( "Start",                 ""));
            Add(new Vakje( "Dorpsstraat",           "Ons Dorp"));
            Add(new Vakje( "Algemeen fonds",        ""));
            Add(new Vakje( "Brink",                 "Ons Dorp"));
            Add(new Vakje( "Inkomstenbelasting",    ""));
            Add(new Vakje( "Station Zuid",          ""));
            Add(new Vakje( "Steenstraat",            "Arnhem"));
            Add(new Vakje( "Kans",                  ""));
            Add(new Vakje( "Ketelstraat",           "Arnhem"));
            Add(new Vakje( "Velperplein",           "Arnhem"));
            Add(new Vakje( "Gevangenis",            ""));
            Add(new Vakje( "Barteljorisstraat",     "Haarlem"));
            Add(new Vakje( "Elektriciteitsbedrijf", ""));
            Add(new Vakje( "Zijlweg",               "Haarlem"));
            Add(new Vakje( "Houtstraat",            "Haarlem"));
            Add(new Vakje( "Station West",          ""));
            Add(new Vakje( "Neude",                 "Utrecht"));
            Add(new Vakje( "Algemeen fonds",        ""));
            Add(new Vakje( "Biltstraat",            "Utrecht"));
            Add(new Vakje( "Vreeburg",              "Utrecht"));
            Add(new Vakje( "Vrij parkeren",         ""));
            Add(new Vakje( "A Kerkhof",             "Groningen"));
            Add(new Vakje( "Kans",                  ""));
            Add(new Vakje( "Grote Markt",           "Groningen"));
            Add(new Vakje( "Heerestraat",           "Groningen"));
            Add(new Vakje( "Station Noord",         ""));
            Add(new Vakje( "Spui",                  "'s-Gravenhage"));
            Add(new Vakje( "Plein",                 "'s-Gravenhage"));
            Add(new Vakje( "Waterleiding",          ""));
            Add(new Vakje( "Lange Poten",           "'s-Gravenhage"));
            Add(new Vakje( "Naar de gevangenis",    ""));
            Add(new Vakje( "Hofplein",              "Rotterdam"));
            Add(new Vakje( "Blaak",                 "Rotterdam"));
            Add(new Vakje( "Algemeen fonds",        ""));
            Add(new Vakje( "Coolsingel",            "Rotterdam"));
            Add(new Vakje( "Station Oost",          ""));
            Add(new Vakje( "Kans",                  ""));
            Add(new Vakje( "Leidschestraat",        "Amsterdam"));
            Add(new Vakje( "Extra belasting",       ""));
            Add(new Vakje( "Kalverstraat",          "Amsterdam"));
        }

        private void Add(Vakje vk)
        {
            bord.Add(vk);
        }
    }
}
