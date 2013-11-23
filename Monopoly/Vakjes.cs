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
            Add(new Vakje(Vakje.VakType.STRAAT, "Dorpsstraat", "Ons Dorp", Color.FromArgb(153,51,153)));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", "",Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Brink", "Ons Dorp", Color.FromArgb(153, 51, 153)));
            Add(new Vakje(Vakje.VakType.BELASTING, "Inkomstenbelasting", "", Color.White));
            Add(new Vakje(Vakje.VakType.STATION, "Station Zuid", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Steenstraat", "Arnhem", Color.FromArgb(170, 204, 255)));
            Add(new Vakje(Vakje.VakType.KANS, "Kans", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Ketelstraat", "Arnhem", Color.FromArgb(170, 204, 255)));
            Add(new Vakje(Vakje.VakType.STRAAT, "Velperplein", "Arnhem", Color.FromArgb(170, 204, 255)));
            Add(new Vakje(Vakje.VakType.GEVANGENIS, "Gevangenis", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Barteljorisstraat", "Haarlem", Color.FromArgb(238, 68, 221)));
            Add(new Vakje(Vakje.VakType.NUTSBEDRIJF, "Elektriciteitsbedrijf", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Zijlweg", "Haarlem", Color.FromArgb(238, 68, 221)));
            Add(new Vakje(Vakje.VakType.STRAAT, "Houtstraat", "Haarlem", Color.FromArgb(238, 68, 221)));
            Add(new Vakje(Vakje.VakType.STATION, "Station West", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Neude", "Utrecht", Color.FromArgb(255, 136, 0)));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Biltstraat", "Utrecht", Color.FromArgb(255, 136, 0)));
            Add(new Vakje(Vakje.VakType.STRAAT, "Vreeburg", "Utrecht", Color.FromArgb(255, 136, 0)));
            Add(new Vakje(Vakje.VakType.VRIJPARKEREN, "Vrij parkeren", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "A Kerkhof", "Groningen", Color.FromArgb(255, 0, 0)));
            Add(new Vakje(Vakje.VakType.STRAAT, "Kans", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Grote Markt", "Groningen", Color.FromArgb(255, 0, 0)));
            Add(new Vakje(Vakje.VakType.STRAAT, "Heerestraat", "Groningen", Color.FromArgb(255, 0, 0)));
            Add(new Vakje(Vakje.VakType.STATION, "Station Noord", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Spui", "'s-Gravenhage", Color.FromArgb(255, 255, 0)));
            Add(new Vakje(Vakje.VakType.STRAAT, "Plein", "'s-Gravenhage", Color.FromArgb(255, 255, 0)));
            Add(new Vakje(Vakje.VakType.NUTSBEDRIJF, "Waterleiding", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Lange Poten", "'s-Gravenhage", Color.FromArgb(255, 255, 0)));
            Add(new Vakje(Vakje.VakType.NAARGEVANGENIS, "Naar de gevangenis", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Hofplein", "Rotterdam", Color.FromArgb(0, 128, 0)));
            Add(new Vakje(Vakje.VakType.STRAAT, "Blaak", "Rotterdam", Color.FromArgb(0, 128, 0)));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Coolsingel", "Rotterdam", Color.FromArgb(0, 128, 0)));
            Add(new Vakje(Vakje.VakType.STATION, "Station Oost", "", Color.White));
            Add(new Vakje(Vakje.VakType.KANS, "Kans", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Leidschestraat", "Amsterdam", Color.FromArgb(51, 51, 255)));
            Add(new Vakje(Vakje.VakType.BELASTING, "Extra belasting", "", Color.White));
            Add(new Vakje(Vakje.VakType.STRAAT, "Kalverstraat", "Amsterdam", Color.FromArgb(51, 51, 255)));
        }

        private void Add(Vakje vk)
        {
            bord.Add(vk);
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