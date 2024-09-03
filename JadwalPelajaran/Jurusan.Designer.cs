namespace Sistem_Informasi_Sekolah.JadwalPelajaran
{
    partial class Jurusan
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
            panel2 = new Panel();
            panel4 = new Panel();
            GridJurusan = new DataGridView();
            panel3 = new Panel();
            ButtonJurusanSave = new Button();
            ButtonJurusanDelete = new Button();
            label2 = new Label();
            label1 = new Label();
            TextJurusanName = new TextBox();
            TextJurusanId = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridJurusan).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 601);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 577);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSlateGray;
            panel4.Controls.Add(GridJurusan);
            panel4.Location = new Point(15, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 540);
            panel4.TabIndex = 1;
            // 
            // GridJurusan
            // 
            GridJurusan.BackgroundColor = SystemColors.ButtonHighlight;
            GridJurusan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridJurusan.Location = new Point(3, 3);
            GridJurusan.Name = "GridJurusan";
            GridJurusan.RowHeadersWidth = 51;
            GridJurusan.RowTemplate.Height = 29;
            GridJurusan.Size = new Size(467, 534);
            GridJurusan.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(ButtonJurusanSave);
            panel3.Controls.Add(ButtonJurusanDelete);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TextJurusanName);
            panel3.Controls.Add(TextJurusanId);
            panel3.Location = new Point(513, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 540);
            panel3.TabIndex = 0;
            // 
            // ButtonJurusanSave
            // 
            ButtonJurusanSave.BackColor = Color.ForestGreen;
            ButtonJurusanSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonJurusanSave.ForeColor = SystemColors.ControlLightLight;
            ButtonJurusanSave.Location = new Point(23, 483);
            ButtonJurusanSave.Name = "ButtonJurusanSave";
            ButtonJurusanSave.Size = new Size(112, 35);
            ButtonJurusanSave.TabIndex = 7;
            ButtonJurusanSave.Text = "Save";
            ButtonJurusanSave.UseVisualStyleBackColor = false;
            // 
            // ButtonJurusanDelete
            // 
            ButtonJurusanDelete.BackColor = Color.Crimson;
            ButtonJurusanDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonJurusanDelete.ForeColor = SystemColors.ControlLightLight;
            ButtonJurusanDelete.Location = new Point(169, 483);
            ButtonJurusanDelete.Name = "ButtonJurusanDelete";
            ButtonJurusanDelete.Size = new Size(112, 35);
            ButtonJurusanDelete.TabIndex = 6;
            ButtonJurusanDelete.Text = "Delete";
            ButtonJurusanDelete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(23, 158);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 3;
            label2.Text = "Jurusan Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 2;
            label1.Text = "Jurusan Id";
            // 
            // TextJurusanName
            // 
            TextJurusanName.BackColor = SystemColors.ControlLightLight;
            TextJurusanName.Location = new Point(23, 189);
            TextJurusanName.Name = "TextJurusanName";
            TextJurusanName.Size = new Size(258, 27);
            TextJurusanName.TabIndex = 1;
            // 
            // TextJurusanId
            // 
            TextJurusanId.BackColor = SystemColors.ControlLightLight;
            TextJurusanId.Location = new Point(23, 94);
            TextJurusanId.Name = "TextJurusanId";
            TextJurusanId.Size = new Size(258, 27);
            TextJurusanId.TabIndex = 0;
            // 
            // Jurusan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 601);
            Controls.Add(panel1);
            Name = "Jurusan";
            Text = "Jurusan";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridJurusan).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private DataGridView GridJurusan;
        private Panel panel3;
        private Button ButtonJurusanSave;
        private Button ButtonJurusanDelete;
        private Label label2;
        private Label label1;
        private TextBox TextJurusanName;
        private TextBox TextJurusanId;
    }
}