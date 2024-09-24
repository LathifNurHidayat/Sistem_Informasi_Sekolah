namespace Sistem_Informasi_Sekolah
{
    partial class FormMataPelajaranPopUp
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
            GridListMapelPopUp = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridListMapelPopUp).BeginInit();
            SuspendLayout();
            // 
            // GridListMapelPopUp
            // 
            GridListMapelPopUp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListMapelPopUp.Dock = DockStyle.Fill;
            GridListMapelPopUp.Location = new Point(0, 0);
            GridListMapelPopUp.Name = "GridListMapelPopUp";
            GridListMapelPopUp.RowHeadersWidth = 51;
            GridListMapelPopUp.RowTemplate.Height = 29;
            GridListMapelPopUp.Size = new Size(418, 514);
            GridListMapelPopUp.TabIndex = 0;
            // 
            // FormMataPelajaranPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 514);
            Controls.Add(GridListMapelPopUp);
            Name = "FormMataPelajaranPopUp";
            Text = "List MataPelajaran";
            ((System.ComponentModel.ISupportInitialize)GridListMapelPopUp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridListMapelPopUp;
    }
}