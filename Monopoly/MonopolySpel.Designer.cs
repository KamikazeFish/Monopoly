namespace Monopoly
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
            this.view = new Monopoly.MonopolyView();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(12, 12);
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
            this.ClientSize = new System.Drawing.Size(1034, 656);
            this.Controls.Add(this.view);
            this.Name = "MonopolySpel";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

    }
}

