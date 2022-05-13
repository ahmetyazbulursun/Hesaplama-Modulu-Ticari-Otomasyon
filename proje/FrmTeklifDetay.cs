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
    public partial class FrmTeklifDetay : Form
    {
        public FrmTeklifDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string id;
        
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ID, URUNAD as 'ÜRÜN', MARKA, HESAPTURU as 'TÜR', MIKTAR as 'MİKTAR', FIYAT as 'FİYAT', TEKLIFID as 'ALICI' From Tbl_TeklifDetay Where TEKLIFID='"+id+"'",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void UrunListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ID, URUNAD as 'ÜRÜN', MARKA, HESAPTURU as 'TÜR', FIYAT as 'FİYAT' From Tbl_Urunler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        void Temizle()
        {
            txtAdet.Text = "";
            txtFiyat.Text = "";
            txtID.Text = "";
            txtMarka.Text = "";
            txtUrunAd.Text = "";
            txtIslemTuru.Text = "";
        }

        void ToplamTutar()
        {
            SqlCommand komut = new SqlCommand("Select Sum(FIYAT) From Tbl_TeklifDetay Where TEKLIFID='" + id + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblToplamTutar.Text = dr[0] + " ₺".ToString();
            }
        }

        private void FrmTeklifDetay_Load(object sender, EventArgs e)
        {
            Listele();
            UrunListesi();
            Temizle();
            ToplamTutar();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
            txtUrunAd.Text = gridView2.GetFocusedRowCellValue("ÜRÜN").ToString();
            txtMarka.Text = gridView2.GetFocusedRowCellValue("MARKA").ToString();
            txtIslemTuru.Text = gridView2.GetFocusedRowCellValue("TÜR").ToString();
            txtFiyat.Text = gridView2.GetFocusedRowCellValue("FİYAT").ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtAdet.Text==""||txtFiyat.Text=="" || txtIslemTuru.Text == "" || txtMarka.Text == "" || txtUrunAd.Text == "")
            {
                MessageBox.Show("Ürün Bilgileri Doldurulmalıdır1", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double fiyat, adet, sonuc;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                adet = Convert.ToDouble(txtAdet.Text);
                sonuc = adet * fiyat;

                SqlCommand komut = new SqlCommand("Insert Into Tbl_TeklifDetay (URUNAD,MARKA,HESAPTURU,MIKTAR,FIYAT,TEKLIFID) Values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", txtMarka.Text);
                komut.Parameters.AddWithValue("@p3", txtIslemTuru.Text);
                komut.Parameters.AddWithValue("@p4", txtAdet.Text);
                komut.Parameters.AddWithValue("@p5", sonuc);
                komut.Parameters.AddWithValue("@p6", id);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                ToplamTutar();
                Listele();
                MessageBox.Show("Ürün Başarıyla Teklife Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_TeklifDetay Where ID=@p1", bgl.baglanti()); ;
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            ToplamTutar();
            MessageBox.Show("Ürün Tekliften Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAd.Text = gridView1.GetFocusedRowCellValue("ÜRÜN").ToString();
            txtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtIslemTuru.Text = gridView1.GetFocusedRowCellValue("TÜR").ToString();
            txtAdet.Text = gridView1.GetFocusedRowCellValue("MİKTAR").ToString();
            txtFiyat.Text = gridView1.GetFocusedRowCellValue("FİYAT").ToString();
        }

    }
}
