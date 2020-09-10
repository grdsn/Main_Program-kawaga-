namespace WindowsFormsApp1
{
    partial class EM_Parts
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
            this.TextAdd = new System.Windows.Forms.TextBox();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            this.parts_name = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAdd
            // 
            this.TextAdd.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextAdd.Location = new System.Drawing.Point(12, 57);
            this.TextAdd.Multiline = true;
            this.TextAdd.Name = "TextAdd";
            this.TextAdd.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextAdd.Size = new System.Drawing.Size(472, 179);
            this.TextAdd.TabIndex = 10;
            this.TextAdd.TextChanged += new System.EventHandler(this.TextAdd_TextChanged);
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(386, 4);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 43);
            this.AddConfirm.TabIndex = 9;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(26, 42);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(80, 12);
            this.info_label.TabIndex = 8;
            this.info_label.Text = "入力してください";
            // 
            // parts_name
            // 
            this.parts_name.AutoSize = true;
            this.parts_name.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.parts_name.Location = new System.Drawing.Point(22, 11);
            this.parts_name.Name = "parts_name";
            this.parts_name.Size = new System.Drawing.Size(133, 21);
            this.parts_name.TabIndex = 7;
            this.parts_name.Text = "テキストの強調";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(12, 242);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(101, 25);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "キャンセル";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // EM_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 273);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.TextAdd);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.parts_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EM_Parts";
            this.Text = "EM_Parts";
            this.Load += new System.EventHandler(this.EM_Parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextAdd;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label parts_name;
        private System.Windows.Forms.Button cancel_btn;
    }
}