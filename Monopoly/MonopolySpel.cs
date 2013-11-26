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
        private Gameloop gameloop;

        public MonopolySpel()
        {
            model = new MonopolyModel();

            InitializeComponent();

            this.gameloop = new Gameloop(model);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
           view.DoPaint(e, model);
        }


    }
}
