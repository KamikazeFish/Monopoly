namespace Monopoly
{
    partial class Sandbox_Form
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
            this.nameClickLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameClickLbl
            // 
            this.nameClickLbl.AutoSize = true;
            this.nameClickLbl.Location = new System.Drawing.Point(13, 13);
            this.nameClickLbl.Name = "nameClickLbl";
            this.nameClickLbl.Size = new System.Drawing.Size(16, 13);
            this.nameClickLbl.TabIndex = 0;
            this.nameClickLbl.Text = "...";
            // 
            // Sandbox_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 686);
            this.Controls.Add(this.nameClickLbl);
            this.Name = "Sandbox_Form";
            this.Text = "Sandbox_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameClickLbl;

    }
}