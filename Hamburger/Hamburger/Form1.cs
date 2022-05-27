using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class Form1 : Form
    {
        double[] fiyat = { 85, 89, 83 };
        StringBuilder siparisNotlarim=new StringBuilder();
        double ekstra, toplamhesap,siparisFiyatBiriktir=0;

        private void btn_siparis_Click(object sender, EventArgs e)
        {
            siparisFiyatBiriktir = fiyat[cmb_menu.SelectedIndex];
            siparisNotlarim.Append(cmb_menu.SelectedItem.ToString());
            if (radioButton1.Checked)
            {
                siparisNotlarim.Append("Orta Menü");
            }
            else if(radioButton2.Checked)
            {
                siparisFiyatBiriktir += 2;
                siparisNotlarim.Append("Büyük Menü (Farkı +2TL) : ");
            }
            else if(radioButton3.Checked)
            {
                siparisFiyatBiriktir += 4;
                siparisNotlarim.Append("Big Menü (Farkı +4TL) ");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked=true;
            cmb_menu.SelectedIndex=0;
        }
    }
}
