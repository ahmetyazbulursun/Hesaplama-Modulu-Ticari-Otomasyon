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
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new FrmAnaSayfa();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }


        FrmUrunler fr1;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 == null || fr1.IsDisposed)
            {
                fr1 = new FrmUrunler();
                fr1.MdiParent = this;
                fr1.Show();
            }
        }

        FrmTeklifler fr2;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new FrmTeklifler();
                fr2.MdiParent = this;
                fr2.Show();
            }

        }


        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYeniTeklif fr = new FrmYeniTeklif();
            fr.Show();
        }


        FrmAnaSayfa fr3;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new FrmAnaSayfa();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }

        DialogResult kapat = new DialogResult();

        private void FrmAnaModul_FormClosing(object sender, FormClosingEventArgs e)
        {
            kapat = MessageBox.Show("Uygulamayı Kapatmak İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kapat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmAnaModul_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }

}
