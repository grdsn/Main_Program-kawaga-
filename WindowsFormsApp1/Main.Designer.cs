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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.Result_Btn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.PartsBox = new System.Windows.Forms.GroupBox();
            this.partsList = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.ResetBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLBtn = new System.Windows.Forms.Button();
            this.HTMLBOX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PartsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result_Btn
            // 
            this.Result_Btn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Result_Btn.Location = new System.Drawing.Point(963, 28);
            this.Result_Btn.Name = "Result_Btn";
            this.Result_Btn.Size = new System.Drawing.Size(90, 34);
            this.Result_Btn.TabIndex = 0;
            this.Result_Btn.Text = "更新";
            this.Result_Btn.UseVisualStyleBackColor = true;
            this.Result_Btn.Click += new System.EventHandler(this.Result_Btn_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(64, 456);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(198, 19);
            this.Title.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "タイトル";
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Reset_Btn.Location = new System.Drawing.Point(1059, 27);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(90, 34);
            this.Reset_Btn.TabIndex = 8;
            this.Reset_Btn.Text = "戻る";
            this.Reset_Btn.UseVisualStyleBackColor = true;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // PartsBox
            // 
            this.PartsBox.Controls.Add(this.partsList);
            this.PartsBox.Location = new System.Drawing.Point(12, 67);
            this.PartsBox.Name = "PartsBox";
            this.PartsBox.Size = new System.Drawing.Size(270, 243);
            this.PartsBox.TabIndex = 10;
            this.PartsBox.TabStop = false;
            this.PartsBox.Text = "素材";
            // 
            // partsList
            // 
            this.partsList.HideSelection = false;
            this.partsList.LargeImageList = this.imageList;
            this.partsList.Location = new System.Drawing.Point(6, 18);
            this.partsList.Name = "partsList";
            this.partsList.Size = new System.Drawing.Size(255, 219);
            this.partsList.TabIndex = 0;
            this.partsList.UseCompatibleStateImageBehavior = false;
            this.partsList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "鉛筆を持つ手のアイコン.png");
            this.imageList.Images.SetKeyName(1, "アンケート用紙のアイコン素材.png");
            this.imageList.Images.SetKeyName(2, "指差しアイコンのフリー素材.png");
            this.imageList.Images.SetKeyName(3, "WEBサイトアイコン.png");
            this.imageList.Images.SetKeyName(4, "ペンキ塗りなどのハケのアイコン素材2.png");
            this.imageList.Images.SetKeyName(5, "メニューの無料アイコン6.png");
            this.imageList.Images.SetKeyName(6, "メニューの無料アイコン9.png");
            this.imageList.Images.SetKeyName(7, "イメージ画像のアイコン素材 2.png");
            this.imageList.Images.SetKeyName(8, "読書のアイコン.png");
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResetBtn.Location = new System.Drawing.Point(204, 27);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(91, 34);
            this.ResetBtn.TabIndex = 11;
            this.ResetBtn.Text = "新規";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(301, 68);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(964, 633);
            this.webBrowser1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.開くToolStripMenuItem.Text = "開く";
            // 
            // HTMLBtn
            // 
            this.HTMLBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HTMLBtn.Location = new System.Drawing.Point(748, 27);
            this.HTMLBtn.Name = "HTMLBtn";
            this.HTMLBtn.Size = new System.Drawing.Size(209, 34);
            this.HTMLBtn.TabIndex = 14;
            this.HTMLBtn.Text = "ソースコード表示";
            this.HTMLBtn.UseVisualStyleBackColor = true;
            this.HTMLBtn.Click += new System.EventHandler(this.HTMLBtn_Click);
            // 
            // HTMLBOX
            // 
            this.HTMLBOX.Location = new System.Drawing.Point(301, 67);
            this.HTMLBOX.Multiline = true;
            this.HTMLBOX.Name = "HTMLBOX";
            this.HTMLBOX.ReadOnly = true;
            this.HTMLBOX.Size = new System.Drawing.Size(964, 633);
            this.HTMLBOX.TabIndex = 15;
            this.HTMLBOX.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 123);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "カラー";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(609, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "上書き保存";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(398, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "名前をつけて保存";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(301, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "開く";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 730);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HTMLBOX);
            this.Controls.Add(this.HTMLBtn);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.PartsBox);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Result_Btn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "メインページ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PartsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Result_Btn;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.GroupBox PartsBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.Button HTMLBtn;
        private System.Windows.Forms.TextBox HTMLBOX;
        private System.Windows.Forms.ListView partsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

