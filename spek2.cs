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
	public partial class spek2 : Form
	{
		public spek2()
		{
			InitializeComponent();
		}

		private void i_Hari_Click(object sender, EventArgs e)
		{
			img1.ImageLocation = "foto\\bali1.jpg";
			img2.ImageLocation = "foto\\bali2.jpg";
			img3.ImageLocation = "foto\\bali3.jpg";
			img4.ImageLocation = "foto\\bali4.jpg";

			fasilitas1.ImageLocation = "foto\\spbu.png";
			fasilitas2.ImageLocation = "foto\\makan.png";
			fasilitas3.ImageLocation = "foto\\pemanduwisata.png";
			fasilitas4.ImageLocation = "foto\\ticket.png";
			fasilitas5.ImageLocation = "foto\\mobil.png";
			fasilitas6.ImageLocation = "foto\\hotel.png";
			fasilitas7.ImageLocation = "foto\\merchandise.png";

			textboxnama.Text = "1 Day Trip";
			textboxharga.Text = "Rp 800.000,-";
			textboxlama.Text = "12 Jam";
			textboxtujuan.Text = "Bedugul, Sangeh, Pantai Pandawa, Pantai Kuta";
			textboxdeskripsi.Text = "Pertama kali anda akan dibawa menuju Danau diatas gunung di pulau Bali yaitu Danau Bedugul. Terdapat dara yang sejuk dengan pemandangna pura di tengah danau. Kemudian anda akan diajak ke Sangeh yang berisikan kera-kera jinak yang bisa anda beri makan. Setelah selesai akhir dari trip adalah pantai kuta dan diakhiri lagi sunset di Pantai Pandawa  ";
		}

		private void btmKembali_Click(object sender, EventArgs e)
		{
			Form1 b = new Form1();
			this.Hide();
			b.ShowDialog();
		}

		private void btmPesan_Click(object sender, EventArgs e)
		{
			pesan b = new pesan();
			this.Hide();
			b.ShowDialog();
		}
	}
}
