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
            this.Title_Visible = new System.Windows.Forms.TextBox();
            this.Parts_Visible = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.HTMLBOX = new System.Windows.Forms.TextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Tutorial_btn = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.HTMLBtn = new System.Windows.Forms.Button();
            this.PreviewBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_input = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Input = new System.Windows.Forms.Button();
            this.groupBody = new System.Windows.Forms.GroupBox();
            this.label_pro = new System.Windows.Forms.Label();
            this.flowLayoutPanel_body = new System.Windows.Forms.FlowLayoutPanel();
            this.groupHead = new System.Windows.Forms.GroupBox();
            this.button_title = new System.Windows.Forms.Button();
            this.flowLayoutPanel_head = new System.Windows.Forms.FlowLayoutPanel();
            this.button_head1 = new System.Windows.Forms.Button();
            this.group_tag = new System.Windows.Forms.GroupBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_body1 = new System.Windows.Forms.Button();
            this.button_html = new System.Windows.Forms.Button();
            this.button_body2 = new System.Windows.Forms.Button();
            oepn_Btn = new System.Windows.Forms.Button();
            this.PartsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupInput.SuspendLayout();
            this.groupBody.SuspendLayout();
            this.groupHead.SuspendLayout();
            this.group_tag.SuspendLayout();
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
            this.Title.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(59, 118);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(299, 23);
            this.Title.TabIndex = 3;
            this.Title.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(4, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "タイトル";
            // 
            // PartsBox
            // 
            this.PartsBox.Controls.Add(this.partsList);
            this.PartsBox.Controls.Add(this.Title_Visible);
            this.PartsBox.Controls.Add(this.Parts_Visible);
            this.PartsBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PartsBox.Location = new System.Drawing.Point(12, 143);
            this.PartsBox.Name = "PartsBox";
            this.PartsBox.Size = new System.Drawing.Size(355, 243);
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
            this.partsList.Size = new System.Drawing.Size(340, 219);
            this.partsList.TabIndex = 0;
            this.partsList.UseCompatibleStateImageBehavior = false;
            this.partsList.Visible = false;
            this.partsList.Click += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // Title_Visible
            // 
            this.Title_Visible.Location = new System.Drawing.Point(47, -25);
            this.Title_Visible.Multiline = true;
            this.Title_Visible.Name = "Title_Visible";
            this.Title_Visible.ReadOnly = true;
            this.Title_Visible.Size = new System.Drawing.Size(262, 19);
            this.Title_Visible.TabIndex = 2;
            this.Title_Visible.Text = "新規作成か開くをクリック後利用できます";
            // 
            // Parts_Visible
            // 
            this.Parts_Visible.Location = new System.Drawing.Point(6, 19);
            this.Parts_Visible.Multiline = true;
            this.Parts_Visible.Name = "Parts_Visible";
            this.Parts_Visible.ReadOnly = true;
            this.Parts_Visible.Size = new System.Drawing.Size(302, 218);
            this.Parts_Visible.TabIndex = 1;
            this.Parts_Visible.Text = "新規作成か開くを選択後,部品が選択できます";
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
            this.webBrowser1.Size = new System.Drawing.Size(892, 783);
            this.webBrowser1.TabIndex = 1;
            // 
            // HTMLBOX
            // 
            this.HTMLBOX.BackColor = System.Drawing.Color.White;
            this.HTMLBOX.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HTMLBOX.Location = new System.Drawing.Point(12, 22);
            this.HTMLBOX.Multiline = true;
            this.HTMLBOX.Name = "HTMLBOX";
            this.HTMLBOX.ReadOnly = true;
            this.HTMLBOX.Size = new System.Drawing.Size(892, 783);
            this.HTMLBOX.TabIndex = 15;
            this.HTMLBOX.Visible = false;
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
            this.panel1.Location = new System.Drawing.Point(373, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 814);
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
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Save;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(379, 31);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 68);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // HTMLBtn
            // 
            this.HTMLBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SauceCode;
            this.HTMLBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HTMLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HTMLBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HTMLBtn.ForeColor = System.Drawing.Color.White;
            this.HTMLBtn.Location = new System.Drawing.Point(507, 32);
            this.HTMLBtn.Name = "HTMLBtn";
            this.HTMLBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HTMLBtn.Size = new System.Drawing.Size(120, 69);
            this.HTMLBtn.TabIndex = 14;
            this.HTMLBtn.UseVisualStyleBackColor = true;
            this.HTMLBtn.Visible = false;
            this.HTMLBtn.Click += new System.EventHandler(this.HTMLBtn_Click);
            // 
            // PreviewBtn
            // 
            this.PreviewBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Preview;
            this.PreviewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewBtn.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PreviewBtn.ForeColor = System.Drawing.Color.White;
            this.PreviewBtn.Location = new System.Drawing.Point(507, 32);
            this.PreviewBtn.Name = "PreviewBtn";
            this.PreviewBtn.Size = new System.Drawing.Size(120, 69);
            this.PreviewBtn.TabIndex = 26;
            this.PreviewBtn.UseVisualStyleBackColor = true;
            this.PreviewBtn.Visible = false;
            this.PreviewBtn.Click += new System.EventHandler(this.PreviewBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(261, 19);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "新規作成・開くを選択後利用できます";
            // 
            // groupInput
            // 
            this.groupInput.BackColor = System.Drawing.Color.White;
            this.groupInput.Controls.Add(this.flowLayoutPanel_input);
            this.groupInput.Controls.Add(this.button_Input);
            this.groupInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupInput.Location = new System.Drawing.Point(0, 0);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(343, 398);
            this.groupInput.TabIndex = 5;
            this.groupInput.TabStop = false;
            this.groupInput.Visible = false;
            // 
            // flowLayoutPanel_input
            // 
            this.flowLayoutPanel_input.AutoScroll = true;
            this.flowLayoutPanel_input.Location = new System.Drawing.Point(3, 62);
            this.flowLayoutPanel_input.Name = "flowLayoutPanel_input";
            this.flowLayoutPanel_input.Size = new System.Drawing.Size(158, 327);
            this.flowLayoutPanel_input.TabIndex = 8;
            // 
            // button_Input
            // 
            this.button_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(195)))));
            this.button_Input.FlatAppearance.BorderSize = 0;
            this.button_Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Input.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.button_Input.Location = new System.Drawing.Point(3, 9);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(122, 52);
            this.button_Input.TabIndex = 7;
            this.button_Input.Text = "<INPUT>";
            this.button_Input.UseVisualStyleBackColor = false;
            // 
            // groupBody
            // 
            this.groupBody.BackColor = System.Drawing.Color.White;
            this.groupBody.Controls.Add(this.groupInput);
            this.groupBody.Controls.Add(this.label_pro);
            this.groupBody.Controls.Add(this.flowLayoutPanel_body);
            this.groupBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(34)))));
            this.groupBody.Location = new System.Drawing.Point(6, 142);
            this.groupBody.Name = "groupBody";
            this.groupBody.Size = new System.Drawing.Size(343, 398);
            this.groupBody.TabIndex = 2;
            this.groupBody.TabStop = false;
            this.groupBody.Visible = false;
            // 
            // label_pro
            // 
            this.label_pro.AutoSize = true;
            this.label_pro.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_pro.Location = new System.Drawing.Point(167, 15);
            this.label_pro.Name = "label_pro";
            this.label_pro.Size = new System.Drawing.Size(0, 16);
            this.label_pro.TabIndex = 9;
            this.label_pro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel_body
            // 
            this.flowLayoutPanel_body.AutoScroll = true;
            this.flowLayoutPanel_body.Location = new System.Drawing.Point(0, 7);
            this.flowLayoutPanel_body.Name = "flowLayoutPanel_body";
            this.flowLayoutPanel_body.Size = new System.Drawing.Size(161, 382);
            this.flowLayoutPanel_body.TabIndex = 6;
            // 
            // groupHead
            // 
            this.groupHead.BackColor = System.Drawing.Color.White;
            this.groupHead.Controls.Add(this.button_title);
            this.groupHead.Controls.Add(this.flowLayoutPanel_head);
            this.groupHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupHead.Location = new System.Drawing.Point(6, 142);
            this.groupHead.Name = "groupHead";
            this.groupHead.Size = new System.Drawing.Size(343, 398);
            this.groupHead.TabIndex = 28;
            this.groupHead.TabStop = false;
            this.groupHead.Visible = false;
            // 
            // button_title
            // 
            this.button_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(195)))));
            this.button_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_title.FlatAppearance.BorderSize = 0;
            this.button_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_title.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.button_title.Location = new System.Drawing.Point(3, 10);
            this.button_title.Name = "button_title";
            this.button_title.Size = new System.Drawing.Size(122, 51);
            this.button_title.TabIndex = 1;
            this.button_title.Text = "<TITLE>";
            this.button_title.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel_head
            // 
            this.flowLayoutPanel_head.AutoScroll = true;
            this.flowLayoutPanel_head.Location = new System.Drawing.Point(0, 62);
            this.flowLayoutPanel_head.Name = "flowLayoutPanel_head";
            this.flowLayoutPanel_head.Size = new System.Drawing.Size(158, 327);
            this.flowLayoutPanel_head.TabIndex = 8;
            // 
            // button_head1
            // 
            this.button_head1.BackColor = System.Drawing.Color.White;
            this.button_head1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_head1.FlatAppearance.BorderSize = 0;
            this.button_head1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_head1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_head1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(34)))));
            this.button_head1.Location = new System.Drawing.Point(6, 90);
            this.button_head1.Name = "button_head1";
            this.button_head1.Size = new System.Drawing.Size(125, 54);
            this.button_head1.TabIndex = 1;
            this.button_head1.Text = "<HEAD>";
            this.button_head1.UseVisualStyleBackColor = false;
            this.button_head1.Click += new System.EventHandler(this.button_head1_Click_1);
            // 
            // group_tag
            // 
            this.group_tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(34)))));
            this.group_tag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.group_tag.Controls.Add(this.groupHead);
            this.group_tag.Controls.Add(this.groupBody);
            this.group_tag.Controls.Add(this.button_edit);
            this.group_tag.Controls.Add(this.label2);
            this.group_tag.Controls.Add(this.button_delete);
            this.group_tag.Controls.Add(this.button_body1);
            this.group_tag.Controls.Add(this.button_html);
            this.group_tag.Controls.Add(this.button_head1);
            this.group_tag.Controls.Add(this.button_body2);
            this.group_tag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_tag.Location = new System.Drawing.Point(12, 392);
            this.group_tag.Name = "group_tag";
            this.group_tag.Size = new System.Drawing.Size(355, 546);
            this.group_tag.TabIndex = 29;
            this.group_tag.TabStop = false;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(195)))));
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(79)))));
            this.button_edit.Location = new System.Drawing.Point(274, 9);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "編集";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "タグツリー";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(34)))));
            this.button_delete.Location = new System.Drawing.Point(274, 38);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "削除";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click_1);
            // 
            // button_body1
            // 
            this.button_body1.BackColor = System.Drawing.Color.White;
            this.button_body1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_body1.FlatAppearance.BorderSize = 0;
            this.button_body1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_body1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_body1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(34)))));
            this.button_body1.Location = new System.Drawing.Point(6, 148);
            this.button_body1.Name = "button_body1";
            this.button_body1.Size = new System.Drawing.Size(125, 54);
            this.button_body1.TabIndex = 1;
            this.button_body1.Text = "<BODY>";
            this.button_body1.UseVisualStyleBackColor = false;
            this.button_body1.Click += new System.EventHandler(this.button_body1_Click_1);
            // 
            // button_html
            // 
            this.button_html.BackColor = System.Drawing.Color.White;
            this.button_html.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_html.FlatAppearance.BorderSize = 0;
            this.button_html.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_html.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_html.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(34)))));
            this.button_html.Location = new System.Drawing.Point(6, 29);
            this.button_html.Name = "button_html";
            this.button_html.Size = new System.Drawing.Size(125, 55);
            this.button_html.TabIndex = 1;
            this.button_html.Text = "<HTML>";
            this.button_html.UseVisualStyleBackColor = false;
            this.button_html.Click += new System.EventHandler(this.button_html_Click_1);
            // 
            // button_body2
            // 
            this.button_body2.BackColor = System.Drawing.Color.White;
            this.button_body2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_body2.FlatAppearance.BorderSize = 0;
            this.button_body2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_body2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_body2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(34)))));
            this.button_body2.Location = new System.Drawing.Point(6, 90);
            this.button_body2.Name = "button_body2";
            this.button_body2.Size = new System.Drawing.Size(125, 54);
            this.button_body2.TabIndex = 1;
            this.button_body2.Text = "<BODY>";
            this.button_body2.UseVisualStyleBackColor = false;
            this.button_body2.Visible = false;
            this.button_body2.Click += new System.EventHandler(this.button_body2_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1302, 943);
            this.Controls.Add(this.group_tag);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tutorial_btn);
            this.Controls.Add(oepn_Btn);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PartsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.HTMLBtn);
            this.Controls.Add(this.PreviewBtn);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1318, 982);
            this.MinimumSize = new System.Drawing.Size(1318, 982);
            this.Name = "main";
            this.Text = "メインページ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PartsBox.ResumeLayout(false);
            this.PartsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupInput.ResumeLayout(false);
            this.groupBody.ResumeLayout(false);
            this.groupBody.PerformLayout();
            this.groupHead.ResumeLayout(false);
            this.group_tag.ResumeLayout(false);
            this.group_tag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PartsBox;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button HTMLBtn;
        private System.Windows.Forms.TextBox HTMLBOX;
        private System.Windows.Forms.ListView partsList;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button Tutorial_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PreviewBtn;
        internal System.Windows.Forms.TextBox Title;
        internal System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox Parts_Visible;
        private System.Windows.Forms.TextBox Title_Visible;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox group_tag;
        private System.Windows.Forms.GroupBox groupBody;
        private System.Windows.Forms.GroupBox groupHead;
        private System.Windows.Forms.Button button_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_head;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_body;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_input;
        private System.Windows.Forms.Button button_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_body1;
        private System.Windows.Forms.Button button_html;
        private System.Windows.Forms.Button button_head1;
        private System.Windows.Forms.Button button_body2;
        private System.Windows.Forms.Label label_pro;
    }
}

