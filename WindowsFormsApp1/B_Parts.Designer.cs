namespace WindowsFormsApp1
{
    partial class B_Parts
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
            this.parts_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(390, 12);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 43);
            this.AddConfirm.TabIndex = 10;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "内容：";
            // 
            // TextAdd
            // 
            this.TextAdd.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextAdd.Location = new System.Drawing.Point(81, 72);
            this.TextAdd.Name = "TextAdd";
            this.TextAdd.Size = new System.Drawing.Size(410, 28);
            this.TextAdd.TabIndex = 8;
            // 
            // parts_name
            // 
            this.parts_name.AutoSize = true;
            this.parts_name.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.parts_name.Location = new System.Drawing.Point(12, 19);
            this.parts_name.Name = "parts_name";
            this.parts_name.Size = new System.Drawing.Size(111, 21);
            this.parts_name.TabIndex = 7;
            this.parts_name.Text = "太字の追加";
            // 
            // B_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 112);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextAdd);
            this.Controls.Add(this.parts_name);
            this.Name = "B_Parts";
            this.Text = "B_Parts";
            this.Load += new System.EventHandler(this.B_Parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextAdd;
        private System.Windows.Forms.Label parts_name;
    }
}