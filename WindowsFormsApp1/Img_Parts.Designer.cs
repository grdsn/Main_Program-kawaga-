namespace WindowsFormsApp1
{
    partial class Img_Parts
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcb_preview = new System.Windows.Forms.PictureBox();
            this.AddConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_preview
            // 
            this.pcb_preview.Location = new System.Drawing.Point(12, 12);
            this.pcb_preview.Name = "pcb_preview";
            this.pcb_preview.Size = new System.Drawing.Size(382, 323);
            this.pcb_preview.TabIndex = 1;
            this.pcb_preview.TabStop = false;
            // 
            // AddConfirm
            // 
            this.AddConfirm.Location = new System.Drawing.Point(293, 341);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(101, 43);
            this.AddConfirm.TabIndex = 9;
            this.AddConfirm.Text = "追加";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // Img_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 393);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.pcb_preview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Img_Parts";
            this.Text = "Img_Parts";
            this.Load += new System.EventHandler(this.Img_Parts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcb_preview;
        private System.Windows.Forms.Button AddConfirm;
    }
}