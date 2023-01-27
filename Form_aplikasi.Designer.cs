namespace terserah
{
    partial class Form_aplikasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_aplikasi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_cariNamaSiswa = new System.Windows.Forms.TextBox();
            this.btn_cariNamaSiswa = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.pb_profil = new System.Windows.Forms.PictureBox();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_jurusan = new System.Windows.Forms.TextBox();
            this.tb_kelas = new System.Windows.Forms.TextBox();
            this.tb_namaSiswa = new System.Windows.Forms.TextBox();
            this.tb_nis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 125);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1042, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(951, 55);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(105, 39);
            this.btn_logout.TabIndex = 17;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikasi input data siswa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.tb_cariNamaSiswa);
            this.panel2.Controls.Add(this.btn_cariNamaSiswa);
            this.panel2.Controls.Add(this.btn_print);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.btn_display);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_input);
            this.panel2.Controls.Add(this.btn_browse);
            this.panel2.Controls.Add(this.pb_profil);
            this.panel2.Controls.Add(this.tb_alamat);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_jurusan);
            this.panel2.Controls.Add(this.tb_kelas);
            this.panel2.Controls.Add(this.tb_namaSiswa);
            this.panel2.Controls.Add(this.tb_nis);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 588);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tb_cariNamaSiswa
            // 
            this.tb_cariNamaSiswa.Location = new System.Drawing.Point(620, 303);
            this.tb_cariNamaSiswa.Name = "tb_cariNamaSiswa";
            this.tb_cariNamaSiswa.Size = new System.Drawing.Size(152, 27);
            this.tb_cariNamaSiswa.TabIndex = 21;
            // 
            // btn_cariNamaSiswa
            // 
            this.btn_cariNamaSiswa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(176)))));
            this.btn_cariNamaSiswa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cariNamaSiswa.FlatAppearance.BorderSize = 0;
            this.btn_cariNamaSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cariNamaSiswa.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cariNamaSiswa.ForeColor = System.Drawing.Color.White;
            this.btn_cariNamaSiswa.Location = new System.Drawing.Point(812, 247);
            this.btn_cariNamaSiswa.Name = "btn_cariNamaSiswa";
            this.btn_cariNamaSiswa.Size = new System.Drawing.Size(244, 39);
            this.btn_cariNamaSiswa.TabIndex = 20;
            this.btn_cariNamaSiswa.Text = "Cari Nama Siswa";
            this.btn_cariNamaSiswa.UseVisualStyleBackColor = false;
            this.btn_cariNamaSiswa.Click += new System.EventHandler(this.btn_cariNamaSiswa_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(176)))));
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(812, 200);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(244, 39);
            this.btn_print.TabIndex = 19;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 361);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1043, 198);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn_display
            // 
            this.btn_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(176)))));
            this.btn_display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_display.FlatAppearance.BorderSize = 0;
            this.btn_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_display.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_display.ForeColor = System.Drawing.Color.White;
            this.btn_display.Location = new System.Drawing.Point(812, 154);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(244, 39);
            this.btn_display.TabIndex = 16;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(176)))));
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(951, 108);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(105, 39);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(176)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(812, 108);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 39);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(176)))));
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(951, 63);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(105, 39);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_input
            // 
            this.btn_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(176)))));
            this.btn_input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_input.FlatAppearance.BorderSize = 0;
            this.btn_input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_input.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_input.ForeColor = System.Drawing.Color.White;
            this.btn_input.Location = new System.Drawing.Point(812, 63);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(105, 39);
            this.btn_input.TabIndex = 12;
            this.btn_input.Text = "Input";
            this.btn_input.UseVisualStyleBackColor = false;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(176)))));
            this.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Location = new System.Drawing.Point(646, 258);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(105, 39);
            this.btn_browse.TabIndex = 11;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // pb_profil
            // 
            this.pb_profil.Image = ((System.Drawing.Image)(resources.GetObject("pb_profil.Image")));
            this.pb_profil.Location = new System.Drawing.Point(620, 40);
            this.pb_profil.Name = "pb_profil";
            this.pb_profil.Size = new System.Drawing.Size(152, 212);
            this.pb_profil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_profil.TabIndex = 10;
            this.pb_profil.TabStop = false;
            this.pb_profil.Click += new System.EventHandler(this.pb_profil_Click);
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(183, 225);
            this.tb_alamat.Multiline = true;
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(243, 60);
            this.tb_alamat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Alamat";
            // 
            // tb_jurusan
            // 
            this.tb_jurusan.Location = new System.Drawing.Point(183, 182);
            this.tb_jurusan.Name = "tb_jurusan";
            this.tb_jurusan.Size = new System.Drawing.Size(243, 27);
            this.tb_jurusan.TabIndex = 7;
            // 
            // tb_kelas
            // 
            this.tb_kelas.Location = new System.Drawing.Point(183, 134);
            this.tb_kelas.Name = "tb_kelas";
            this.tb_kelas.Size = new System.Drawing.Size(125, 27);
            this.tb_kelas.TabIndex = 6;
            // 
            // tb_namaSiswa
            // 
            this.tb_namaSiswa.Location = new System.Drawing.Point(183, 87);
            this.tb_namaSiswa.Name = "tb_namaSiswa";
            this.tb_namaSiswa.Size = new System.Drawing.Size(243, 27);
            this.tb_namaSiswa.TabIndex = 5;
            // 
            // tb_nis
            // 
            this.tb_nis.Location = new System.Drawing.Point(183, 44);
            this.tb_nis.Name = "tb_nis";
            this.tb_nis.Size = new System.Drawing.Size(158, 27);
            this.tb_nis.TabIndex = 4;
            this.tb_nis.TextChanged += new System.EventHandler(this.tb_nis_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Jurusan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kelas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Siswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "NIS";
            // 
            // Form_aplikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 713);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_aplikasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_aplikasi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btn_browse;
        private PictureBox pb_profil;
        private TextBox tb_alamat;
        private Label label6;
        private TextBox tb_jurusan;
        private TextBox tb_kelas;
        private TextBox tb_namaSiswa;
        private TextBox tb_nis;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_logout;
        private DataGridView dataGridView2;
        private Button btn_display;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_clear;
        private Button btn_input;
        private Button button2;
        private TextBox tb_cariNamaSiswa;
        private Button btn_cariNamaSiswa;
        private Button btn_print;
    }
}