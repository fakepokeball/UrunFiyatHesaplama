using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sonFiyat;
        double indirim = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtFiyat.Text, out double girilenFiyat))
            {
                MessageBox.Show("Hatalı Giriş");
            }
            else
            {
                sonFiyat = girilenFiyat;
                if (chkNakit.Checked)
                {
                    indirim += (girilenFiyat * 5) / 100;
                }
                if (chkKampanya.Checked)
                {
                    indirim += (girilenFiyat * 10) / 100;
                }
                if (chkDevamli.Checked)
                {
                    indirim += (girilenFiyat * 10) / 100;
                }
                sonFiyat = girilenFiyat - indirim;
                indirim = 0;
                lblSonFiyat.Text = sonFiyat.ToString();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtFiyat.Clear();
            lblSonFiyat.Text = "";
            chkDevamli.Checked= false;
            chkKampanya.Checked= false;
            chkNakit.Checked= false;


        }
    }
}
