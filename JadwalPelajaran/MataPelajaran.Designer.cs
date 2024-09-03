namespace Sistem_Informasi_Sekolah.JadwalPelajaran
{
    partial class MataPelajaran
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
            panel3 = new Panel();
            panel4 = new Panel();
            GridMapel = new DataGridView();
            TextMapelId = new TextBox();
            TextMapelName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ButtonMapelDelete = new Button();
            ButtonMapelSave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridMapel).BeginInit();
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
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(ButtonMapelSave);
            panel3.Controls.Add(ButtonMapelDelete);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TextMapelName);
            panel3.Controls.Add(TextMapelId);
            panel3.Location = new Point(513, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 540);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSlateGray;
            panel4.Controls.Add(GridMapel);
            panel4.Location = new Point(15, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 540);
            panel4.TabIndex = 1;
            // 
            // GridMapel
            // 
            GridMapel.BackgroundColor = SystemColors.ButtonHighlight;
            GridMapel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridMapel.Location = new Point(3, 3);
            GridMapel.Name = "GridMapel";
            GridMapel.RowHeadersWidth = 51;
            GridMapel.RowTemplate.Height = 29;
            GridMapel.Size = new Size(467, 534);
            GridMapel.TabIndex = 0;
            // 
            // TextMapelId
            // 
            TextMapelId.BackColor = SystemColors.ControlLightLight;
            TextMapelId.Location = new Point(23, 94);
            TextMapelId.Name = "TextMapelId";
            TextMapelId.Size = new Size(258, 27);
            TextMapelId.TabIndex = 0;
            // 
            // TextMapelName
            // 
            TextMapelName.BackColor = SystemColors.ControlLightLight;
            TextMapelName.Location = new Point(23, 189);
            TextMapelName.Name = "TextMapelName";
            TextMapelName.Size = new Size(258, 27);
            TextMapelName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 2;
            label1.Text = "Mapel Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(23, 158);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 3;
            label2.Text = "Mapel Name";
            // 
            // ButtonMapelDelete
            // 
            ButtonMapelDelete.BackColor = Color.Crimson;
            ButtonMapelDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMapelDelete.ForeColor = SystemColors.ControlLightLight;
            ButtonMapelDelete.Location = new Point(169, 483);
            ButtonMapelDelete.Name = "ButtonMapelDelete";
            ButtonMapelDelete.Size = new Size(112, 35);
            ButtonMapelDelete.TabIndex = 6;
            ButtonMapelDelete.Text = "Delete";
            ButtonMapelDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonMapelSave
            // 
            ButtonMapelSave.BackColor = Color.ForestGreen;
            ButtonMapelSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMapelSave.ForeColor = SystemColors.ControlLightLight;
            ButtonMapelSave.Location = new Point(23, 483);
            ButtonMapelSave.Name = "ButtonMapelSave";
            ButtonMapelSave.Size = new Size(112, 35);
            ButtonMapelSave.TabIndex = 7;
            ButtonMapelSave.Text = "Save";
            ButtonMapelSave.UseVisualStyleBackColor = false;
            // 
            // MataPelajaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 601);
            Controls.Add(panel1);
            Name = "MataPelajaran";
            Text = "MataPelajaran";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridMapel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private DataGridView GridMapel;
        private Panel panel3;
        private TextBox TextMapelId;
        private Label label1;
        private TextBox TextMapelName;
        private Label label2;
        private Button ButtonMapelDelete;
        private Button ButtonMapelSave;
    }
}