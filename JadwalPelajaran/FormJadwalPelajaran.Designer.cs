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
            RadioKhusus = new RadioButton();
            GridListJadwalPelajaran = new DataGridView();
            RadioUmum = new RadioButton();
            label3 = new Label();
            panel3 = new Panel();
            RadioInputKhusus = new RadioButton();
            RadioInputUmum = new RadioButton();
            PickerJamSelesai = new DateTimePicker();
            PickerJamMulai = new DateTimePicker();
            ComboHari = new ComboBox();
            ComboGuru = new ComboBox();
            ComboMataPelajaran = new ComboBox();
            ButtonMapelDelete = new Button();
            ButtonMapelSave = new Button();
            ButtonMapelNew = new Button();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            TextKelasName = new TextBox();
            label1 = new Label();
            TextKelasId = new TextBox();
            label5 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(15, 16);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1790, 900);
            panel1.TabIndex = 0;
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
            panel4.Location = new Point(11, 11);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1087, 873);
            panel4.TabIndex = 2;
            // 
            // RadioKhusus
            // 
            RadioKhusus.AutoSize = true;
            RadioKhusus.Location = new Point(354, 22);
            RadioKhusus.Margin = new Padding(4, 4, 4, 4);
            RadioKhusus.Name = "RadioKhusus";
            RadioKhusus.Size = new Size(93, 29);
            RadioKhusus.TabIndex = 23;
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
            GridListJadwalPelajaran.Location = new Point(12, 80);
            GridListJadwalPelajaran.Margin = new Padding(4, 4, 4, 4);
            GridListJadwalPelajaran.Name = "GridListJadwalPelajaran";
            GridListJadwalPelajaran.RowHeadersWidth = 51;
            GridListJadwalPelajaran.RowTemplate.Height = 29;
            GridListJadwalPelajaran.Size = new Size(1060, 779);
            GridListJadwalPelajaran.TabIndex = 0;
            // 
            // RadioUmum
            // 
            RadioUmum.AutoSize = true;
            RadioUmum.Location = new Point(191, 22);
            RadioUmum.Margin = new Padding(4, 4, 4, 4);
            RadioUmum.Name = "RadioUmum";
            RadioUmum.Size = new Size(91, 29);
            RadioUmum.TabIndex = 22;
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
            label3.Location = new Point(45, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 21;
            label3.Text = "Jenis Jadwal  :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(RadioInputKhusus);
            panel3.Controls.Add(RadioInputUmum);
            panel3.Controls.Add(PickerJamSelesai);
            panel3.Controls.Add(PickerJamMulai);
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
            panel3.Location = new Point(1106, 248);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(672, 637);
            panel3.TabIndex = 1;
            // 
            // RadioInputKhusus
            // 
            RadioInputKhusus.AutoSize = true;
            RadioInputKhusus.Location = new Point(489, 44);
            RadioInputKhusus.Margin = new Padding(4, 4, 4, 4);
            RadioInputKhusus.Name = "RadioInputKhusus";
            RadioInputKhusus.Size = new Size(93, 29);
            RadioInputKhusus.TabIndex = 43;
            RadioInputKhusus.TabStop = true;
            RadioInputKhusus.Text = "Khusus";
            RadioInputKhusus.UseVisualStyleBackColor = true;
            // 
            // RadioInputUmum
            // 
            RadioInputUmum.AutoSize = true;
            RadioInputUmum.Location = new Point(259, 44);
            RadioInputUmum.Margin = new Padding(4, 4, 4, 4);
            RadioInputUmum.Name = "RadioInputUmum";
            RadioInputUmum.Size = new Size(91, 29);
            RadioInputUmum.TabIndex = 42;
            RadioInputUmum.TabStop = true;
            RadioInputUmum.Text = "Umum";
            RadioInputUmum.UseVisualStyleBackColor = true;
            // 
            // PickerJamSelesai
            // 
            PickerJamSelesai.CustomFormat = "HH:MM";
            PickerJamSelesai.Format = DateTimePickerFormat.Custom;
            PickerJamSelesai.Location = new Point(232, 248);
            PickerJamSelesai.Margin = new Padding(4, 4, 4, 4);
            PickerJamSelesai.Name = "PickerJamSelesai";
            PickerJamSelesai.ShowUpDown = true;
            PickerJamSelesai.Size = new Size(375, 31);
            PickerJamSelesai.TabIndex = 41;
            // 
            // PickerJamMulai
            // 
            PickerJamMulai.CustomFormat = "HH:MM";
            PickerJamMulai.Format = DateTimePickerFormat.Custom;
            PickerJamMulai.Location = new Point(232, 179);
            PickerJamMulai.Margin = new Padding(4, 4, 4, 4);
            PickerJamMulai.Name = "PickerJamMulai";
            PickerJamMulai.ShowUpDown = true;
            PickerJamMulai.Size = new Size(375, 31);
            PickerJamMulai.TabIndex = 40;
            // 
            // ComboHari
            // 
            ComboHari.FormattingEnabled = true;
            ComboHari.Location = new Point(232, 109);
            ComboHari.Margin = new Padding(4, 4, 4, 4);
            ComboHari.Name = "ComboHari";
            ComboHari.Size = new Size(375, 33);
            ComboHari.TabIndex = 38;
            // 
            // ComboGuru
            // 
            ComboGuru.FormattingEnabled = true;
            ComboGuru.Location = new Point(232, 460);
            ComboGuru.Margin = new Padding(4, 4, 4, 4);
            ComboGuru.Name = "ComboGuru";
            ComboGuru.Size = new Size(375, 33);
            ComboGuru.TabIndex = 37;
            // 
            // ComboMataPelajaran
            // 
            ComboMataPelajaran.FormattingEnabled = true;
            ComboMataPelajaran.Location = new Point(232, 395);
            ComboMataPelajaran.Margin = new Padding(4, 4, 4, 4);
            ComboMataPelajaran.Name = "ComboMataPelajaran";
            ComboMataPelajaran.Size = new Size(375, 33);
            ComboMataPelajaran.TabIndex = 36;
            // 
            // ButtonMapelDelete
            // 
            ButtonMapelDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonMapelDelete.BackColor = Color.Crimson;
            ButtonMapelDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMapelDelete.ForeColor = SystemColors.ControlLightLight;
            ButtonMapelDelete.Location = new Point(332, 548);
            ButtonMapelDelete.Margin = new Padding(4, 4, 4, 4);
            ButtonMapelDelete.Name = "ButtonMapelDelete";
            ButtonMapelDelete.Size = new Size(120, 44);
            ButtonMapelDelete.TabIndex = 34;
            ButtonMapelDelete.Text = "Delete";
            ButtonMapelDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonMapelSave
            // 
            ButtonMapelSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonMapelSave.BackColor = Color.ForestGreen;
            ButtonMapelSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMapelSave.ForeColor = SystemColors.ControlLightLight;
            ButtonMapelSave.Location = new Point(489, 548);
            ButtonMapelSave.Margin = new Padding(4, 4, 4, 4);
            ButtonMapelSave.Name = "ButtonMapelSave";
            ButtonMapelSave.Size = new Size(120, 44);
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
            ButtonMapelNew.Location = new Point(176, 548);
            ButtonMapelNew.Margin = new Padding(4, 4, 4, 4);
            ButtonMapelNew.Name = "ButtonMapelNew";
            ButtonMapelNew.Size = new Size(120, 44);
            ButtonMapelNew.TabIndex = 35;
            ButtonMapelNew.Text = "New Data";
            ButtonMapelNew.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(59, 466);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(50, 25);
            label8.TabIndex = 32;
            label8.Text = "Guru";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(59, 399);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(126, 25);
            label9.TabIndex = 30;
            label9.Text = "Mata Pelajaran";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(59, 254);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 28;
            label6.Text = "Selesai";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(59, 184);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 26;
            label7.Text = "Jam Mulai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(59, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 24;
            label2.Text = "Hari";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(59, 44);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 22;
            label4.Text = "Jenis Jadwal";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(TextKelasName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TextKelasId);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(1106, 12);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 227);
            panel2.TabIndex = 0;
            // 
            // TextKelasName
            // 
            TextKelasName.BackColor = SystemColors.ControlLightLight;
            TextKelasName.BorderStyle = BorderStyle.FixedSingle;
            TextKelasName.Location = new Point(232, 130);
            TextKelasName.Margin = new Padding(4, 4, 4, 4);
            TextKelasName.Name = "TextKelasName";
            TextKelasName.ReadOnly = true;
            TextKelasName.Size = new Size(376, 31);
            TextKelasName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(59, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 20;
            label1.Text = "Kelas Name";
            // 
            // TextKelasId
            // 
            TextKelasId.BackColor = SystemColors.ControlLightLight;
            TextKelasId.BorderStyle = BorderStyle.FixedSingle;
            TextKelasId.Location = new Point(232, 62);
            TextKelasId.Margin = new Padding(4, 4, 4, 4);
            TextKelasId.Name = "TextKelasId";
            TextKelasId.ReadOnly = true;
            TextKelasId.Size = new Size(313, 31);
            TextKelasId.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(59, 68);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 18;
            label5.Text = "Kelas Id";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(557, 62);
            button1.Name = "button1";
            button1.Size = new Size(50, 31);
            button1.TabIndex = 21;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormJadwalPelajaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 930);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormJadwalPelajaran";
            Text = "FormJadwalPelajaran";
            panel1.ResumeLayout(false);
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
        private Button ButtonMapelDelete;
        private Button ButtonMapelSave;
        private Button ButtonMapelNew;
        private Label label5;
        private DateTimePicker PickerJamMulai;
        private ComboBox ComboHari;
        private ComboBox ComboGuru;
        private ComboBox ComboMataPelajaran;
        private DateTimePicker PickerJamSelesai;
        private RadioButton RadioKhusus;
        private RadioButton RadioUmum;
        private Label label3;
        private RadioButton RadioInputKhusus;
        private RadioButton RadioInputUmum;
        private Button button1;
    }
}