﻿namespace Monopoly
{
    partial class MonopolySpel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonopolySpel));
            this.buttonGooi = new System.Windows.Forms.Button();
            this.buttonKoopHuidigeVakje = new System.Windows.Forms.Button();
            this.buttonKoopHuisHotel = new System.Windows.Forms.Button();
            this.buttonEindeBeurt = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.comboBoxVolledigeStraten = new System.Windows.Forms.ComboBox();
            this.labelBedragHuidigeVakje = new System.Windows.Forms.Label();
            this.menuStripMonopoly = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwSpelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view = new Monopoly.MonopolyView();
            this.menuStripMonopoly.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGooi
            // 
            this.buttonGooi.Location = new System.Drawing.Point(12, 600);
            this.buttonGooi.Name = "buttonGooi";
            this.buttonGooi.Size = new System.Drawing.Size(142, 23);
            this.buttonGooi.TabIndex = 1;
            this.buttonGooi.Text = "Gooi!";
            this.buttonGooi.UseVisualStyleBackColor = true;
            this.buttonGooi.Click += new System.EventHandler(this.buttonGooi_Click);
            // 
            // buttonKoopHuidigeVakje
            // 
            this.buttonKoopHuidigeVakje.Location = new System.Drawing.Point(12, 629);
            this.buttonKoopHuidigeVakje.Name = "buttonKoopHuidigeVakje";
            this.buttonKoopHuidigeVakje.Size = new System.Drawing.Size(142, 23);
            this.buttonKoopHuidigeVakje.TabIndex = 2;
            this.buttonKoopHuidigeVakje.Text = "Koop huidige vakje";
            this.buttonKoopHuidigeVakje.UseVisualStyleBackColor = true;
            this.buttonKoopHuidigeVakje.Click += new System.EventHandler(this.buttonKoopHuidigeVakje_Click);
            // 
            // buttonKoopHuisHotel
            // 
            this.buttonKoopHuisHotel.Location = new System.Drawing.Point(12, 658);
            this.buttonKoopHuisHotel.Name = "buttonKoopHuisHotel";
            this.buttonKoopHuisHotel.Size = new System.Drawing.Size(96, 23);
            this.buttonKoopHuisHotel.TabIndex = 3;
            this.buttonKoopHuisHotel.Text = "Koop huis/hotel";
            this.buttonKoopHuisHotel.UseVisualStyleBackColor = true;
            this.buttonKoopHuisHotel.Click += new System.EventHandler(this.buttonKoopHuisHotel_Click);
            // 
            // buttonEindeBeurt
            // 
            this.buttonEindeBeurt.Location = new System.Drawing.Point(12, 687);
            this.buttonEindeBeurt.Name = "buttonEindeBeurt";
            this.buttonEindeBeurt.Size = new System.Drawing.Size(142, 23);
            this.buttonEindeBeurt.TabIndex = 4;
            this.buttonEindeBeurt.Text = "Einde beurt";
            this.buttonEindeBeurt.UseVisualStyleBackColor = true;
            this.buttonEindeBeurt.Click += new System.EventHandler(this.buttonEindeBeurt_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(251, 600);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(771, 108);
            this.listBoxLog.TabIndex = 5;
            // 
            // comboBoxVolledigeStraten
            // 
            this.comboBoxVolledigeStraten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVolledigeStraten.FormattingEnabled = true;
            this.comboBoxVolledigeStraten.Location = new System.Drawing.Point(115, 658);
            this.comboBoxVolledigeStraten.Name = "comboBoxVolledigeStraten";
            this.comboBoxVolledigeStraten.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVolledigeStraten.TabIndex = 6;
            this.comboBoxVolledigeStraten.TextChanged += new System.EventHandler(this.comboBoxVolledigeStraten_TextChanged);
            // 
            // labelBedragHuidigeVakje
            // 
            this.labelBedragHuidigeVakje.AutoSize = true;
            this.labelBedragHuidigeVakje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBedragHuidigeVakje.Location = new System.Drawing.Point(160, 632);
            this.labelBedragHuidigeVakje.Name = "labelBedragHuidigeVakje";
            this.labelBedragHuidigeVakje.Size = new System.Drawing.Size(13, 17);
            this.labelBedragHuidigeVakje.TabIndex = 7;
            this.labelBedragHuidigeVakje.Text = "-";
            // 
            // menuStripMonopoly
            // 
            this.menuStripMonopoly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem});
            this.menuStripMonopoly.Location = new System.Drawing.Point(0, 0);
            this.menuStripMonopoly.Name = "menuStripMonopoly";
            this.menuStripMonopoly.Size = new System.Drawing.Size(1034, 24);
            this.menuStripMonopoly.TabIndex = 8;
            this.menuStripMonopoly.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwSpelToolStripMenuItem,
            this.sluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // nieuwSpelToolStripMenuItem
            // 
            this.nieuwSpelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nieuwSpelToolStripMenuItem.Image")));
            this.nieuwSpelToolStripMenuItem.Name = "nieuwSpelToolStripMenuItem";
            this.nieuwSpelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nieuwSpelToolStripMenuItem.Text = "Nieuw Spel";
            this.nieuwSpelToolStripMenuItem.Click += new System.EventHandler(this.nieuwSpelToolStripMenuItem_Click);
            // 
            // sluitenToolStripMenuItem
            // 
            this.sluitenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sluitenToolStripMenuItem.Image")));
            this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
            this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sluitenToolStripMenuItem.Text = "Sluiten";
            this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.sluitenToolStripMenuItem_Click);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(12, 25);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(1010, 558);
            this.view.TabIndex = 0;
            this.view.TabStop = false;
            this.view.Text = "Speelbord";
            this.view.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // MonopolySpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 729);
            this.Controls.Add(this.labelBedragHuidigeVakje);
            this.Controls.Add(this.comboBoxVolledigeStraten);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.buttonEindeBeurt);
            this.Controls.Add(this.buttonKoopHuisHotel);
            this.Controls.Add(this.buttonKoopHuidigeVakje);
            this.Controls.Add(this.buttonGooi);
            this.Controls.Add(this.view);
            this.Controls.Add(this.menuStripMonopoly);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMonopoly;
            this.Name = "MonopolySpel";
            this.Text = "Monopoly Spel";
            this.menuStripMonopoly.ResumeLayout(false);
            this.menuStripMonopoly.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGooi;
        private System.Windows.Forms.Button buttonKoopHuidigeVakje;
        private System.Windows.Forms.Button buttonKoopHuisHotel;
        private System.Windows.Forms.Button buttonEindeBeurt;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.ComboBox comboBoxVolledigeStraten;
        private System.Windows.Forms.Label labelBedragHuidigeVakje;
        private System.Windows.Forms.MenuStrip menuStripMonopoly;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwSpelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;

    }
}

