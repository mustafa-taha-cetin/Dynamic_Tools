using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnKonum = new Point(150,150);
            btn.Location = btnKonum;
            btn.Name= "btnYeni";
            btn.Text = "Yeni Buton";
            btn.BackColor= Color.YellowGreen;
            btn.Height= 50;
            btn.Width= 100;
            // Buton oluşturuldu

            Label lbl = new Label();
            Point lblKonum = new Point(300,300);
            lbl.Location = lblKonum;
            lbl.Name = "lblYeni";
            lbl.Text = "Yeniyim";
            lbl.BackColor= Color.Lime;
            lbl.Height= 100;
            lbl.Width= 150;
            lbl.AutoSize= true; // Kendisine göre size ayarlıyor
            // Label oluşturuldu

            this.Controls.Add(lbl);
            // Label getirildi
            this.Controls.Add(btn);
            // Buton getirildi


            
            for(int i=1 ; i <=5 ; i++)
            {
                TextBox txt = new TextBox();
                Point txtKonum = new Point(300,i*50);
                txt.Location = txtKonum;
                txt.Height= 50;
                txt.Width= 100;
                txt.AutoSize= true;
                this.Controls.Add(txt);
                // Yeni textbox oluşturuldu
            }
            // Birden çok Textbox oluşturmuş olduk


        }
    }
}
