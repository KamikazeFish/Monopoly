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
    public abstract class Actie
    {
        public Actie()
        {
        }

        public abstract void VoerUit(MonopolyModel model, MonopolyView view);
    }

    public class LegeActie : Actie
    {
        public LegeActie()
        {
        }

        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            // niks te doen
        }
    }

    public class BetaalOntvangActie : Actie
    {
        // de huidige speler krijgt een bedrag of moet dit betalen.
        // bedrag kan dus ook negatief zijn
        private int bedrag;

        public BetaalOntvangActie(int bedrag)
        {
            this.bedrag = bedrag;
        }

        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            model.Spelers.HuidigeSpeler.KrijgInkomsten(bedrag);
            if (bedrag > 0)
            {
                view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' ontvangt ƒ" + bedrag);
            }
            else
            {
                view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' betaalt ƒ" + -bedrag);
            }
        }
    }

    public class PakKansKaartActie : Actie
    {
        public PakKansKaartActie()
        {

        }

        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            Kaart kaart = model.KansKaarten.PakKaart();
            if (kaart.Bewaren)
            {
                model.Spelers.HuidigeSpeler.AddKaart(kaart);

                view.AddMessageToLog( "Speler '" + model.Spelers.HuidigeSpeler.Naam + "' pakt de kans kaart '" + kaart.ToString() + "' en bewaart deze." );
            }
            else
            {
                view.AddMessageToLog( "Speler '" + model.Spelers.HuidigeSpeler.Naam + "' pakt de kans kaart '" + kaart.ToString() );
                kaart.Actie.VoerUit(model, view);
            }
        }
    }

    public class PakAlgemeenFondsKaartActie : Actie
    {
        public PakAlgemeenFondsKaartActie()
        {
        }

        public override void VoerUit(MonopolyModel model, MonopolyView view)
        {
            Kaart kaart = model.AlgemeenFondsKaarten.PakKaart();
            if (kaart.Bewaren)
            {
                model.Spelers.HuidigeSpeler.AddKaart(kaart);

                view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' pakt de algemeenfonds kaart '" + kaart.ToString() + "' en bewaart deze.");
            }
            else
            {
                view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' pakt de algemeenfonds kaart '" + kaart.ToString() + "'");
                kaart.Actie.VoerUit(model, view);
            }
        }
    }



    //public class GooiActie : Actie
    //{
    //    public GooiActie(string tekst = "De volgende speler mag gooien")
    //    {
    //    }

    //    public override void VoerUit(MonopolyModel model) 
    //    {

    //    }
    //}

    //public class BetaalOntvangPerHuisHotelActie : Actie
    //{
    //    public BetaalOntvangPerHuisHotelActie(string tekst) : base(tekst)
    //    {
    //    }

    //    public override void VoerUit(MonopolyModel model) 
    //    {

    //    }
    //}

    //public class GaNaarActie : Actie
    //{
    //    public GaNaarActie(string tekst) : base(tekst)
    //    {
    //    }

    //    public override void VoerUit(MonopolyModel model) 
    //    {

    //    }
    //}

    //public class VerlaatDeGevangenisActie : Actie
    //{
    //    public VerlaatDeGevangenisActie(string tekst)
    //        : base(tekst)
    //    {
    //    }

    //    public override void VoerUit(MonopolyModel model) 
    //    {

    //    }
    //}

    //public class KeuzeActie : Actie
    //{
    //    Actie actie1;
    //    Actie actie2;
    //    string vraag;

    //    public KeuzeActie(string tekst, string vraag, Actie actie1, Actie actie2)
    //        : base(tekst)
    //    {
    //        this.actie1 = actie1;
    //        this.actie2 = actie2;
    //        this.vraag = vraag;
    //    }

    //    public override void VoerUit(MonopolyModel model) 
    //    {
    //        // TODO: Custom dialog maken om meteen actie 1 of actie 2 te kunnen selecteren. (of andere buttons)
    //        DialogResult result = MessageBox.Show(this.vraag, "Wat wilt u doen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    //        if (result == DialogResult.Yes)
    //        {
    //            this.actie1.VoerUit(model);
    //        }
    //        else //if( result == DialogResult.No) // Als de dialoogbox weggedrukt wordt altijd actie 2 uitvoeren
    //        {
    //            this.actie2.VoerUit(model);
    //        }

    //    }
    //}
}
