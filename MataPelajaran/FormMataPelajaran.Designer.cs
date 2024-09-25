namespace Sistem_Informasi_Sekolah
{
    partial class FormMataPelajaran
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
            ButtonMapelNew = new Button();
            GridListMapel = new DataGridView();
            panel3 = new Panel();
            TextMapelId = new TextBox();
            panel6 = new Panel();
            LabelMapelUpdate = new Label();
            panel5 = new Panel();
            label2 = new Label();
            ButtonMapelDelete = new Button();
            label1 = new Label();
            ButtonMapelSave = new Button();
            TextMapelName = new TextBox();
            panel27 = new Panel();
            panel7 = new Panel();
            label49 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListMapel).BeginInit();
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
            panel2.Location = new Point(12, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 558);
            panel2.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(GridListMapel);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(485, 550);
            panel4.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ButtonMapelNew);
            panel1.Location = new Point(11, 471);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 64);
            panel1.TabIndex = 8;
            // 
            // ButtonMapelNew
            // 
            ButtonMapelNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonMapelNew.BackColor = Color.RoyalBlue;
            ButtonMapelNew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMapelNew.ForeColor = SystemColors.ControlLightLight;
            ButtonMapelNew.Location = new Point(325, 14);
            ButtonMapelNew.Name = "ButtonMapelNew";
            ButtonMapelNew.Size = new Size(120, 35);
            ButtonMapelNew.TabIndex = 4;
            ButtonMapelNew.Text = "New Data";
            ButtonMapelNew.UseVisualStyleBackColor = false;
            // 
            // GridListMapel
            // 
            GridListMapel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListMapel.BackgroundColor = SystemColors.ButtonHighlight;
            GridListMapel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListMapel.Location = new Point(11, 10);
            GridListMapel.Name = "GridListMapel";
            GridListMapel.RowHeadersWidth = 51;
            GridListMapel.RowTemplate.Height = 29;
            GridListMapel.Size = new Size(460, 455);
            GridListMapel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(TextMapelId);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(494, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 550);
            panel3.TabIndex = 0;
            // 
            // TextMapelId
            // 
            TextMapelId.BackColor = SystemColors.ActiveBorder;
            TextMapelId.BorderStyle = BorderStyle.FixedSingle;
            TextMapelId.Location = new Point(26, 128);
            TextMapelId.Name = "TextMapelId";
            TextMapelId.ReadOnly = true;
            TextMapelId.Size = new Size(288, 27);
            TextMapelId.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(LabelMapelUpdate);
            panel6.Location = new Point(11, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(317, 61);
            panel6.TabIndex = 10;
            // 
            // LabelMapelUpdate
            // 
            LabelMapelUpdate.AutoSize = true;
            LabelMapelUpdate.BackColor = Color.LightGray;
            LabelMapelUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelMapelUpdate.ForeColor = Color.Black;
            LabelMapelUpdate.Location = new Point(111, 14);
            LabelMapelUpdate.Name = "LabelMapelUpdate";
            LabelMapelUpdate.Size = new Size(89, 28);
            LabelMapelUpdate.TabIndex = 11;
            LabelMapelUpdate.Text = "UPDATE";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.LightGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(ButtonMapelDelete);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(ButtonMapelSave);
            panel5.Controls.Add(TextMapelName);
            panel5.Location = new Point(11, 78);
            panel5.Name = "panel5";
            panel5.Size = new Size(317, 458);
            panel5.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 113);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 3;
            label2.Text = "Mapel Name";
            // 
            // ButtonMapelDelete
            // 
            ButtonMapelDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonMapelDelete.BackColor = Color.Crimson;
            ButtonMapelDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMapelDelete.ForeColor = SystemColors.ControlLightLight;
            ButtonMapelDelete.Location = new Point(182, 407);
            ButtonMapelDelete.Name = "ButtonMapelDelete";
            ButtonMapelDelete.Size = new Size(120, 35);
            ButtonMapelDelete.TabIndex = 3;
            ButtonMapelDelete.Text = "Delete";
            ButtonMapelDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 2;
            label1.Text = "Mapel Id";
            // 
            // ButtonMapelSave
            // 
            ButtonMapelSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonMapelSave.BackColor = Color.ForestGreen;
            ButtonMapelSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMapelSave.ForeColor = SystemColors.ControlLightLight;
            ButtonMapelSave.Location = new Point(14, 407);
            ButtonMapelSave.Name = "ButtonMapelSave";
            ButtonMapelSave.Size = new Size(120, 35);
            ButtonMapelSave.TabIndex = 2;
            ButtonMapelSave.Text = "Save";
            ButtonMapelSave.UseVisualStyleBackColor = false;
            // 
            // TextMapelName
            // 
            TextMapelName.BackColor = SystemColors.ControlLightLight;
            TextMapelName.BorderStyle = BorderStyle.FixedSingle;
            TextMapelName.Location = new Point(14, 144);
            TextMapelName.Name = "TextMapelName";
            TextMapelName.Size = new Size(288, 27);
            TextMapelName.TabIndex = 1;
            // 
            // panel27
            // 
            panel27.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel27.BackColor = Color.DarkGray;
            panel27.BorderStyle = BorderStyle.FixedSingle;
            panel27.Controls.Add(panel7);
            panel27.Location = new Point(12, 7);
            panel27.Name = "panel27";
            panel27.Size = new Size(838, 88);
            panel27.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            label49.Location = new Point(319, 21);
            label49.Name = "label49";
            label49.Size = new Size(186, 38);
            label49.TabIndex = 8;
            label49.Text = "Mata Pelajaran";
            // 
            // FormMataPelajaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 671);
            Controls.Add(panel27);
            Controls.Add(panel2);
            Name = "FormMataPelajaran";
            Text = "MataPelajaran";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridListMapel).EndInit();
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
        private Panel panel1;
        private Button ButtonMapelNew;
        private DataGridView GridListMapel;
        private Panel panel3;
        private TextBox TextMapelId;
        private Panel panel6;
        private Label LabelMapelUpdate;
        private Panel panel5;
        private Label label2;
        private Button ButtonMapelDelete;
        private Label label1;
        private Button ButtonMapelSave;
        private TextBox TextMapelName;
        private Panel panel27;
        private Panel panel7;
        private Label label49;
    }
}