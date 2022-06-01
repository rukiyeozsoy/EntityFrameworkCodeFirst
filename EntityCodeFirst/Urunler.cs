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

namespace EntityCodeFirst
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Rukiye;Initial Catalog=EntityCodeFirst;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Urunlers", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand ekle = new SqlCommand("insert into Urunlers (UrunAd, UrunKategori) values(@u1,@u2)", baglanti);
            ekle.Parameters.AddWithValue("@u1", textBox1.Text);
            ekle.Parameters.AddWithValue("@u2", textBox2.Text);
            

            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sil = new SqlCommand("Delete from Urunlers where UrunAd=@ad", baglanti);
            sil.Parameters.AddWithValue("@ad", textBox1.Text);
            
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string kategori = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            textBox1.Text = ad;
            textBox2.Text = kategori;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncelle = new SqlCommand("Update Urunlers set UrunAd=@u1, UrunKategori=@u2 where UrunAd=@u1", baglanti);
            guncelle.Parameters.AddWithValue("@u1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@u2", textBox2.Text);

            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris git = new Giris();
            git.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Urunlers where UrunAd like '%" + textBox3.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Urunlers order by UrunAd asc", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
