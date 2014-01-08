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
            List<Vakje> spelerVakjes = GetVakjesVan(speler);
            List<Vakje> tempSpelerVakjes = new List<Vakje>();

            // Alleen de straat vakjes van de huidige speler
            foreach (Vakje vakje in spelerVakjes)
            {
                if (vakje.Vaktype == Vakje.VakType.STRAAT)
                {
                    tempSpelerVakjes.Add(vakje);
                }
            }
            spelerVakjes.Clear();
            spelerVakjes.AddRange(tempSpelerVakjes);

            if (tempSpelerVakjes.Count > 0)
            {
                // de andere straat vakjes in een lijst stoppen
                List<Vakje> andereBordVakjes = new List<Vakje>();

                foreach (Vakje vakje in bord)
                {
                    if (!spelerVakjes.Contains(vakje) && vakje.Vaktype == Vakje.VakType.STRAAT)
                    {
                        andereBordVakjes.Add(vakje);
                    }
                }

                // Alle vakjes verwijderen uit de spelerVakjes waarvan de straat ook voorkomt in de andereBordVakjes (dus geen volledige straat is)
                foreach (Vakje spelerVakje in tempSpelerVakjes)
                {
                    foreach (Vakje anderVakje in andereBordVakjes)
                    {
                        if (spelerVakje.StadNaam == anderVakje.StadNaam)
                        {
                            spelerVakjes.Remove(spelerVakje);
                            break;
                        }
                    }
                }
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