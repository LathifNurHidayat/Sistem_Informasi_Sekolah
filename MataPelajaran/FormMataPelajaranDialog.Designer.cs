namespace Sistem_Informasi_Sekolah
{
    partial class FormMataPelajaranDialog
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
            GridListMapelDialog = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridListMapelDialog).BeginInit();
            SuspendLayout();
            // 
            // GridListMapelDialog
            // 
            GridListMapelDialog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListMapelDialog.Dock = DockStyle.Fill;
            GridListMapelDialog.Location = new Point(0, 0);
            GridListMapelDialog.Margin = new Padding(4, 4, 4, 4);
            GridListMapelDialog.Name = "GridListMapelDialog";
            GridListMapelDialog.RowHeadersWidth = 51;
            GridListMapelDialog.RowTemplate.Height = 29;
            GridListMapelDialog.Size = new Size(528, 644);
            GridListMapelDialog.TabIndex = 0;
            // 
            // FormMataPelajaranDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 644);
            Controls.Add(GridListMapelDialog);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormMataPelajaranDialog";
            Text = "List MataPelajaran";
            ((System.ComponentModel.ISupportInitialize)GridListMapelDialog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridListMapelDialog;
    }
}