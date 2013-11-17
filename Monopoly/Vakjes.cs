using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monopoly;


namespace Monopoly
{
    public class Vakjes
    {
        private List<Vakje> bord;

        public Vakjes()
        {
            bord = new List<Vakje>();
            Add(new Vakje(Vakje.VakType.START, "Start", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Dorpsstraat", "Ons Dorp"));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Brink", "Ons Dorp"));
            Add(new Vakje(Vakje.VakType.BELASTING, "Inkomstenbelasting", ""));
            Add(new Vakje(Vakje.VakType.STATION, "Station Zuid", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Steenstraat", "Arnhem"));
            Add(new Vakje(Vakje.VakType.KANS, "Kans", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Ketelstraat", "Arnhem"));
            Add(new Vakje(Vakje.VakType.STRAAT, "Velperplein", "Arnhem"));
            Add(new Vakje(Vakje.VakType.GEVANGENIS, "Gevangenis", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Barteljorisstraat", "Haarlem"));
            Add(new Vakje(Vakje.VakType.NUTSBEDRIJF, "Elektriciteitsbedrijf", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Zijlweg", "Haarlem"));
            Add(new Vakje(Vakje.VakType.STRAAT, "Houtstraat", "Haarlem"));
            Add(new Vakje(Vakje.VakType.STATION, "Station West", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Neude", "Utrecht"));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Biltstraat", "Utrecht"));
            Add(new Vakje(Vakje.VakType.STRAAT, "Vreeburg", "Utrecht"));
            Add(new Vakje(Vakje.VakType.VRIJPARKEREN, "Vrij parkeren", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "A Kerkhof", "Groningen"));
            Add(new Vakje(Vakje.VakType.STRAAT, "Kans", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Grote Markt", "Groningen"));
            Add(new Vakje(Vakje.VakType.STRAAT, "Heerestraat", "Groningen"));
            Add(new Vakje(Vakje.VakType.STATION, "Station Noord", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Spui", "'s-Gravenhage"));
            Add(new Vakje(Vakje.VakType.STRAAT, "Plein", "'s-Gravenhage"));
            Add(new Vakje(Vakje.VakType.NUTSBEDRIJF, "Waterleiding", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Lange Poten", "'s-Gravenhage"));
            Add(new Vakje(Vakje.VakType.NAARGEVANGENIS, "Naar de gevangenis", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Hofplein", "Rotterdam"));
            Add(new Vakje(Vakje.VakType.STRAAT, "Blaak", "Rotterdam"));
            Add(new Vakje(Vakje.VakType.ALGEMEENFONDS, "Algemeen fonds", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Coolsingel", "Rotterdam"));
            Add(new Vakje(Vakje.VakType.STATION, "Station Oost", ""));
            Add(new Vakje(Vakje.VakType.KANS, "Kans", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Leidschestraat", "Amsterdam"));
            Add(new Vakje(Vakje.VakType.BELASTING, "Extra belasting", ""));
            Add(new Vakje(Vakje.VakType.STRAAT, "Kalverstraat", "Amsterdam"));
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