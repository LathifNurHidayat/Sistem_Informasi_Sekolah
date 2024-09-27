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
            panel4 = new Panel();
            panel5 = new Panel();
            RadioUmum = new RadioButton();
            label3 = new Label();
            GridListJadwalPelajaran = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            RadioKhusus = new RadioButton();
            TextKelasId = new TextBox();
            TextKelasName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ButtonMapelDelete = new Button();
            ButtonMapelSave = new Button();
            ButtonMapelNew = new Button();
            label5 = new Label();
            ComboMataPelajaran = new ComboBox();
            ComboGuru = new ComboBox();
            ComboHari = new ComboBox();
            ComboJenisJadwal = new ComboBox();
            PickerJamMulai = new DateTimePicker();
            PickerJamSelesai = new DateTimePicker();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListJadwalPelajaran).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(1432, 720);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Gainsboro;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(GridListJadwalPelajaran);
            panel4.Location = new Point(9, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(870, 699);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(RadioKhusus);
            panel5.Controls.Add(RadioUmum);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(868, 55);
            panel5.TabIndex = 2;
            // 
            // RadioUmum
            // 
            RadioUmum.AutoSize = true;
            RadioUmum.Location = new Point(137, 15);
            RadioUmum.Name = "RadioUmum";
            RadioUmum.Size = new Size(74, 24);
            RadioUmum.TabIndex = 16;
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
            label3.Location = new Point(20, 17);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 15;
            label3.Text = "Jenis Jadwal  :";
            // 
            // GridListJadwalPelajaran
            // 
            GridListJadwalPelajaran.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListJadwalPelajaran.BackgroundColor = Color.WhiteSmoke;
            GridListJadwalPelajaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListJadwalPelajaran.GridColor = SystemColors.Control;
            GridListJadwalPelajaran.Location = new Point(10, 64);
            GridListJadwalPelajaran.Name = "GridListJadwalPelajaran";
            GridListJadwalPelajaran.RowHeadersWidth = 51;
            GridListJadwalPelajaran.RowTemplate.Height = 29;
            GridListJadwalPelajaran.Size = new Size(848, 623);
            GridListJadwalPelajaran.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(PickerJamSelesai);
            panel3.Controls.Add(PickerJamMulai);
            panel3.Controls.Add(ComboJenisJadwal);
            panel3.Controls.Add(ComboHari);
            panel3.Controls.Add(ComboGuru);
            panel3.Controls.Add(ComboMataPelajaran);
            panel3.Controls.Add(ButtonMapelDelete);
            panel3.Controls.Add(ButtonMapelSave);
            panel3.Controls.Add(ButtonMapelNew);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(885, 198);
            panel3.Name = "panel3";
            panel3.Size = new Size(538, 510);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextKelasName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TextKelasId);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(885, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 182);
            panel2.TabIndex = 0;
            // 
            // RadioKhusus
            // 
            RadioKhusus.AutoSize = true;
            RadioKhusus.Location = new Point(267, 15);
            RadioKhusus.Name = "RadioKhusus";
            RadioKhusus.Size = new Size(75, 24);
            RadioKhusus.TabIndex = 17;
            RadioKhusus.TabStop = true;
            RadioKhusus.Text = "Khusus";
            RadioKhusus.UseVisualStyleBackColor = true;
            // 
            // TextKelasId
            // 
            TextKelasId.BackColor = SystemColors.ControlLightLight;
            TextKelasId.BorderStyle = BorderStyle.FixedSingle;
            TextKelasId.Location = new Point(186, 50);
            TextKelasId.Name = "TextKelasId";
            TextKelasId.Size = new Size(301, 27);
            TextKelasId.TabIndex = 17;
            // 
            // TextKelasName
            // 
            TextKelasName.BackColor = SystemColors.ControlLightLight;
            TextKelasName.BorderStyle = BorderStyle.FixedSingle;
            TextKelasName.Location = new Point(186, 104);
            TextKelasName.Name = "TextKelasName";
            TextKelasName.Size = new Size(301, 27);
            TextKelasName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(47, 108);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 20;
            label1.Text = "Kelas Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(47, 91);
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
            label4.Location = new Point(47, 35);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 22;
            label4.Text = "Jenis Jadwal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(47, 203);
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
            label7.Location = new Point(47, 147);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 26;
            label7.Text = "Jam Mulai";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(47, 373);
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
            label9.Location = new Point(47, 319);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 30;
            label9.Text = "Mata Pelajaran";
            // 
            // ButtonMapelDelete
            // 
            ButtonMapelDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonMapelDelete.BackColor = Color.Crimson;
            ButtonMapelDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMapelDelete.ForeColor = SystemColors.ControlLightLight;
            ButtonMapelDelete.Location = new Point(266, 438);
            ButtonMapelDelete.Name = "ButtonMapelDelete";
            ButtonMapelDelete.Size = new Size(96, 35);
            ButtonMapelDelete.TabIndex = 34;
            ButtonMapelDelete.Text = "Delete";
            ButtonMapelDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonMapelSave
            // 
            ButtonMapelSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonMapelSave.BackColor = Color.ForestGreen;
            ButtonMapelSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMapelSave.ForeColor = SystemColors.ControlLightLight;
            ButtonMapelSave.Location = new Point(391, 438);
            ButtonMapelSave.Name = "ButtonMapelSave";
            ButtonMapelSave.Size = new Size(96, 35);
            ButtonMapelSave.TabIndex = 33;
            ButtonMapelSave.Text = "Save";
            ButtonMapelSave.UseVisualStyleBackColor = false;
            // 
            // ButtonMapelNew
            // 
            ButtonMapelNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonMapelNew.BackColor = Color.RoyalBlue;
            ButtonMapelNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMapelNew.ForeColor = SystemColors.ControlLightLight;
            ButtonMapelNew.Location = new Point(141, 438);
            ButtonMapelNew.Name = "ButtonMapelNew";
            ButtonMapelNew.Size = new Size(96, 35);
            ButtonMapelNew.TabIndex = 35;
            ButtonMapelNew.Text = "New Data";
            ButtonMapelNew.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(47, 54);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 18;
            label5.Text = "Kelas Id";
            // 
            // ComboMataPelajaran
            // 
            ComboMataPelajaran.FormattingEnabled = true;
            ComboMataPelajaran.Location = new Point(186, 316);
            ComboMataPelajaran.Name = "ComboMataPelajaran";
            ComboMataPelajaran.Size = new Size(301, 28);
            ComboMataPelajaran.TabIndex = 36;
            // 
            // ComboGuru
            // 
            ComboGuru.FormattingEnabled = true;
            ComboGuru.Location = new Point(186, 368);
            ComboGuru.Name = "ComboGuru";
            ComboGuru.Size = new Size(301, 28);
            ComboGuru.TabIndex = 37;
            // 
            // ComboHari
            // 
            ComboHari.FormattingEnabled = true;
            ComboHari.Location = new Point(186, 88);
            ComboHari.Name = "ComboHari";
            ComboHari.Size = new Size(301, 28);
            ComboHari.TabIndex = 38;
            // 
            // ComboJenisJadwal
            // 
            ComboJenisJadwal.FormattingEnabled = true;
            ComboJenisJadwal.Location = new Point(186, 31);
            ComboJenisJadwal.Name = "ComboJenisJadwal";
            ComboJenisJadwal.Size = new Size(301, 28);
            ComboJenisJadwal.TabIndex = 39;
            // 
            // PickerJamMulai
            // 
            PickerJamMulai.CustomFormat = "HH:MM";
            PickerJamMulai.Format = DateTimePickerFormat.Custom;
            PickerJamMulai.Location = new Point(186, 143);
            PickerJamMulai.Name = "PickerJamMulai";
            PickerJamMulai.ShowUpDown = true;
            PickerJamMulai.Size = new Size(301, 27);
            PickerJamMulai.TabIndex = 40;
            // 
            // PickerJamSelesai
            // 
            PickerJamSelesai.CustomFormat = "HH:MM";
            PickerJamSelesai.Format = DateTimePickerFormat.Custom;
            PickerJamSelesai.Location = new Point(186, 199);
            PickerJamSelesai.Name = "PickerJamSelesai";
            PickerJamSelesai.ShowUpDown = true;
            PickerJamSelesai.Size = new Size(301, 27);
            PickerJamSelesai.TabIndex = 41;
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
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panel5;
        private DataGridView GridListJadwalPelajaran;
        private Panel panel3;
        private Label label3;
        private RadioButton RadioUmum;
        private RadioButton RadioKhusus;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label label4;
        private TextBox TextKelasName;
        private Label label1;
        private TextBox TextKelasId;
        private Button ButtonMapelDelete;
        private Button ButtonMapelSave;
        private Button ButtonMapelNew;
        private Label label5;
        private DateTimePicker PickerJamMulai;
        private ComboBox ComboJenisJadwal;
        private ComboBox ComboHari;
        private ComboBox ComboGuru;
        private ComboBox ComboMataPelajaran;
        private DateTimePicker PickerJamSelesai;
    }
}