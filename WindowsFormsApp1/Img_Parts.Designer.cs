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
            this.File_Open = new System.Windows.Forms.Button();
            this.show_image_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.show_image_box)).BeginInit();
            this.SuspendLayout();
            // 
            // File_Open
            // 
            this.File_Open.Location = new System.Drawing.Point(485, 338);
            this.File_Open.Name = "File_Open";
            this.File_Open.Size = new System.Drawing.Size(75, 23);
            this.File_Open.TabIndex = 0;
            this.File_Open.Text = "ファイルを開く";
            this.File_Open.UseVisualStyleBackColor = true;
            this.File_Open.Click += new System.EventHandler(this.File_Open_Click);
            // 
            // show_image_box
            // 
            this.show_image_box.Location = new System.Drawing.Point(12, 12);
            this.show_image_box.Name = "show_image_box";
            this.show_image_box.Size = new System.Drawing.Size(445, 349);
            this.show_image_box.TabIndex = 1;
            this.show_image_box.TabStop = false;
            // 
            // Img_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 373);
            this.Controls.Add(this.show_image_box);
            this.Controls.Add(this.File_Open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Img_Parts";
            this.Text = "Img_Parts";
            this.Load += new System.EventHandler(this.Img_Parts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_image_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button File_Open;
        private System.Windows.Forms.PictureBox show_image_box;
    }
}