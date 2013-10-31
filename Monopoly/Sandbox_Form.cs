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
    public partial class Sandbox_Form : Form
    {
        Sandbox sandbox;

        public Sandbox_Form()
        {
            InitializeComponent();

            sandbox = new Sandbox();

            this.Draw();
        }

        private void Draw()
        {
            foreach (Sandbox_entity entity in sandbox.Entities)
            {
                entity.Draw(this);
            }
        }
    }
}
