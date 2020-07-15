namespace WindowsFormsApp1
{
    partial class main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Result_Btn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parts_list = new System.Windows.Forms.ListBox();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.HTMLBOX = new System.Windows.Forms.TextBox();
            this.PartsBox = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PartsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result_Btn
            // 
            this.Result_Btn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Result_Btn.Location = new System.Drawing.Point(12, 591);
            this.Result_Btn.Name = "Result_Btn";
            this.Result_Btn.Size = new System.Drawing.Size(111, 47);
            this.Result_Btn.TabIndex = 0;
            this.Result_Btn.Text = "更新";
            this.Result_Btn.UseVisualStyleBackColor = true;
            this.Result_Btn.Click += new System.EventHandler(this.Result_Btn_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(58, 644);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(182, 19);
            this.Title.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 647);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "タイトル";
            // 
            // parts_list
            // 
            this.parts_list.FormattingEnabled = true;
            this.parts_list.ItemHeight = 12;
            this.parts_list.Items.AddRange(new object[] {
            "見出し",
            "テキスト",
            "テキストの強調",
            "ハイパーテキスト",
            "順序のあるリスト",
            "順序のないリスト",
            "画像",
            "スクリプト",
            "太字"});
            this.parts_list.Location = new System.Drawing.Point(6, 18);
            this.parts_list.Name = "parts_list";
            this.parts_list.Size = new System.Drawing.Size(228, 124);
            this.parts_list.TabIndex = 6;
            this.parts_list.SelectedIndexChanged += new System.EventHandler(this.parts_list_SelectedIndexChanged);
            this.parts_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.parts_list_MouseDoubleClick);
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Reset_Btn.Location = new System.Drawing.Point(129, 591);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(111, 47);
            this.Reset_Btn.TabIndex = 8;
            this.Reset_Btn.Text = "戻る";
            this.Reset_Btn.UseVisualStyleBackColor = true;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(295, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 593);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "プレビュー";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(624, 533);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.HTMLBOX);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HTML";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // HTMLBOX
            // 
            this.HTMLBOX.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HTMLBOX.Location = new System.Drawing.Point(-10, 0);
            this.HTMLBOX.Multiline = true;
            this.HTMLBOX.Name = "HTMLBOX";
            this.HTMLBOX.ReadOnly = true;
            this.HTMLBOX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HTMLBOX.Size = new System.Drawing.Size(722, 567);
            this.HTMLBOX.TabIndex = 0;
            // 
            // PartsBox
            // 
            this.PartsBox.Controls.Add(this.parts_list);
            this.PartsBox.Location = new System.Drawing.Point(12, 31);
            this.PartsBox.Name = "PartsBox";
            this.PartsBox.Size = new System.Drawing.Size(268, 165);
            this.PartsBox.TabIndex = 10;
            this.PartsBox.TabStop = false;
            this.PartsBox.Text = "素材";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 676);
            this.Controls.Add(this.PartsBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Result_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main";
            this.Text = "メインページ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.PartsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Result_Btn;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox parts_list;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox HTMLBOX;
        private System.Windows.Forms.GroupBox PartsBox;
    }
}

