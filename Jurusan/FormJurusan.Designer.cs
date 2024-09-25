namespace Sistem_Informasi_Sekolah
{
    partial class FormJurusan
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
            panel1 = new Panel();
            ButtonJurusanNew = new Button();
            GridListJurusan = new DataGridView();
            panel3 = new Panel();
            TextJurusanId = new TextBox();
            panel6 = new Panel();
            LabelJurusanUpdate = new Label();
            panel5 = new Panel();
            label3 = new Label();
            TextJurusanKode = new TextBox();
            label2 = new Label();
            ButtonJurusanDelete = new Button();
            label1 = new Label();
            ButtonJurusanSave = new Button();
            TextJurusanName = new TextBox();
            panel27 = new Panel();
            panel7 = new Panel();
            label49 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListJurusan).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
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
            panel2.Location = new Point(12, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 594);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(GridListJurusan);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(485, 586);
            panel4.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ButtonJurusanNew);
            panel1.Location = new Point(11, 507);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 64);
            panel1.TabIndex = 8;
            // 
            // ButtonJurusanNew
            // 
            ButtonJurusanNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonJurusanNew.BackColor = Color.RoyalBlue;
            ButtonJurusanNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonJurusanNew.ForeColor = SystemColors.ControlLightLight;
            ButtonJurusanNew.Location = new Point(325, 14);
            ButtonJurusanNew.Name = "ButtonJurusanNew";
            ButtonJurusanNew.Size = new Size(120, 35);
            ButtonJurusanNew.TabIndex = 5;
            ButtonJurusanNew.Text = "New Data";
            ButtonJurusanNew.UseVisualStyleBackColor = false;
            // 
            // GridListJurusan
            // 
            GridListJurusan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListJurusan.BackgroundColor = SystemColors.ButtonHighlight;
            GridListJurusan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListJurusan.Location = new Point(11, 10);
            GridListJurusan.Name = "GridListJurusan";
            GridListJurusan.RowHeadersWidth = 51;
            GridListJurusan.RowTemplate.Height = 29;
            GridListJurusan.Size = new Size(460, 491);
            GridListJurusan.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(TextJurusanId);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(494, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 586);
            panel3.TabIndex = 0;
            // 
            // TextJurusanId
            // 
            TextJurusanId.BackColor = SystemColors.ActiveBorder;
            TextJurusanId.BorderStyle = BorderStyle.FixedSingle;
            TextJurusanId.Location = new Point(26, 128);
            TextJurusanId.Name = "TextJurusanId";
            TextJurusanId.ReadOnly = true;
            TextJurusanId.Size = new Size(288, 27);
            TextJurusanId.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(LabelJurusanUpdate);
            panel6.Location = new Point(11, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(317, 61);
            panel6.TabIndex = 10;
            // 
            // LabelJurusanUpdate
            // 
            LabelJurusanUpdate.AutoSize = true;
            LabelJurusanUpdate.BackColor = Color.LightGray;
            LabelJurusanUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJurusanUpdate.ForeColor = Color.Black;
            LabelJurusanUpdate.Location = new Point(111, 14);
            LabelJurusanUpdate.Name = "LabelJurusanUpdate";
            LabelJurusanUpdate.Size = new Size(89, 28);
            LabelJurusanUpdate.TabIndex = 11;
            LabelJurusanUpdate.Text = "UPDATE";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel5.BackColor = Color.LightGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(TextJurusanKode);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(ButtonJurusanDelete);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(ButtonJurusanSave);
            panel5.Controls.Add(TextJurusanName);
            panel5.Location = new Point(11, 78);
            panel5.Name = "panel5";
            panel5.Size = new Size(317, 494);
            panel5.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 208);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 9;
            label3.Text = "Kode Jurusan";
            // 
            // TextJurusanKode
            // 
            TextJurusanKode.BackColor = SystemColors.ControlLightLight;
            TextJurusanKode.BorderStyle = BorderStyle.FixedSingle;
            TextJurusanKode.Location = new Point(13, 239);
            TextJurusanKode.Name = "TextJurusanKode";
            TextJurusanKode.Size = new Size(149, 27);
            TextJurusanKode.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 113);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 3;
            label2.Text = "Jurusan Name";
            // 
            // ButtonJurusanDelete
            // 
            ButtonJurusanDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonJurusanDelete.BackColor = Color.Crimson;
            ButtonJurusanDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonJurusanDelete.ForeColor = SystemColors.ControlLightLight;
            ButtonJurusanDelete.Location = new Point(182, 443);
            ButtonJurusanDelete.Name = "ButtonJurusanDelete";
            ButtonJurusanDelete.Size = new Size(120, 35);
            ButtonJurusanDelete.TabIndex = 4;
            ButtonJurusanDelete.Text = "Delete";
            ButtonJurusanDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 2;
            label1.Text = "Jurusan Id";
            // 
            // ButtonJurusanSave
            // 
            ButtonJurusanSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonJurusanSave.BackColor = Color.ForestGreen;
            ButtonJurusanSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonJurusanSave.ForeColor = SystemColors.ControlLightLight;
            ButtonJurusanSave.Location = new Point(14, 443);
            ButtonJurusanSave.Name = "ButtonJurusanSave";
            ButtonJurusanSave.Size = new Size(120, 35);
            ButtonJurusanSave.TabIndex = 3;
            ButtonJurusanSave.Text = "Save";
            ButtonJurusanSave.UseVisualStyleBackColor = false;
            // 
            // TextJurusanName
            // 
            TextJurusanName.BackColor = SystemColors.ControlLightLight;
            TextJurusanName.BorderStyle = BorderStyle.FixedSingle;
            TextJurusanName.Location = new Point(14, 144);
            TextJurusanName.Name = "TextJurusanName";
            TextJurusanName.Size = new Size(288, 27);
            TextJurusanName.TabIndex = 1;
            // 
            // panel27
            // 
            panel27.BackColor = Color.DarkGray;
            panel27.BorderStyle = BorderStyle.FixedSingle;
            panel27.Controls.Add(panel7);
            panel27.Location = new Point(12, 12);
            panel27.Name = "panel27";
            panel27.Size = new Size(838, 88);
            panel27.TabIndex = 8;
            // 
            // panel7
            // 
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
            label49.Location = new Point(368, 20);
            label49.Name = "label49";
            label49.Size = new Size(102, 38);
            label49.TabIndex = 8;
            label49.Text = "Jurusan";
            // 
            // FormJurusan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(862, 714);
            Controls.Add(panel27);
            Controls.Add(panel2);
            Name = "FormJurusan";
            Text = "Jurusan";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridListJurusan).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel27.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel4;
        private DataGridView GridListJurusan;
        private Panel panel3;
        private Button ButtonJurusanSave;
        private Button ButtonJurusanDelete;
        private Label label2;
        private Label label1;
        private TextBox TextJurusanName;
        private TextBox TextJurusanId;
        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
        private Button ButtonJurusanNew;
        private Label LabelJurusanUpdate;
        private Label label3;
        private TextBox TextJurusanKode;
        private Panel panel27;
        private Panel panel7;
        private Label label49;
    }
}