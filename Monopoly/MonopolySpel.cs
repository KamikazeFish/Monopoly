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
            model = new MonopolyModel();
            controller = new MonopolyController(model, view);
            controller.StartNewSpel();                      // todo: fix this
            
            EnableDisable(); // knoppen goed zetten voor de eerste beurt
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
           view.DoPaint(e, model);
        }

        // zet alle knoppen aan of uit
        private void EnableDisable()
        {
            // Mag de huidige speler nog (of nogmaals) gooien?
            buttonGooi.Enabled = model.HuidigeSpelerMagGooien;
            // Zo ja, dan ook de einde beurt knop disablen
            buttonEindeBeurt.Enabled = model.HuidigeSpelerMagGooien ? false : true;
            // Kan de huidige speler het vakje nog kopen?
            buttonKoopHuidigeVakje.Enabled = model.HuidigVakjeIsKoopbaar();
            // Prijs van de straat laten zien in het label
            labelBedragHuidigeVakje.Text = model.HuidigVakjeIsKoopbaar() ? "ƒ" + model.Vakjes[model.Spelers.HuidigeSpeler.Positie].Waarde + ",-" : "";

            // Als er in de combobox geen straat is geactiveerd, mag je ook geen huis kunnen kopen.
            buttonKoopHuisHotel.Enabled = (comboBoxVolledigeStraten.Text != string.Empty);

            // Als er geen straat is om een huis op te kopen, is de combobox niet nodig
            VulVolledigeStratenDropDown();
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
            EnableDisable();
        }

        private void buttonKoopHuisHotel_Click(object sender, EventArgs e)
        {
            controller.HuidigeSpelerKliktOpKoopHuisHotel(comboBoxVolledigeStraten.Text);
            EnableDisable();
        }

        private void buttonEindeBeurt_Click(object sender, EventArgs e)
        {
            controller.HuidigeSpelerKliktOpEindeBeurt();
            EnableDisable();
        }

        private void comboBoxVolledigeStraten_TextChanged(object sender, EventArgs e)
        {
            //EnableDisable();
        }
   }
}
