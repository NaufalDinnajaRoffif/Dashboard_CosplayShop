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
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DGVPrinterHelper;

namespace terserah
{
    public partial class Form_aplikasi : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HDDLAL19\SQLEXPRESS;Initial Catalog=db_latihan;Integrated Security=True");
        public Form_aplikasi()
        {
            InitializeComponent();
        }
        string imgLocation = "";
        SqlCommand cmd;

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login frm2 = new login();
            frm2.Show();
            this.Visible = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_nis.Clear();
            tb_namaSiswa.Clear();
            tb_kelas.Clear();
            tb_jurusan.Clear(); 
            tb_alamat.Clear();
            pb_profil.Image.Tag = null;
        }

        private void pb_profil_Click(object sender, EventArgs e)
        {

        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [tb_siswa] (nis,nama_siswa,kelas,jurusan,alamat,foto) values ('" + tb_nis.Text + "','" + tb_namaSiswa.Text + "','" + tb_kelas.Text + "','" + tb_jurusan.Text + "','" + tb_alamat.Text + "',@images)";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");

        }

        private void tb_nis_TextChanged(object sender, EventArgs e)
        {

        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [tb_siswa]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            con.Close();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pb_profil.ImageLocation = imgLocation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [tb_siswa] Where nis = '" + tb_nis.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            tb_nis.Text = "";
            display_data();
            MessageBox.Show("Data delete successfully");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [tb_siswa] set nis='" + this.tb_nis.Text + "', kelas='" + this.tb_kelas.Text + "',jurusan='" + this.tb_jurusan.Text + "', alamat='" + this.tb_alamat.Text + "', nama_siswa='" + this.tb_namaSiswa.Text + "', foto=@images where nis='" + this.tb_nis.Text + "'";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            tb_nis.Text = "";
            tb_namaSiswa.Text = "";
            tb_kelas.Text = "";
            tb_jurusan.Text = "";
            tb_alamat.Text = "";
            pb_profil.ImageLocation = null;
            display_data();
            MessageBox.Show("Data Berhasil Di Update");
        }

        private void btn_cariNamaSiswa_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [tb_siswa] where nama_siswa like ('%" + tb_cariNamaSiswa.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            tb_cariNamaSiswa.Text = "";
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Laporan Nama";
            printer.SubTitle = string.Format("Tanggal {0}", DateTime.Now.Date.ToString("dddd-MMMM-yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "by PoH";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView2);
        }
    }
}
