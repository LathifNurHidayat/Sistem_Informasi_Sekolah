namespace Sistem_Informasi_Sekolah.JadwalPelajaran
{
    partial class Kelas
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
            GridKelas = new DataGridView();
            panel3 = new Panel();
            label3 = new Label();
            TextJurusanKelas = new TextBox();
            ButtonKelasSave = new Button();
            ButtonKelasDelete = new Button();
            label2 = new Label();
            label1 = new Label();
            TextKelasName = new TextBox();
            TextKelasId = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridKelas).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSlateGray;
            panel4.Controls.Add(GridKelas);
            panel4.Location = new Point(15, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 540);
            panel4.TabIndex = 1;
            // 
            // GridKelas
            // 
            GridKelas.BackgroundColor = SystemColors.ButtonHighlight;
            GridKelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridKelas.Location = new Point(9, 9);
            GridKelas.Name = "GridKelas";
            GridKelas.RowHeadersWidth = 51;
            GridKelas.RowTemplate.Height = 29;
            GridKelas.Size = new Size(455, 520);
            GridKelas.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(TextJurusanKelas);
            panel3.Controls.Add(ButtonKelasSave);
            panel3.Controls.Add(ButtonKelasDelete);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TextKelasName);
            panel3.Controls.Add(TextKelasId);
            panel3.Location = new Point(513, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 540);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(23, 241);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 9;
            label3.Text = "Jurusan Name";
            // 
            // TextJurusanKelas
            // 
            TextJurusanKelas.BackColor = SystemColors.ControlLightLight;
            TextJurusanKelas.BorderStyle = BorderStyle.FixedSingle;
            TextJurusanKelas.Location = new Point(23, 272);
            TextJurusanKelas.Name = "TextJurusanKelas";
            TextJurusanKelas.Size = new Size(258, 27);
            TextJurusanKelas.TabIndex = 8;
            // 
            // ButtonKelasSave
            // 
            ButtonKelasSave.BackColor = Color.ForestGreen;
            ButtonKelasSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonKelasSave.ForeColor = SystemColors.ControlLightLight;
            ButtonKelasSave.Location = new Point(23, 483);
            ButtonKelasSave.Name = "ButtonKelasSave";
            ButtonKelasSave.Size = new Size(112, 35);
            ButtonKelasSave.TabIndex = 7;
            ButtonKelasSave.Text = "Save";
            ButtonKelasSave.UseVisualStyleBackColor = false;
            // 
            // ButtonKelasDelete
            // 
            ButtonKelasDelete.BackColor = Color.Crimson;
            ButtonKelasDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonKelasDelete.ForeColor = SystemColors.ControlLightLight;
            ButtonKelasDelete.Location = new Point(169, 483);
            ButtonKelasDelete.Name = "ButtonKelasDelete";
            ButtonKelasDelete.Size = new Size(112, 35);
            ButtonKelasDelete.TabIndex = 6;
            ButtonKelasDelete.Text = "Delete";
            ButtonKelasDelete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(23, 158);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 3;
            label2.Text = "Kelas Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 2;
            label1.Text = "Kelas Id";
            // 
            // TextKelasName
            // 
            TextKelasName.BackColor = SystemColors.ControlLightLight;
            TextKelasName.BorderStyle = BorderStyle.FixedSingle;
            TextKelasName.Location = new Point(23, 189);
            TextKelasName.Name = "TextKelasName";
            TextKelasName.Size = new Size(258, 27);
            TextKelasName.TabIndex = 1;
            // 
            // TextKelasId
            // 
            TextKelasId.BackColor = SystemColors.AppWorkspace;
            TextKelasId.BorderStyle = BorderStyle.FixedSingle;
            TextKelasId.Location = new Point(23, 94);
            TextKelasId.Name = "TextKelasId";
            TextKelasId.ReadOnly = true;
            TextKelasId.Size = new Size(258, 27);
            TextKelasId.TabIndex = 0;
            // 
            // Kelas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 601);
            Controls.Add(panel1);
            Name = "Kelas";
            Text = "Kelas";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridKelas).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private DataGridView GridKelas;
        private Panel panel3;
        private Button ButtonKelasSave;
        private Button ButtonKelasDelete;
        private Label label2;
        private Label label1;
        private TextBox TextKelasName;
        private TextBox TextKelasId;
        private Label label3;
        private TextBox TextJurusanKelas;
    }
}