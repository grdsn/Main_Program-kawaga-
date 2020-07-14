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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Reset_Btn = new System.Windows.Forms.Button();
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
            this.parts_list.Location = new System.Drawing.Point(12, 12);
            this.parts_list.Name = "parts_list";
            this.parts_list.Size = new System.Drawing.Size(228, 568);
            this.parts_list.TabIndex = 6;
            this.parts_list.SelectedIndexChanged += new System.EventHandler(this.parts_list_SelectedIndexChanged);
            this.parts_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.parts_list_MouseDoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(260, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(943, 651);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
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
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 676);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.parts_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Result_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main";
            this.Text = "メインページ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Result_Btn;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox parts_list;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Reset_Btn;
    }
}

