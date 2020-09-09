namespace WindowsFormsApp1
{
    partial class Text_parts
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
            this.parts_name = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.TextAdd = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parts_name
            // 
            this.parts_name.AutoSize = true;
            this.parts_name.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.parts_name.Location = new System.Drawing.Point(12, 9);
            this.parts_name.Name = "parts_name";
            this.parts_name.Size = new System.Drawing.Size(80, 21);
            this.parts_name.TabIndex = 0;
            this.parts_name.Text = "パーツ名";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(16, 40);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(24, 12);
            this.info_label.TabIndex = 2;
            this.info_label.Text = "info";
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(361, 6);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 43);
            this.AddConfirm.TabIndex = 3;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // TextAdd
            // 
            this.TextAdd.Location = new System.Drawing.Point(12, 55);
            this.TextAdd.Multiline = true;
            this.TextAdd.Name = "TextAdd";
            this.TextAdd.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextAdd.Size = new System.Drawing.Size(450, 179);
            this.TextAdd.TabIndex = 6;
            this.TextAdd.TextChanged += new System.EventHandler(this.TextAdd_TextChanged);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(12, 240);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(101, 22);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "キャンセル";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Text_parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 273);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.TextAdd);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.parts_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Text_parts";
            this.Text = "Create_parts";
            this.Load += new System.EventHandler(this.Create_parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label parts_name;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.TextBox TextAdd;
        private System.Windows.Forms.Button cancel_btn;
    }
}