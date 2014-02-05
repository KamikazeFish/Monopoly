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
        private const int pionGrootte = 20;

        private ListBox log;
        private KeuzeDialog keuzeDialog;

        // vertaal spelvak-index naar x en y positie
        // van een vakje.
        private void GetXYByIndex(int index, ref int x, ref int y)
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

        public void SetLog( ListBox log)
        {
            this.log = log;
        }

        public void SetKeuzeDialog(KeuzeDialog keuzeDialog)
        {
            this.keuzeDialog = keuzeDialog;
        }

        public void AddKeuzeActie(OmschrijvingActie actie) 
        {
            keuzeDialog.AddActie(actie);
        }

        public void ShowKeuzeDialog()
        {
            keuzeDialog.Show();
        }

        public void AddMessageToLog(string msg)
        {
            if (msg.Length > 0)
            {
                log.Items.Add(msg);
                // scroll to lowest
                int visibleItems = log.ClientSize.Height / log.ItemHeight;
                log.TopIndex = Math.Max(log.Items.Count - visibleItems + 1, 0);
            }
        }

        private Rectangle GetRectangleVoorVakje(Rectangle rand, int index)
        {
            int x = 0;
            int y = 0;
            GetXYByIndex(index, ref x, ref y);
            int breedteVakje = (rand.Width - 10 * margeVakje) / 11;
            int hoogteVakje = (rand.Height - 10 * margeVakje) / 11;

            Rectangle vakjeOmtrek = new Rectangle(
                rand.Left + x * (breedteVakje + margeVakje),
                rand.Top + y * (hoogteVakje + margeVakje),
                breedteVakje,
                hoogteVakje);
            return vakjeOmtrek;
        }

        // paint alle vakjes van het bord

        private void DoPaintVakjes(PaintEventArgs e, MonopolyModel model, Rectangle rand)
        {
            Pen vakjePen = new Pen(Color.Black, 1.0f);
            SolidBrush vakjeBrush = new SolidBrush(Color.White);
            Font naamFont = new Font("Arial Narrow", (float)naamHoogte);
            SolidBrush tekstBrush = new SolidBrush(Color.Black);


            // teken alle vakjes
            int x = 0, y = 0;

            for (int index = 0; index < 40; index++)
            {
                GetXYByIndex(index, ref x, ref y);
                Rectangle vakjeOmtrek = GetRectangleVoorVakje(rand, index);

                Vakje huidigVakje = model.Vakjes[index];

                // vul het vakje in
                e.Graphics.FillRectangle(vakjeBrush, vakjeOmtrek);
                e.Graphics.DrawRectangle(vakjePen, vakjeOmtrek);
                e.Graphics.SetClip(vakjeOmtrek);

                // maak de kleurborder
                Rectangle vakjeKleur = new Rectangle(
                    rand.Left + x * (vakjeOmtrek.Width + margeVakje),
                    rand.Top + y * (vakjeOmtrek.Height + margeVakje),
                    vakjeOmtrek.Width,
                    vakjeOmtrek.Height / 4);
                Brush vakjeKleurBrush = new SolidBrush(model.Vakjes[index].Kleur);
                e.Graphics.FillRectangle(vakjeKleurBrush, vakjeKleur);
                e.Graphics.DrawRectangle(vakjePen, vakjeKleur);


                // teken de naam
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;


                RectangleF naamLayout = new RectangleF(vakjeOmtrek.Left, vakjeOmtrek.Top + naamOffset, vakjeOmtrek.Width, naamHoogte * 2);
                string naamTekst = huidigVakje.StraatNaam;
                e.Graphics.DrawString(naamTekst, naamFont, tekstBrush, naamLayout, sf);

                // teken stadnaam indien aanwezig
                if (model.Vakjes[index].StadNaam.Length > 0)
                {
                    RectangleF stadLayout = new RectangleF(vakjeOmtrek.Left, vakjeOmtrek.Top + stadOffset, vakjeOmtrek.Width, naamHoogte * 2);
                    string stadTekst = "(" + huidigVakje.StadNaam + ")";
                    e.Graphics.DrawString(stadTekst, naamFont, tekstBrush, stadLayout, sf);
                }

                // teken de eigenaar indien aanwezig
                if (huidigVakje.Eigenaar != null)
                {
                    const int grootteEigenaarHoekje = 10;
                    // maak een driehoekje onderaan in het vakje
                    Point[] points = new Point[3];

                    points[0].X = vakjeOmtrek.Right;
                    points[0].Y = vakjeOmtrek.Bottom;

                    points[1].X = vakjeOmtrek.Right;
                    points[1].Y = vakjeOmtrek.Bottom - grootteEigenaarHoekje;

                    points[2].X = vakjeOmtrek.Right - grootteEigenaarHoekje;
                    points[2].Y = vakjeOmtrek.Bottom;

                    SolidBrush spelerBrush = new SolidBrush(huidigVakje.Eigenaar.Kleur);
                    e.Graphics.FillPolygon(spelerBrush, points, System.Drawing.Drawing2D.FillMode.Alternate);
                }

                // teken de huizen
                if (huidigVakje.AantalHuizen == 5)
                {
                    SolidBrush redBrush = new SolidBrush(Color.Red);
                    Rectangle vakjeHotel = new Rectangle(
                        vakjeOmtrek.Left + 2,
                        vakjeOmtrek.Top + 2,
                        8,
                        8);
                    e.Graphics.FillRectangle(redBrush, vakjeHotel);
                }
                else
                {
                    SolidBrush greenBrush = new SolidBrush(Color.Green);
                    for (int huisIndex = 0; huisIndex < huidigVakje.AantalHuizen; huisIndex++)
                    {
                        Rectangle vakjeHuis = new Rectangle(
                            vakjeOmtrek.Left + 2 + huisIndex * 10,
                            vakjeOmtrek.Top + 2,
                            8,
                            8);
                        e.Graphics.FillRectangle(greenBrush, vakjeHuis);
                    }
                }

                e.Graphics.ResetClip();
            }

        }


        // paint alle spelers.

        private void DoPaintSpelers(PaintEventArgs e, MonopolyModel model, Rectangle rand)
        {
            Font spelerFont = new Font("Arial Narrow", 15.0f);
            SolidBrush spelerBrush = new SolidBrush(Color.Black);
            Pen zwartePen = new Pen(Color.Black, 1.0f);

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Near;
            sf.Alignment = StringAlignment.Near;

            int ypos = rand.Top + rand.Height / 2;
            int xpos = rand.Left + rand.Width / 2;

            for (int speler = 0; speler < model.Spelers.GetAantalSpelers(); ++speler)
            {
                Speler huidigeSpeler = model.Spelers[speler];

                RectangleF naamRect = new RectangleF(xpos, ypos, rand.Width, 20);
                RectangleF aandebeurtRect = new RectangleF(xpos - 90, ypos, 40, 20);
                RectangleF pionRect = new RectangleF(xpos - 30, ypos, 20, 20);

                // teken tekst van speler
                e.Graphics.DrawString(huidigeSpeler.ToString(), spelerFont, spelerBrush, naamRect, sf);

                // teken rondje voor pion
                e.Graphics.FillEllipse(new SolidBrush(huidigeSpeler.Kleur), pionRect);

                // teken pijltje indien aan de beurt

                if (huidigeSpeler == model.Spelers.HuidigeSpeler)
                    e.Graphics.DrawString("=>", spelerFont, spelerBrush, aandebeurtRect, sf);

                // paint pionnetje van speler
                Rectangle vakjeSpeler = GetRectangleVoorVakje(rand, huidigeSpeler.Positie);
                e.Graphics.FillEllipse(
                    new SolidBrush(huidigeSpeler.Kleur),
                    vakjeSpeler.Left + 2 + speler * pionGrootte,
                    vakjeSpeler.Top + vakjeSpeler.Height - pionGrootte - 2, 
                    (float)pionGrootte, (float)pionGrootte);

                // step up speler positie
                ypos -= 25;
            }

        }

        private void DoPaintDobbelstenen(PaintEventArgs e, MonopolyModel model, Rectangle rect)
        {
            Pen dblPen = new Pen(Color.Black, 1.0f);

            string naamSteen1 = "Monopoly.Resources.Dice" + model.Steen1.LaatsteWaarde + ".bmp";
            string naamSteen2 = "Monopoly.Resources.Dice" + model.Steen2.LaatsteWaarde + ".bmp";

            Bitmap bmp1 = new Bitmap(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream(naamSteen1));
            Bitmap bmp2 = new Bitmap(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream(naamSteen2));

            Point dbl1 = new Point(
                rect.Left + rect.Width / 2 - 50 - bmp1.Width,
                rect.Top + rect.Height / 2 + 90
                );
            Point dbl2 = new Point(
                rect.Left + rect.Width / 2 + 50 - bmp2.Width,
                rect.Top + rect.Height / 2 + 90
                );

            e.Graphics.DrawImage(bmp1, dbl1);
            e.Graphics.DrawImage(bmp2, dbl2);

            
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

            DoPaintVakjes(e, model, rand);
            DoPaintSpelers(e, model, rand);
            DoPaintDobbelstenen(e, model, rand);
        }
    }

}
