namespace Sistem_Informasi_Sekolah
{
    partial class FormPresensi
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
            GridListJadwalPelajaran = new DataGridView();
            panel1 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListJadwalPelajaran).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Gainsboro;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(GridListJadwalPelajaran);
            panel4.Location = new Point(457, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(713, 729);
            panel4.TabIndex = 4;
            // 
            // GridListJadwalPelajaran
            // 
            GridListJadwalPelajaran.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListJadwalPelajaran.BackgroundColor = Color.WhiteSmoke;
            GridListJadwalPelajaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListJadwalPelajaran.GridColor = SystemColors.Control;
            GridListJadwalPelajaran.Location = new Point(10, 11);
            GridListJadwalPelajaran.Name = "GridListJadwalPelajaran";
            GridListJadwalPelajaran.RowHeadersWidth = 51;
            GridListJadwalPelajaran.RowTemplate.Height = 29;
            GridListJadwalPelajaran.Size = new Size(690, 618);
            GridListJadwalPelajaran.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 729);
            panel1.TabIndex = 5;
            // 
            // FormPresensi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "FormPresensi";
            Text = "Presensi";
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridListJadwalPelajaran).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DataGridView GridListJadwalPelajaran;
        private Panel panel1;
    }
}