using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

// 1> Knopjes:
//
// - koop vakje
// - koop huis op: <dropdown>
// - gooi
// - einde beurt.
// 
// 2> Kaartje: 
// - we gaan de vakjes naar subklasses uitsplitsen.
// 
// 3> Designbeslissingen:
// - De controller krijgt alle logica en eventuele foutmeldingen en vragen.
// - 

namespace Monopoly
{
    // in deze klasse gaan we de business logic implementeren..
    //
    class MonopolyController
    {
        // enkele definities
        private const int beginSaldo = 10000;
        private List<Color> beschikbareKleuren = new List<Color>
        {
            Color.Blue,
            Color.Red,
            Color.Green,
            Color.Yellow
        };

        MonopolyModel model;

        public MonopolyController(MonopolyModel model)
        {
            this.model = model;
        }

        // business logic

        void StartNewSpel()
        {
            // voorlopig voegen we hardcoded twee spelers toe...
            // todo: een dialoog die de aantallen en namen vraagt.
            //
            model.Spelers.Clear();
            model.Spelers.Add(new Speler("Pieter", beginSaldo, this.PickColor()));
            model.Spelers.Add(new Speler("Ilja", beginSaldo, this.PickColor()));

        }

        private Color PickColor()
        {
            Random rnd = new Random();
            Color kleur = this.beschikbareKleuren[rnd.Next(0, this.beschikbareKleuren.Count - 1)];
            this.beschikbareKleuren.Remove(kleur);
            return kleur;
        }
    }
}
