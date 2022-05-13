using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje
{
    public partial class FrmYeniTeklif : Form
    {
        public FrmYeniTeklif()
        {
            InitializeComponent();
        }


        sqlbaglantisi bgl = new sqlbaglantisi();


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtFirmaMusteriAd.Text == "" || mskTarih.Text == "")
            {
                MessageBox.Show("Teklif Bilgileri Boş Bırakılamaz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlCommand komut = new SqlCommand("Insert Into Tbl_Teklifler (KIME, TARIH, DURUM) Values (@p1,@p2,@p3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtFirmaMusteriAd.Text);
                komut.Parameters.AddWithValue("@p2", DateTime.Parse(mskTarih.Text));
                komut.Parameters.AddWithValue("@p3", false);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Teklif Başarıyla Oluşturuldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            
        }
    }
}
