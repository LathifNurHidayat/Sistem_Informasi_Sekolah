﻿namespace Sistem_Informasi_Sekolah
{
    partial class FormKelasDialog
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
            GridListKelasDialog = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridListKelasDialog).BeginInit();
            SuspendLayout();
            // 
            // GridListKelasDialog
            // 
            GridListKelasDialog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListKelasDialog.Dock = DockStyle.Fill;
            GridListKelasDialog.Location = new Point(0, 0);
            GridListKelasDialog.Margin = new Padding(4);
            GridListKelasDialog.Name = "GridListKelasDialog";
            GridListKelasDialog.RowHeadersWidth = 51;
            GridListKelasDialog.RowTemplate.Height = 29;
            GridListKelasDialog.Size = new Size(528, 644);
            GridListKelasDialog.TabIndex = 1;
            // 
            // FormKelasDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 644);
            Controls.Add(GridListKelasDialog);
            Name = "FormKelasDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKelasDialog";
            ((System.ComponentModel.ISupportInitialize)GridListKelasDialog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridListKelasDialog;
    }
}