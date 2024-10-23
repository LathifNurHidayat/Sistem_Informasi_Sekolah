namespace Sistem_Informasi_Sekolah
{
    partial class FormDataSiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataSiswa));
            panel1 = new Panel();
            ButtonAdd = new Button();
            CekLIstBoxSiswa = new CheckedListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(ButtonAdd);
            panel1.Controls.Add(CekLIstBoxSiswa);
            panel1.Location = new Point(11, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 594);
            panel1.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonAdd.BackColor = Color.DarkGray;
            ButtonAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAdd.ForeColor = SystemColors.ControlLightLight;
            ButtonAdd.Location = new Point(393, 535);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(120, 35);
            ButtonAdd.TabIndex = 6;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = false;
            // 
            // CekLIstBoxSiswa
            // 
            CekLIstBoxSiswa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CekLIstBoxSiswa.FormattingEnabled = true;
            CekLIstBoxSiswa.Location = new Point(3, 3);
            CekLIstBoxSiswa.Name = "CekLIstBoxSiswa";
            CekLIstBoxSiswa.Size = new Size(527, 510);
            CekLIstBoxSiswa.TabIndex = 1;
            // 
            // FormDataSiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 614);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDataSiswa";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckedListBox CekLIstBoxSiswa;
        private Button ButtonAdd;
    }
}