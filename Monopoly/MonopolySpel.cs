using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class MonopolySpel : Form
    {
        public MonopolyModel model;
        private MonopolyView view;
        private MonopolyController controller;

        public MonopolySpel()
        {
            InitializeComponent();

            view.SetLog(listBoxLog);
            StartNieuwSpel();   
        }

        private void StartNieuwSpel()
        {
            NieuwSpel aantalSpelersDialoog = new NieuwSpel();
            if (aantalSpelersDialoog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Log leeg gooien
                listBoxLog.Items.Clear();

                // De spelernamen uit het NieuwSpel form ophalen
                List<string> spelersNamen = aantalSpelersDialoog.Spelers;

                model = new MonopolyModel();
                controller = new MonopolyController(model, view);
                controller.InitialiseerSpel(spelersNamen);

                EnableDisable(); // knoppen goed zetten voor de eerste beurt
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            try
            {
                if (model != null)
                {
                    view.DoPaint(e, model);
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("De bank is berooft en al het geld is weg. Niemand kan meer winnen. Spel wordt beeindigd.\n\nIn english: \n" + ex.Message,"Fout",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Close();
            }
        }

        // zet alle knoppen aan of uit
        private void EnableDisable()
        {
            // Mag de huidige speler nog (of nogmaals) gooien?
            buttonGooi.Enabled = model.HuidigeSpelerMagGooien;
            // Zo ja, dan ook de einde beurt knop disablen
            buttonEindeBeurt.Enabled = model.HuidigeSpelerMagGooien ? false : true;
            // Kan de huidige speler het vakje nog kopen?
            buttonKoopHuidigeVakje.Enabled = (model.HuidigVakjeIsKoopbaar() && model.NieuweBeurt == false);
            // Prijs van de straat laten zien in het label, alleen als buttonKoopHuidigeVakje geactiveerd is
            labelBedragHuidigeVakje.Text = buttonKoopHuidigeVakje.Enabled ? "ƒ" + model.Vakjes[model.Spelers.HuidigeSpeler.Positie].Waarde + ",-" : "";

            // Als er in de combobox geen straat is geactiveerd, mag je ook geen huis kunnen kopen.
            buttonKoopHuisHotel.Enabled = (comboBoxVolledigeStraten.Text != string.Empty);

            // Als er geen straat is om een huis op te kopen, is de combobox niet nodig
            comboBoxVolledigeStraten.Enabled = (comboBoxVolledigeStraten.Items.Count > 0);
        }

        private void VulVolledigeStratenDropDown()
        {
            comboBoxVolledigeStraten.Items.Clear();
            foreach (string straatnaam in model.GetStraatnamenVolledigeStedenHuidigeSpeler())
            {
                comboBoxVolledigeStraten.Items.Add(straatnaam);
            }
        }

        // alle button acties volgen hier:

        private void buttonGooi_Click(object sender, EventArgs e)
        {
            controller.HuidigeSpelerkliktOpGooi();
            EnableDisable();
        }

        private void buttonKoopHuidigeVakje_Click(object sender, EventArgs e)
        {

            controller.HuidigeSpelerKliktOpKoopHuidigVakje();
            VulVolledigeStratenDropDown();
            EnableDisable();
        }

        private void buttonKoopHuisHotel_Click(object sender, EventArgs e)
        {
            controller.HuidigeSpelerKliktOpKoopHuisHotel(comboBoxVolledigeStraten.Text);
            VulVolledigeStratenDropDown();
            EnableDisable();
        }

        private void buttonEindeBeurt_Click(object sender, EventArgs e)
        {
            controller.HuidigeSpelerKliktOpEindeBeurt();
            VulVolledigeStratenDropDown();
            EnableDisable();
        }

        private void comboBoxVolledigeStraten_TextChanged(object sender, EventArgs e)
        {
            EnableDisable();
        }

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nieuwSpelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNieuwSpel();
        }
   }
}
