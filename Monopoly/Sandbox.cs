using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    public class Sandbox_entity
    {
        private int index; // nummer in lijst
        private int posX;  // links-boven x positie
        private int posY;  // links-boven y positie
        private int height;
        private int width;
        private string name;

        public Sandbox_entity(int index, int posX, int posY, int width, int height, string name)
        {
            this.index = index;
            this.posX = posX;
            this.posY = posY;
            this.width = width;
            this.height = height;
            this.name = name;
        }

        public int Index { get { return this.index; } set { this.index = value; } }
        public int PosX { get { return this.posX; } set { this.posX = value; } }
        public int PosY { get { return this.posY; } set { this.posY = value; } }
        public int Width { get { return this.width; } set { this.width = value; } }
        public int Height { get { return this.height; } set { this.height = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }

        public void Draw(Form form)
        {
            GroupBox grpBox = new GroupBox();
            grpBox.BackColor = System.Drawing.Color.White;

            grpBox.Width = this.width;
            grpBox.Height = this.height;

            grpBox.Location = new System.Drawing.Point(this.posX, this.posY);
            grpBox.Click += new EventHandler(grpBox_Click);

            form.Controls.Add(grpBox);

            Label nameLbl = new Label();
            nameLbl.Text = this.name;

            nameLbl.Location = new System.Drawing.Point(2, 2);
            nameLbl.Name = "nameLbl";
            grpBox.Controls.Add(nameLbl);
        }

        void grpBox_Click(object sender, EventArgs e)
        {
            GroupBox grpBox = (GroupBox)sender;
            Label nameLbl = (Label)grpBox.Controls.Find("nameLbl", false)[0];

            MessageBox.Show(nameLbl.Text);
        }
    }

    public class Sandbox
    {
        private List<Sandbox_entity> entities;

        public Sandbox()
        {
            this.entities = new List<Sandbox_entity>();

            this.PopulateEntities();
        }

        public List<Sandbox_entity> Entities { get { return this.entities; } }

        public void PopulateEntities()
        {
            List<string> texts = GetTexts();

            int posX = 80; // startPosX
            int posY = 10; // startPosY

            int width = 100;
            int height = 50;

            int margin = 2;
            int i = 1;

            do
	        {
                Sandbox_entity entity = new Sandbox_entity(i, posX, posY, width, height, texts[i-1]);
                this.entities.Add(entity);

                int divideByTen = (int)Math.Ceiling(i / (double)10);

                switch (divideByTen)
	            {
                    case 1:
                        posX += (width + margin);
                        break;
                    case 2:
                        posY += (height + margin);
                        break;
                    case 3:
                        posX -= (width + margin);
                        break;
		            default:
                        posY -= (height + margin);
                        break;
	            }
                i++;
	        } while (i <= 40);           
        }

        private List<string> GetTexts()
        {
            // wikipedia monopoly - firefox - ctrl op tabelvakjes - ctrl-c
            // sublime text 2 - replace... - regexp on - find /n - replace "/n"

            List<string> names = new List<string> {
                "Start",
                "Dorpsstraat Ons Dorp",
                "Algemeen fonds",
                "Brink Ons Dorp",
                "Inkomstenbelasting",
                "Station Zuid",
                "Steenstraat Arnhem",
                "Kans",
                "Ketelstraat Arnhem",
                "Velperplein Arnhem",
                "Gevangenis",
                "Barteljorisstraat Haarlem",
                "Elektriciteitsbedrijf",
                "Zijlweg Haarlem",
                "Houtstraat Haarlem",
                "Station West",
                "Neude Utrecht",
                "Algemeen fonds",
                "Biltstraat Utrecht",
                "Vreeburg Utrecht",
                "Vrij parkeren",
                "A Kerkhof Groningen",
                "Kans",
                "Grote Markt Groningen",
                "Heerestraat Groningen",
                "Station Noord",
                "Spui 's-Gravenhage",
                "Plein 's-Gravenhage",
                "Waterleiding",
                "Lange Poten 's-Gravenhage",
                "Naar de gevangenis",
                "Hofplein Rotterdam",
                "Blaak Rotterdam",
                "Algemeen fonds",
                "Coolsingel Rotterdam",
                "Station Oost",
                "Kans",
                "Leidschestraat Amsterdam",
                "Extra belasting",
                "Kalverstraat Amsterdam"
            };
            return names;
        }
    }
}
