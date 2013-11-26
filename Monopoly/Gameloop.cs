using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Gameloop
    {
        private MonopolyController controller;
        private MonopolyModel model;

        private bool stop;
        private List<Actie> acties = new List<Actie>();

        public Gameloop(MonopolyModel model)
        {
            this.model = model;
            this.controller = new MonopolyController(model);
            this.stop = false;

            this.stop = true; // !!TIJDELIJK, anders nu een infinite loop

            this.defaultActies();
            this.Loop();
        }

        private void Loop()
        {
            Actie actie = this.acties.Last(); // acties van achter naar voren
            this.acties.Remove(actie);

            this.executeActie(actie);

            // drawBoard

            if (this.acties.Count == 0)
            {
                this.model.Spelers.Next(); // volgende speler aan de beurt laten
                this.defaultActies();      // standaard acties inladen
            }

            // alle acties uitvoeren

            if (!this.stop)
            {
                this.Loop();
            }
        }

        public void addActie(Actie actie)
        {
            this.acties.Add(actie);
        }

        public void executeActie(Actie actie) 
        {
            actie.VoerUit(this.model);
        }

        public void removeActie(Actie actie)
        {
            this.acties.Remove(actie);
        }

        public void defaultActies()
        {
            this.acties.Clear();

            this.acties.AddRange(new List<Actie> { 
                new GooiActie(),
                // acties van het vakje wordt hiertussen aan de acties toegevoegd
                new KoopHuisActie()
            });

            this.acties.Reverse();
        }


    }
}
