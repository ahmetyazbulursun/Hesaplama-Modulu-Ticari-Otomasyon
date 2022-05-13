using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }


        private void FrmGiris_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar1.Visible = true;
            labelControl3.Visible = true;

            progressBar1.Value = sayac;
            if (sayac == 1)
            {
                labelControl3.Text = "Kullanıcı Bilgileri Doğrulanıyor.";
            }

            if (sayac == 2)
            {
                labelControl3.Text = "Kullanıcı Bilgileri Doğrulanıyor..";
            }

            if (sayac == 3)
            {
                labelControl3.Text = "Veri Tabanı Bağlantısı Kuruluyor.";
            }

            if (sayac == 4)
            {
                labelControl3.Text = "Veri Tabanı Bağlantısı Kuruluyor..";
            }

            if (sayac == 5)
            {
                labelControl3.Text = "Uygulama Başlatılıyor.";
            }

            if (sayac == 6)
            {
                labelControl3.Text = "Uygulama Başlatılıyor..";
            }

            if (sayac == 7)
            {
                timer1.Stop();
                FrmAnaModul fr = new FrmAnaModul();
                fr.Show();
                this.Hide();
            }
        }

        
    }
}
