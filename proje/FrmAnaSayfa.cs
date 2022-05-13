using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace proje
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }


        sqlbaglantisi bgl = new sqlbaglantisi();


        // SON 10 TEKLİF
        void SonTeklifler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Top 10 ID, KIME as 'Müşteri/Firma' , TARIH as 'TARİH' From Tbl_Teklifler Where DURUM='false' Order By ID Desc", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        // ÜRÜNLERİN LİSTESİ
        void UrunListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select URUNAD as 'ÜRÜN', MARKA, FIYAT as 'FİYAT', ACIKLAMA as 'AÇIKLAMA' From Tbl_Urunler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        // TOPLAM ÜRÜN
        void ToplamUrun()
        {
            SqlCommand komut = new SqlCommand("Select Count(*) From Tbl_Urunler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblToplamUrun.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        // TOPLAM TEKLİF
        void ToplamTeklif()
        {
            SqlCommand komut = new SqlCommand("Select Count(*) From Tbl_Teklifler Where DURUM='false'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblToplamTeklif.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            UrunListesi();
            SonTeklifler();
            ToplamTeklif();
            ToplamUrun();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmTeklifDetay fr = new FrmTeklifDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["ID"].ToString();
                fr.Show();
            }
        }

    }
}
