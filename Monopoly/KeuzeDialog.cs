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
    public partial class KeuzeDialog : Form
    {
        List<OmschrijvingActie> acties;
        OmschrijvingActie gekozenActie;

        public KeuzeDialog()
        {
            InitializeComponent();
            this.acties = new List<OmschrijvingActie>();
        }

        public OmschrijvingActie GekozenActie { get { return gekozenActie; } }

        public void AddActie(OmschrijvingActie actie)
        {
            acties.Add(actie);
            RefreshControls();
        }

        public void ClearActies()
        {
            acties.Clear();
            RefreshControls();
        }

        private void RefreshComboBox()
        {
            comboBoxKeuzeActies.Items.Clear();

            foreach (OmschrijvingActie act in acties)
            {
                comboBoxKeuzeActies.Items.Add(act.Omschrijving);
            }

            if (comboBoxKeuzeActies.Items.Count > 0)
            {
                comboBoxKeuzeActies.SelectedIndex = 0;
                gekozenActie = acties.First();
            }
        }

        private void RefreshButton()
        {
            buttonKeuzeActies.Enabled = (comboBoxKeuzeActies.Items.Count > 0);
        }

        private void RefreshControls()
        {
            RefreshComboBox();
            RefreshButton();
        }

        private void buttonKeuzeActies_Click(object sender, EventArgs e)
        {
            KiesActie();
            SluitDialoog();
        }

        private void KiesActie()
        {
            if (comboBoxKeuzeActies.Items.Count > 0)
            {
                foreach (OmschrijvingActie actie in acties)
                {
                    if (actie.Omschrijving == comboBoxKeuzeActies.SelectedItem.ToString())
                    {
                        gekozenActie = actie;
                        break;
                    }
                }
            }
        }

        public void SluitDialoog()
        {
            ClearActies();
            this.Close();
        }
    }
}
