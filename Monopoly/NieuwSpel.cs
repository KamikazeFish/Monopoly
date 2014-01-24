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
    public partial class NieuwSpel : Form
    {
        private List<string> spelers;

        public NieuwSpel()
        {
            InitializeComponent();
            // Text van errorlabel verwijderen, pas nodig als er een error is
            labelError.Text = string.Empty;
            
            // Default waardes invoegen
            spelers = new List<string> { "Ilja", "Pieter", "Jelle" };
            // Default waardes ook in textBoxNamen zetten
            foreach (string spelersNaam in spelers)
            {
                textBoxNamen.Text += spelersNaam + Environment.NewLine;
            }

            ValidateTextBox();
        }

        public List<string> Spelers { get { return spelers; } }

        private void textBoxNamen_KeyUp(object sender, KeyEventArgs e)
        {
            // Valideer textbox
            ValidateTextBox();
        }

        private void buttonStartSpel_Click(object sender, EventArgs e)
        {
            ValidateTextBox();
        }

        private void ValidateTextBox()
        {          
            labelError.Text = string.Empty;

            List<string> namen = SplitTextBoxNamen();

            if (namen.Count > 4)
            {
                buttonStartSpel.DialogResult = System.Windows.Forms.DialogResult.None;
                labelError.Text = "Meer dan 4 namen ingevoerd!";
            }
            else
            {
                buttonStartSpel.DialogResult = System.Windows.Forms.DialogResult.OK;
                spelers = namen;
            }
        }

        private List<string> SplitTextBoxNamen()
        {
            // De namen uit de multiline textbox halen en de lege regels eruit halen
            List<string> names = new List<string>();

            string text = textBoxNamen.Text;
            string[] textRegels = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string regel in textRegels)
            {
                string name = regel.Trim();
                if (name != string.Empty)
                {
                    names.Add(name);
                }
            }

            return names;
        }

        private void buttonStartSpel_MouseHover(object sender, EventArgs e)
        {
            buttonStartSpel.Image = Monopoly.Properties.Resources.monopoly_1_click;
        }

        private void buttonStartSpel_MouseLeave(object sender, EventArgs e)
        {
            buttonStartSpel.Image = Monopoly.Properties.Resources.monopoly_1;
        }
    }
}
