namespace Sistem_Informasi_Sekolah
{
    partial class FormAbsensi
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
            panel4 = new Panel();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TextTotalAlpha = new TextBox();
            TextTotalIzin = new TextBox();
            TextTotalSakit = new TextBox();
            TextTotalHadir = new TextBox();
            label1 = new Label();
            ButtonSave = new Button();
            GridListPresensi = new DataGridView();
            panel1 = new Panel();
            ComboKelas = new ComboBox();
            ComboGuru = new ComboBox();
            ComboMataPelajaran = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label2 = new Label();
            ButtonListSiswa = new Button();
            ButtonNew = new Button();
            PickerTanggal = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            TextJamKe = new TextBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListPresensi).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Gainsboro;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(TextTotalAlpha);
            panel4.Controls.Add(TextTotalIzin);
            panel4.Controls.Add(TextTotalSakit);
            panel4.Controls.Add(TextTotalHadir);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(ButtonSave);
            panel4.Controls.Add(GridListPresensi);
            panel4.Location = new Point(400, 9);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(624, 547);
            panel4.TabIndex = 1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(389, 461);
            label10.Name = "label10";
            label10.Size = new Size(18, 19);
            label10.TabIndex = 50;
            label10.Text = "A";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(354, 462);
            label5.Name = "label5";
            label5.Size = new Size(13, 19);
            label5.TabIndex = 49;
            label5.Text = "I";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(315, 461);
            label4.Name = "label4";
            label4.Size = new Size(16, 19);
            label4.TabIndex = 48;
            label4.Text = "S";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(264, 461);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 47;
            label3.Text = "Hadir";
            // 
            // TextTotalAlpha
            // 
            TextTotalAlpha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TextTotalAlpha.BorderStyle = BorderStyle.FixedSingle;
            TextTotalAlpha.Location = new Point(383, 481);
            TextTotalAlpha.Margin = new Padding(3, 2, 3, 2);
            TextTotalAlpha.Name = "TextTotalAlpha";
            TextTotalAlpha.Size = new Size(33, 23);
            TextTotalAlpha.TabIndex = 46;
            // 
            // TextTotalIzin
            // 
            TextTotalIzin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TextTotalIzin.BorderStyle = BorderStyle.FixedSingle;
            TextTotalIzin.Location = new Point(346, 481);
            TextTotalIzin.Margin = new Padding(3, 2, 3, 2);
            TextTotalIzin.Name = "TextTotalIzin";
            TextTotalIzin.Size = new Size(33, 23);
            TextTotalIzin.TabIndex = 45;
            // 
            // TextTotalSakit
            // 
            TextTotalSakit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TextTotalSakit.BorderStyle = BorderStyle.FixedSingle;
            TextTotalSakit.Location = new Point(308, 481);
            TextTotalSakit.Margin = new Padding(3, 2, 3, 2);
            TextTotalSakit.Name = "TextTotalSakit";
            TextTotalSakit.Size = new Size(33, 23);
            TextTotalSakit.TabIndex = 44;
            // 
            // TextTotalHadir
            // 
            TextTotalHadir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TextTotalHadir.BorderStyle = BorderStyle.FixedSingle;
            TextTotalHadir.Location = new Point(270, 481);
            TextTotalHadir.Margin = new Padding(3, 2, 3, 2);
            TextTotalHadir.Name = "TextTotalHadir";
            TextTotalHadir.Size = new Size(33, 23);
            TextTotalHadir.TabIndex = 43;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(203, 481);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 42;
            label1.Text = "Total";
            // 
            // ButtonSave
            // 
            ButtonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSave.BackColor = Color.LimeGreen;
            ButtonSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSave.ForeColor = SystemColors.ControlLightLight;
            ButtonSave.Location = new Point(471, 481);
            ButtonSave.Margin = new Padding(3, 2, 3, 2);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(105, 26);
            ButtonSave.TabIndex = 4;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = false;
            // 
            // GridListPresensi
            // 
            GridListPresensi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListPresensi.BackgroundColor = Color.WhiteSmoke;
            GridListPresensi.ColumnHeadersHeight = 29;
            GridListPresensi.GridColor = SystemColors.Control;
            GridListPresensi.Location = new Point(9, 8);
            GridListPresensi.Margin = new Padding(3, 2, 3, 2);
            GridListPresensi.Name = "GridListPresensi";
            GridListPresensi.RowHeadersWidth = 51;
            GridListPresensi.RowTemplate.Height = 29;
            GridListPresensi.Size = new Size(604, 430);
            GridListPresensi.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ComboKelas);
            panel1.Controls.Add(ComboGuru);
            panel1.Controls.Add(ComboMataPelajaran);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ButtonListSiswa);
            panel1.Controls.Add(ButtonNew);
            panel1.Location = new Point(10, 122);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 435);
            panel1.TabIndex = 0;
            // 
            // ComboKelas
            // 
            ComboKelas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKelas.FormattingEnabled = true;
            ComboKelas.Location = new Point(34, 48);
            ComboKelas.Margin = new Padding(3, 2, 3, 2);
            ComboKelas.Name = "ComboKelas";
            ComboKelas.Size = new Size(303, 27);
            ComboKelas.TabIndex = 33;
            // 
            // ComboGuru
            // 
            ComboGuru.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboGuru.FormattingEnabled = true;
            ComboGuru.Location = new Point(34, 186);
            ComboGuru.Margin = new Padding(3, 2, 3, 2);
            ComboGuru.Name = "ComboGuru";
            ComboGuru.Size = new Size(303, 27);
            ComboGuru.TabIndex = 36;
            // 
            // ComboMataPelajaran
            // 
            ComboMataPelajaran.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboMataPelajaran.FormattingEnabled = true;
            ComboMataPelajaran.Location = new Point(34, 117);
            ComboMataPelajaran.Margin = new Padding(3, 2, 3, 2);
            ComboMataPelajaran.Name = "ComboMataPelajaran";
            ComboMataPelajaran.Size = new Size(303, 27);
            ComboMataPelajaran.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(34, 167);
            label8.Name = "label8";
            label8.Size = new Size(40, 19);
            label8.TabIndex = 40;
            label8.Text = "Guru";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(34, 99);
            label9.Name = "label9";
            label9.Size = new Size(99, 19);
            label9.TabIndex = 39;
            label9.Text = "Mata Pelajaran";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 31);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 37;
            label2.Text = "Kelas";
            // 
            // ButtonListSiswa
            // 
            ButtonListSiswa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonListSiswa.BackColor = Color.DarkGray;
            ButtonListSiswa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonListSiswa.ForeColor = SystemColors.ControlLightLight;
            ButtonListSiswa.Location = new Point(232, 364);
            ButtonListSiswa.Margin = new Padding(3, 2, 3, 2);
            ButtonListSiswa.Name = "ButtonListSiswa";
            ButtonListSiswa.Size = new Size(105, 26);
            ButtonListSiswa.TabIndex = 3;
            ButtonListSiswa.Text = "List Siswa";
            ButtonListSiswa.UseVisualStyleBackColor = false;
            // 
            // ButtonNew
            // 
            ButtonNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonNew.BackColor = Color.RoyalBlue;
            ButtonNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonNew.ForeColor = SystemColors.ControlLightLight;
            ButtonNew.Location = new Point(34, 364);
            ButtonNew.Margin = new Padding(3, 2, 3, 2);
            ButtonNew.Name = "ButtonNew";
            ButtonNew.Size = new Size(105, 26);
            ButtonNew.TabIndex = 1;
            ButtonNew.Text = "New";
            ButtonNew.UseVisualStyleBackColor = false;
            // 
            // PickerTanggal
            // 
            PickerTanggal.CustomFormat = "dd-MM-yyyy";
            PickerTanggal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PickerTanggal.Format = DateTimePickerFormat.Custom;
            PickerTanggal.Location = new Point(35, 44);
            PickerTanggal.Margin = new Padding(3, 2, 3, 2);
            PickerTanggal.Name = "PickerTanggal";
            PickerTanggal.Size = new Size(128, 26);
            PickerTanggal.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(210, 24);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 38;
            label6.Text = "Jam ke-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(35, 24);
            label7.Name = "label7";
            label7.Size = new Size(55, 19);
            label7.TabIndex = 26;
            label7.Text = "Tanggal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextJamKe);
            panel2.Controls.Add(PickerTanggal);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(10, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 100);
            panel2.TabIndex = 42;
            // 
            // TextJamKe
            // 
            TextJamKe.BorderStyle = BorderStyle.FixedSingle;
            TextJamKe.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextJamKe.Location = new Point(210, 44);
            TextJamKe.Margin = new Padding(3, 2, 3, 2);
            TextJamKe.Name = "TextJamKe";
            TextJamKe.Size = new Size(128, 26);
            TextJamKe.TabIndex = 47;
            // 
            // FormAbsensi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 565);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAbsensi";
            Text = "Presensi";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridListPresensi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DataGridView GridListPresensi;
        private Panel panel1;
        private Button ButtonListSiswa;
        private Button ButtonNew;
        private Button ButtonSave;
        private ComboBox ComboKelas;
        private ComboBox ComboGuru;
        private ComboBox ComboMataPelajaran;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label2;
        private Label label7;
        private DateTimePicker PickerTanggal;
        private Label label1;
        private TextBox TextTotalAlpha;
        private TextBox TextTotalIzin;
        private TextBox TextTotalSakit;
        private TextBox TextTotalHadir;
        private Panel panel2;
        private TextBox TextJamKe;
        private Label label3;
        private Label label10;
        private Label label5;
        private Label label4;
    }
}