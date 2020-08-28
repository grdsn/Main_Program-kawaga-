namespace WindowsFormsApp1
{
    partial class Hyper_Parts
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
            this.TextAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title_Add = new System.Windows.Forms.TextBox();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parts_name
            // 
            this.parts_name.AutoSize = true;
            this.parts_name.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.parts_name.Location = new System.Drawing.Point(12, 9);
            this.parts_name.Name = "parts_name";
            this.parts_name.Size = new System.Drawing.Size(179, 21);
            this.parts_name.TabIndex = 1;
            this.parts_name.Text = "ハイパーリンクの追加";
            // 
            // TextAdd
            // 
            this.TextAdd.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextAdd.Location = new System.Drawing.Point(95, 49);
            this.TextAdd.Name = "TextAdd";
            this.TextAdd.Size = new System.Drawing.Size(410, 28);
            this.TextAdd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "タイトル：";
            // 
            // Title_Add
            // 
            this.Title_Add.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title_Add.Location = new System.Drawing.Point(95, 86);
            this.Title_Add.Name = "Title_Add";
            this.Title_Add.Size = new System.Drawing.Size(410, 28);
            this.Title_Add.TabIndex = 4;
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(404, 2);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 43);
            this.AddConfirm.TabIndex = 6;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click_1);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(10, 120);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(101, 21);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "キャンセル";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Hyper_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 153);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextAdd);
            this.Controls.Add(this.parts_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hyper_Parts";
            this.Text = "Hyper_Parts";
            this.Load += new System.EventHandler(this.Hyper_Parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label parts_name;
        private System.Windows.Forms.TextBox TextAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Title_Add;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.Button cancel_btn;
    }
}