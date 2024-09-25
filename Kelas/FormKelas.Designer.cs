namespace Sistem_Informasi_Sekolah
{
    partial class FormKelas
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
            label5 = new Label();
            TextFlagKelas = new TextBox();
            TextKelasName = new TextBox();
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
            panel27 = new Panel();
            panel7 = new Panel();
            label49 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListKelas).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel27.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.DarkGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 585);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(GridListKelas);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(446, 577);
            panel4.TabIndex = 1;
            // 
            // GridListKelas
            // 
            GridListKelas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListKelas.BackgroundColor = SystemColors.ButtonHighlight;
            GridListKelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListKelas.Location = new Point(9, 9);
            GridListKelas.Name = "GridListKelas";
            GridListKelas.RowHeadersWidth = 51;
            GridListKelas.RowTemplate.Height = 29;
            GridListKelas.Size = new Size(425, 556);
            GridListKelas.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.Silver;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(455, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 577);
            panel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TextFlagKelas);
            panel1.Controls.Add(TextKelasName);
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
            panel1.Size = new Size(352, 468);
            panel1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 334);
            label5.Name = "label5";
            label5.Size = new Size(49, 28);
            label5.TabIndex = 17;
            label5.Text = "Flag";
            // 
            // TextFlagKelas
            // 
            TextFlagKelas.BorderStyle = BorderStyle.FixedSingle;
            TextFlagKelas.Location = new Point(15, 365);
            TextFlagKelas.Name = "TextFlagKelas";
            TextFlagKelas.Size = new Size(148, 27);
            TextFlagKelas.TabIndex = 5;
            // 
            // TextKelasName
            // 
            TextKelasName.BackColor = SystemColors.ActiveBorder;
            TextKelasName.BorderStyle = BorderStyle.FixedSingle;
            TextKelasName.Location = new Point(13, 142);
            TextKelasName.Name = "TextKelasName";
            TextKelasName.ReadOnly = true;
            TextKelasName.Size = new Size(315, 27);
            TextKelasName.TabIndex = 15;
            // 
            // ComboKelasJurusan
            // 
            ComboKelasJurusan.FormattingEnabled = true;
            ComboKelasJurusan.Location = new Point(13, 294);
            ComboKelasJurusan.Name = "ComboKelasJurusan";
            ComboKelasJurusan.Size = new Size(316, 28);
            ComboKelasJurusan.TabIndex = 4;
            // 
            // RadioKelas_12
            // 
            RadioKelas_12.AutoSize = true;
            RadioKelas_12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RadioKelas_12.ForeColor = Color.Black;
            RadioKelas_12.Location = new Point(282, 223);
            RadioKelas_12.Name = "RadioKelas_12";
            RadioKelas_12.Size = new Size(40, 27);
            RadioKelas_12.TabIndex = 12;
            RadioKelas_12.TabStop = true;
            RadioKelas_12.Text = "3";
            RadioKelas_12.UseVisualStyleBackColor = true;
            // 
            // RadioKelas_11
            // 
            RadioKelas_11.AutoSize = true;
            RadioKelas_11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RadioKelas_11.ForeColor = Color.Black;
            RadioKelas_11.Location = new Point(150, 223);
            RadioKelas_11.Name = "RadioKelas_11";
            RadioKelas_11.Size = new Size(40, 27);
            RadioKelas_11.TabIndex = 11;
            RadioKelas_11.TabStop = true;
            RadioKelas_11.Text = "2";
            RadioKelas_11.UseVisualStyleBackColor = true;
            // 
            // RadioKelas_10
            // 
            RadioKelas_10.AutoSize = true;
            RadioKelas_10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RadioKelas_10.ForeColor = Color.Black;
            RadioKelas_10.Location = new Point(16, 223);
            RadioKelas_10.Name = "RadioKelas_10";
            RadioKelas_10.Size = new Size(38, 27);
            RadioKelas_10.TabIndex = 10;
            RadioKelas_10.TabStop = true;
            RadioKelas_10.Text = "1";
            RadioKelas_10.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 263);
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
            label3.Location = new Point(16, 192);
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
            label2.Location = new Point(15, 111);
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
            TextKelasId.BackColor = SystemColors.ActiveBorder;
            TextKelasId.BorderStyle = BorderStyle.FixedSingle;
            TextKelasId.Location = new Point(14, 65);
            TextKelasId.Name = "TextKelasId";
            TextKelasId.ReadOnly = true;
            TextKelasId.Size = new Size(315, 27);
            TextKelasId.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.LightGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(ButtonKelasSave);
            panel5.Controls.Add(ButtonKelasDelete);
            panel5.Controls.Add(ButtonKelasNew);
            panel5.Location = new Point(12, 490);
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
            ButtonKelasSave.TabIndex = 6;
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
            ButtonKelasDelete.TabIndex = 7;
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
            ButtonKelasNew.TabIndex = 8;
            ButtonKelasNew.Text = "New";
            ButtonKelasNew.UseVisualStyleBackColor = false;
            // 
            // panel27
            // 
            panel27.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel27.BackColor = Color.DarkGray;
            panel27.BorderStyle = BorderStyle.FixedSingle;
            panel27.Controls.Add(panel7);
            panel27.Location = new Point(12, 12);
            panel27.Name = "panel27";
            panel27.Size = new Size(838, 88);
            panel27.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.LightGray;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label49);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(830, 80);
            panel7.TabIndex = 8;
            // 
            // label49
            // 
            label49.Anchor = AnchorStyles.None;
            label49.AutoSize = true;
            label49.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label49.Location = new Point(378, 20);
            label49.Name = "label49";
            label49.Size = new Size(78, 38);
            label49.TabIndex = 8;
            label49.Text = "Kelas";
            // 
            // FormKelas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 703);
            Controls.Add(panel27);
            Controls.Add(panel2);
            Name = "FormKelas";
            Text = "Kelas";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridListKelas).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel27.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private TextBox TextKelasName;
        private Label label5;
        private TextBox TextFlagKelas;
        private Panel panel27;
        private Panel panel7;
        private Label label49;
    }
}