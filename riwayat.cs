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
	public partial class riwayat : Form
	{
		MySqlConnection con = new MySqlConnection(@"data source = 127.0.0.1;port=3306;username=root;password=''");
		MySqlConnection query;
		public riwayat()
		{
			InitializeComponent();
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}	
		
		private void button2_Click(object sender, EventArgs e)
		{
			/*DataTable datatable;
			try
			{
				MySqlCommand command = con.CreateCommand();
				con.Open();
				command.CommandText = "SELECT * FROM ngetrip_com.tb_pesan; ";

				datatable = new DataTable();
				MySqlDataAdapter da = new MySqlDataAdapter(command);
				da.Fill(datatable);
				dataGridView1.DataSource = datatable;*/
			}


			/*catch (Exception EX)
			{
				MessageBox.Show(EX.Message);
			}
			con.Close();*/

		}
	}
}
