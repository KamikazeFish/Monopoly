namespace Monopoly
{
    partial class KeuzeDialog
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
            this.comboBoxKeuzeActies = new System.Windows.Forms.ComboBox();
            this.buttonKeuzeActies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxKeuzeActies
            // 
            this.comboBoxKeuzeActies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKeuzeActies.FormattingEnabled = true;
            this.comboBoxKeuzeActies.Location = new System.Drawing.Point(12, 12);
            this.comboBoxKeuzeActies.Name = "comboBoxKeuzeActies";
            this.comboBoxKeuzeActies.Size = new System.Drawing.Size(429, 24);
            this.comboBoxKeuzeActies.TabIndex = 0;
            // 
            // buttonKeuzeActies
            // 
            this.buttonKeuzeActies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeuzeActies.Location = new System.Drawing.Point(447, 8);
            this.buttonKeuzeActies.Name = "buttonKeuzeActies";
            this.buttonKeuzeActies.Size = new System.Drawing.Size(94, 30);
            this.buttonKeuzeActies.TabIndex = 1;
            this.buttonKeuzeActies.Text = "Kies Actie";
            this.buttonKeuzeActies.UseVisualStyleBackColor = true;
            this.buttonKeuzeActies.Click += new System.EventHandler(this.buttonKeuzeActies_Click);
            // 
            // KeuzeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 49);
            this.Controls.Add(this.buttonKeuzeActies);
            this.Controls.Add(this.comboBoxKeuzeActies);
            this.Name = "KeuzeDialog";
            this.Text = "KeuzeDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKeuzeActies;
        private System.Windows.Forms.Button buttonKeuzeActies;
    }
}