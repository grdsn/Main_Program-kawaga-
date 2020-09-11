namespace WindowsFormsApp1
{
    partial class Script_Parts
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
            this.SuspendLayout();
            // 
            // TextAdd
            // 
            this.TextAdd.Location = new System.Drawing.Point(12, 55);
            this.TextAdd.Multiline = true;
            this.TextAdd.Name = "TextAdd";
            this.TextAdd.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextAdd.Size = new System.Drawing.Size(472, 179);
            this.TextAdd.TabIndex = 10;
            this.TextAdd.UseWaitCursor = true;
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(371, 9);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 43);
            this.AddConfirm.TabIndex = 9;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(26, 40);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(139, 12);
            this.info_label.TabIndex = 8;
            this.info_label.Text = "javascriptを入力してください";
            // 
            // parts_name
            // 
            this.parts_name.AutoSize = true;
            this.parts_name.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.parts_name.Location = new System.Drawing.Point(22, 9);
            this.parts_name.Name = "parts_name";
            this.parts_name.Size = new System.Drawing.Size(126, 21);
            this.parts_name.TabIndex = 7;
            this.parts_name.Text = "スクリプト追加";
            // 
            // Script_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 248);
            this.Controls.Add(this.TextAdd);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.parts_name);
            this.Name = "Script_Parts";
            this.Text = "Script_Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextAdd;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label parts_name;
    }
}