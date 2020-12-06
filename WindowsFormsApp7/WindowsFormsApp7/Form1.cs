using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            string plaka = Convert.ToString(textBox1.Text);
            string[]plakakelimeler = plaka.Split(Convert.ToChar(" "));
            int sehirkod = Convert.ToInt32(plakakelimeler[0]);
            int plakakod = Convert.ToInt32(plakakelimeler[2]);
            if (plakakod % sehirkod == 0)
            {
                int bolum1 = plakakod / sehirkod;
                label2.Text = "KARDEŞİM BU PLAKA TAM BİR SANAT ESERİ!";
                label2.Show();
                label3.Text = "TAM OLARAK" +" "+ Convert.ToString(bolum1)+" " + "KATI!";
                label3.Show();
            }else if (plakakod % sehirkod > 0)
            {
                int kalan1 = plakakod % sehirkod;
                label2.Text = "D- DOSTUM BU PLAKA BİRAZ CRİNGEMİŞ DOĞRUSU";
                label2.Show();
                label3.Text="ŞU SON YAZDIĞINDAN"+" "+Convert.ToString(kalan1)+" "+"ÇIKARIP BİR DAHA YAZSANA KNK";
                label3.Show();
            }
        }
    }
}
