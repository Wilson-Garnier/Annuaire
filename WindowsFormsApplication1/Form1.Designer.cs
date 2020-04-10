namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(613, 399);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.TextBox textboxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox textboxPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox textboxTel;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox textboxAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dvgList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

