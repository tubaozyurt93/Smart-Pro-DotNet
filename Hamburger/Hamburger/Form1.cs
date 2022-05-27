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
                siparisNotlarim.Append(" Orta Menü");
            }
            else if(radioButton2.Checked)
            {
                siparisFiyatBiriktir += 2;
                siparisNotlarim.Append("Büyük Menü (Farkı +2TL) : ");
            }
            else if(radioButton3.Checked)
            {
                siparisFiyatBiriktir += 4;
                siparisNotlarim.Append(" Big Menü (Farkı +4TL) ");
            }
            foreach (Control chckekstra  in groupBox1.Controls)
            {
                if (chckekstra is CheckBox && (chckekstra as CheckBox).Checked)
                {
                    ekstra += 0.50;
                }
                if(ekstra>0)
                {
                    siparisNotlarim.Append(" Ekstralar : ");
                    siparisNotlarim.Append(ekstra.ToString("C2"));

                    siparisFiyatBiriktir += ekstra;
                }
                btn_hesap.Enabled = true;
                Temizle();
            }
            int adet = Convert.ToInt16(numadet.Value);
            siparisFiyatBiriktir *= adet;
            siparisNotlarim.Append(" " + adet.ToString() + "Adet Toplam : ");
            list_siparisler.Items.Add(siparisNotlarim.ToString() + siparisFiyatBiriktir.ToString("C2"));
            toplamhesap += siparisFiyatBiriktir;
        }
        public void Temizle()
        {
            cmb_menu.SelectedIndex = 0;
            radioButton1.Checked = true;
            numadet.Value = 1;
            //for (int i = 0; i < groupBox1.; i++)
            //{
            //    domates_chk.Checked = false;
            //    sogan_chk.Checked = false;
            //    ketcap_chk.Checked = false;
            //    mayonez_chk.Checked = false;
            //    peynir_chk.Checked = false;
            //}
            foreach (Control chckekstra in groupBox1.Controls)
            {
                if (chckekstra is CheckBox && (chckekstra as CheckBox).Checked)
                {
                    (chckekstra as CheckBox).Checked = false;
                }
            }
            list_siparisler.Items.Clear();
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            
            if (true)
            {
                MessageBox.Show("Ödemeniz Gereken Tutar :" + toplamhesap.ToString("C2"));
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
