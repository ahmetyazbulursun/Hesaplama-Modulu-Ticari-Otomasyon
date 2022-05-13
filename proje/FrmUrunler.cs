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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }


        // BAĞLANTI SINIFINDAN SQL BAĞLANTISI TÜRETİLDİ
        sqlbaglantisi bgl = new sqlbaglantisi();


        // VERİTABANINDAKİ ÜRÜNLERİ LİSTELEME METODU
        void UrunListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ID, URUNAD as 'ÜRÜN', MARKA, HESAPTURU as 'TÜR', FIYAT as 'FİYAT', ACIKLAMA as 'AÇIKLAMA' From Tbl_Urunler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }


        // TEMİZLEME METODU
        void Temizle()
        {
            txtID.Text = "";
            txtIslemTuru.Text = "";
            txtMarka.Text = "";
            txtUrunAd.Text = "";
            txtFiyat.Text = "";
            rchAciklama.Text = "";
        }


        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            UrunListesi();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAd.Text = gridView1.GetFocusedRowCellValue("ÜRÜN").ToString();
            txtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtIslemTuru.Text = gridView1.GetFocusedRowCellValue("TÜR").ToString();
            txtFiyat.Text = gridView1.GetFocusedRowCellValue("FİYAT").ToString();
            rchAciklama.Text = gridView1.GetFocusedRowCellValue("AÇIKLAMA").ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtFiyat.Text == "" || txtIslemTuru.Text == "" || txtMarka.Text == "" || txtUrunAd.Text == "")
            {
                MessageBox.Show("Ürün Bilgileri Doldurulmalıdır!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Insert Into Tbl_Urunler (URUNAD, MARKA, HESAPTURU, FIYAT, ACIKLAMA) Values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", txtMarka.Text);
                komut.Parameters.AddWithValue("@p3", txtIslemTuru.Text);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p5", rchAciklama.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                UrunListesi();
                MessageBox.Show("Ürün Sisteme Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Urunler Where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            UrunListesi();
            MessageBox.Show("Ürün Sistemden Başarıyla Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Urunler Set URUNAD=@p1, MARKA=@p2, HESAPTURU=@p3, FIYAT=@p4, ACIKLAMA=@p5 Where ID=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtIslemTuru.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtFiyat.Text));
            komut.Parameters.AddWithValue("@p5", rchAciklama.Text);
            komut.Parameters.AddWithValue("@p6", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            UrunListesi();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }
    }
}
