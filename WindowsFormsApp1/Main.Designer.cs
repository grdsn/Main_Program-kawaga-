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
            System.Windows.Forms.Button oepn_Btn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PartsBox = new System.Windows.Forms.GroupBox();
            this.partsList = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackText = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.group_tag = new System.Windows.Forms.GroupBox();
            this.groupBody = new System.Windows.Forms.GroupBox();
            this.button_body2 = new System.Windows.Forms.Button();
            this.property_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupHead = new System.Windows.Forms.GroupBox();
            this.button_head2 = new System.Windows.Forms.Button();
            this.button_title = new System.Windows.Forms.Button();
            this.button_swap = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_head1 = new System.Windows.Forms.Button();
            this.button_body1 = new System.Windows.Forms.Button();
            this.button_html = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Tutorial_btn = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.HTMLBtn = new System.Windows.Forms.Button();
            this.PreviewBtn = new System.Windows.Forms.Button();
            oepn_Btn = new System.Windows.Forms.Button();
            this.PartsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.group_tag.SuspendLayout();
            this.groupBody.SuspendLayout();
            this.groupHead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oepn_Btn
            // 
            oepn_Btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Open;
            oepn_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            oepn_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            oepn_Btn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold);
            oepn_Btn.ForeColor = System.Drawing.Color.White;
            oepn_Btn.Location = new System.Drawing.Point(134, 32);
            oepn_Btn.Name = "oepn_Btn";
            oepn_Btn.Size = new System.Drawing.Size(115, 67);
            oepn_Btn.TabIndex = 19;
            oepn_Btn.UseVisualStyleBackColor = true;
            oepn_Btn.Click += new System.EventHandler(this.oepn_Btn_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(59, 118);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(262, 19);
            this.Title.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "タイトル";
            // 
            // PartsBox
            // 
            this.PartsBox.Controls.Add(this.partsList);
            this.PartsBox.Location = new System.Drawing.Point(12, 143);
            this.PartsBox.Name = "PartsBox";
            this.PartsBox.Size = new System.Drawing.Size(318, 243);
            this.PartsBox.TabIndex = 10;
            this.PartsBox.TabStop = false;
            this.PartsBox.Text = "素材";
            this.PartsBox.Enter += new System.EventHandler(this.PartsBox_Enter);
            // 
            // partsList
            // 
            this.partsList.HideSelection = false;
            this.partsList.LargeImageList = this.imageList;
            this.partsList.Location = new System.Drawing.Point(6, 18);
            this.partsList.Name = "partsList";
            this.partsList.Size = new System.Drawing.Size(303, 219);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 22);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(917, 757);
            this.webBrowser1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.BackText});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileNew,
            this.MenuItemFileOpen,
            this.toolStripSeparator1,
            this.MenuItemFileSave,
            this.MenuItemFileSaveAs,
            this.toolStripSeparator2,
            this.終了XToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // MenuItemFileNew
            // 
            this.MenuItemFileNew.Name = "MenuItemFileNew";
            this.MenuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItemFileNew.Size = new System.Drawing.Size(181, 22);
            this.MenuItemFileNew.Text = "新規作成(&N)";
            this.MenuItemFileNew.Click += new System.EventHandler(this.MenuItemFileNew_Click);
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemFileOpen.Size = new System.Drawing.Size(181, 22);
            this.MenuItemFileOpen.Text = "開く(&O)";
            this.MenuItemFileOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.Size = new System.Drawing.Size(181, 22);
            this.MenuItemFileSave.Text = "上書き保存(&S)";
            this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // MenuItemFileSaveAs
            // 
            this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
            this.MenuItemFileSaveAs.Size = new System.Drawing.Size(181, 22);
            this.MenuItemFileSaveAs.Text = "名前を付けて保存(&A)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileExitToolStripMenuItem});
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            // 
            // menuItemFileExitToolStripMenuItem
            // 
            this.menuItemFileExitToolStripMenuItem.Name = "menuItemFileExitToolStripMenuItem";
            this.menuItemFileExitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.menuItemFileExitToolStripMenuItem.Text = "MenuItemFileExit";
            this.menuItemFileExitToolStripMenuItem.Click += new System.EventHandler(this.menuItemFileExitToolStripMenuItem_Click);
            // 
            // BackText
            // 
            this.BackText.Name = "BackText";
            this.BackText.Size = new System.Drawing.Size(40, 20);
            this.BackText.Text = "戻る";
            this.BackText.Click += new System.EventHandler(this.BackText_Click);
            // 
            // HTMLBOX
            // 
            this.HTMLBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(29)))));
            this.HTMLBOX.Location = new System.Drawing.Point(12, 22);
            this.HTMLBOX.Multiline = true;
            this.HTMLBOX.Name = "HTMLBOX";
            this.HTMLBOX.ReadOnly = true;
            this.HTMLBOX.Size = new System.Drawing.Size(917, 763);
            this.HTMLBOX.TabIndex = 15;
            this.HTMLBOX.Visible = false;
            this.HTMLBOX.TextChanged += new System.EventHandler(this.HTMLBOX_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(29)))));
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "タグツリー";
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_edit.Location = new System.Drawing.Point(255, 393);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 20;
            this.button_edit.Text = "編集";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // group_tag
            // 
            this.group_tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(29)))));
            this.group_tag.Controls.Add(this.groupBody);
            this.group_tag.Controls.Add(this.groupHead);
            this.group_tag.Controls.Add(this.button_swap);
            this.group_tag.Controls.Add(this.button_delete);
            this.group_tag.Controls.Add(this.button_head1);
            this.group_tag.Controls.Add(this.button_body1);
            this.group_tag.Controls.Add(this.button_html);
            this.group_tag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.group_tag.Location = new System.Drawing.Point(12, 409);
            this.group_tag.Name = "group_tag";
            this.group_tag.Size = new System.Drawing.Size(318, 507);
            this.group_tag.TabIndex = 21;
            this.group_tag.TabStop = false;
            // 
            // groupBody
            // 
            this.groupBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBody.Controls.Add(this.button_body2);
            this.groupBody.Controls.Add(this.property_text);
            this.groupBody.Controls.Add(this.label3);
            this.groupBody.Controls.Add(this.flowLayoutPanel1);
            this.groupBody.Location = new System.Drawing.Point(0, 56);
            this.groupBody.Name = "groupBody";
            this.groupBody.Size = new System.Drawing.Size(309, 445);
            this.groupBody.TabIndex = 2;
            this.groupBody.TabStop = false;
            this.groupBody.Visible = false;
            // 
            // button_body2
            // 
            this.button_body2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_body2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_body2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_body2.ForeColor = System.Drawing.Color.White;
            this.button_body2.Location = new System.Drawing.Point(3, 21);
            this.button_body2.Name = "button_body2";
            this.button_body2.Size = new System.Drawing.Size(122, 54);
            this.button_body2.TabIndex = 1;
            this.button_body2.Text = "<BODY>";
            this.button_body2.UseVisualStyleBackColor = false;
            this.button_body2.Click += new System.EventHandler(this.button_body2_Click);
            // 
            // property_text
            // 
            this.property_text.BackColor = System.Drawing.Color.White;
            this.property_text.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.property_text.ForeColor = System.Drawing.SystemColors.InfoText;
            this.property_text.Location = new System.Drawing.Point(167, 34);
            this.property_text.Multiline = true;
            this.property_text.Name = "property_text";
            this.property_text.Size = new System.Drawing.Size(136, 401);
            this.property_text.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(166, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "プロパティ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(128, 354);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // groupHead
            // 
            this.groupHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupHead.Controls.Add(this.button_head2);
            this.groupHead.Controls.Add(this.button_title);
            this.groupHead.Location = new System.Drawing.Point(0, 57);
            this.groupHead.Name = "groupHead";
            this.groupHead.Size = new System.Drawing.Size(309, 443);
            this.groupHead.TabIndex = 2;
            this.groupHead.TabStop = false;
            this.groupHead.Visible = false;
            // 
            // button_head2
            // 
            this.button_head2.BackColor = System.Drawing.Color.Blue;
            this.button_head2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_head2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_head2.ForeColor = System.Drawing.Color.White;
            this.button_head2.Location = new System.Drawing.Point(0, 20);
            this.button_head2.Name = "button_head2";
            this.button_head2.Size = new System.Drawing.Size(122, 54);
            this.button_head2.TabIndex = 1;
            this.button_head2.Text = "<HEAD>";
            this.button_head2.UseVisualStyleBackColor = false;
            this.button_head2.Click += new System.EventHandler(this.button_head2_Click);
            // 
            // button_title
            // 
            this.button_title.BackColor = System.Drawing.Color.Blue;
            this.button_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_title.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_title.ForeColor = System.Drawing.Color.White;
            this.button_title.Location = new System.Drawing.Point(0, 96);
            this.button_title.Name = "button_title";
            this.button_title.Size = new System.Drawing.Size(122, 54);
            this.button_title.TabIndex = 1;
            this.button_title.Text = "<TITLE>";
            this.button_title.UseVisualStyleBackColor = false;
            // 
            // button_swap
            // 
            this.button_swap.Location = new System.Drawing.Point(162, 10);
            this.button_swap.Name = "button_swap";
            this.button_swap.Size = new System.Drawing.Size(75, 23);
            this.button_swap.TabIndex = 4;
            this.button_swap.Text = "並び替え";
            this.button_swap.UseVisualStyleBackColor = true;
            this.button_swap.Visible = false;
            this.button_swap.Click += new System.EventHandler(this.button_swap_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_delete.Location = new System.Drawing.Point(243, 10);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "削除";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_head1
            // 
            this.button_head1.BackColor = System.Drawing.Color.Blue;
            this.button_head1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_head1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_head1.ForeColor = System.Drawing.Color.White;
            this.button_head1.Location = new System.Drawing.Point(0, 77);
            this.button_head1.Name = "button_head1";
            this.button_head1.Size = new System.Drawing.Size(122, 54);
            this.button_head1.TabIndex = 1;
            this.button_head1.Text = "<HEAD>";
            this.button_head1.UseVisualStyleBackColor = false;
            this.button_head1.Click += new System.EventHandler(this.button_head1_Click);
            // 
            // button_body1
            // 
            this.button_body1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_body1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_body1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_body1.ForeColor = System.Drawing.Color.White;
            this.button_body1.Location = new System.Drawing.Point(0, 152);
            this.button_body1.Name = "button_body1";
            this.button_body1.Size = new System.Drawing.Size(122, 54);
            this.button_body1.TabIndex = 1;
            this.button_body1.Text = "<BODY>";
            this.button_body1.UseVisualStyleBackColor = false;
            this.button_body1.Click += new System.EventHandler(this.button_body1_Click);
            // 
            // button_html
            // 
            this.button_html.BackColor = System.Drawing.Color.Yellow;
            this.button_html.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_html.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_html.Location = new System.Drawing.Point(3, 10);
            this.button_html.Name = "button_html";
            this.button_html.Size = new System.Drawing.Size(122, 41);
            this.button_html.TabIndex = 1;
            this.button_html.Text = "<HTML>";
            this.button_html.UseVisualStyleBackColor = false;
            this.button_html.Click += new System.EventHandler(this.button_html_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.HTMLBOX);
            this.panel1.Location = new System.Drawing.Point(345, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 798);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(29)))));
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(9, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "プレビュー";
            // 
            // Tutorial_btn
            // 
            this.Tutorial_btn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Tutorial;
            this.Tutorial_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tutorial_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial_btn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tutorial_btn.ForeColor = System.Drawing.Color.White;
            this.Tutorial_btn.Location = new System.Drawing.Point(254, 32);
            this.Tutorial_btn.Name = "Tutorial_btn";
            this.Tutorial_btn.Size = new System.Drawing.Size(119, 67);
            this.Tutorial_btn.TabIndex = 23;
            this.Tutorial_btn.UseVisualStyleBackColor = true;
            this.Tutorial_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewButton
            // 
            this.NewButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.New;
            this.NewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NewButton.ForeColor = System.Drawing.Color.White;
            this.NewButton.Location = new System.Drawing.Point(12, 32);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(116, 67);
            this.NewButton.TabIndex = 11;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SaveAs;
            this.SaveAsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold);
            this.SaveAsButton.ForeColor = System.Drawing.Color.White;
            this.SaveAsButton.Location = new System.Drawing.Point(379, 32);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(124, 67);
            this.SaveAsButton.TabIndex = 18;
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Save;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(509, 31);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 68);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // HTMLBtn
            // 
            this.HTMLBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SauceCode;
            this.HTMLBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HTMLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HTMLBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HTMLBtn.ForeColor = System.Drawing.Color.White;
            this.HTMLBtn.Location = new System.Drawing.Point(637, 30);
            this.HTMLBtn.Name = "HTMLBtn";
            this.HTMLBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HTMLBtn.Size = new System.Drawing.Size(120, 69);
            this.HTMLBtn.TabIndex = 14;
            this.HTMLBtn.UseVisualStyleBackColor = true;
            this.HTMLBtn.Click += new System.EventHandler(this.HTMLBtn_Click);
            // 
            // PreviewBtn
            // 
            this.PreviewBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Preview;
            this.PreviewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PreviewBtn.ForeColor = System.Drawing.Color.White;
            this.PreviewBtn.Location = new System.Drawing.Point(637, 30);
            this.PreviewBtn.Name = "PreviewBtn";
            this.PreviewBtn.Size = new System.Drawing.Size(120, 69);
            this.PreviewBtn.TabIndex = 26;
            this.PreviewBtn.UseVisualStyleBackColor = true;
            this.PreviewBtn.Visible = false;
            this.PreviewBtn.Click += new System.EventHandler(this.PreviewBtn_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 918);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tutorial_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(oepn_Btn);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveAsButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PartsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.group_tag);
            this.Controls.Add(this.HTMLBtn);
            this.Controls.Add(this.PreviewBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "メインページ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PartsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.group_tag.ResumeLayout(false);
            this.groupBody.ResumeLayout(false);
            this.groupBody.PerformLayout();
            this.groupHead.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PartsBox;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.Button HTMLBtn;
        private System.Windows.Forms.TextBox HTMLBOX;
        private System.Windows.Forms.ListView partsList;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.GroupBox group_tag;
        private System.Windows.Forms.Button button_swap;
        private System.Windows.Forms.GroupBox groupBody;
        private System.Windows.Forms.Button button_body2;
        private System.Windows.Forms.TextBox property_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupHead;
        private System.Windows.Forms.Button button_head2;
        private System.Windows.Forms.Button button_title;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_head1;
        private System.Windows.Forms.Button button_body1;
        private System.Windows.Forms.Button button_html;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackText;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileExitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button Tutorial_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PreviewBtn;
        internal System.Windows.Forms.TextBox Title;
        internal System.Windows.Forms.WebBrowser webBrowser1;
    }
}

