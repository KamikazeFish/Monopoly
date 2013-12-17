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
            this.buttonGooi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.view = new Monopoly.MonopolyView();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonGooi
            // 
            this.buttonGooi.Location = new System.Drawing.Point(36, 600);
            this.buttonGooi.Name = "buttonGooi";
            this.buttonGooi.Size = new System.Drawing.Size(142, 23);
            this.buttonGooi.TabIndex = 1;
            this.buttonGooi.Text = "Gooi!";
            this.buttonGooi.UseVisualStyleBackColor = true;
            this.buttonGooi.Click += new System.EventHandler(this.buttonGooi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 629);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Koop huidige vakje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonKoopHuidigeVakje_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 658);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Koop huis/hotel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonKoopHuisHotel_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 687);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Einde beurt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonEindeBeurt_Click);
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
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(251, 600);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(771, 108);
            this.listBoxLog.TabIndex = 5;
            // 
            // MonopolySpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 735);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonGooi);
            this.Controls.Add(this.view);
            this.Name = "MonopolySpel";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGooi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBoxLog;

    }
}

