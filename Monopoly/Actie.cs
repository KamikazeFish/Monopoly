using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        private string tekst; // tekst om te gebruiken in textbox met events

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

    public class LegeActie : Actie
    {
        public LegeActie(string tekst = "")
            : base(tekst)
        {
        }

        public override void VoerUit(MonopolyModel model)
        {
            // niks te doen
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

    public class KoopHuisActie : Actie
    {
        public KoopHuisActie(string tekst = "Speler koopt een huis") : base(tekst)
        {

        }

        public override void VoerUit(MonopolyModel model) 
        {

        }
    }

    public class BetaalOntvangActie : Actie
    {
        public BetaalOntvangActie(string tekst) : base(tekst)
        {
        }

        public override void VoerUit(MonopolyModel model) 
        {

        }
    }

    public class BetaalOntvangPerHuisHotelActie : Actie
    {
        public BetaalOntvangPerHuisHotelActie(string tekst) : base(tekst)
        {
        }

        public override void VoerUit(MonopolyModel model) 
        {

        }
    }

    public class GaNaarActie : Actie
    {
        public GaNaarActie(string tekst) : base(tekst)
        {
        }

        public override void VoerUit(MonopolyModel model) 
        {

        }
    }

    public class VerlaatDeGevangenisActie : Actie
    {
        public VerlaatDeGevangenisActie(string tekst)
            : base(tekst)
        {
        }

        public override void VoerUit(MonopolyModel model) 
        {

        }
    }

    public class KeuzeActie : Actie
    {
        Actie actie1;
        Actie actie2;
        string vraag;

        public KeuzeActie(string tekst, string vraag, Actie actie1, Actie actie2)
            : base(tekst)
        {
            this.actie1 = actie1;
            this.actie2 = actie2;
            this.vraag = vraag;
        }

        public override void VoerUit(MonopolyModel model) 
        {
            // TODO: Custom dialog maken om meteen actie 1 of actie 2 te kunnen selecteren. (of andere buttons)
            DialogResult result = MessageBox.Show(this.vraag, "Wat wilt u doen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.actie1.VoerUit(model);
            }
            else //if( result == DialogResult.No) // Als de dialoogbox weggedrukt wordt altijd actie 2 uitvoeren
            {
                this.actie2.VoerUit(model);
            }

        }
    }


}
