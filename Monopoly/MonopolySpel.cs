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
        private MonopolyController controller;
        private Gameloop gameloop;

        public MonopolySpel()
        {
            model = new MonopolyModel();
            controller = new MonopolyController(model);
            controller.StartNewSpel();                      // todo: fix this

            InitializeComponent();

            this.gameloop = new Gameloop(model);


        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
           view.DoPaint(e, model);
        }


    }
}
