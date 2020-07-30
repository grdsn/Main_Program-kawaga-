using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        //定義--------------------------------------------------------
        const string ApplicationName = "かんたんWeb君";//アプリケーション名
        private string FileName = ""; //ファイル名(フルパス)
        string result;//結果格納
        private bool Edited = false;
        string adress; //アドレスの相対パス
        string[] text_box = new string[10000]; //HTMLタグ格納用
        int cnt = 0; //タグ数カウント
        string sel; //選択した部品の名前を格納
        Boolean HTML_flg = false;//ソースコード表示判定用
        //定義----------------------------------------------------------------


        //在間くん作成部分------------------------------------------------------

        //画面フラグ
        public int flg = 0;
        //入れ替え部品
        public int contflg = 0;
        public int BCount1 = 0;
        public int BCount2 = 0;
        public int ItemCount1 = 0;
        public int ItemCount2 = 0;
        public Dictionary<String, int> dic = new Dictionary<string, int>() { { "", 0 } };
        public String name1 = "";
        public String name2 = "";
        //追加部品のカウント
        public int addHeadCount = 2;
        public int addBodyCount = 1;
        public int addH1Count = 0;
        public int addPCount = 0;
        public int addTableCount = 0;
        public int addImgCount = 0;
        public int addUrlCount = 0;
        public int addTextboxCount = 0;
        public int addButtonCount = 0;

        public int cont1 = 0;
        public int cont2 = 0;

        //ボタンイベントの有無
        public Boolean button_event = false;
        //終わり---------------------------------------------------------------

        Control ctrl1;
        Control ctrl2;
        System.IO.StreamWriter writer = null;
        public main()
        {
            InitializeComponent();
        }

        /*
         * リストに部品名を挿入する(かわが)
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            
            lvi.Text = "見出し";
            lvi.ImageIndex = 0;
            partsList.Items.Add(lvi);

            lvi = new ListViewItem("テキスト");
            lvi.ImageIndex = 1;
            lvi.Name = "parts_Text";
            partsList.Items.Add(lvi);

            lvi = new ListViewItem("テキストの強調");
            lvi.ImageIndex = 2;
            partsList.Items.Add(lvi);

            lvi = new ListViewItem("ハイパーテキスト");
            lvi.ImageIndex = 3;
            partsList.Items.Add(lvi);

            lvi = new ListViewItem("太字");
            lvi.ImageIndex = 4;
            partsList.Items.Add(lvi);

            lvi = new ListViewItem("テーブル");
            lvi.ImageIndex = 8;
            partsList.Items.Add(lvi);

            lvi = new ListViewItem("順序のあるリスト");
            lvi.ImageIndex = 5;
            partsList.Items.Add(lvi);

            lvi = new ListViewItem("順序のないリスト");
            lvi.ImageIndex = 6;
            partsList.Items.Add(lvi);

            lvi = new ListViewItem("画像");
            lvi.ImageIndex = 7;
            partsList.Items.Add(lvi);

            //在間くん作成部分--------------------------------------------
            this.flowLayoutPanel1.VerticalScroll.Visible = true;
            //在間くん作成部分--------------------------------------------

            this.Text = ApplicationName;

            // 複数行入力を有効化
            HTMLBOX.Multiline = true;

            // 垂直方向スクロールバー表示を有効化
            HTMLBOX.ScrollBars = ScrollBars.Vertical;

            // フォーム全体にテキストボックスを表示
            //textBox.Dock = DockStyle.Fill;

            // 「名前を付けて保存」ダイアログで「ファイル種類」を選択させる
            SaveFileDialog.Filter = "HTML|*.html|CSS|*.css";

            UpdateStatus("", false);        
        }

        /*
         * ブラウザ内の情報を更新するインスタンスを呼び出す(かわが)
         */
        private void Result_Btn_Click(object sender, EventArgs e)
        {
            Browser_show();　//結果を画面上に表示
        }

        /*
         * 相対パスでデスクトップを指定する
         */
        private string get_Path()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), FileName);
        }

        /*
         *HTMLを書き出すためのプログラム(かわが)
         */
        public void writer_html(string input,int flag)
        {
            String destinationPath = get_Path(); //相対パスで指定 (デスクトップに保存)
            if (flag == 0) //配列にデータを追加する
            {
                text_box[cnt] = input;
                writer = new System.IO.StreamWriter(destinationPath, false, System.Text.Encoding.UTF8);
                writer.Write("<DOCTYPE! HTML>\r\n");
                writer.Write("<HTML>\r\n"); //HTML開始
                writer.Write("<head>\r\n" + "<title>" + Title.Text + "</title>\r\n</head>\r\n"); //タイトルの定義
                writer.Write("<body>\r\n");
                for (int i = 0; i <= cnt; i++)
                {
                    writer.Write("<div class=\"" + i + "\">\r\n" + text_box[i] + "\r\n</div>\r\n"); //HTMLコードを追加する
                }
                writer.Write("</body>\r\n");
                writer.Write("</HTML>"); //HTML終了
                writer.Close();
            }
            else　if(flg==1) //配列内のデータを初期化
            {
                for(int i = 0; i <=cnt; i++)
                {
                    text_box[cnt] = "";
                }
                writer = new System.IO.StreamWriter(destinationPath, false, System.Text.Encoding.UTF8);
                writer.Write("");
                cnt = 0;
                writer.Close(); //閉じる
            }
            
        }

        /*
         * HTMLのファイルに位置を置き換える
         */
        private void replace_HTML(string input1,string input2)
        {

        }

        /*
         * 戻るボタンが押された場合
         */
        private void BackText_Click(object sender, EventArgs e)
        {
            if (cnt > 0)
            {
                cnt--;
                writer_html("", 0);
                Browser_show();　//結果を画面上に表示
            }
        }

        /*
         *終了がクリックされたとき 
         */
        private void menuItemFileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * アプリケーションを更新する
         */
        private void UpdateStatus(string Name, bool Edited)
        {
            // ファイル名を保持する
            this.FileName = Name;

            // 編集状態を保持する
            this.Edited = Edited;

            // タイトルバー表示名
            string title = ApplicationName + " - " + this.FileName;

            if (FileName != "")
            {
                // タイトルバーにファイル名を表示する
                this.Text = ApplicationName + " - " + this.FileName;
            }

            if (Edited)
            {
                // 編集中があれば「（変更あり）」をタイトル名に付ける
                title += "（変更あり）";
            }

            // タイトルバー表示名を設定する
            this.Text = title;

            if (FileName == "")
            {
                // ファイル名が未設定
                // 「上書き保存」を無効
                MenuItemFileSave.Enabled = false;
                SaveButton.Enabled = false;
            }
            else
            {
                // 「上書き保存」を有効
                MenuItemFileSave.Enabled = true;
                SaveButton.Enabled = true;
            }

            if (!Edited)
            {
                // 編集前
                // 「名前を付けて保存」を無効
                MenuItemFileSaveAs.Enabled = false;
                SaveAsButton.Enabled = false;
            }
            else
            {
                // 編集中
                // 「名前を付けて保存」を有効
                MenuItemFileSaveAs.Enabled = true;
                SaveAsButton.Enabled = true;
            }
        }
        /*
         * 終了する前にデータが残っていたら確認する
         */
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Edited)
            {
                // テキストが「未編集」の場合はそのまま終了
                return;
            }

            // 終了確認ダイアログを表示
            bool result = ShowDiscardDialog();

            if (!result)
            {
                // 「はい」以外が選択された場合は
                // アプリケーション終了をキャンセルする
                e.Cancel = true;
            }
        }

        /*
         * HTMLファイルを開く
         */
        private void oepn_Btn_Click(object sender, EventArgs e)
        {
            MenuItemFileOpen_Click(sender, e);
        }

        /*
         * ファイル新規作成
         */
        private void MenuItemFileNew_Click(object sender, EventArgs e)
        {
            if (!Edited)
            {
                //テキストボックスの内容をクリア
                HTMLBOX.Clear();

                // ファイル名（フルパス）
                this.FileName = "新規作成";

                //ファイル名保持
                this.Text = ApplicationName + " - " + this.FileName;
            }
            else
            {
                // テキストが「編集中」
                // 終了確認ダイアログを表示
                bool result = ShowDiscardDialog();

                if (!result)
                {
                    // 「OK」ボタン以外がクリックされた場合は処理を中断
                    return;
                }
                else
                {
                    //テキストボックスの内容をクリア
                    HTMLBOX.Clear();

                    // ファイル名（フルパス）
                    this.FileName = "新規作成";

                    //ファイル名保持
                    this.Text = ApplicationName + " - " + this.FileName;
                }
            }
        }

        /*
         *テキストファイルの内容をテキストボックスに格納する 
         */
        private void LoadFile(string value)
        {
            //UTF-8に変換してファイルを開く
            HTMLBOX.Text = System.IO.File.ReadAllText(value, Encoding.GetEncoding("UTF-8"));

            this.FileName = value;

            UpdateStatus(FileName, false);

            Browser_show();

        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            HTML_show();
            MenuItemSaveAs_Click(sender, e);
        }

        private void MenuItemSaveAs_Click(object sender, EventArgs e)
        {
            // ファイル名を初期入力させておく
            SaveFileDialog.FileName = System.IO.Path.GetFileName(this.FileName);

            if (DialogResult.OK == SaveFileDialog.ShowDialog())
            {
                // 「開く」ボタンがクリックされたとき
                SaveFile(SaveFileDialog.FileName);
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            SaveFile(this.FileName);
        }

        private void SaveFile(string value)
        {
            //UTF-8で保存
            System.IO.File.WriteAllText(value, HTMLBOX.Text, Encoding.GetEncoding("UTF-8"));

            // ファイル名を保持する
            this.FileName = value;

            UpdateStatus(FileName, false);

        }

        /*
         * ファイルを開く処理
         */
        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            if (Edited)
            {
                // テキストが「編集中」
                // 終了確認ダイアログを表示
                bool result = ShowDiscardDialog();

                // キャンセルがクリックされた場合は処理を中断
                if (!result)
                {
                    return;
                }
            }

            OpenFileDialog.FileName = "";
            if (DialogResult.OK == OpenFileDialog.ShowDialog())
            {
                // 「開く」ボタンがクリックされたとき
                LoadFile(OpenFileDialog.FileName);

            }
        }

        /*
         * 警告を表示する
         */
        private bool ShowDiscardDialog()
        {
            // ダイアログ表示
            DialogResult result = MessageBox.Show("編集内容を破棄しますか？", ApplicationName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (DialogResult.OK == result)
            {
                // 「OK」
                return true;
            }
            else
            {
                // 「OK」以外
                return false;
            }
        }

        /*
         *  最下部のHTMLタグを削除する(かわが)
         */
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            if (cnt >0)
            {
                cnt--;
                writer_html("",0);
                Browser_show();　//結果を画面上に表示
            }
        }

        /*
         * フォーム内のブラウザを更新する(かわが)
         */
        private void Browser_show()
        {
            webBrowser1.Navigate(get_Path());　//相対パスで指定 (デスクトップに保存)
        }

        /*
         *新規追加(かわが)
         */
        private void NewButton_Click(object sender, EventArgs e)
        {
            MenuItemFileNew_Click(sender, e);
        }


        /*
         * HTMLソースコードを表示する(かわが)
         */
        private void HTML_show()
        {
            String destinationPath = get_Path(); //相対パスで指定 (デスクトップに保存)
            StreamReader st = new StreamReader(destinationPath, Encoding.GetEncoding("UTF-8"));　//StreamReaderでファイルの内容を読み込む
            HTMLBOX.Text = st.ReadToEnd(); //streamReader内のテキストを書き込む
            st.Close();//終了
        }


        /*
         * ソースコード表示ボタン制御(かわが)
         */
        private void HTMLBtn_Click(object sender, EventArgs e)
        {
            if (HTML_flg == false)
            {
                HTMLBtn.Visible = false;
                PreviewBtn.Visible = true;
                HTMLBOX.Visible = true; //HTMLソースコード用のテキストボックスを有効化
                //HTMLBtn.Text = "プレビュー表示";
                HTML_show(); //ソースコードを表示
                HTML_flg = true; //次回クリック時にブラウザ画面にもどる
            }
           
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            if (HTML_flg == true)
            {
                HTMLBtn.Visible = true;
                PreviewBtn.Visible = false;
                HTMLBOX.Visible = false;　//HTMLソースコード用のテキストボックスを無効化
                //HTMLBtn.Text = "ソースコード表示";
                HTML_flg = false; //再びソースコード表示可にする
            }
        }

        /*
         * パーツ名返却(かわが)
         */
        private string Create_parts_num()
        {
            if (partsList.SelectedItems.Count > 0)
            {
                return partsList.SelectedItems[0].Index.ToString();
            }
            return "-1";
        }

        /*
         * 
         */
        private void insert_Parts(string sel)
        {
            Text_parts tp = new Text_parts(); //テキスト
            EM_Parts ep = new EM_Parts(); //テキストの強調
            Hyper_Parts hpp = new Hyper_Parts(); //ハイパーテキスト
            Img_Parts ip = new Img_Parts(); //画像
            OL_Parts op = new OL_Parts(); //順序のあるリスト
            UL_Parts up = new UL_Parts(); //順序のないリスト
            H_Parts hp = new H_Parts(); //見出し
            B_Parts bp = new B_Parts(); //太字
            Table_Parts tbp = new Table_Parts(); //テーブル
            //部品選択分岐-----------------------------------------------
            if (sel == "1") //テキスト
            {
                result = tp.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }

            if (sel == "2") //テキストの強調
            {
                result = ep.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }

            if (sel == "3") //ハイパーテキスト
            {
                result = hpp.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }

            if (sel == "8")　//画像
            {
                result = ip.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }

            if (sel == "6") //順序のあるリスト
            {
                result = op.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }

            if (sel == "7") //順序のないリスト
            {
                result = up.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }

            if (sel == "0") //見出し
            {
                result = hp.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }
            if (sel == "4") //太字
            {
                result = bp.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }

            if (sel == "5") //テーブル
            {
                result = tbp.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }
            //部品選択分岐-----------------------------------------------
        }

        /*
         * パーツを選択し、各部品に分岐させる(かわが)
         */
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //(create_parts_num)indexの要素番号を出力する
            // 選択されている部品の名前を取り込む
            insert_Parts(Create_parts_num()); //indexで判別し部品を挿入する
            Browser_show(); //結果を画面上に表示

            UpdateStatus(FileName, true); //変更あり状態に変更する

            //在間くん作成プログラム-----------------------------------------------

            switch (int.Parse(Create_parts_num()))
            {
                //見出し
                case 0:
                    addH1Count++;                                                                   //見出し個数のカウント
                    Button button_h1 = new Button();                                                //新規ボタンのインスタンス                    //ボタンの配置場所の設定
                    button_h1.Size = new Size(122, 54);                                             //ボタンのサイズ
                    button_h1.ForeColor = Color.FromName("White");                                  //ボタンの文字色の設定
                    button_h1.BackColor = Color.FromName("DodgerBlue");                             //ボタンの背景色の設定
                    button_h1.Text = "<H1>";                                                        //ボタンのテキスト
                    button_h1.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);                   //フォントの設定
                    button_h1.Name = "button_h1_" + addH1Count;                                     //ボタンのNameの設定
                    flowLayoutPanel1.Controls.Add(button_h1);
                    addBodyCount++;                                                                 //BODYの個数のカウント
                    dic.Add(button_h1.Name, flowLayoutPanel1.Controls.GetChildIndex(button_h1));
                    button_h1.Click += btnclick(button_h1.Name, "h1", dic[button_h1.Name], addH1Count, button_h1);                  //追加したボタンにイベントを追加
                    break;
                //文
                case 1:
                    addPCount++;
                    Button button_div = new Button();
                    button_div.Size = new Size(122, 54);
                    button_div.ForeColor = Color.FromName("White");
                    button_div.BackColor = Color.FromName("DodgerBlue");
                    button_div.Text = "<div>";
                    button_div.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_div.Name = "button_div_" + addPCount;
                    flowLayoutPanel1.Controls.Add(button_div);
                    addBodyCount++;
                    dic.Add(button_div.Name, flowLayoutPanel1.Controls.GetChildIndex(button_div));
                    button_div.Click += btnclick(button_div.Name, "div", dic[button_div.Name], addPCount, button_div);
                    break;
                //表
                case 2:
                    addTableCount++;
                    Button button_table = new Button();
                    button_table.Size = new Size(122, 54);
                    button_table.ForeColor = Color.FromName("White");
                    button_table.BackColor = Color.FromName("DodgerBlue");
                    button_table.Text = "<TABLE>";
                    button_table.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_table.Name = "button_table_" + addTableCount;
                    flowLayoutPanel1.Controls.Add(button_table);
                    addBodyCount++;
                    dic.Add(button_table.Name, flowLayoutPanel1.Controls.GetChildIndex(button_table));
                    button_table.Click += btnclick(button_table.Name, "table", dic[button_table.Name], addTableCount, button_table);
                    break;
                //URL
                case 3:
                    addUrlCount++;
                    Button button_url = new Button();
                    button_url.Size = new Size(122, 54);
                    button_url.ForeColor = Color.FromName("White");
                    button_url.BackColor = Color.FromName("DodgerBlue");
                    button_url.Text = "<URL>";
                    button_url.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_url.Name = "button_url_" + addUrlCount;
                    flowLayoutPanel1.Controls.Add(button_url);
                    addBodyCount++;
                    dic.Add(button_url.Name, flowLayoutPanel1.Controls.GetChildIndex(button_url));
                    button_url.Click += btnclick(button_url.Name, "url", dic[button_url.Name], addUrlCount, button_url);
                    break;

                //画像
                case 4:
                    addImgCount++;
                    Button button_img = new Button();
                    button_img.Size = new Size(122, 54);
                    button_img.ForeColor = Color.FromName("White");
                    button_img.BackColor = Color.FromName("DodgerBlue");
                    button_img.Text = "<IMG>";
                    button_img.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_img.Name = "button_img_" + addImgCount;
                    flowLayoutPanel1.Controls.Add(button_img);
                    addBodyCount++;
                    dic.Add(button_img.Name, flowLayoutPanel1.Controls.GetChildIndex(button_img));
                    button_img.Click += btnclick(button_img.Name, "img", dic[button_img.Name], addImgCount, button_img);
                    break;
               
                //テキストボックス
                case 5:
                    addTextboxCount++;
                    Button button_textBox = new Button();
                    button_textBox.Size = new Size(122, 54);
                    button_textBox.ForeColor = Color.FromName("White");
                    button_textBox.BackColor = Color.FromName("DodgerBlue");
                    button_textBox.Text = "<TEXTBOX>";
                    button_textBox.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
                    button_textBox.Name = "button_textbox_" + addTextboxCount;
                    flowLayoutPanel1.Controls.Add(button_textBox);
                    addBodyCount++;
                    dic.Add(button_textBox.Name, flowLayoutPanel1.Controls.GetChildIndex(button_textBox));
                    button_textBox.Click += btnclick(button_textBox.Name, "textbox", dic[button_textBox.Name], addTextboxCount, button_textBox);
                    break;
                //ボタン
                case 6:
                    addButtonCount++;
                    Button button_Button = new Button();
                    button_Button.Size = new Size(122, 54);
                    button_Button.ForeColor = Color.FromName("White");
                    button_Button.BackColor = Color.FromName("DodgerBlue");
                    button_Button.Text = "<BUTTON>";
                    button_Button.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
                    button_Button.Name = "button_button_" + addButtonCount;
                    flowLayoutPanel1.Controls.Add(button_Button);
                    addBodyCount++;
                    dic.Add(button_Button.Name, flowLayoutPanel1.Controls.GetChildIndex(button_Button));
                    button_Button.Click += btnclick(button_Button.Name, "button_button", dic[button_Button.Name], addButtonCount, button_Button);
                    break;
                default:
                    break;
            }
            //在間くん作成プログラム-----------------------------------------------
        }

        //在間くん作成プログラム統合部分-----------------------------------------------

        /*
         * タグツリーのボタン表示の切り替え(在間くん)
         */
        public void ButtonVisible()
        {
            switch (flg)
            {
                //HTMLボタン
                case 0:
                    this.group_tag.Visible = true;
                    this.groupHead.Visible = false;
                    this.groupBody.Visible = false;
                    this.button_delete.Visible = false;
                    this.button_swap.Visible = false;
                    contflg = 0;
                    break;
                //HEADボタン
                case 1:
                    this.groupHead.Visible = true;
                    this.groupBody.Visible = false;
                    this.groupHead.BackColor = Color.FromArgb(128, 128, 255);
                    this.button_delete.Visible = false;
                    this.button_swap.Visible = false;
                    contflg = 0;
                    break;
                //BDOYボタン
                case 2:
                    this.groupHead.Visible = false;
                    this.groupBody.Visible = true;
                    this.groupBody.BackColor = Color.FromArgb(192, 255, 255);
                    this.button_delete.Visible = false;
                    this.button_swap.Visible = false;
                    contflg = 0;
                    break;
                //削除ボタン
                case 5:
                    this.groupHead.Visible = false;
                    this.groupBody.Visible = true;
                    this.groupBody.BackColor = Color.FromName("Red");
                    contflg = 0;
                    break;
                //編集ボタン
                case 6:
                    this.groupHead.Visible = false;
                    this.groupBody.Visible = true;
                    this.groupBody.BackColor = Color.FromArgb(0, 192, 0);
                    this.button_delete.Visible = true;
                    this.button_swap.Visible = true;
                    contflg = 0;
                    break;
                //入れ替え
                case 7:
                    this.groupHead.Visible = false;
                    this.groupBody.Visible = true;
                    //this.groupBody.BackColor = Color.FromArgb(0, 192, 0);
                    //this.tableLayoutPanel1.BackColor = Color.FromArgb(0, 192, 0);
                    this.button_delete.Visible = false;
                    break;
                //例外
                default:
                    this.group_tag.Visible = true;
                    this.groupHead.Visible = false;
                    this.groupBody.Visible = false;
                    this.button_delete.Visible = false;
                    this.button_swap.Visible = false;
                    contflg = 0;
                    break;

            }
        }

        /*
         * タグツリーのHEADボタン処理(在間くん)
         */
        private void button_head1_Click(object sender, EventArgs e)
        {
            flg = 1;
            ButtonVisible();
        }
        private void button_head2_Click(object sender, EventArgs e)
        {
            flg = 1;
            ButtonVisible();
        }

        /*
         * タグツリーのタグツリーのBODYボタン処理(在間くん)
         */
        private void button_body1_Click(object sender, EventArgs e)
        {
            flg = 2;
            ButtonVisible();
        }
        private void button_body2_Click(object sender, EventArgs e)
        {
            flg = 2;
            ButtonVisible();
        }

        /*
         * タグツリーのHTMLボタン処理(在間くん)
         */
        private void button_html_Click(object sender, EventArgs e)
        {
            flg = 0;
            ButtonVisible();
        }

        /*
         * 編集ボタンを押したとき(在間くん)
         */
        private void button_edit_Click(object sender, EventArgs e)
        {
            flg = 6;
            ButtonVisible();
        }

        //---動的ボタンのイベント(引数：部品名、部品の種類、追加カウント、アイテムカウント、部品)
        private EventHandler btnclick(String name, String getkind, int BodyCount, int itemCount, Control cont)
        {
            return delegate (object sender2, EventArgs e2)
            {
                if (flg != 6 && flg != 5 && flg != 7)
                {   //通常時の処理
                    //選択したボタンのプロパティを表示
                    switch (getkind)
                    {
                        case "h1":
                            property_text.Text = "name : " + name;
                            break;
                        case "div":
                            property_text.Text = "name :" + name;
                            break;
                        case "table":
                            property_text.Text = "name :" + name;
                            break;
                        case "img":
                            property_text.Text = "name :" + name;
                            break;
                        case "url":
                            property_text.Text = "name :" + name;
                            break;
                        case "textbox":
                            property_text.Text = "name :" + name;
                            break;
                        case "button_button":
                            property_text.Text = "name :" + name;
                            break;
                        default:
                            break;
                    }
                }//通常時
                else if (flg == 5)
                {   //押されている
                    Control[] controls = Controls.Find(name, true);
                    foreach (Control control in controls)
                    {   //部品の削除処理
                        this.Controls.Remove(control);
                        control.Dispose();
                        dic.Remove(name);
                        addBodyCount--;
                        switch (getkind)
                        {
                            case "h1":
                                addH1Count--;
                                break;
                            case "p":
                                addPCount--;
                                break;
                            case "table":
                                addTableCount--;
                                break;
                            case "img":
                                addImgCount--;
                                break;
                            case "url":
                                addUrlCount--;
                                break;
                            case "textbox":
                                addTextboxCount--;
                                break;
                            case "button_button":
                                addButtonCount--;
                                break;
                            default:
                                break;
                        }
                    }
                }//flg==5
                else if (flg == 7)
                {
                    //入れ替え処理
                    switch (contflg)
                    {   //選択回数
                        //1回目
                        case 0:
                            name1 = name;   //一つ目の部品の名前を保持
                            ctrl1 = cont;   //部品のコントロールを保持
                            cont1 = flowLayoutPanel1.Controls.GetChildIndex(cont);  //部品のFlowLayoutPanelのインデックスを保持
                            contflg = 1;    //選択カウントを設定
                            break;
                        //二回目
                        case 1:
                            name2 = name;
                            ctrl2 = cont;   //二つ目の部品の名前を保持
                            cont2 = flowLayoutPanel1.Controls.GetChildIndex(cont);  //部品のFlowLayoutPanelのインデックスを保持
                            SwapControls(cont1, cont2, ctrl1, ctrl2);       //入れ替えメソッドの実行
                            contflg = 0;    //初期化
                            break;
                        default:
                            break;
                    }
                    replace_HTML(name1, name2);
                }//flg==7
            };
        }

        /*
         * 入れ替えボタン(在間くん)
         */
        private void button_swap_Click(object sender, EventArgs e)
        {
            flg = 7;
            ButtonVisible();
        }

        /*
         * 削除ボタン(在間くん)
         */
        private void button_delete_Click(object sender, EventArgs e)
        {
            flg = 5;
            ButtonVisible();
        }

        /*
         * 入れ替え処理メソッド(在間くん)
         */
        private void SwapControls(int x, int y, Control ctrl1, Control ctrl2)
        {
            flowLayoutPanel1.SuspendLayout();

            //入れ替え処理
            flowLayoutPanel1.Controls.SetChildIndex(ctrl1, y); //1個目に選択したもの
            flowLayoutPanel1.Controls.SetChildIndex(ctrl2, x); //2個目

            flowLayoutPanel1.ResumeLayout();
        }

        private void HTMLBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFile(this.FileName);
        }

        //チュートリアルボタン
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //在間くん作成プログラム統合部分-----------------------------------------------




    }
}
