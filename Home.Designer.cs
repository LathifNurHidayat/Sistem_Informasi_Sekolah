namespace Sistem_Informasi_Sekolah
{
    partial class Home
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
            PanelMain = new Panel();
            dataToolStripMenuItem = new ToolStripMenuItem();
            jurusanToolStripMenuItem = new ToolStripMenuItem();
            mataPelajaranToolStripMenuItem = new ToolStripMenuItem();
            kelasToolStripMenuItem = new ToolStripMenuItem();
            guruToolStripMenuItem = new ToolStripMenuItem();
            jadwalPelajaranToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            kesiswaanToolStripMenuItem = new ToolStripMenuItem();
            dataIndukSiswaToolStripMenuItem = new ToolStripMenuItem();
            kelasSiswaToolStripMenuItem = new ToolStripMenuItem();
            absensiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMain
            // 
            PanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelMain.BackColor = Color.LightGray;
            PanelMain.Location = new Point(0, 43);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1039, 568);
            PanelMain.TabIndex = 1;
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jurusanToolStripMenuItem, mataPelajaranToolStripMenuItem, kelasToolStripMenuItem, guruToolStripMenuItem, jadwalPelajaranToolStripMenuItem });
            dataToolStripMenuItem.Image = Properties.Resources.exploration;
            dataToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(128, 36);
            dataToolStripMenuItem.Text = "Pengajaran";
            // 
            // jurusanToolStripMenuItem
            // 
            jurusanToolStripMenuItem.Image = Properties.Resources.report;
            jurusanToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            jurusanToolStripMenuItem.Name = "jurusanToolStripMenuItem";
            jurusanToolStripMenuItem.Size = new Size(236, 38);
            jurusanToolStripMenuItem.Text = "Jurusan";
            // 
            // mataPelajaranToolStripMenuItem
            // 
            mataPelajaranToolStripMenuItem.Image = Properties.Resources.book_stack;
            mataPelajaranToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            mataPelajaranToolStripMenuItem.Name = "mataPelajaranToolStripMenuItem";
            mataPelajaranToolStripMenuItem.Size = new Size(236, 38);
            mataPelajaranToolStripMenuItem.Text = "Mata Pelajaran";
            // 
            // kelasToolStripMenuItem
            // 
            kelasToolStripMenuItem.Image = Properties.Resources.classroom;
            kelasToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kelasToolStripMenuItem.Name = "kelasToolStripMenuItem";
            kelasToolStripMenuItem.Size = new Size(236, 38);
            kelasToolStripMenuItem.Text = "Kelas";
            // 
            // guruToolStripMenuItem
            // 
            guruToolStripMenuItem.Image = Properties.Resources.teacher;
            guruToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            guruToolStripMenuItem.Name = "guruToolStripMenuItem";
            guruToolStripMenuItem.Size = new Size(236, 38);
            guruToolStripMenuItem.Text = "Guru";
            // 
            // jadwalPelajaranToolStripMenuItem
            // 
            jadwalPelajaranToolStripMenuItem.Image = Properties.Resources.homework;
            jadwalPelajaranToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            jadwalPelajaranToolStripMenuItem.Name = "jadwalPelajaranToolStripMenuItem";
            jadwalPelajaranToolStripMenuItem.Size = new Size(236, 38);
            jadwalPelajaranToolStripMenuItem.Text = "Jadwal Pelajaran";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kesiswaanToolStripMenuItem, dataToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1039, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kesiswaanToolStripMenuItem
            // 
            kesiswaanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataIndukSiswaToolStripMenuItem, kelasSiswaToolStripMenuItem, absensiToolStripMenuItem });
            kesiswaanToolStripMenuItem.Image = Properties.Resources.graduation;
            kesiswaanToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kesiswaanToolStripMenuItem.Name = "kesiswaanToolStripMenuItem";
            kesiswaanToolStripMenuItem.Size = new Size(123, 36);
            kesiswaanToolStripMenuItem.Text = "Kesiswaan";
            // 
            // dataIndukSiswaToolStripMenuItem
            // 
            dataIndukSiswaToolStripMenuItem.Image = Properties.Resources.students;
            dataIndukSiswaToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            dataIndukSiswaToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            dataIndukSiswaToolStripMenuItem.Name = "dataIndukSiswaToolStripMenuItem";
            dataIndukSiswaToolStripMenuItem.Size = new Size(236, 38);
            dataIndukSiswaToolStripMenuItem.Text = "Data Induk Siswa";
            // 
            // kelasSiswaToolStripMenuItem
            // 
            kelasSiswaToolStripMenuItem.Image = Properties.Resources.lecture;
            kelasSiswaToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kelasSiswaToolStripMenuItem.Name = "kelasSiswaToolStripMenuItem";
            kelasSiswaToolStripMenuItem.Size = new Size(236, 38);
            kelasSiswaToolStripMenuItem.Text = "Kelas-Siswa";
            // 
            // absensiToolStripMenuItem
            // 
            absensiToolStripMenuItem.Image = Properties.Resources.time;
            absensiToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            absensiToolStripMenuItem.Name = "absensiToolStripMenuItem";
            absensiToolStripMenuItem.Size = new Size(236, 38);
            absensiToolStripMenuItem.Text = "Absensi";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 612);
            Controls.Add(PanelMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PanelMain;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem jurusanToolStripMenuItem;
        private ToolStripMenuItem mataPelajaranToolStripMenuItem;
        private ToolStripMenuItem kelasToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem guruToolStripMenuItem;
        private ToolStripMenuItem jadwalPelajaranToolStripMenuItem;
        private ToolStripMenuItem kesiswaanToolStripMenuItem;
        private ToolStripMenuItem dataIndukSiswaToolStripMenuItem;
        private ToolStripMenuItem kelasSiswaToolStripMenuItem;
        private ToolStripMenuItem absensiToolStripMenuItem;
    }
}