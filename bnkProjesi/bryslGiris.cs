using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bnkProjesi
{
    public partial class bryslGiris : Form
    {
        public bryslGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kaydet kydt = new Kaydet
            {
                sayi1 = Convert.ToInt32(maskedTextBox1.Text),
                sayi2 = Convert.ToInt32(maskedTextBox2.Text)
            };
            if (kydt.musteriNo == kydt.sayi1 && kydt.sifre == kydt.sayi2)
            {
                BireyselAnaSayfa anaSayfa = new BireyselAnaSayfa();
                anaSayfa.Show();
            }
            else
            {
                MessageBox.Show("hatalı sıfre");
            }
        }
    }
}
