namespace Sistem_Informasi_Sekolah
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
            panel2 = new Panel();
            panel4 = new Panel();
            GridListKelas = new DataGridView();
            panel3 = new Panel();
            panel1 = new Panel();
            ComboKelasName = new ComboBox();
            ComboKelasJurusan = new ComboBox();
            RadioKelas_12 = new RadioButton();
            RadioKelas_11 = new RadioButton();
            RadioKelas_10 = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TextKelasId = new TextBox();
            panel5 = new Panel();
            ButtonKelasSave = new Button();
            ButtonKelasDelete = new Button();
            ButtonKelasNew = new Button();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListKelas).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
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
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(GridListKelas);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(446, 569);
            panel4.TabIndex = 1;
            // 
            // GridListKelas
            // 
            GridListKelas.BackgroundColor = SystemColors.ButtonHighlight;
            GridListKelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListKelas.Location = new Point(9, 9);
            GridListKelas.Name = "GridListKelas";
            GridListKelas.RowHeadersWidth = 51;
            GridListKelas.RowTemplate.Height = 29;
            GridListKelas.Size = new Size(425, 548);
            GridListKelas.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(455, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 569);
            panel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ComboKelasName);
            panel1.Controls.Add(ComboKelasJurusan);
            panel1.Controls.Add(RadioKelas_12);
            panel1.Controls.Add(RadioKelas_11);
            panel1.Controls.Add(RadioKelas_10);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextKelasId);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 460);
            panel1.TabIndex = 15;
            // 
            // ComboKelasName
            // 
            ComboKelasName.FormattingEnabled = true;
            ComboKelasName.Location = new Point(17, 149);
            ComboKelasName.Name = "ComboKelasName";
            ComboKelasName.Size = new Size(312, 28);
            ComboKelasName.TabIndex = 14;
            // 
            // ComboKelasJurusan
            // 
            ComboKelasJurusan.FormattingEnabled = true;
            ComboKelasJurusan.Location = new Point(17, 315);
            ComboKelasJurusan.Name = "ComboKelasJurusan";
            ComboKelasJurusan.Size = new Size(312, 28);
            ComboKelasJurusan.TabIndex = 13;
            // 
            // RadioKelas_12
            // 
            RadioKelas_12.AutoSize = true;
            RadioKelas_12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RadioKelas_12.ForeColor = Color.Black;
            RadioKelas_12.Location = new Point(282, 244);
            RadioKelas_12.Name = "RadioKelas_12";
            RadioKelas_12.Size = new Size(47, 27);
            RadioKelas_12.TabIndex = 12;
            RadioKelas_12.TabStop = true;
            RadioKelas_12.Text = "12";
            RadioKelas_12.UseVisualStyleBackColor = true;
            // 
            // RadioKelas_11
            // 
            RadioKelas_11.AutoSize = true;
            RadioKelas_11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RadioKelas_11.ForeColor = Color.Black;
            RadioKelas_11.Location = new Point(143, 244);
            RadioKelas_11.Name = "RadioKelas_11";
            RadioKelas_11.Size = new Size(45, 27);
            RadioKelas_11.TabIndex = 11;
            RadioKelas_11.TabStop = true;
            RadioKelas_11.Text = "11";
            RadioKelas_11.UseVisualStyleBackColor = true;
            // 
            // RadioKelas_10
            // 
            RadioKelas_10.AutoSize = true;
            RadioKelas_10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RadioKelas_10.ForeColor = Color.Black;
            RadioKelas_10.Location = new Point(17, 244);
            RadioKelas_10.Name = "RadioKelas_10";
            RadioKelas_10.Size = new Size(47, 27);
            RadioKelas_10.TabIndex = 10;
            RadioKelas_10.TabStop = true;
            RadioKelas_10.Text = "10";
            RadioKelas_10.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 284);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 9;
            label4.Text = "Jurusan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(17, 202);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 8;
            label3.Text = "Tingkat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 118);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 3;
            label2.Text = "Kelas Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 2;
            label1.Text = "Kelas Id";
            // 
            // TextKelasId
            // 
            TextKelasId.BackColor = SystemColors.ControlLightLight;
            TextKelasId.BorderStyle = BorderStyle.FixedSingle;
            TextKelasId.Location = new Point(14, 65);
            TextKelasId.Name = "TextKelasId";
            TextKelasId.ReadOnly = true;
            TextKelasId.Size = new Size(315, 27);
            TextKelasId.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(ButtonKelasSave);
            panel5.Controls.Add(ButtonKelasDelete);
            panel5.Controls.Add(ButtonKelasNew);
            panel5.Location = new Point(12, 482);
            panel5.Name = "panel5";
            panel5.Size = new Size(352, 74);
            panel5.TabIndex = 16;
            // 
            // ButtonKelasSave
            // 
            ButtonKelasSave.BackColor = Color.ForestGreen;
            ButtonKelasSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonKelasSave.ForeColor = SystemColors.ControlLightLight;
            ButtonKelasSave.Location = new Point(131, 20);
            ButtonKelasSave.Name = "ButtonKelasSave";
            ButtonKelasSave.Size = new Size(95, 35);
            ButtonKelasSave.TabIndex = 7;
            ButtonKelasSave.Text = "Save";
            ButtonKelasSave.UseVisualStyleBackColor = false;
            // 
            // ButtonKelasDelete
            // 
            ButtonKelasDelete.BackColor = Color.Crimson;
            ButtonKelasDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonKelasDelete.ForeColor = SystemColors.ControlLightLight;
            ButtonKelasDelete.Location = new Point(244, 20);
            ButtonKelasDelete.Name = "ButtonKelasDelete";
            ButtonKelasDelete.Size = new Size(95, 35);
            ButtonKelasDelete.TabIndex = 6;
            ButtonKelasDelete.Text = "Delete";
            ButtonKelasDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonKelasNew
            // 
            ButtonKelasNew.BackColor = Color.DodgerBlue;
            ButtonKelasNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonKelasNew.ForeColor = SystemColors.ControlLightLight;
            ButtonKelasNew.Location = new Point(15, 20);
            ButtonKelasNew.Name = "ButtonKelasNew";
            ButtonKelasNew.Size = new Size(95, 35);
            ButtonKelasNew.TabIndex = 14;
            ButtonKelasNew.Text = "New";
            ButtonKelasNew.UseVisualStyleBackColor = false;
            // 
            // Kelas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 601);
            Controls.Add(panel2);
            Name = "Kelas";
            Text = "Kelas";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridListKelas).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel4;
        private DataGridView GridListKelas;
        private Panel panel3;
        private Button ButtonKelasSave;
        private Button ButtonKelasDelete;
        private Label label2;
        private Label label1;
        private TextBox TextKelasId;
        private Button ButtonKelasNew;
        private ComboBox ComboKelasJurusan;
        private RadioButton RadioKelas_12;
        private RadioButton RadioKelas_11;
        private RadioButton RadioKelas_10;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Panel panel5;
        private ComboBox ComboKelasName;
    }
}