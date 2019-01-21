using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace final
{
	public partial class pesan : Form
	{
		MySqlConnection con = new MySqlConnection(@"data source = 127.0.0.1;port=3306;username=root;password=''");

		public pesan()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void bunifuButton2_Click(object sender, EventArgs e)
		{
			spek b = new spek();
			this.Hide();
			b.ShowDialog();
		}

		private void bunifuButton1_Click(object sender, EventArgs e)
		{
			MySqlCommand cmd = con.CreateCommand();
			string query = "INSERT INTO ngetrip_com.tb_pesan(nama,email,no_hp,paket,tanggal,b_pesan,L_trip) VALUES ('" + nama.Text + "','" + email.Text + "','" + no.Text + "','" + paket.Text + "','" + tgl.Text + "','" + banyak.Text + "','" + lama.Text + "');";
			MySqlCommand Quer = new MySqlCommand(query, con);
			MySqlDataReader myread;
			try
			{
				con.Open();
				myread = Quer.ExecuteReader();
				MessageBox.Show("Silahkan Cek Email");
				while (myread.Read()) ;

			}
			catch (Exception EX)
			{
				MessageBox.Show(EX.Message);
			}
			con.Close();

			riwayat q = new riwayat();
			this.Hide();
			q.ShowDialog();
		}

		private void nama_OnValueChanged(object sender, EventArgs e)
		{

		}
	}
}
