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
            menuStrip1 = new MenuStrip();
            dataToolStripMenuItem = new ToolStripMenuItem();
            dataIndukSiswaToolStripMenuItem = new ToolStripMenuItem();
            jadwalPelajaranToolStripMenuItem = new ToolStripMenuItem();
            jurusanToolStripMenuItem = new ToolStripMenuItem();
            mataPelajaranToolStripMenuItem = new ToolStripMenuItem();
            kelasToolStripMenuItem = new ToolStripMenuItem();
            PanelMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dataToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1082, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataIndukSiswaToolStripMenuItem, jadwalPelajaranToolStripMenuItem, jurusanToolStripMenuItem, mataPelajaranToolStripMenuItem, kelasToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(55, 24);
            dataToolStripMenuItem.Text = "Data";
            // 
            // dataIndukSiswaToolStripMenuItem
            // 
            dataIndukSiswaToolStripMenuItem.Name = "dataIndukSiswaToolStripMenuItem";
            dataIndukSiswaToolStripMenuItem.Size = new Size(224, 26);
            dataIndukSiswaToolStripMenuItem.Text = "Data Induk Siswa";
            // 
            // jadwalPelajaranToolStripMenuItem
            // 
            jadwalPelajaranToolStripMenuItem.Name = "jadwalPelajaranToolStripMenuItem";
            jadwalPelajaranToolStripMenuItem.Size = new Size(224, 26);
            jadwalPelajaranToolStripMenuItem.Text = "Jadwal Pelajaran";
            // 
            // jurusanToolStripMenuItem
            // 
            jurusanToolStripMenuItem.Name = "jurusanToolStripMenuItem";
            jurusanToolStripMenuItem.Size = new Size(224, 26);
            jurusanToolStripMenuItem.Text = "Jurusan";
            // 
            // mataPelajaranToolStripMenuItem
            // 
            mataPelajaranToolStripMenuItem.Name = "mataPelajaranToolStripMenuItem";
            mataPelajaranToolStripMenuItem.Size = new Size(224, 26);
            mataPelajaranToolStripMenuItem.Text = "Mata Pelajaran";
            // 
            // kelasToolStripMenuItem
            // 
            kelasToolStripMenuItem.Name = "kelasToolStripMenuItem";
            kelasToolStripMenuItem.Size = new Size(224, 26);
            kelasToolStripMenuItem.Text = "Kelas";
            // 
            // PanelMain
            // 
            PanelMain.BackColor = Color.LightGray;
            PanelMain.Location = new Point(0, 31);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1082, 771);
            PanelMain.TabIndex = 1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 803);
            Controls.Add(PanelMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem dataIndukSiswaToolStripMenuItem;
        private ToolStripMenuItem jadwalPelajaranToolStripMenuItem;
        private Panel PanelMain;
        private ToolStripMenuItem jurusanToolStripMenuItem;
        private ToolStripMenuItem mataPelajaranToolStripMenuItem;
        private ToolStripMenuItem kelasToolStripMenuItem;
    }
}