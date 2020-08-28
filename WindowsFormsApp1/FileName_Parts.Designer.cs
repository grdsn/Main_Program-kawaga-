namespace WindowsFormsApp1
{
    partial class FileName_Parts
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
            this.AddConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(327, 62);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 21);
            this.AddConfirm.TabIndex = 13;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "名前：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextAdd
            // 
            this.TextAdd.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextAdd.Location = new System.Drawing.Point(82, 28);
            this.TextAdd.Name = "TextAdd";
            this.TextAdd.Size = new System.Drawing.Size(290, 28);
            this.TextAdd.TabIndex = 11;
            this.TextAdd.TextChanged += new System.EventHandler(this.TextAdd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(378, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = ".html";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(13, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "・ファイル名を指定してください";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FileName_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 94);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileName_Parts";
            this.Text = "ファイル名を指定してください";
            this.Load += new System.EventHandler(this.FileName_Parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}