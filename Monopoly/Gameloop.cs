using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Gameloop
    {
        private MonopolyController controller;
        private bool stop;
        private List<Actie> acties = new List<Actie>();

        public Gameloop()
        {
            this.controller = new MonopolyController(new MonopolyModel());
            this.stop = false;

            this.Loop();
        }

        private void Loop()
        {
            Actie actie = this.acties.First();
            this.acties.Remove(actie);

            this.executeActie(actie);

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

        }

        public void removeActie(Actie actie)
        {
            this.acties.Remove(actie);
        }

        public void defaultActies()
        {
            this.acties.Clear();

            this.acties.AddRange(new List<Actie> { 
                new GooiActie()
               
            });
        }


    }
}
