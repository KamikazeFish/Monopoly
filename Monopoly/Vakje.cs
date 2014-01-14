using System;
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
        private int aantalHuizen;                       // 5 huizen == 1 hotel
        private int prijsPerHuis;
        private int[] tarieven;                         // de 6 prijzen: onbebouwd en 1 huis t/m hotel (Het aantal huizen is de index voor dit array)

        public Vakje(VakType tp, string straatNaam, string stadNaam, Color kleur, Actie landingsActie = null, int waarde = 0, int hypotheekwaarde = 0, int huizenPrijs = 0, int[] bezoekersTarieven = null)
        {
            this.tp = tp;
            this.straatNaam = straatNaam;
            this.stadNaam = stadNaam;
            this.waarde = waarde;
            this.kleur = kleur;
            this.landingsActie = landingsActie;
            eigenaar = null; // In het begin is niemand eigenaar.
            aantalHuizen = 0;
            prijsPerHuis = huizenPrijs;

            if ((bezoekersTarieven != null) && 
                ((tp == VakType.STRAAT && bezoekersTarieven.Length != 6) ||
                 (tp == VakType.STATION && bezoekersTarieven.Length != 4) ||
                 (tp == VakType.NUTSBEDRIJF && bezoekersTarieven.Length != 2)))
            {
                throw new InvalidArrayLengthException("Verkeerd aantal bezoekerstarieven in het array gedefinieerd!"); // custom Exception
            }
            else
            {
                tarieven = bezoekersTarieven;
            }
        }

        public VakType Vaktype { get { return this.tp; } }

        public string StraatNaam
        {
            get { return straatNaam; }
        }
        public string StadNaam
        {
            get { return stadNaam; }
        }
        public int Waarde { get { return waarde; } }
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

        public int AantalHuizen { get { return aantalHuizen; } }
        public int PrijsPerHuis { get { return prijsPerHuis; } }

        public bool AddHuis()
        {
            if (tp == VakType.STRAAT && aantalHuizen < 5)
            {
                aantalHuizen++;
                return true;
            }
            return false;
        }

        public int GetBezoekerPrijs()
        {
            return 0; // nog logica toevoegen
        }

        public override String ToString()
        {
            if (stadNaam.Length > 0)
                return straatNaam + " (" + stadNaam + ")";
            else
                return straatNaam;
        }
    }
}
