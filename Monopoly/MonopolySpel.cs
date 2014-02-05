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
        private MonopolyModel model;
        private MonopolyView view;
        private MonopolyController controller;

        private KeuzeDialog keuzeDialog;

        public MonopolySpel()
        {
            InitializeComponent();

            RefreshKeuzeDialog();
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

        private void RefreshKeuzeDialog(bool force = false)
        {
            if (keuzeDialog == null || force == true)
            {
                keuzeDialog = new KeuzeDialog();
                keuzeDialog.FormClosing += new FormClosingEventHandler(keuzeDialog_FormClosing);
                keuzeDialog.Shown += new EventHandler(keuzeDialog_Shown);

                view.SetKeuzeDialog(keuzeDialog);
            }
        }

        void keuzeDialog_Shown(object sender, EventArgs e)
        {
            DisableButtons();
        }

        void keuzeDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            // KeuzeDialog wordt gesloten, dus er is een actie die uitgevoerd moet worden
            try
            {
                KeuzeDialog keuzeDialog = (KeuzeDialog)sender;

                if (keuzeDialog.GekozenActie != null)
                {
                    view.AddMessageToLog("Speler '" + model.Spelers.HuidigeSpeler.Naam + "' kiest voor: " + keuzeDialog.GekozenActie.Omschrijving);
                    keuzeDialog.GekozenActie.VoerUit(model, view);
                }

                this.Refresh();
                EnableDisable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is iets mis gegaan bij het uitvoeren van de actie!\n\n" + ex.Message);
            }
            finally
            {
                RefreshKeuzeDialog(true);
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

        private void DisableButtons()
        {
            // alle MonopolySpel buttons disablen
            buttonGooi.Enabled = false;
            buttonEindeBeurt.Enabled = false;
            buttonKoopHuidigeVakje.Enabled = false;
            buttonKoopHuisHotel.Enabled = false;
            comboBoxVolledigeStraten.Enabled = false;
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
            
            // Test KeuzeActie
            /*Kaart kaart = model.AlgemeenFondsKaarten.PakKaart();
            kaart.Actie.VoerUit(model, view);*/
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
            EindeBeurt();
        }

        private void EindeBeurt()
        {
            controller.HuidigeSpelerKliktOpEindeBeurt();
            VulVolledigeStratenDropDown();
            EnableDisable();

            if (model.Spelers.HuidigeSpeler.InDeGevangenis)
            {
                HuidigeSpelerZitInDeGevangenis();
            }
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

        private void HuidigeSpelerZitInDeGevangenis()
        {
            //DisableButtons();
            /*KeuzeActie keuzeActie = new KeuzeActie(
                new List<OmschrijvingActie> { 
                    
                });*/

            // Voor nu een speler meteen uit de gevangenis halen
            model.Spelers.HuidigeSpeler.InDeGevangenis = false;

            EindeBeurt();
        }
   }
}
