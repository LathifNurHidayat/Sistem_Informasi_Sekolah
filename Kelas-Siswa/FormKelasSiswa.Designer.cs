namespace Sistem_Informasi_Sekolah
{
    partial class FormKelasSiswa
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
            TextSearch = new TextBox();
            GridListAllSiswa = new DataGridView();
            ButtonSaveData = new Button();
            GridListKelasSiswa = new DataGridView();
            panel5 = new Panel();
            label1 = new Label();
            ComboWaliKelas = new ComboBox();
            ComboKelas = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            TextTahunAjaran = new TextBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListAllSiswa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridListKelasSiswa).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.LightGray;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(TextSearch);
            panel4.Controls.Add(GridListAllSiswa);
            panel4.Controls.Add(ButtonSaveData);
            panel4.Controls.Add(GridListKelasSiswa);
            panel4.Location = new Point(369, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(785, 644);
            panel4.TabIndex = 2;
            // 
            // TextSearch
            // 
            TextSearch.BorderStyle = BorderStyle.FixedSingle;
            TextSearch.Location = new Point(13, 25);
            TextSearch.Name = "TextSearch";
            TextSearch.PlaceholderText = "🔎 Cari data siswa ";
            TextSearch.Size = new Size(373, 27);
            TextSearch.TabIndex = 7;
            // 
            // GridListAllSiswa
            // 
            GridListAllSiswa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridListAllSiswa.BackgroundColor = Color.WhiteSmoke;
            GridListAllSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListAllSiswa.GridColor = SystemColors.Control;
            GridListAllSiswa.Location = new Point(13, 79);
            GridListAllSiswa.Name = "GridListAllSiswa";
            GridListAllSiswa.RowHeadersWidth = 51;
            GridListAllSiswa.RowTemplate.Height = 29;
            GridListAllSiswa.Size = new Size(373, 492);
            GridListAllSiswa.TabIndex = 6;
            // 
            // ButtonSaveData
            // 
            ButtonSaveData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSaveData.BackColor = Color.LimeGreen;
            ButtonSaveData.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSaveData.ForeColor = SystemColors.ControlLightLight;
            ButtonSaveData.Location = new Point(650, 588);
            ButtonSaveData.Name = "ButtonSaveData";
            ButtonSaveData.Size = new Size(120, 35);
            ButtonSaveData.TabIndex = 5;
            ButtonSaveData.Text = "Save";
            ButtonSaveData.UseVisualStyleBackColor = false;
            // 
            // GridListKelasSiswa
            // 
            GridListKelasSiswa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridListKelasSiswa.BackgroundColor = Color.WhiteSmoke;
            GridListKelasSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListKelasSiswa.GridColor = SystemColors.Control;
            GridListKelasSiswa.Location = new Point(392, 79);
            GridListKelasSiswa.Name = "GridListKelasSiswa";
            GridListKelasSiswa.RowHeadersWidth = 51;
            GridListKelasSiswa.RowTemplate.Height = 29;
            GridListKelasSiswa.Size = new Size(378, 492);
            GridListKelasSiswa.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel5.BackColor = Color.LightGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(ComboWaliKelas);
            panel5.Controls.Add(ComboKelas);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(TextTahunAjaran);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(351, 644);
            panel5.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 234);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 12;
            label1.Text = "Wali Kelas";
            // 
            // ComboWaliKelas
            // 
            ComboWaliKelas.FormattingEnabled = true;
            ComboWaliKelas.Location = new Point(30, 266);
            ComboWaliKelas.Name = "ComboWaliKelas";
            ComboWaliKelas.Size = new Size(288, 28);
            ComboWaliKelas.TabIndex = 11;
            // 
            // ComboKelas
            // 
            ComboKelas.FormattingEnabled = true;
            ComboKelas.Location = new Point(30, 79);
            ComboKelas.Name = "ComboKelas";
            ComboKelas.Size = new Size(288, 28);
            ComboKelas.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(30, 141);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 9;
            label3.Text = "Tahun Ajaran";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 48);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 3;
            label2.Text = "Kelas";
            // 
            // TextTahunAjaran
            // 
            TextTahunAjaran.BackColor = SystemColors.ControlLightLight;
            TextTahunAjaran.BorderStyle = BorderStyle.FixedSingle;
            TextTahunAjaran.Location = new Point(30, 173);
            TextTahunAjaran.Name = "TextTahunAjaran";
            TextTahunAjaran.Size = new Size(288, 27);
            TextTahunAjaran.TabIndex = 1;
            // 
            // FormKelasSiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 668);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Name = "FormKelasSiswa";
            Text = "FormKelasSiswa";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridListAllSiswa).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridListKelasSiswa).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Button ButtonSaveData;
        private Panel panel5;
        private Label label1;
        private ComboBox ComboWaliKelas;
        private ComboBox ComboKelas;
        private Label label3;
        private Label label2;
        private TextBox TextTahunAjaran;
        private TextBox TextSearch;
        private DataGridView GridListAllSiswa;
        private DataGridView GridListKelasSiswa;
    }
}