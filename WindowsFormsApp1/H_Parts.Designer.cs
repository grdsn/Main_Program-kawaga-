namespace WindowsFormsApp1
{
    partial class H_Parts
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
            this.info_label = new System.Windows.Forms.Label();
            this.parts_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title_Add = new System.Windows.Forms.TextBox();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.size_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.info_label.Location = new System.Drawing.Point(12, 51);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(98, 19);
            this.info_label.TabIndex = 9;
            this.info_label.Text = "階層(1～6)";
            // 
            // parts_name
            // 
            this.parts_name.AutoSize = true;
            this.parts_name.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.parts_name.Location = new System.Drawing.Point(12, 9);
            this.parts_name.Name = "parts_name";
            this.parts_name.Size = new System.Drawing.Size(67, 21);
            this.parts_name.TabIndex = 8;
            this.parts_name.Text = "見出し";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "見出し";
            // 
            // Title_Add
            // 
            this.Title_Add.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title_Add.Location = new System.Drawing.Point(79, 85);
            this.Title_Add.Name = "Title_Add";
            this.Title_Add.Size = new System.Drawing.Size(255, 28);
            this.Title_Add.TabIndex = 12;
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(232, 9);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 43);
            this.AddConfirm.TabIndex = 13;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // size_box
            // 
            this.size_box.Location = new System.Drawing.Point(125, 51);
            this.size_box.Name = "size_box";
            this.size_box.Size = new System.Drawing.Size(33, 19);
            this.size_box.TabIndex = 14;
            this.size_box.Text = "1";
            this.size_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // H_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 130);
            this.Controls.Add(this.size_box);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.Title_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.parts_name);
            this.Name = "H_Parts";
            this.Text = "H_Parts";
            this.Load += new System.EventHandler(this.H_Parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label parts_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Title_Add;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.TextBox size_box;
    }
}