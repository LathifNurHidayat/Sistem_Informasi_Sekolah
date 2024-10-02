namespace Sistem_Informasi_Sekolah
{
    partial class FormJadwalPelajaran
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
            panel1 = new Panel();
            panel5 = new Panel();
            ButtonJadwalSave = new Button();
            ButtonJadwalDelete = new Button();
            ButtonJadwalNew = new Button();
            panel4 = new Panel();
            RadioKhusus = new RadioButton();
            GridListJadwalPelajaran = new DataGridView();
            RadioUmum = new RadioButton();
            label3 = new Label();
            panel3 = new Panel();
            MaskedSelesai = new MaskedTextBox();
            MaskedJamMulai = new MaskedTextBox();
            ComboJenisJadwal = new ComboBox();
            ComboHari = new ComboBox();
            ComboGuru = new ComboBox();
            ComboMataPelajaran = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            ButtonDialogKelas = new Button();
            TextKelasId = new TextBox();
            label5 = new Label();
            TextKelasName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListJadwalPelajaran).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(1432, 720);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = Color.Gainsboro;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(ButtonJadwalSave);
            panel5.Controls.Add(ButtonJadwalDelete);
            panel5.Controls.Add(ButtonJadwalNew);
            panel5.Location = new Point(972, 609);
            panel5.Name = "panel5";
            panel5.Size = new Size(451, 100);
            panel5.TabIndex = 2;
            // 
            // ButtonJadwalSave
            // 
            ButtonJadwalSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonJadwalSave.BackColor = Color.LimeGreen;
            ButtonJadwalSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonJadwalSave.ForeColor = SystemColors.ControlLightLight;
            ButtonJadwalSave.Location = new Point(321, 32);
            ButtonJadwalSave.Name = "ButtonJadwalSave";
            ButtonJadwalSave.Size = new Size(96, 35);
            ButtonJadwalSave.TabIndex = 3;
            ButtonJadwalSave.Text = "Save";
            ButtonJadwalSave.UseVisualStyleBackColor = false;
            // 
            // ButtonJadwalDelete
            // 
            ButtonJadwalDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonJadwalDelete.BackColor = Color.Crimson;
            ButtonJadwalDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonJadwalDelete.ForeColor = SystemColors.ControlLightLight;
            ButtonJadwalDelete.Location = new Point(179, 32);
            ButtonJadwalDelete.Name = "ButtonJadwalDelete";
            ButtonJadwalDelete.Size = new Size(96, 35);
            ButtonJadwalDelete.TabIndex = 2;
            ButtonJadwalDelete.Text = "Delete";
            ButtonJadwalDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonJadwalNew
            // 
            ButtonJadwalNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonJadwalNew.BackColor = Color.RoyalBlue;
            ButtonJadwalNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonJadwalNew.ForeColor = SystemColors.ControlLightLight;
            ButtonJadwalNew.Location = new Point(37, 32);
            ButtonJadwalNew.Name = "ButtonJadwalNew";
            ButtonJadwalNew.Size = new Size(96, 35);
            ButtonJadwalNew.TabIndex = 1;
            ButtonJadwalNew.Text = "New Data";
            ButtonJadwalNew.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Gainsboro;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(RadioKhusus);
            panel4.Controls.Add(GridListJadwalPelajaran);
            panel4.Controls.Add(RadioUmum);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(9, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(957, 699);
            panel4.TabIndex = 3;
            // 
            // RadioKhusus
            // 
            RadioKhusus.AutoSize = true;
            RadioKhusus.Location = new Point(283, 18);
            RadioKhusus.Name = "RadioKhusus";
            RadioKhusus.Size = new Size(75, 24);
            RadioKhusus.TabIndex = 2;
            RadioKhusus.TabStop = true;
            RadioKhusus.Text = "Khusus";
            RadioKhusus.UseVisualStyleBackColor = true;
            // 
            // GridListJadwalPelajaran
            // 
            GridListJadwalPelajaran.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListJadwalPelajaran.BackgroundColor = Color.WhiteSmoke;
            GridListJadwalPelajaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListJadwalPelajaran.GridColor = SystemColors.Control;
            GridListJadwalPelajaran.Location = new Point(10, 63);
            GridListJadwalPelajaran.Name = "GridListJadwalPelajaran";
            GridListJadwalPelajaran.RowHeadersWidth = 51;
            GridListJadwalPelajaran.RowTemplate.Height = 29;
            GridListJadwalPelajaran.Size = new Size(935, 623);
            GridListJadwalPelajaran.TabIndex = 3;
            // 
            // RadioUmum
            // 
            RadioUmum.AutoSize = true;
            RadioUmum.Location = new Point(153, 18);
            RadioUmum.Name = "RadioUmum";
            RadioUmum.Size = new Size(74, 24);
            RadioUmum.TabIndex = 1;
            RadioUmum.TabStop = true;
            RadioUmum.Text = "Umum";
            RadioUmum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 20);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 21;
            label3.Text = "Jenis Jadwal  :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(MaskedSelesai);
            panel3.Controls.Add(MaskedJamMulai);
            panel3.Controls.Add(ComboJenisJadwal);
            panel3.Controls.Add(ComboHari);
            panel3.Controls.Add(ComboGuru);
            panel3.Controls.Add(ComboMataPelajaran);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(972, 198);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 404);
            panel3.TabIndex = 1;
            // 
            // MaskedSelesai
            // 
            MaskedSelesai.BorderStyle = BorderStyle.FixedSingle;
            MaskedSelesai.Location = new Point(292, 186);
            MaskedSelesai.Name = "MaskedSelesai";
            MaskedSelesai.Size = new Size(125, 27);
            MaskedSelesai.TabIndex = 4;
            // 
            // MaskedJamMulai
            // 
            MaskedJamMulai.BorderStyle = BorderStyle.FixedSingle;
            MaskedJamMulai.Location = new Point(37, 186);
            MaskedJamMulai.Name = "MaskedJamMulai";
            MaskedJamMulai.Size = new Size(125, 27);
            MaskedJamMulai.TabIndex = 3;
            // 
            // ComboJenisJadwal
            // 
            ComboJenisJadwal.FormattingEnabled = true;
            ComboJenisJadwal.Location = new Point(37, 51);
            ComboJenisJadwal.Name = "ComboJenisJadwal";
            ComboJenisJadwal.Size = new Size(380, 28);
            ComboJenisJadwal.TabIndex = 1;
            // 
            // ComboHari
            // 
            ComboHari.FormattingEnabled = true;
            ComboHari.Location = new Point(37, 118);
            ComboHari.Name = "ComboHari";
            ComboHari.Size = new Size(380, 28);
            ComboHari.TabIndex = 2;
            // 
            // ComboGuru
            // 
            ComboGuru.FormattingEnabled = true;
            ComboGuru.Location = new Point(37, 349);
            ComboGuru.Name = "ComboGuru";
            ComboGuru.Size = new Size(380, 28);
            ComboGuru.TabIndex = 6;
            // 
            // ComboMataPelajaran
            // 
            ComboMataPelajaran.FormattingEnabled = true;
            ComboMataPelajaran.Location = new Point(37, 283);
            ComboMataPelajaran.Name = "ComboMataPelajaran";
            ComboMataPelajaran.Size = new Size(380, 28);
            ComboMataPelajaran.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(37, 326);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 32;
            label8.Text = "Guru";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(37, 260);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 30;
            label9.Text = "Mata Pelajaran";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(292, 163);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 28;
            label6.Text = "Selesai";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(37, 163);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 26;
            label7.Text = "Jam Mulai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(37, 95);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 24;
            label2.Text = "Hari";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(37, 28);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 22;
            label4.Text = "Jenis Jadwal";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ButtonDialogKelas);
            panel2.Controls.Add(TextKelasId);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(TextKelasName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(972, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 182);
            panel2.TabIndex = 0;
            // 
            // ButtonDialogKelas
            // 
            ButtonDialogKelas.BackColor = Color.WhiteSmoke;
            ButtonDialogKelas.FlatStyle = FlatStyle.Flat;
            ButtonDialogKelas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonDialogKelas.Location = new Point(376, 58);
            ButtonDialogKelas.Margin = new Padding(2);
            ButtonDialogKelas.Name = "ButtonDialogKelas";
            ButtonDialogKelas.Size = new Size(40, 25);
            ButtonDialogKelas.TabIndex = 1;
            ButtonDialogKelas.Text = "...";
            ButtonDialogKelas.UseVisualStyleBackColor = false;
            // 
            // TextKelasId
            // 
            TextKelasId.BackColor = SystemColors.Control;
            TextKelasId.BorderStyle = BorderStyle.FixedSingle;
            TextKelasId.Location = new Point(37, 58);
            TextKelasId.Name = "TextKelasId";
            TextKelasId.ReadOnly = true;
            TextKelasId.Size = new Size(334, 27);
            TextKelasId.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(37, 29);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 18;
            label5.Text = "Kelas Id";
            // 
            // TextKelasName
            // 
            TextKelasName.BackColor = SystemColors.Control;
            TextKelasName.BorderStyle = BorderStyle.FixedSingle;
            TextKelasName.Location = new Point(37, 124);
            TextKelasName.Name = "TextKelasName";
            TextKelasName.ReadOnly = true;
            TextKelasName.Size = new Size(379, 27);
            TextKelasName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, 100);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 20;
            label1.Text = "Kelas Name";
            // 
            // FormJadwalPelajaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 744);
            Controls.Add(panel1);
            Name = "FormJadwalPelajaran";
            Text = "FormJadwalPelajaran";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridListJadwalPelajaran).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private DataGridView GridListJadwalPelajaran;
        private Panel panel3;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label label4;
        private TextBox TextKelasName;
        private Label label1;
        private TextBox TextKelasId;
        private Button ButtonJadwalDelete;
        private Button ButtonJadwalSave;
        private Button ButtonJadwalNew;
        private Label label5;
        private ComboBox ComboHari;
        private ComboBox ComboGuru;
        private ComboBox ComboMataPelajaran;
        private RadioButton RadioKhusus;
        private RadioButton RadioUmum;
        private Label label3;
        private Button ButtonDialogKelas;
        private Panel panel5;
        private MaskedTextBox MaskedSelesai;
        private MaskedTextBox MaskedJamMulai;
        private ComboBox ComboJenisJadwal;
    }
}