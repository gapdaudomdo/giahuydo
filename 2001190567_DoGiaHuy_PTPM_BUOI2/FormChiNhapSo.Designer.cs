namespace _2001190567_DoGiaHuy_PTPM_BUOI2
{
    partial class FormChiNhapSo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtChiNhapSo1 = new Controls.txtChiNhapSo();
            this.txtChiNhapSo2 = new Controls.txtChiNhapSo();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtChiNhapSo1
            // 
            this.txtChiNhapSo1.Location = new System.Drawing.Point(115, 195);
            this.txtChiNhapSo1.Name = "txtChiNhapSo1";
            this.txtChiNhapSo1.Size = new System.Drawing.Size(100, 20);
            this.txtChiNhapSo1.TabIndex = 1;
            // 
            // txtChiNhapSo2
            // 
            this.txtChiNhapSo2.Location = new System.Drawing.Point(115, 222);
            this.txtChiNhapSo2.Name = "txtChiNhapSo2";
            this.txtChiNhapSo2.Size = new System.Drawing.Size(100, 20);
            this.txtChiNhapSo2.TabIndex = 2;
            // 
            // FormChiNhapSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 317);
            this.Controls.Add(this.txtChiNhapSo2);
            this.Controls.Add(this.txtChiNhapSo1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormChiNhapSo";
            this.Text = "FormChiNhapSo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private Controls.txtChiNhapSo txtChiNhapSo1;
        private Controls.txtChiNhapSo txtChiNhapSo2;
    }
}