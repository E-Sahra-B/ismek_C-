using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace kütüphane
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAB03-01;Initial Catalog=kitaplik;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        void listele()
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_books", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void tur_listele()
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_tur",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTur.ValueMember = "id";
            cmbTur.DisplayMember = "turAdi";
            cmbTur.DataSource = dt;

        }
        void kitap_adedi()
        {
            SqlCommand cmdAdet = new SqlCommand("select count(kitapAdi) from tbl_books", baglanti);
            baglanti.Open();
            object sonuc = cmdAdet.ExecuteScalar();
            lblAdet.Text = sonuc.ToString();
            baglanti.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            tur_listele();
            label10.Text = DateTime.Now.ToString();
            kitap_adedi();
        }
        void temizle()
        {
            txtId.Clear();
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtYayinEvi.Clear();
            txtSayfa.Clear();
            txtFiyat.Clear();
            cmbTur.Text = "";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmdekle = new SqlCommand("INSERT INTO tbl_books(yazarAdi,kitapAdi,kitapTuru,yayinEvi,sayfa,fiyat) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            cmdekle.Parameters.AddWithValue("@p1", txtYazar.Text);
            cmdekle.Parameters.AddWithValue("@p2", txtKitapAdi.Text);
            cmdekle.Parameters.AddWithValue("@p3", cmbTur.SelectedIndex);//tür
            cmdekle.Parameters.AddWithValue("@p4", txtYayinEvi.Text);
            cmdekle.Parameters.AddWithValue("@p5", txtSayfa.Text);
            cmdekle.Parameters.AddWithValue("@p6", Convert.ToDecimal(txtFiyat.Text));//fiyat
            cmdekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydınız Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
            kitap_adedi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmdSil = new SqlCommand("Delete from tbl_books where id=@p1", baglanti);
            cmdSil.Parameters.AddWithValue("@p1", txtId.Text);
            cmdSil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap veritabanından silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
            kitap_adedi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmdGuncelle = new SqlCommand("update tbl_books set yazarAdi=@p1,kitapAdi=@p2,kitapTuru=@p3,yayinEvi=@p4,sayfa=@p5,fiyat=@p6 where id=@p7", baglanti);
            cmdGuncelle.Parameters.AddWithValue("@p1", txtYazar.Text);
            cmdGuncelle.Parameters.AddWithValue("@p2", txtKitapAdi.Text);
            cmdGuncelle.Parameters.AddWithValue("@p3", Convert.ToInt32(cmbTur.SelectedIndex));//tür
            cmdGuncelle.Parameters.AddWithValue("@p4", txtYayinEvi.Text);
            cmdGuncelle.Parameters.AddWithValue("@p5", txtSayfa.Text);
            cmdGuncelle.Parameters.AddWithValue("@p6", Convert.ToDecimal(txtFiyat.Text));//fiyat
            cmdGuncelle.Parameters.AddWithValue("@p7", Convert.ToInt32(txtId.Text));//id
            cmdGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKitapAdi.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtYayinEvi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbTur.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}