namespace WindowsFormsApp1
{
    partial class OL_Parts
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
            this.info_label = new System.Windows.Forms.Label();
            this.parts_name = new System.Windows.Forms.Label();
            this.OL_box = new System.Windows.Forms.ListBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Add_Text = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(250, 9);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 43);
            this.AddConfirm.TabIndex = 4;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(12, 40);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(156, 12);
            this.info_label.TabIndex = 7;
            this.info_label.Text = "挿入する項目を入力してください";
            // 
            // parts_name
            // 
            this.parts_name.AutoSize = true;
            this.parts_name.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.parts_name.Location = new System.Drawing.Point(8, 9);
            this.parts_name.Name = "parts_name";
            this.parts_name.Size = new System.Drawing.Size(145, 21);
            this.parts_name.TabIndex = 6;
            this.parts_name.Text = "順序のあるリスト";
            // 
            // OL_box
            // 
            this.OL_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OL_box.FormattingEnabled = true;
            this.OL_box.ItemHeight = 12;
            this.OL_box.Location = new System.Drawing.Point(14, 61);
            this.OL_box.Name = "OL_box";
            this.OL_box.Size = new System.Drawing.Size(337, 160);
            this.OL_box.TabIndex = 8;
            this.OL_box.SelectedIndexChanged += new System.EventHandler(this.OL_box_SelectedIndexChanged);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(274, 236);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 9;
            this.Add_button.Text = "リスト追加";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Add_Text
            // 
            this.Add_Text.Location = new System.Drawing.Point(14, 238);
            this.Add_Text.Name = "Add_Text";
            this.Add_Text.Size = new System.Drawing.Size(236, 19);
            this.Add_Text.TabIndex = 10;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(12, 263);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "キャンセル";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // OL_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 295);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.Add_Text);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.OL_box);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.parts_name);
            this.Controls.Add(this.AddConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OL_Parts";
            this.Text = "OL_Parts";
            this.Load += new System.EventHandler(this.OL_Parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label parts_name;
        private System.Windows.Forms.ListBox OL_box;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox Add_Text;
        private System.Windows.Forms.Button cancel_btn;
    }
}