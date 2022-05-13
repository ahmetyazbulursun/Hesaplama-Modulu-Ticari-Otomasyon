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
    public partial class FrmTeklifler : Form
    {
        public FrmTeklifler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public void TeklifListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, KIME as 'Müşteri/Firma', TARIH From Tbl_Teklifler Where DURUM='false'", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Temizle()
        {
            txtAd.Text = "";
            txtID.Text = "";
        }

        private void FrmTeklifler_Load(object sender, EventArgs e)
        {
            TeklifListesi();
            Temizle();
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("Müşteri/Firma").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil;
            sil = MessageBox.Show("Teklifi Silmek İstediğinize Emin Misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            if (sil == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update Tbl_Teklifler Set DURUM=@p1 Where ID=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", true);
                komut.Parameters.AddWithValue("@p2", txtID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                TeklifListesi();
                MessageBox.Show("Teklif Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            
        }
    }
}
