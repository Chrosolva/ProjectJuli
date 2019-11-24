using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Item_Card[] listitemcard = new Item_Card[20];
            for(int i =0;i< listitemcard.Length;i ++)
            {
                listitemcard[i] = new Item_Card("menu " + i, 20000, "lorem ipsum bla bla bla lba bla", "D:\"Program\"home-512.png");
                flowlayoutpanel.Controls.Add(listitemcard[i]);
            }
            
        }
    }
}
