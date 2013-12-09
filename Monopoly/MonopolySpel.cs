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

            model = new MonopolyModel();
            controller = new MonopolyController(model, view);
            controller.StartNewSpel();                      // todo: fix this

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
           view.DoPaint(e, model);
        }

        // zet alle knoppen aan of uit
        private void EnableDisable()
        {
            // mag de huidige speler nog (of nogmaals) gooien?
            buttonGooi.Enabled = model.HuidigeSpelerMagGooien;
        }

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
            controller.HuidigeSpelerKliktOpKoopHuisHotel();
            EnableDisable();
        }

        private void buttonEindeBeurt_Click(object sender, EventArgs e)
        {
            controller.HuidigeSpelerKliktOpEindeBeurt();
            EnableDisable();
        }


    }
}
