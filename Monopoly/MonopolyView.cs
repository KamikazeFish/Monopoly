using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Monopoly
{
    public class MonopolyView : GroupBox
    {
        private const int margeLinks  = 10;
        private const int margeRechts = 10;
        private const int margeBoven  = 20;
        private const int margeOnder  = 20;
        private const int margeVakje  = 0;
        private const int naamOffset  = 10;
        private const int stadOffset  = 20;
        private const int naamHoogte  = 8;

        // vertaal spelvak-index naar x en y positie
        // van een vakje.
        public void GetXYByIndex(int index, ref int x, ref int y)
        {
            if (index >= 30)
            {
                x = 10; y = index - 30;
            }
            else if (index >= 20)
            {
                x = index - 20; y = 0;
            }
            else if (index >= 10)
            {
                x = 0; y = 20 - index;
            }
            else
            {
                x = 10 - index; y = 10;
            }
        }

        public void DoPaint(PaintEventArgs e, MonopolyModel model)
        {
            Pen vakjePen = new Pen( Color.Black, 1.0f) ;
            SolidBrush vakjeBrush = new SolidBrush(Color.White);
            Font naamFont = new Font("Arial Narrow", (float)naamHoogte);
            SolidBrush tekstBrush = new SolidBrush(Color.Black);


            Rectangle rand = new Rectangle( 
                e.ClipRectangle.Left + margeLinks, 
                e.ClipRectangle.Top + margeBoven, 
                e.ClipRectangle.Width - margeLinks - margeRechts, 
                e.ClipRectangle.Height - margeBoven - margeOnder 
                );

            // teken alle vakjes

            int breedteVakje = (rand.Width - 10 * margeVakje ) / 11;
            int hoogteVakje = (rand.Height - 10 * margeVakje ) / 11;

            int x=0, y=0;

            for (int index = 0; index < 40; index++)
            {
                GetXYByIndex(index, ref x, ref y);
                Rectangle vakjeOmtrek = new Rectangle(
                    rand.Left + x * (breedteVakje + margeVakje),
                    rand.Top + y * (hoogteVakje + margeVakje),
                    breedteVakje,
                    hoogteVakje);

                // vul het vakje in
                e.Graphics.FillRectangle(vakjeBrush, vakjeOmtrek);
                e.Graphics.DrawRectangle(vakjePen, vakjeOmtrek);
                e.Graphics.SetClip(vakjeOmtrek);

                // maak de kleurborder
                Rectangle vakjeKleur = new Rectangle(
                    rand.Left + x * (breedteVakje + margeVakje),
                    rand.Top + y * (hoogteVakje + margeVakje),
                    breedteVakje,
                    hoogteVakje/4);
                Brush vakjeKleurBrush = new SolidBrush(model.Vakjes[index].Kleur);
                e.Graphics.FillRectangle(vakjeKleurBrush, vakjeKleur);
                e.Graphics.DrawRectangle(vakjePen, vakjeKleur);


                // teken de naam
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                
                
                RectangleF naamLayout = new RectangleF(vakjeOmtrek.Left, vakjeOmtrek.Top + naamOffset, vakjeOmtrek.Width, naamHoogte*2);
                string naamTekst = model.Vakjes[index].StraatNaam;
                e.Graphics.DrawString(naamTekst, naamFont, tekstBrush, naamLayout, sf);

                // teken stadnaam indien aanwezig
                if (model.Vakjes[index].StadNaam.Length > 0)
                {
                    RectangleF stadLayout = new RectangleF(vakjeOmtrek.Left, vakjeOmtrek.Top + stadOffset, vakjeOmtrek.Width, naamHoogte * 2);
                    string stadTekst = "(" + model.Vakjes[index].StadNaam + ")";
                    e.Graphics.DrawString(stadTekst, naamFont, tekstBrush, stadLayout, sf);
                }

                e.Graphics.ResetClip();
            }

        }
    }

}
