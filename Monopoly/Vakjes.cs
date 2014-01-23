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
            Add(new Vakje(Vakje.VakType.START, "Start", "", Color.White));

            Add(new Vakje(Vakje.VakType.STRAAT, "Dorpsstraat", "Ons Dorp", Color.FromArgb(0, 0, 153), new LandingsActie(), 60, 30, 50, new int[] { 2, 10, 30, 90, 160, 250 }));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", "", Color.White, new PakAlgemeenFondsKaartActie())); ;
            Add(new Vakje(Vakje.VakType.STRAAT, "Brink", "Ons Dorp", Color.FromArgb(0, 0, 153), new LandingsActie(), 60, 30, 50, new int[] { 4, 20, 60, 180, 320, 450 }));
            Add(new Vakje(Vakje.VakType.BELASTING, "Inkomstenbelasting", "", Color.White));

            Add(new Vakje(Vakje.VakType.STATION, "Station Zuid", "", Color.White, null, 200, 100, 0, new int[] { 25, 50, 100, 200 }));

            Add(new Vakje(Vakje.VakType.STRAAT, "Steenstraat", "Arnhem", Color.FromArgb(170, 204, 255), new LandingsActie(), 100, 50, 50, new int[] { 6, 30, 90, 270, 400, 550 }));
            Add(new Vakje(Vakje.VakType.KANS, "Kans", "", Color.White, new PakKansKaartActie()));
            Add(new Vakje(Vakje.VakType.STRAAT, "Ketelstraat", "Arnhem", Color.FromArgb(170, 204, 255), new LandingsActie(), 100, 50, 50, new int[] { 6, 30, 90, 270, 400, 550 }));
            Add(new Vakje(Vakje.VakType.STRAAT, "Velperplein", "Arnhem", Color.FromArgb(170, 204, 255), new LandingsActie(), 120, 60, 50, new int[] { 8, 40, 100, 300, 450, 600 }));

            Add(new Vakje(Vakje.VakType.GEVANGENIS, "Gevangenis", "", Color.White));

            Add(new Vakje(Vakje.VakType.STRAAT, "Barteljorisstraat", "Haarlem", Color.FromArgb(238, 68, 221), new LandingsActie(), 140, 70, 100, new int[] { 10, 50, 150, 450, 625, 750 }));
            Add(new Vakje(Vakje.VakType.NUTSBEDRIJF, "Elektriciteitsbedrijf", "", Color.White, null, 150, 75, 0, new int[] { 4, 10 }));
            Add(new Vakje(Vakje.VakType.STRAAT, "Zijlweg", "Haarlem", Color.FromArgb(238, 68, 221), new LandingsActie(), 140, 70, 100, new int[] { 10, 50, 150, 450, 625, 750 }));
            Add(new Vakje(Vakje.VakType.STRAAT, "Houtstraat", "Haarlem", Color.FromArgb(238, 68, 221), new LandingsActie(), 160, 80, 100, new int[] { 12, 60, 180, 500, 700, 900 }));

            Add(new Vakje(Vakje.VakType.STATION, "Station West", "", Color.White, null, 200, 100, 0, new int[] { 25, 50, 100, 200 }));

            Add(new Vakje(Vakje.VakType.STRAAT, "Neude", "Utrecht", Color.FromArgb(255, 136, 0), new LandingsActie(), 180, 90, 100, new int[] { 14, 70, 200, 550, 750, 950 }));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", "", Color.White, new PakAlgemeenFondsKaartActie()));
            Add(new Vakje(Vakje.VakType.STRAAT, "Biltstraat", "Utrecht", Color.FromArgb(255, 136, 0), new LandingsActie(), 180, 90, 100, new int[] { 14, 70, 200, 550, 750, 950 }));
            Add(new Vakje(Vakje.VakType.STRAAT, "Vreeburg", "Utrecht", Color.FromArgb(255, 136, 0), new LandingsActie(), 200, 100, 100, new int[] { 16, 80, 220, 600, 800, 1000 }));

            Add(new Vakje(Vakje.VakType.VRIJPARKEREN, "Vrij parkeren", "", Color.White));

            Add(new Vakje(Vakje.VakType.STRAAT, "A Kerkhof", "Groningen", Color.FromArgb(255, 0, 0), new LandingsActie(), 220, 110, 150, new int[] { 18, 90, 250, 700, 875, 1050 }));
            Add(new Vakje(Vakje.VakType.KANS, "Kans", "", Color.White, new PakKansKaartActie()));
            Add(new Vakje(Vakje.VakType.STRAAT, "Grote Markt", "Groningen", Color.FromArgb(255, 0, 0), new LandingsActie(), 220, 110, 150, new int[] { 18, 90, 250, 700, 875, 1050 }));
            Add(new Vakje(Vakje.VakType.STRAAT, "Heerestraat", "Groningen", Color.FromArgb(255, 0, 0), new LandingsActie(), 240, 120, 150, new int[] { 20, 100, 300, 750, 925, 1100 }));

            Add(new Vakje(Vakje.VakType.STATION, "Station Noord", "", Color.White, null, 200, 100, 0, new int[] { 25, 50, 100, 200 }));

            Add(new Vakje(Vakje.VakType.STRAAT, "Spui", "'s-Gravenhage", Color.FromArgb(255, 255, 0), new LandingsActie(), 260, 130, 150, new int[] { 22, 110, 330, 800, 975, 1150 }));
            Add(new Vakje(Vakje.VakType.STRAAT, "Plein", "'s-Gravenhage", Color.FromArgb(255, 255, 0), new LandingsActie(), 260, 130, 150, new int[] { 22, 110, 330, 800, 975, 1150 }));
            Add(new Vakje(Vakje.VakType.NUTSBEDRIJF, "Waterleiding", "", Color.White, null, 150, 75, 0, new int[] { 4, 10 }));
            Add(new Vakje(Vakje.VakType.STRAAT, "Lange Poten", "'s-Gravenhage", Color.FromArgb(255, 255, 0), new LandingsActie(), 280, 140, 150, new int[] { 24, 120, 360, 850, 1025, 1200 }));

            Add(new Vakje(Vakje.VakType.NAARGEVANGENIS, "Naar de gevangenis", "", Color.White, null));

            Add(new Vakje(Vakje.VakType.STRAAT, "Hofplein", "Rotterdam", Color.FromArgb(0, 128, 0), new LandingsActie(), 300, 150, 200, new int[] { 26, 130, 390, 900, 1100, 1275 }));
            Add(new Vakje(Vakje.VakType.STRAAT, "Blaak", "Rotterdam", Color.FromArgb(0, 128, 0), new LandingsActie(), 300, 150, 200, new int[] { 26, 130, 390, 900, 1100, 1275 }));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", "", Color.White, new PakAlgemeenFondsKaartActie()));
            Add(new Vakje(Vakje.VakType.STRAAT, "Coolsingel", "Rotterdam", Color.FromArgb(0, 128, 0), new LandingsActie(), 320, 160, 200, new int[] { 28, 150, 450, 1000, 1200, 1400 }));

            Add(new Vakje(Vakje.VakType.STATION, "Station Oost", "", Color.White, null, 200, 100, 0, new int[] { 25, 50, 100, 200 }));

            Add(new Vakje(Vakje.VakType.KANS, "Kans", "", Color.White, new PakKansKaartActie()));
            Add(new Vakje(Vakje.VakType.STRAAT, "Leidschestraat", "Amsterdam", Color.FromArgb(51, 51, 255), new LandingsActie(), 350, 175, 200, new int[] { 35, 175, 500, 1100, 1300, 1500 }));
            Add(new Vakje(Vakje.VakType.BELASTING, "Extra belasting", "", Color.White, null));
            Add(new Vakje(Vakje.VakType.STRAAT, "Kalverstraat", "Amsterdam", Color.FromArgb(51, 51, 255), new LandingsActie(), 400, 200, 200, new int[] { 50, 200, 600, 1400, 1700, 2000 }));
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

        public bool IsStraatVanVolledigeStad(Vakje huidigVakje)
        {
            int aantalStratenHuidigeStad = 0;
            if( huidigVakje.Vaktype == Vakje.VakType.STRAAT) {
                foreach (Vakje vakje in bord)
                {
                    if (huidigVakje.StadNaam != string.Empty && huidigVakje.StadNaam == vakje.StadNaam)
                    {
                        if (vakje.Eigenaar != huidigVakje.Eigenaar)
                        {
                            return false;
                        }
                        aantalStratenHuidigeStad++;
                    }

                    // nooit meer als 3 straten in 1 stad, dus ook geen zin om de loop door te laten gaan
                    if (aantalStratenHuidigeStad >= 3) 
                    {
                        return true;
                    }
                }
                return true;
            }
            return false;
        }

        public int GetAantalStationsVoor(Speler speler)
        {
            int aantalStations = 0;
            int aantalStationsVanSpeler = 0;
            foreach (Vakje vakje in bord)
            {
                if (vakje.Vaktype == Vakje.VakType.STATION)
                {
                    aantalStations++;
                    if (vakje.Eigenaar == speler)
                    {
                        aantalStationsVanSpeler++;
                    }
                }
                if (aantalStations == 4)
                {
                    break;
                }
            }
            return aantalStationsVanSpeler;
        }

        public bool HeeftBeideNutsBedrijven(Speler speler)
        {
            int aantalNutsBedrijven = 0;
            foreach (Vakje vakje in bord)
            {
                if (vakje.Vaktype == Vakje.VakType.NUTSBEDRIJF) 
                {
                    aantalNutsBedrijven++;
                    if (vakje.Eigenaar != speler)
                    {
                        return false;
                    }

                    if (aantalNutsBedrijven >= 2)
                    {
                        break;
                    }
                }
            }
            return true;
        }

        public int GetBezoekerPrijs(Speler speler)
        {
            Vakje vakje = bord[speler.Positie];

            if (vakje.Eigenaar != speler)
            {
                if (vakje.Vaktype == Vakje.VakType.STRAAT)
                {
                    if (vakje.AantalHuizen == 0)
                    {
                        if (IsStraatVanVolledigeStad(vakje))
                        {
                            return vakje.Tarieven[0] * 2;
                        }
                        else
                        {
                            return vakje.Tarieven[0];
                        }
                    }
                    else
                    {
                        return vakje.Tarieven[vakje.AantalHuizen];
                    }
                }
                else if (vakje.Vaktype == Vakje.VakType.STATION)
                {
                    return vakje.Tarieven[GetAantalStationsVoor(vakje.Eigenaar) - 1];
                }
                else if (vakje.Vaktype == Vakje.VakType.NUTSBEDRIJF) // aantal waarmee het aantal ogen vermenigvuldigd moet worden
                {
                    if (HeeftBeideNutsBedrijven(vakje.Eigenaar))
                    {
                        return vakje.Tarieven[1];
                    }
                    else
                    {
                        return vakje.Tarieven[0];
                    }
                }
            }
            return 0;
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