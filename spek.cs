using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
	public partial class spek : Form
	{
		public spek()
		{
			InitializeComponent();
		}

		private void spek_Load(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void i_Hari_Click(object sender, EventArgs e)
		{
			img1.ImageLocation = "foto\\jogja1.jpg";
			img2.ImageLocation = "foto\\jogja2.jpg";
			img3.ImageLocation = "foto\\jogja3.jpg";
			img4.ImageLocation = "foto\\jogja4.jpg";

			fasilitas2.ImageLocation = "foto\\spbu.png";
			fasilitas1.ImageLocation = "foto\\makan.png";
			fasilitas3.ImageLocation = "foto\\pemanduwisata.png";
			fasilitas4.ImageLocation = "foto\\ticket.png";
			fasilitas5.ImageLocation = "foto\\mobil.png";
			fasilitas6.ImageLocation = "foto\\hotel.png";
			fasilitas7.ImageLocation = "foto\\merchandise.png";

			textboxnama.Text = "1 Day Trip";
			textboxharga.Text = "Rp 500.000,-";
			textboxlama.Text = "12 Jam";
			textboxtujuan.Text = "Hutan Pinus, Gumbuk Pasir,Pantai Parangtritis, Bukit Bintang";
			textboxdeskripsi.Text = "Pertama kali anda akan diantar ke kawasan hutan pinus dengan udara sejuk dan berbagai macam spot foto di tengah hutan pinus ataupun tebing-tebing. Setelah 2 jam di hutan pinus selanjutnya anda diantar ke gumuk pasir dan juga parang tritis. Selanjutnya pada malam hari anda diantarkan ke Bukit Bintang dimana tempat s=tersebut mendapat view jogja kota dengan kelap kelip cahaya. ";
		}

		private void ii_Hari_Click(object sender, EventArgs e)
		{
			img1.ImageLocation = "foto\\jogja5.jpg";
			img2.ImageLocation = "foto\\jogja6.png";
			img3.ImageLocation = "foto\\jogja7.jpg";
			img4.ImageLocation = "foto\\jogja8.jpg";

			fasilitas1.ImageLocation = "foto\\spbu.png";
			fasilitas2.ImageLocation = "foto\\makan.png";
			fasilitas3.ImageLocation = "foto\\pemanduwisata.png";
			fasilitas4.ImageLocation = "foto\\ticket.png";
			fasilitas5.ImageLocation = "foto\\mobil.png";
			fasilitas6.ImageLocation = "foto\\hotel.png";
			fasilitas7.ImageLocation = "foto\\merchandise.png";


			textboxnama.Text = "2 Day Trip";
			textboxharga.Text = "Rp 1.000.000,-";
			textboxlama.Text = "48 jam";
			textboxtujuan.Text = "Benteng Vedreburg, Malioboro, Candi Ratu Boko, Bakpia Pathok";
			textboxdeskripsi.Text = "Untuk Wisata di Jogja anda di hari pertama akan diajak ke daerah jogja kota. Dengan tujuan Benteng Vedreburg atau berisi seperti museum. Kemudia keluar anda langsung ke jalan Malioboro yang anda dapat membeli sesuatu atau sekedar berjalan-jalan. Setelah sore anda diajak ke Candi ratu Boko untuk menikmati epci susnset disana. Dan akan dibawa ke Hotel untuk istirahat guna menyimpan tenaga di hari selanjutnya. Hari kedua anda dibawa menuju Gunung Kidul seharian anda akan diantar ke pantai 3 tujuan dengan masing-masing keindahannya.";
		}

		private void btmKembali_Click(object sender, EventArgs e)
		{
			Form1 b = new Form1();
			this.Hide();
			b.ShowDialog();
		}

		private void btmPesan_Click(object sender, EventArgs e)
		{
			pesan a = new pesan();
			this.Hide();
			a.ShowDialog();
		}

		private void label4_Click_1(object sender, EventArgs e)
		{
			

		}
	}
}
