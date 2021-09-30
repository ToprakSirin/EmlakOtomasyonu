using System;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiteEmlakProgrami
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MKCV300;Initial Catalog=siteler;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from sitebilgiler", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());

                listView1.Items.Add(ekle);


            }
            baglan.Close();




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Zambak Sitesi")
            {
                button1.BackColor = Color.Pink;
                button2.BackColor = Color.Goldenrod;
                button3.BackColor = Color.Goldenrod;
                button4.BackColor = Color.Goldenrod;
            }

            if (comboBox1.Text == "Papatya Sitesi")
            {
                button1.BackColor = Color.Goldenrod;
                button2.BackColor = Color.Pink;
                button3.BackColor = Color.Goldenrod;
                button4.BackColor = Color.Goldenrod;
            }

            if (comboBox1.Text == "Gül Sitesi")
            {
                button1.BackColor = Color.Goldenrod;
                button2.BackColor = Color.Goldenrod;
                button3.BackColor = Color.Pink;
                button4.BackColor = Color.Goldenrod;
            }

            if (comboBox1.Text == "Menekşe Sitesi")
            {
                button1.BackColor = Color.Goldenrod;
                button2.BackColor = Color.Goldenrod;
                button3.BackColor = Color.Goldenrod;
                button4.BackColor = Color.Pink;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();


            SqlCommand komut = new SqlCommand("insert into sitebilgiler (id,site,satkira,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar) values('" + textBox8.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from sitebilgiler where id=(" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();


        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox8.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update sitebilgiler set id='" + textBox8.Text.ToString() + "',site='" + comboBox1.Text.ToString() + "',satkira='" + comboBox2.Text.ToString() + "',oda='" + comboBox3.Text.ToString() + "',metre='" + textBox1.Text.ToString() + "',fiyat='" + textBox2.Text.ToString() + "',blok='" + comboBox4.Text.ToString() +  "',no='" + textBox7.Text.ToString() + "',adsoyad='" + textBox4.Text.ToString() + "',telefon='" + textBox5.Text.ToString() + "',notlar='" + textBox6.Text.ToString() + "'where id=" + id + "", baglan);
     
           komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }
    }
}
