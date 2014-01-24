namespace Monopoly
{
    partial class NieuwSpel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NieuwSpel));
            this.textBoxNamen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartSpel = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNamen
            // 
            this.textBoxNamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamen.Location = new System.Drawing.Point(12, 50);
            this.textBoxNamen.Multiline = true;
            this.textBoxNamen.Name = "textBoxNamen";
            this.textBoxNamen.Size = new System.Drawing.Size(300, 224);
            this.textBoxNamen.TabIndex = 4;
            this.textBoxNamen.TabStop = false;
            this.textBoxNamen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNamen_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Voer spelersnamen in: ";
            // 
            // buttonStartSpel
            // 
            this.buttonStartSpel.BackColor = System.Drawing.Color.White;
            this.buttonStartSpel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartSpel.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartSpel.Image")));
            this.buttonStartSpel.Location = new System.Drawing.Point(12, 326);
            this.buttonStartSpel.Name = "buttonStartSpel";
            this.buttonStartSpel.Size = new System.Drawing.Size(300, 300);
            this.buttonStartSpel.TabIndex = 7;
            this.buttonStartSpel.Text = "button1";
            this.buttonStartSpel.UseVisualStyleBackColor = false;
            this.buttonStartSpel.Click += new System.EventHandler(this.buttonStartSpel_Click);
            this.buttonStartSpel.MouseEnter += new System.EventHandler(this.buttonStartSpel_MouseHover);
            this.buttonStartSpel.MouseLeave += new System.EventHandler(this.buttonStartSpel_MouseLeave);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(19, 288);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(75, 17);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "ErrorLabel";
            // 
            // NieuwSpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 639);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonStartSpel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNamen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NieuwSpel";
            this.Text = "Monopoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNamen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartSpel;
        private System.Windows.Forms.Label labelError;
    }
}