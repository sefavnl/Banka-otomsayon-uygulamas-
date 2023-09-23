using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bnkProjesi
{
    public partial class kaydol : Form
    {
        public kaydol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = new Kaydet
            {
                musteriNo = Convert.ToInt32(MusteriNoTextBox.Text),
                sifre = Convert.ToInt32(sifreTextBox.Text)
            };

            MessageBox.Show("Kayıt Tamamlandı");
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
