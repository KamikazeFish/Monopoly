using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    /**
     * kaarten en vakjes kunnen acties hebben, deze actie worden dan uitgevoerd als de speler een kaart pakt of op een vakje komt.
     */
   /* public delegate void VoerUitHandler(object sender, ActieEventArgs e);

    public class ActieEventArgs : EventArgs, IDisposable
    {
        public void Dispose();
    }*/

    public abstract class Actie
    {
        private string tekst;

        public Actie(string tekst)
        {
            this.tekst = tekst;
        }

        public abstract void VoerUit(MonopolyModel model);

        public override string ToString()
        {
            return this.tekst;
        }
    }

    public class GooiActie : Actie
    {
        public GooiActie(string tekst = "De volgende speler mag gooien") : base(tekst)
        {
        
        }

        public override void VoerUit(MonopolyModel model) 
        {

        }
    }


}
