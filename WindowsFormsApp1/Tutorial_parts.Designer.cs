namespace WindowsFormsApp1
{
    partial class Tutorial_Parts
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
            this.btnNext = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TutoStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnI01 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnI02 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnI03 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnI04 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnI05 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnI06 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnI07 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(457, 152);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 46);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "次へ";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTitle.Location = new System.Drawing.Point(12, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(182, 31);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "サンプルタイトル";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelText.Location = new System.Drawing.Point(13, 64);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(88, 28);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "サンプル";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TutoStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TutoStripMenu
            // 
            this.TutoStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnI01,
            this.mnI02,
            this.mnI03,
            this.mnI04,
            this.mnI05,
            this.mnI06,
            this.mnI07});
            this.TutoStripMenu.Name = "TutoStripMenu";
            this.TutoStripMenu.Size = new System.Drawing.Size(43, 20);
            this.TutoStripMenu.Text = "一覧";
            // 
            // mnI01
            // 
            this.mnI01.Name = "mnI01";
            this.mnI01.Size = new System.Drawing.Size(160, 22);
            this.mnI01.Text = "1.新規作成";
            this.mnI01.Click += new System.EventHandler(this.mnI01_Click_1);
            // 
            // mnI02
            // 
            this.mnI02.Name = "mnI02";
            this.mnI02.Size = new System.Drawing.Size(160, 22);
            this.mnI02.Text = "2.タイトル作成";
            this.mnI02.Click += new System.EventHandler(this.mnI02_Click);
            // 
            // mnI03
            // 
            this.mnI03.Name = "mnI03";
            this.mnI03.Size = new System.Drawing.Size(160, 22);
            this.mnI03.Text = "3.見出し作成";
            this.mnI03.Click += new System.EventHandler(this.mnI03_Click);
            // 
            // mnI04
            // 
            this.mnI04.Name = "mnI04";
            this.mnI04.Size = new System.Drawing.Size(160, 22);
            this.mnI04.Text = "4.本文作成";
            this.mnI04.Click += new System.EventHandler(this.mnI04_Click);
            // 
            // mnI05
            // 
            this.mnI05.Name = "mnI05";
            this.mnI05.Size = new System.Drawing.Size(160, 22);
            this.mnI05.Text = "5.上書き保存";
            this.mnI05.Click += new System.EventHandler(this.mnI05_Click);
            // 
            // mnI06
            // 
            this.mnI06.Name = "mnI06";
            this.mnI06.Size = new System.Drawing.Size(160, 22);
            this.mnI06.Text = "6.タグツリーの編集";
            this.mnI06.Click += new System.EventHandler(this.mnI06_Click);
            // 
            // mnI07
            // 
            this.mnI07.Name = "mnI07";
            this.mnI07.Size = new System.Drawing.Size(160, 22);
            this.mnI07.Text = "7.終了";
            this.mnI07.Click += new System.EventHandler(this.mnI07_Click);
            // 
            // lblBar
            // 
            this.lblBar.AutoSize = true;
            this.lblBar.Font = new System.Drawing.Font("メイリオ", 12F);
            this.lblBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBar.Location = new System.Drawing.Point(114, 204);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(37, 24);
            this.lblBar.TabIndex = 13;
            this.lblBar.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "進行状況:";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar1.Location = new System.Drawing.Point(157, 204);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(388, 24);
            this.progressBar1.TabIndex = 11;
            // 
            // Tutorial_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 237);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tutorial_Parts";
            this.Text = "Tutorial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tutorial_Parts_FormClosing);
            this.Load += new System.EventHandler(this.Tutorial_Parts_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TutoStripMenu;
        private System.Windows.Forms.ToolStripMenuItem mnI01;
        private System.Windows.Forms.ToolStripMenuItem mnI02;
        private System.Windows.Forms.ToolStripMenuItem mnI03;
        private System.Windows.Forms.ToolStripMenuItem mnI04;
        private System.Windows.Forms.ToolStripMenuItem mnI05;
        private System.Windows.Forms.ToolStripMenuItem mnI06;
        private System.Windows.Forms.ToolStripMenuItem mnI07;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}