using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernDesign
{
    public partial class Item_Card : UserControl
    {
        public string Name, desc, imagepath;
        public int price;
        public Item_Card()
        {
            this.Name = "test";
            this.price = 1000;
            this.desc = "Testing lorem ipsum bla bla bla";
            this.imagepath = " ";
            InitializeComponent();
        }

        public Item_Card(string name, int price, string desc, string imagepath)
        {
            this.Name = name;
            this.price = price;
            this.desc = desc;
            this.imagepath = imagepath;
            
            InitializeComponent();
        }

        private void Item_Card_Load(object sender, EventArgs e)
        {
            this.lblNama.Text = this.Name;
            this.lblPrice.Text = "Rp. " + this.price.ToString();
            this.CardImage.Image = Image.FromFile(imagepath);
            this.lblDesc.Text = this.desc;
        }
    }
}
