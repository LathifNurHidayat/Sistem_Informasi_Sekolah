﻿namespace Sistem_Informasi_Sekolah
{
    partial class FormGuru
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
            panel3 = new Panel();
            ComboTingkatPendidikan = new ComboBox();
            PickerTglLahirGuru = new DateTimePicker();
            label8 = new Label();
            panel6 = new Panel();
            GridListGuruMapel = new DataGridView();
            TextKota = new TextBox();
            label6 = new Label();
            TextInstansiPendidikan = new TextBox();
            label7 = new Label();
            TextTahunLulus = new TextBox();
            label4 = new Label();
            TextJurusanPendidikan = new TextBox();
            label5 = new Label();
            label3 = new Label();
            TextGuruNama = new TextBox();
            label2 = new Label();
            TextGuruId = new TextBox();
            panel5 = new Panel();
            PictureFotoGuru = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            GridListGuru = new DataGridView();
            panel1 = new Panel();
            ButtonGuruNew = new Button();
            ButtonGuruDelete = new Button();
            ButtonGuruSave = new Button();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListGuruMapel).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureFotoGuru).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListGuru).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(ComboTingkatPendidikan);
            panel3.Controls.Add(PickerTglLahirGuru);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(TextKota);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(TextInstansiPendidikan);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(TextTahunLulus);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(TextJurusanPendidikan);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(TextGuruNama);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(TextGuruId);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(405, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(661, 717);
            panel3.TabIndex = 23;
            // 
            // ComboTingkatPendidikan
            // 
            ComboTingkatPendidikan.FormattingEnabled = true;
            ComboTingkatPendidikan.Location = new Point(22, 280);
            ComboTingkatPendidikan.Name = "ComboTingkatPendidikan";
            ComboTingkatPendidikan.Size = new Size(301, 28);
            ComboTingkatPendidikan.TabIndex = 3;
            // 
            // PickerTglLahirGuru
            // 
            PickerTglLahirGuru.Location = new Point(22, 202);
            PickerTglLahirGuru.Name = "PickerTglLahirGuru";
            PickerTglLahirGuru.Size = new Size(301, 27);
            PickerTglLahirGuru.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightGray;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(22, 257);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 25;
            label8.Text = "Tingkat Pendidikan";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gainsboro;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(GridListGuruMapel);
            panel6.Location = new Point(22, 487);
            panel6.Name = "panel6";
            panel6.Size = new Size(627, 125);
            panel6.TabIndex = 6;
            // 
            // GridListGuruMapel
            // 
            GridListGuruMapel.BackgroundColor = SystemColors.ButtonHighlight;
            GridListGuruMapel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListGuruMapel.Location = new Point(3, 3);
            GridListGuruMapel.Name = "GridListGuruMapel";
            GridListGuruMapel.RowHeadersWidth = 51;
            GridListGuruMapel.RowTemplate.Height = 29;
            GridListGuruMapel.Size = new Size(619, 117);
            GridListGuruMapel.TabIndex = 8;
            // 
            // TextKota
            // 
            TextKota.BackColor = SystemColors.ControlLightLight;
            TextKota.BorderStyle = BorderStyle.FixedSingle;
            TextKota.Location = new Point(348, 429);
            TextKota.Name = "TextKota";
            TextKota.Size = new Size(301, 27);
            TextKota.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(348, 406);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 22;
            label6.Text = "Kota";
            // 
            // TextInstansiPendidikan
            // 
            TextInstansiPendidikan.BackColor = SystemColors.ControlLightLight;
            TextInstansiPendidikan.BorderStyle = BorderStyle.FixedSingle;
            TextInstansiPendidikan.Location = new Point(348, 352);
            TextInstansiPendidikan.Name = "TextInstansiPendidikan";
            TextInstansiPendidikan.Size = new Size(301, 27);
            TextInstansiPendidikan.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightGray;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(348, 329);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 20;
            label7.Text = "Instansi Pendidikan";
            // 
            // TextTahunLulus
            // 
            TextTahunLulus.BackColor = SystemColors.ControlLightLight;
            TextTahunLulus.BorderStyle = BorderStyle.FixedSingle;
            TextTahunLulus.Location = new Point(22, 429);
            TextTahunLulus.Name = "TextTahunLulus";
            TextTahunLulus.Size = new Size(301, 27);
            TextTahunLulus.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(22, 406);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 18;
            label4.Text = "Tahun Lulus";
            // 
            // TextJurusanPendidikan
            // 
            TextJurusanPendidikan.BackColor = SystemColors.ControlLightLight;
            TextJurusanPendidikan.BorderStyle = BorderStyle.FixedSingle;
            TextJurusanPendidikan.Location = new Point(22, 352);
            TextJurusanPendidikan.Name = "TextJurusanPendidikan";
            TextJurusanPendidikan.Size = new Size(301, 27);
            TextJurusanPendidikan.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(22, 329);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 16;
            label5.Text = "Jurusan Pendidikan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 179);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 14;
            label3.Text = "Tanggal Lahir";
            // 
            // TextGuruNama
            // 
            TextGuruNama.BackColor = SystemColors.ControlLightLight;
            TextGuruNama.BorderStyle = BorderStyle.FixedSingle;
            TextGuruNama.Location = new Point(22, 125);
            TextGuruNama.Name = "TextGuruNama";
            TextGuruNama.Size = new Size(301, 27);
            TextGuruNama.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 101);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 12;
            label2.Text = "Nama";
            // 
            // TextGuruId
            // 
            TextGuruId.BackColor = SystemColors.ControlLight;
            TextGuruId.BorderStyle = BorderStyle.FixedSingle;
            TextGuruId.Location = new Point(22, 48);
            TextGuruId.Name = "TextGuruId";
            TextGuruId.ReadOnly = true;
            TextGuruId.Size = new Size(301, 27);
            TextGuruId.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(PictureFotoGuru);
            panel5.Location = new Point(375, 23);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 283);
            panel5.TabIndex = 5;
            // 
            // PictureFotoGuru
            // 
            PictureFotoGuru.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PictureFotoGuru.BackColor = Color.WhiteSmoke;
            PictureFotoGuru.BorderStyle = BorderStyle.FixedSingle;
            PictureFotoGuru.Location = new Point(4, 4);
            PictureFotoGuru.Name = "PictureFotoGuru";
            PictureFotoGuru.Size = new Size(260, 273);
            PictureFotoGuru.TabIndex = 4;
            PictureFotoGuru.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "GuruId";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.LightGray;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(GridListGuru);
            panel4.Location = new Point(11, 11);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 717);
            panel4.TabIndex = 1;
            // 
            // GridListGuru
            // 
            GridListGuru.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListGuru.BackgroundColor = SystemColors.ButtonHighlight;
            GridListGuru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListGuru.Location = new Point(10, 10);
            GridListGuru.Name = "GridListGuru";
            GridListGuru.RowHeadersWidth = 51;
            GridListGuru.RowTemplate.Height = 29;
            GridListGuru.Size = new Size(358, 695);
            GridListGuru.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ButtonGuruNew);
            panel1.Controls.Add(ButtonGuruDelete);
            panel1.Controls.Add(ButtonGuruSave);
            panel1.Location = new Point(11, 743);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 77);
            panel1.TabIndex = 8;
            // 
            // ButtonGuruNew
            // 
            ButtonGuruNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonGuruNew.BackColor = Color.RoyalBlue;
            ButtonGuruNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonGuruNew.ForeColor = SystemColors.ControlLightLight;
            ButtonGuruNew.Location = new Point(630, 16);
            ButtonGuruNew.Name = "ButtonGuruNew";
            ButtonGuruNew.Size = new Size(118, 35);
            ButtonGuruNew.TabIndex = 11;
            ButtonGuruNew.Text = "New Data";
            ButtonGuruNew.UseVisualStyleBackColor = false;
            // 
            // ButtonGuruDelete
            // 
            ButtonGuruDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonGuruDelete.BackColor = Color.Crimson;
            ButtonGuruDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonGuruDelete.ForeColor = SystemColors.ControlLightLight;
            ButtonGuruDelete.Location = new Point(916, 16);
            ButtonGuruDelete.Name = "ButtonGuruDelete";
            ButtonGuruDelete.Size = new Size(118, 35);
            ButtonGuruDelete.TabIndex = 10;
            ButtonGuruDelete.Text = "Delete";
            ButtonGuruDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonGuruSave
            // 
            ButtonGuruSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonGuruSave.BackColor = Color.ForestGreen;
            ButtonGuruSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonGuruSave.ForeColor = SystemColors.ControlLightLight;
            ButtonGuruSave.Location = new Point(774, 16);
            ButtonGuruSave.Name = "ButtonGuruSave";
            ButtonGuruSave.Size = new Size(118, 35);
            ButtonGuruSave.TabIndex = 9;
            ButtonGuruSave.Text = "Save";
            ButtonGuruSave.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 833);
            panel2.TabIndex = 6;
            // 
            // FormGuru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 833);
            Controls.Add(panel2);
            Name = "FormGuru";
            Text = "Guru";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridListGuruMapel).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureFotoGuru).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridListGuru).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private ComboBox ComboTingkatPendidikan;
        private DateTimePicker PickerTglLahirGuru;
        private Label label8;
        private Panel panel6;
        private DataGridView GridListGuruMapel;
        private TextBox TextKota;
        private Label label6;
        private TextBox TextInstansiPendidikan;
        private Label label7;
        private TextBox TextTahunLulus;
        private Label label4;
        private TextBox TextJurusanPendidikan;
        private Label label5;
        private Label label3;
        private TextBox TextGuruNama;
        private Label label2;
        private TextBox TextGuruId;
        private Panel panel5;
        private PictureBox PictureFotoGuru;
        private Label label1;
        private Panel panel4;
        private DataGridView GridListGuru;
        private Panel panel1;
        private Button ButtonGuruNew;
        private Button ButtonGuruDelete;
        private Button ButtonGuruSave;
        private Panel panel2;
    }
}