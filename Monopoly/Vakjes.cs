using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monopoly;
using System.Drawing;


namespace Monopoly
{
    public class Vakjes
    {
        private List<Vakje> bord;

        public Vakjes()
        {
            bord = new List<Vakje>();
            Add(new Vakje(Vakje.VakType.START, "Start", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Dorpsstraat", "Ons Dorp", 60, Color.FromArgb(0, 0, 153), null));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", "", 0, Color.White, null)); ;
            Add(new Vakje(Vakje.VakType.STRAAT, "Brink", "Ons Dorp", 60, Color.FromArgb(0, 0, 153), null));
            Add(new Vakje(Vakje.VakType.BELASTING, "Inkomstenbelasting", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STATION, "Station Zuid", "", 200, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Steenstraat", "Arnhem", 100, Color.FromArgb(170, 204, 255), null));
            Add(new Vakje(Vakje.VakType.KANS, "Kans", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Ketelstraat", "Arnhem", 100, Color.FromArgb(170, 204, 255), null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Velperplein", "Arnhem", 120, Color.FromArgb(170, 204, 255), null));
            Add(new Vakje(Vakje.VakType.GEVANGENIS, "Gevangenis", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Barteljorisstraat", "Haarlem", 140, Color.FromArgb(238, 68, 221), null));
            Add(new Vakje(Vakje.VakType.NUTSBEDRIJF, "Elektriciteitsbedrijf", "", 150, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Zijlweg", "Haarlem", 140, Color.FromArgb(238, 68, 221), null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Houtstraat", "Haarlem", 160, Color.FromArgb(238, 68, 221), null));
            Add(new Vakje(Vakje.VakType.STATION, "Station West", "", 200, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Neude", "Utrecht", 150, Color.FromArgb(255, 136, 0), null));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Biltstraat", "Utrecht", 150, Color.FromArgb(255, 136, 0), null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Vreeburg", "Utrecht", 200, Color.FromArgb(255, 136, 0), null));
            Add(new Vakje(Vakje.VakType.VRIJPARKEREN, "Vrij parkeren", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "A Kerkhof", "Groningen", 220, Color.FromArgb(255, 0, 0), null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Kans", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Grote Markt", "Groningen", 220, Color.FromArgb(255, 0, 0), null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Heerestraat", "Groningen", 240, Color.FromArgb(255, 0, 0), null));
            Add(new Vakje(Vakje.VakType.STATION, "Station Noord", "", 200, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Spui", "'s-Gravenhage", 260, Color.FromArgb(255, 255, 0), null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Plein", "'s-Gravenhage", 260, Color.FromArgb(255, 255, 0), null));
            Add(new Vakje(Vakje.VakType.NUTSBEDRIJF, "Waterleiding", "", 150, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Lange Poten", "'s-Gravenhage", 280, Color.FromArgb(255, 255, 0), null));
            Add(new Vakje(Vakje.VakType.NAARGEVANGENIS, "Naar de gevangenis", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Hofplein", "Rotterdam", 300, Color.FromArgb(0, 128, 0), null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Blaak", "Rotterdam", 300, Color.FromArgb(0, 128, 0), null));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Coolsingel", "Rotterdam", 320, Color.FromArgb(0, 128, 0), null));
            Add(new Vakje(Vakje.VakType.STATION, "Station Oost", "", 200, Color.White, null));
            Add(new Vakje(Vakje.VakType.KANS, "Kans", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Leidschestraat", "Amsterdam", 350, Color.FromArgb(51, 51, 255), null));
            Add(new Vakje(Vakje.VakType.BELASTING, "Extra belasting", "", 0, Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Kalverstraat", "Amsterdam", 400, Color.FromArgb(51, 51, 255), null));
        }

        private void Add(Vakje vk)
        {
            bord.Add(vk);
        }

        public int GetAantalVakjes()
        {
            return bord.Count;
        }

        public Vakje GetVakjeMetStraatnaam(string straatnaam)
        {
            foreach (Vakje vakje in bord)
            {
                if (vakje.StraatNaam == straatnaam)
                {
                    return vakje;
                }
            }
            return null;
        }

        public List<Vakje> GetVakjesVan(Speler speler)
        {
            List<Vakje> vakjes = new List<Vakje>();

            foreach (Vakje vakje in bord)
            {
                if (vakje.Eigenaar == speler)
                {
                    vakjes.Add(vakje);
                }
            }

            return vakjes;
        }

        public List<Vakje> GetStratenVolledigeStedenVan(Speler speler)
        {
            // stap 1. we maken een lijst met alle vakjes die gekocht zijn door de huidige speler. 
            List<Vakje> spelerVakjes = GetVakjesVan(speler);

            // stap 2. uit deze  lijst, verwijder alle vakjes waar we de stad niet van hebben.
            int index = 0; 
            while (index < spelerVakjes.Count)
            {
                Vakje kandidaatVakje = spelerVakjes[index];

                // is kandidaatVakje deel van een stad?
                bool isStad = true;

                foreach (Vakje bordVakje in bord)
                {
                    if (bordVakje.Eigenaar != speler &&
                        bordVakje.StadNaam == kandidaatVakje.StadNaam)
                    {
                        // het bord bevat een vakje, dat niet van ons is, en dat een straatnaam heeft 
                        // van kandidaatVakje. Dit betekent dat we de straat niet hebben!
                        isStad = false;
                    }
                }

                if (isStad)
                    index++;
                else
                    spelerVakjes.RemoveAt(index);
            }

            return spelerVakjes;
        }

        // overload operator []
        public Vakje this[int i]
        {
            get
            {
                return bord[i];
            }
            set
            {
                bord[i] = value;
            }
        }

    }

}