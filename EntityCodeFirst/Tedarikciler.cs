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
    public partial class Tedarikciler : Form
    {
        public Tedarikciler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=Rukiye;Initial Catalog=EntityCodeFirst;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from Tedarikcilers", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand ekle = new SqlCommand("insert into Tedarikcilers (TedarikciAd, TedarikciSoyad, TedarikAdres, TedarikTelNo) values(@t1,@t2, @t3, @t4)", baglanti);
            ekle.Parameters.AddWithValue("@t1", textBox1.Text);
            ekle.Parameters.AddWithValue("@t2", textBox2.Text);
            ekle.Parameters.AddWithValue("@t3", textBox3.Text);
            ekle.Parameters.AddWithValue("@t4", textBox4.Text);


            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sil = new SqlCommand("Delete from Tedarikcilers where TedarikciAd=@ad", baglanti);
            sil.Parameters.AddWithValue("@ad", textBox1.Text);

            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncelle = new SqlCommand("Update Tedarikcilers set TedarikciAd=@t1, TedarikciSoyad=@t2 where TedarikciAd=@t1", baglanti);
            guncelle.Parameters.AddWithValue("@t1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@t2", textBox2.Text);

            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string adres = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string tel = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            textBox1.Text = ad;
            textBox2.Text = soyad;
            textBox3.Text = adres;
            textBox4.Text = tel;
        }
    }
}
