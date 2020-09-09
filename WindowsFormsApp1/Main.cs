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
            //private string name = "";
            string result;//結果格納
            private bool Edited = false;
            string adress; //アドレスの相対パス
            string[] text_box = new string[10000]; //HTMLタグ格納用
            int cnt = 0; //タグ数カウント
            string sel; //選択した部品の名前を格納
            Boolean create_new = false; //新規作成判定フラグ
            Boolean HTML_flg = false;//ソースコード表示判定用

        //定義----------------------------------------------------------------

        //在間定義------------------------------------------------------------
        //画面フラグ
            bool parts_flg = false;
            bool open_flg = false; //ファイルを開くか判定
            public int flg = 0;
        //編集フラグ
            public int editflg = 0;
        //入れ替え部品
            public int contflg = 0;
            public int BCount1 = 0;
            public int BCount2 = 0;
            public int ItemCount1 = 0;
            public int ItemCount2 = 0;
            public Dictionary<String, int> dic = new Dictionary<string, int>();
            public Dictionary<int, String> OpenedTag = new Dictionary<int, string>();
            public Dictionary<int, String> OpenedName = new Dictionary<int, string>();

            public String name1 = "";
            public String name2 = "";
            public String title = "新規作成";

            public String[] csv1 = new String[0];
            public String[] csv2 = new String[0];
        //追加部品のカウント
            public int addHeadCount = 1;
            public int addBodyCount = 0;
            public int addHCount = 0;
            public int addDivCount = 0;
            public int addTableCount = 0;
            public int addImgCount = 0;
            public int addUrlCount = 0;
            public int addPCount = 0;
            public int addEmCount = 0;
            public int addBCount = 0;
            public int addOlCount = 0;
            public int addUlCount = 0;

        //入れ替え時のインデックス保持用
            public int cont1 = 0;
            public int cont2 = 0;
        //入れ替え時の部品コントロール保持用
            Control ctrl1;
            Control ctrl2;

        //作業状態系
            List<string> listTag = new List<string>();
            List<string> listName = new List<string>();
            List<string> listTitle = new List<string>();

        //ボタンイベントの有無
            public Boolean button_event = false;

            private String FilePath = Directory.GetCurrentDirectory();
        
        //在間定義------------------------------------------------------------


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
            this.Left = 180;
            this.Top = 15;
            
            try
            {
                //////////////////////////////////////////////////////////////////
                //---タグツリーグループのスクロール
                this.flowLayoutPanel_body.VerticalScroll.Visible = true;
                this.flowLayoutPanel_input.VerticalScroll.Visible = true;
                this.flowLayoutPanel_head.VerticalScroll.Visible = true;
                //---
                ToolTip tt = new ToolTip();
                tt.SetToolTip(button_html, "全体");
                tt.SetToolTip(button_head1, "<head>部分");
                tt.SetToolTip(button_body1, "<body>部分");

                //////////////////////////////////////////////////////////////////

                MessageBox.Show("まず新規作成でファイルを作成するか\n開くボタンでファイルを開いてください\n" +
                                "ファイルはデスクトップ上に作成されます");
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

                lvi = new ListViewItem("順序のあるリスト");
                lvi.ImageIndex = 5;
                partsList.Items.Add(lvi);

                lvi = new ListViewItem("順序のないリスト");
                lvi.ImageIndex = 6;
                partsList.Items.Add(lvi);

                lvi = new ListViewItem("画像");
                lvi.ImageIndex = 7;
                partsList.Items.Add(lvi);

                lvi = new ListViewItem("テーブル");
                lvi.ImageIndex = 8;
                partsList.Items.Add(lvi);
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
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }   
        }

        private void Start_Visible()
        {
          
            SaveButton.Visible = true; //上書き保存ボタン
            HTMLBtn.Visible = true; //ソースコード表示ボタン
            partsList.Visible = true; //部品リスト
            Title.Visible = true;  //タイトル
        }

        /*
         * ブラウザ内の情報を更新するインスタンスを呼び出す(かわが)
         */
        private void Result_Btn_Click(object sender, EventArgs e)
        {
            if (HTML_flg == true)
            {
                Browser_show();　//結果を画面上に表示
            }
        }

        /*
         * 相対パスでデスクトップを指定する
         */
        private string get_Path()
        {  
            return Directory.GetCurrentDirectory() + "\\HTML\\" + FileName;      
        }

        /*
         *HTMLを書き出すためのプログラム(かわが)
         */
        public void writer_html(string input, int flag)
        {
            try
            {
                String destinationPath = get_Path(); //相対パスで指定
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
                        if (text_box[i] != "-1")
                        {
                            writer.Write("<div class=\"" + (i + 1) + "\">\r\n" + text_box[i] + "\r\n</div>\r\n"); //HTMLコードを追加する
                        }
                    }
                    writer.Write("</body>\r\n");
                    writer.Write("</HTML>"); //HTML終了
                    writer.Close();
                }
                else if (flg == 1) //配列内のデータを初期化
                {
                    for (int i = 0; i <= cnt; i++)
                    {
                        text_box[cnt] = "";
                    }
                    writer = new System.IO.StreamWriter(destinationPath, false, System.Text.Encoding.UTF8);
                    writer.Write("");
                    cnt = 0;
                    writer.Close(); //閉じる
                }
            }
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
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
         *　終了がクリックされたとき 
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
            try
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
                    //SaveAsButton.Enabled = false;
                }
                else
                {
                    // 編集中
                    // 「名前を付けて保存」を有効
                    MenuItemFileSaveAs.Enabled = true;
                   // SaveAsButton.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
        }
        /*
         * 終了する前にデータが残っていたら確認する
         */
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
        }

        /*
         * HTMLファイルを開く
         */
        private void oepn_Btn_Click(object sender, EventArgs e)
        {
            
            MenuItemFileOpen_Click(sender, e);
            create_new = true;
            open_flg = true;
            Start_Visible();
        }
        /*
         * TEXTファイルからHTMLデータを生成
         */
        private void TEXTToHTML(string name)
        {
            try
            {
                cnt = 0;
                for (int i = 0; i < text_box.Length; i++)
                {
                    text_box[i] = "";
                }
                var filePath = name + "TEMP" + ".txt"; //HTMLフォルダ内のTEMPファイルをパスに設定

                // csvファイルの読込
                StreamReader reader = new StreamReader(File.OpenRead(filePath));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != "")
                    {
                        text_box[cnt] = line;
                        cnt++;
                    }
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
        }

        /*
         * ファイル新規作成
         */
        private void MenuItemFileNew_Click(object sender, EventArgs e)
        {
            try
            {
                FileName_Parts fnp = new FileName_Parts();
                if (!Edited)
                {
                    //テキストボックスの内容をクリア
                    HTMLBOX.Clear();
                    webBrowser1.Navigate("about:blank");
                    Reset();
                    // ファイル名（フルパス）
                    this.FileName = fnp.ShowMiniForm() + ".html"; //ファイル名を指定させる

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
                        html_delete();
                        // ファイル名（フルパス）
                        this.FileName = fnp.ShowMiniForm() + ".html"; //ファイル名を指定させる

                        //ファイル名保持
                        this.Text = ApplicationName + " - " + this.FileName;
                    }
                }
            }
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
        }

        /*
         *テキストファイルの内容をテキストボックスに格納する 
         */
        private void LoadFile(string value)
        {
            //UTF-8に変換してファイルを開く
            HTMLBOX.Text = System.IO.File.ReadAllText(value, Encoding.GetEncoding("UTF-8"));
            //this.FileName = value;
            UpdateStatus(FileName, false);
            MessageBox.Show(value);
            Browser_show();

        }

        private void LoadFile(string value, string name) {
            try
            {
                //変数の初期化
                Reset();
                Title.Text = "";
                // csvファイルのパス
                var filePath = Directory.GetCurrentDirectory() + "\\CSV\\" + name + ".csv";

                // csvファイルの読込
                StreamReader reader = new StreamReader(File.OpenRead(filePath));

                int tflg = 0;
                //CSVファイルから取得後、配列に入れる
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listTag.Add(values[0]);
                    listName.Add(values[1]);

                    //タイトルの取得
                    if (tflg == 0)
                    {
                        listTitle.Add(values[2]);
                        tflg++;
                    }
                }

                reader.Close();
                OpenProcess();
            }
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
            
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
            try
            {
                //UTF-8で保存
                System.IO.File.WriteAllText(value, HTMLBOX.Text, Encoding.GetEncoding("UTF-8"));

                // ファイル名を保持する
                this.FileName = value;
                String path = Directory.GetCurrentDirectory();
                //csv---
                var filePath = path + "\\CSV\\" + value + ".csv";   //パスは変える (作業ファイル名.csv)
                                                                    // csvに出力するデータ
                for (int i = 0; i < OpenedTag.Count; i++)
                {
                    Array.Resize(ref csv1, csv1.Length + 1);
                    Array.Resize(ref csv2, csv2.Length + 1);

                    csv1[i] = OpenedTag[i + 1];
                    csv2[i] = OpenedName[i + 1];
                }
                // csvファイルの書き込み
                StreamWriter file = new StreamWriter(filePath, false, Encoding.UTF8);
                for (int i = 0; i < csv1.Length; i++)
                {
                    if (i == 0)
                    {
                        file.WriteLine(string.Format("{0},{1},{2}", csv1[i], csv2[i], Title.Text)); //1-3にタイトルのテキストボックスの値を保存
                    }
                    else
                    {
                        file.WriteLine(string.Format("{0},{1}", csv1[i], csv2[i])); // データ部出力
                    }
                }
                file.Close();
                //---csv
                UpdateStatus(FileName, false);
            }
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
            

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
            OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\HTML\\";
            OpenFileDialog.FileName = "";
            if (DialogResult.OK == OpenFileDialog.ShowDialog())
            {
                // 「開く」ボタンがクリックされたとき
                FileName = OpenFileDialog.SafeFileName;
                LoadFile(OpenFileDialog.FileName);
                LoadFile(OpenFileDialog.FileName, FileName);
                TEXTToHTML(OpenFileDialog.FileName);

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
                html_delete();
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
            reset_cls();

        }
        private void reset_cls()
            {
                if (cnt > 0)
                {
                    
                    cnt--;
                    writer_html("", 0);
                    Browser_show(); //結果を画面上に表示
                }
            }

        /*
         * フォーム内のブラウザを更新する(かわが)
         */
        private void Browser_show()
        {
            String destinationPath = get_Path(); //相対パスで指定 (デスクトップに保存)
            //String destinationPath = FilePath + "\\HTML\\" + FileName;
            webBrowser1.Navigate(destinationPath);
        }

        /*
         *新規追加(かわが)
         */
        private void NewButton_Click(object sender, EventArgs e)
        {
            CheckFolder();
            MenuItemFileNew_Click(sender, e);
            html_delete();
            //title += "（変更あり）";
            Start_Visible();
            for (int i = 0; i < text_box.Length; i++)
            {
                text_box[i] = "";
            }
            create_new = true;
        }


        /*
         * HTMLソースコードを表示する(かわが)
         */
        private void HTML_show()
        {
            try
            {
                String destinationPath = get_Path(); //相対パスで指定 (デスクトップに保存)
                StreamReader st = new StreamReader(destinationPath, Encoding.GetEncoding("UTF-8")); //StreamReaderでファイルの内容を読み込む
                HTMLBOX.Text = st.ReadToEnd(); //streamReader内のテキストを書き込む
                st.Close();//終了
            }
            catch(Exception e)
            {
                
            }
        }
        /*
         * ソースコード表示ボタン制御(かわが)
         */
        private void HTMLBtn_Click(object sender, EventArgs e)
        {
                
                HTMLBtn.Visible = false;
                PreviewBtn.Visible = true;
                webBrowser1.Visible = false;
                HTMLBOX.Visible = true; //HTMLソースコード用のテキストボックスを有効化
                //HTMLBtn.Text = "プレビュー表示";
                if(create_new == true)
                {
                HTML_show(); //ソースコードを表示
            }
                
                //HTML_flg = true; //次回クリック時にブラウザ画面にもどる
            
           
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            
                HTMLBtn.Visible = true;
                PreviewBtn.Visible = false;
                webBrowser1.Visible = true;
                HTMLBOX.Visible = false;　//HTMLソースコード用のテキストボックスを無効化
                //HTMLBtn.Text = "ソースコード表示";
                //HTML_flg = false; //再びソースコード表示可にする
            
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
                if(result == "-1")
                {
                    parts_flg = true;
                    Browser_show();
                }
                else
                {
                    writer_html(result, 0);
                    parts_flg = false;
                    cnt++; //次の行へ
                }
            }

            if (sel == "2") //テキストの強調
            {
                result = ep.ShowMiniForm();
                if (result == "-1")
                {
                    parts_flg = true;
                }
                else
                {
                    writer_html(result, 0);
                    parts_flg = false;
                    cnt++; //次の行へ
                }
            }

            if (sel == "3") //ハイパーテキスト
            {
                result = hpp.ShowMiniForm();
                if (result == "-1")
                {
                    parts_flg = true;
                }
                else
                {
                    writer_html(result, 0);
                    parts_flg = false;
                    cnt++; //次の行へ
                }
                
            }

            if (sel == "7")　//画像
            {
                result = ip.ShowMiniForm();
                if (result == "-1")
                {
                    parts_flg = true;
                }
                else
                {
                    writer_html(result, 0);
                    parts_flg = false;
                    cnt++; //次の行へ
                }
            }

            if (sel == "5") //順序のあるリスト
            {
                result = op.ShowMiniForm();
                if (result == "-1")
                {
                    parts_flg = true;
                }
                else
                {
                    writer_html(result, 0);
                    parts_flg = false;
                    cnt++; //次の行へ
                }
             
            }

            if (sel == "6") //順序のないリスト
            {
                result = up.ShowMiniForm();
                if (result == "-1")
                {
                    parts_flg = true;
                }
                else
                {
                    writer_html(result, 0);
                    parts_flg = false;
                    cnt++; //次の行へ
                }
                
            }

            if (sel == "0") //見出し
            {
                result = hp.ShowMiniForm();
                if (result == "-1")
                {
                    parts_flg = true;
                }
                else
                {
                    writer_html(result, 0);
                    parts_flg = false;
                    cnt++; //次の行へ
                }
                
            }
            if (sel == "4") //太字
            {
                result = bp.ShowMiniForm();
                if (result == "-1")
                {
                    parts_flg = true;

                }
                else
                {
                    writer_html(result, 0);
                    parts_flg = false;
                    cnt++; //次の行へ
                }
            }

            if (sel == "8") //テーブル
            {
                result = tbp.ShowMiniForm();
                if (result == "-1")
                {
                    parts_flg = true;
                }
                writer_html(result, 0);
                parts_flg = false;
                cnt++; //次の行へ
            }

            if(parts_flg == false)
            {
                AddTag(int.Parse(Create_parts_num()));
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

            
        }

        //在間くん作成プログラム統合部分-----------------------------------------------

        private void Reset()
        {
            try
            {
                this.flowLayoutPanel_body.Controls.Clear();
                this.flowLayoutPanel_head.Controls.Clear();
                this.flowLayoutPanel_input.Controls.Clear();
                Title.Text = "";

                //画面フラグ
                flg = 0;
                //編集フラグ
                editflg = 0;
                //入れ替え部品
                contflg = 0;
                BCount1 = 0;
                BCount2 = 0;
                ItemCount1 = 0;
                ItemCount2 = 0;
                dic.Clear();
                OpenedTag.Clear();
                OpenedName.Clear();

                name1 = null;
                name2 = null;

                var list = new List<string>();
                list.AddRange(csv1);
                list.Clear();
                csv1 = list.ToArray();

                list.AddRange(csv2);
                list.Clear();
                csv2 = list.ToArray();

                //追加部品のカウント
                addHeadCount = 1;
                addBodyCount = 0;
                addHCount = 0;
                addPCount = 0;
                addTableCount = 0;
                addImgCount = 0;
                addUrlCount = 0;
                addPCount = 0;
                addEmCount = 0;
                addBCount = 0;
                addOlCount = 0;
                addUlCount = 0;

                //入れ替え時のインデックス保持用
                cont1 = 0;
                cont2 = 0;
                //作業状態系
                listTag.Clear();
                listName.Clear();
            }
            catch (Exception ex)
            {
                OutputErrorLog(ex);
            }

        }


        //タグツリーのボタン表示の切り替え
        public void ButtonVisible()
        {
            try
            {
                switch (flg)
                {
                    //HTMLボタン
                    case 0:
                        this.button_body2.Visible = false;
                        this.button_head1.Visible = true;
                        this.group_tag.Visible = true;
                        this.groupHead.Visible = false;
                        this.groupBody.Visible = false;
                        this.button_delete.Visible = false;
                        this.groupInput.Visible = false;
                        this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                        this.label2.BackColor = Color.FromArgb(238, 106, 34);
                        editflg = 0;
                        contflg = 0;
                        break;
                    //HEADボタン
                    case 1:
                        this.groupHead.Visible = true;
                        this.groupBody.Visible = false;
                        this.button_delete.Visible = false;
                        this.groupInput.Visible = false;
                        this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                        this.label2.BackColor = Color.FromArgb(238, 106, 34);
                        editflg = 0;
                        contflg = 0;
                        break;
                    //BODYボタン
                    case 2:
                        this.groupHead.Visible = false;
                        this.groupBody.Visible = true;
                        this.button_delete.Visible = false;
                        this.groupInput.Visible = false;
                        this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                        this.label2.BackColor = Color.FromArgb(238, 106, 34);
                        editflg = 0;
                        contflg = 0;
                        break;
                    //削除ボタン
                    case 5:

                        this.button_delete.Visible = true;
                        this.group_tag.BackColor = Color.FromName("Brown");
                        this.label2.BackColor = Color.FromName("Brown");
                        contflg = 0;
                        break;

                    //編集ボタン
                    case 6:
                        if (editflg == 0)
                        {
                            this.button_delete.Visible = true;
                        }
                        else
                        {
                            this.button_delete.Visible = false;
                        }
                        this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                        this.label2.BackColor = Color.FromArgb(238, 106, 34);
                        contflg = 0;
                        break;
                    //入れ替え
                    case 7:
                        this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                        this.label2.BackColor = Color.FromArgb(238, 106, 34);
                        break;
                    //例外
                    default:
                        this.group_tag.Visible = true;
                        this.groupHead.Visible = false;
                        this.groupBody.Visible = false;
                        this.groupInput.Visible = false;
                        this.button_delete.Visible = false;
                        this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                        this.label2.BackColor = Color.FromArgb(238, 106, 34);
                        editflg = 0;
                        contflg = 0;
                        break;

                }
            }
            catch (Exception ex)
            {
                OutputErrorLog(ex);
            }

        }

        //---タグツリーのHEADボタン処理
        private void button_head1_Click_1(object sender, EventArgs e)
        {
            if (flg == 5)
            {
                flg = 1;
                ButtonVisible();
                flg = 5;
                ButtonVisible();
            }
            else
            {
                flg = 1;
                ButtonVisible();
            }
        }

       
        //---

        //---タグツリーのタグツリーのBODYボタン処理
        private void button_body1_Click_1(object sender, EventArgs e)
        {
            if (flg == 5)
            {
                flg = 2;
                button_head1.Visible = false;
                button_body2.Visible = true;
                ButtonVisible();
                flg = 5;
                ButtonVisible();
            }
            else
            {
                flg = 2;
                button_head1.Visible = false;
                button_body2.Visible = true;
                ButtonVisible();
            }
        }

        private void button_body2_Click_1(object sender, EventArgs e)
        {
            if (flg == 5)
            {
                flg = 2;
                button_head1.Visible = false;
                button_body2.Visible = true;
                ButtonVisible();
                flg = 5;
                ButtonVisible();
            }
            else
            {
                flg = 2;
                button_head1.Visible = false;
                button_body2.Visible = true;
                ButtonVisible();
            }
        }
        //---

        //---タグツリーのHTMLボタン処理
        private void button_html_Click_1(object sender, EventArgs e)
        {
            flg = 0;
            ButtonVisible();
        }
        //---

        //Formロード時処理
        //上で定義済み
        //---

        //部品一覧の部品選択時の処理
        //上で定義済み
        //---

        //---編集ボタンを押したとき
        private void button_edit_Click(object sender, EventArgs e)
        {
            if (editflg == 0)
            {
                flg = 6;
                ButtonVisible();
                editflg = 1;
            }
            else
            {
                flg = 6;
                ButtonVisible();
                editflg = 0;
            }
        }
        //---

        //---動的ボタンのイベント(引数：部品名、部品の種類、追加カウント、アイテムカウント、部品)
        private EventHandler btnclick(String name, String getkind, int BodyCount, int itemCount, Control cont)
        {
            return delegate (object sender2, EventArgs e2)
            {
                try
                {
                    if (flg != 6 && flg != 5 && flg != 7)
                    {   //通常時の処理
                        switch (getkind)
                        {
                            //プロパティ系
                            case "h":
                                label_pro.Text = "見出しです";
                                break;
                            case "p":
                                label_pro.Text = "テキストです";
                                break;
                            case "em":
                                label_pro.Text = "強調されて表示します";
                                break;
                            case "url"://urlの編集がしたい
                                label_pro.Text = "指定したサイトが開きます";
                                break;
                            case "b":
                                label_pro.Text = "太字で表示します";
                                break;
                            case "lo":
                                label_pro.Text = "順序なしリストです";
                                break;
                            case "ul":
                                label_pro.Text = "順序ありリストです";
                                break;
                            case "img":
                                label_pro.Text = "指定した画像を表示します";
                                break;
                            case "table":
                                label_pro.Text = "テーブルです";
                                break;
                            default:
                                break;
                        }

                    }//通常時
                    else if (flg == 6)   //編集時
                    {
                        ButtonVisible();

                    }//flg==6編集時
                    /*else if (flg == 5)
                    {   //削除ボタン
                        Control[] controls = Controls.Find(name, true);
                        foreach (Control control in controls)
                        {   //部品の削除処理
                            this.Controls.Remove(control);
                            OpenedName.Remove(dic[name]);
                            OpenedTag.Remove(dic[name]);
                            dic.Remove(name);
                            control.Dispose();
                            reset_cls();
                        }

                    }//flg==5削除
                    */
                    /*else if (flg == 7)
                    {//bodyグループ入れ替え処理
                        switch (contflg)
                        {   //選択回数
                            //1回目
                            case 0:
                                name1 = name;   //一つ目の部品の名前を保持
                                ctrl1 = cont;   //部品のコントロールを保持
                                cont1 = flowLayoutPanel_body.Controls.GetChildIndex(cont);  //Body部品のFlowLayoutPanelのインデックスを保持
                                contflg = 1;    //選択カウントを設定
                                break;
                            //二回目
                            case 1:
                                ctrl2 = cont;   //二つ目の部品の名前を保持
                                cont2 = flowLayoutPanel_body.Controls.GetChildIndex(cont);  //Body部品のFlowLayoutPanelのインデックスを保持
                                SwapControls(cont1, cont2, ctrl1, ctrl2);       //入れ替えメソッドの実行
                                contflg = 0;    //初期化
                                break;
                            default:
                                break;
                        }
                    }//flg==7入れ替え
                    */
                }
                catch (Exception ex)
                {
                    OutputErrorLog(ex);
                }
            };
        }
        //---

        //削除ボタン
        private void button_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                flg = 5;
                int count = flowLayoutPanel_body.Controls.Count;
                if (count != 0)
                {
                    dic.Remove(OpenedName[count]);
                    OpenedName.Remove(count);
                    OpenedTag.Remove(count);
                    flowLayoutPanel_body.Controls.RemoveAt(count - 1);
                    reset_cls();
                }
            }
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
            
        }
        //---

        //入れ替えボタン
        private void button_swap_Click_1(object sender, EventArgs e)
        {
            flg = 7;
            ButtonVisible();
        }
        //---

        //---入れ替え処理メソッド
        /*private void SwapControls(int x, int y, Control ctrl1, Control ctrl2)
        {
            try
            {
                flowLayoutPanel_body.SuspendLayout();
                flowLayoutPanel_body.Controls.SetChildIndex(ctrl1, y);
                flowLayoutPanel_body.Controls.SetChildIndex(ctrl2, x);
                flowLayoutPanel_body.ResumeLayout();

                //csv用入れ替え
                x++;
                y++;
                var tmp = OpenedTag[x];
                OpenedTag[x] = OpenedTag[y];
                OpenedTag[y] = tmp;
                //csv用入れ替え
                tmp = OpenedName[x];
                OpenedName[x] = OpenedName[y];
                OpenedName[y] = tmp;
            }
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
        }
        //---
        */
        
        //作業ファイルを開いたときの処理
        private void OpenProcess()
        {
            try
            {
                Title.Text = listTitle[0];
                int lc = 0;
                while (lc != listTag.Count)
                {
                    //読み込んだcsvファイルを元にタグツリーの部品の生成
                    switch (listTag[lc])
                    {
                        //
                        case "h":
                            AddTag(0, listName[lc]);
                            break;
                        case "p":
                            AddTag(1, listName[lc]);
                            break;
                        case "em":
                            AddTag(2, listName[lc]);
                            break;
                        case "url":
                            AddTag(3, listName[lc]);
                            break;
                        case "b":
                            AddTag(4, listName[lc]);
                            break;
                        case "ol":
                            AddTag(5, listName[lc]);
                            break;
                        case "ul":
                            AddTag(6, listName[lc]);
                            break;
                        case "img":
                            AddTag(7, listName[lc]);
                            break;
                        case "table":
                            AddTag(8, listName[lc]);
                            break;
                    }
                    lc++;
                }
            }
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
        }

        //タグツリーの部品追加処理（通常時）
        private void AddTag(int Index)
        {
            try
            {
                //タグツリーのBODYグループに部品のボタンを追加
                switch (Index)
                {
                    //見出し
                    case 0:
                        addHCount++;                                                                   //見出し個数のカウント
                        Button button_h = new Button();                                                //新規ボタンのインスタンス                    //ボタンの配置場所の設定
                        button_h.Size = new Size(122, 54);                                             //ボタンのサイズ
                        button_h.ForeColor = Color.FromArgb(90, 92, 79);                               //ボタンの文字色の設定
                        button_h.BackColor = Color.FromArgb(211, 214, 195);                              //ボタンの背景色の設定
                        button_h.FlatStyle = FlatStyle.Flat;                                           //枠のスタイルの設定
                        button_h.FlatAppearance.BorderSize = 0;                                        //枠なしに設定
                        button_h.Text = "<H>";                                                        //ボタンのテキスト
                        button_h.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);                  //フォントの設定
                        button_h.Name = "h_" + addHCount;                                            //ボタンのNameの設定
                        flowLayoutPanel_body.Controls.Add(button_h);
                        addBodyCount++;                                                                 //BODYの個数のカウント
                        dic.Add(button_h.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "h");
                        OpenedName.Add(addBodyCount, button_h.Name.ToString());
                        button_h.Click += btnclick(button_h.Name, "h", dic[button_h.Name], addHCount, button_h);                  //追加したボタンにイベントを追加
                        break;
                    //テキスト
                    case 1:
                        addPCount++;
                        Button button_p = new Button();
                        button_p.Size = new Size(122, 54);
                        button_p.ForeColor = Color.FromArgb(90, 92, 79);
                        button_p.BackColor = Color.FromArgb(211, 214, 195);
                        button_p.FlatStyle = FlatStyle.Flat;
                        button_p.FlatAppearance.BorderSize = 0;
                        button_p.Text = "<P>";
                        button_p.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_p.Name = "p_" + addPCount;
                        flowLayoutPanel_body.Controls.Add(button_p);
                        addBodyCount++;
                        dic.Add(button_p.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "p");
                        OpenedName.Add(addBodyCount, button_p.Name.ToString());
                        button_p.Click += btnclick(button_p.Name, "p", dic[button_p.Name], addPCount, button_p);
                        break;
                    //強調
                    case 2:
                        addEmCount++;
                        Button button_em = new Button();
                        button_em.Size = new Size(122, 54);
                        button_em.ForeColor = Color.FromArgb(90, 92, 79);
                        button_em.BackColor = Color.FromArgb(211, 214, 195);
                        button_em.FlatStyle = FlatStyle.Flat;
                        button_em.FlatAppearance.BorderSize = 0;
                        button_em.Text = "<EM>";
                        button_em.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_em.Name = "em_" + addTableCount;
                        flowLayoutPanel_body.Controls.Add(button_em);
                        addBodyCount++;
                        dic.Add(button_em.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "em");
                        OpenedName.Add(addBodyCount, button_em.Name.ToString());
                        button_em.Click += btnclick(button_em.Name, "em", dic[button_em.Name], addTableCount, button_em);
                        break;
                    //ハイパーテキスト
                    case 3:
                        addUrlCount++;
                        Button button_url = new Button();
                        button_url.Size = new Size(122, 54);
                        button_url.ForeColor = Color.FromArgb(90, 92, 79);
                        button_url.BackColor = Color.FromArgb(211, 214, 195);
                        button_url.FlatStyle = FlatStyle.Flat;
                        button_url.FlatAppearance.BorderSize = 0;
                        button_url.Text = "<URL>";
                        button_url.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_url.Name = "url_" + addImgCount;
                        flowLayoutPanel_body.Controls.Add(button_url);
                        addBodyCount++;
                        dic.Add(button_url.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "url");
                        OpenedName.Add(addBodyCount, button_url.Name.ToString());
                        button_url.Click += btnclick(button_url.Name, "url", dic[button_url.Name], addImgCount, button_url);
                        break;
                    //太字
                    case 4:
                        addBCount++;
                        Button button_b = new Button();
                        button_b.Size = new Size(122, 54);
                        button_b.ForeColor = Color.FromArgb(90, 92, 79);
                        button_b.BackColor = Color.FromArgb(211, 214, 195);
                        button_b.FlatStyle = FlatStyle.Flat;
                        button_b.FlatAppearance.BorderSize = 0;
                        button_b.Text = "<B>";
                        button_b.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_b.Name = "b_" + addBCount;
                        flowLayoutPanel_body.Controls.Add(button_b);
                        addBodyCount++;
                        dic.Add(button_b.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "b");
                        OpenedName.Add(addBodyCount, button_b.Name.ToString());
                        button_b.Click += btnclick(button_b.Name, "b", dic[button_b.Name], addBCount, button_b);
                        break;
                    //順序ありリスト
                    case 5:
                        addOlCount++;
                        Button button_ol = new Button();
                        button_ol.Size = new Size(122, 54);
                        button_ol.ForeColor = Color.FromArgb(90, 92, 79);
                        button_ol.BackColor = Color.FromArgb(211, 214, 195);
                        button_ol.FlatStyle = FlatStyle.Flat;
                        button_ol.FlatAppearance.BorderSize = 0;
                        button_ol.Text = "<OL>";
                        button_ol.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_ol.Name = "ol_" + addOlCount;
                        flowLayoutPanel_body.Controls.Add(button_ol);
                        dic.Add(button_ol.Name, addBodyCount);
                        addBodyCount++;
                        OpenedTag.Add(addBodyCount, "ol");
                        OpenedName.Add(addBodyCount, button_ol.Name.ToString());
                        button_ol.Click += btnclick(button_ol.Name, "ol", dic[button_ol.Name], addOlCount, button_ol);
                        break;
                    //順序なしリスト
                    case 6:
                        addUlCount++;
                        Button button_ul = new Button();
                        button_ul.Size = new Size(122, 54);
                        button_ul.ForeColor = Color.FromArgb(90, 92, 79);
                        button_ul.BackColor = Color.FromArgb(211, 214, 195);
                        button_ul.FlatStyle = FlatStyle.Flat;
                        button_ul.FlatAppearance.BorderSize = 0;
                        button_ul.Text = "<UL>";
                        button_ul.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_ul.Name = "ul_" + addUlCount;
                        flowLayoutPanel_body.Controls.Add(button_ul);
                        dic.Add(button_ul.Name, addBodyCount);
                        addBodyCount++;
                        OpenedTag.Add(addBodyCount, "ul");
                        OpenedName.Add(addBodyCount, button_ul.Name.ToString());
                        button_ul.Click += btnclick(button_ul.Name, "ul", dic[button_ul.Name], addUlCount, button_ul);
                        break;
                    //画像
                    case 7:
                        addImgCount++;
                        Button button_img = new Button();
                        button_img.Size = new Size(122, 54);
                        button_img.ForeColor = Color.FromArgb(90, 92, 79);
                        button_img.BackColor = Color.FromArgb(211, 214, 195);
                        button_img.FlatStyle = FlatStyle.Flat;
                        button_img.FlatAppearance.BorderSize = 0;
                        button_img.Text = "<IMG>";
                        button_img.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_img.Name = "img_" + addImgCount;
                        flowLayoutPanel_body.Controls.Add(button_img);
                        addBodyCount++;
                        dic.Add(button_img.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "img");
                        OpenedName.Add(addBodyCount, button_img.Name.ToString());
                        button_img.Click += btnclick(button_img.Name, "img", dic[button_img.Name], addImgCount, button_img);
                        break;

                    //テーブル
                    case 8:
                        Button button_table = new Button();
                        button_table.Size = new Size(122, 54);
                        button_table.ForeColor = Color.FromArgb(90, 92, 79);
                        button_table.BackColor = Color.FromArgb(211, 214, 195);
                        button_table.FlatStyle = FlatStyle.Flat;
                        button_table.FlatAppearance.BorderSize = 0;
                        button_table.Text = "<TABLE>";
                        button_table.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_table.Name = "table_" + addTableCount;
                        flowLayoutPanel_body.Controls.Add(button_table);
                        addBodyCount++;
                        dic.Add(button_table.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "table");
                        OpenedName.Add(addBodyCount, button_table.Name.ToString());
                        button_table.Click += btnclick(button_table.Name, "table", dic[button_table.Name], addTableCount, button_table);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                OutputErrorLog(ex);
            }

        }
        //タグツリーの部品追加処理（作業ファイルを開いたとき）
        private void AddTag(int Index, String name)
        {
            try
            {
                //タグツリーのBODYグループに部品のボタンを追加
                switch (Index)
                {
                    //見出し
                    case 0:
                        addHCount++;                                                                   //見出し個数のカウント
                        Button button_h = new Button();                                                //新規ボタンのインスタンス                    //ボタンの配置場所の設定
                        button_h.Size = new Size(122, 54);                                             //ボタンのサイズ
                        button_h.ForeColor = Color.FromArgb(90, 92, 79);                               //ボタンの文字色の設定
                        button_h.BackColor = Color.FromArgb(211, 214, 195);                            //ボタンの背景色の設定
                        button_h.FlatStyle = FlatStyle.Flat;                                           //枠のスタイルの設定
                        button_h.FlatAppearance.BorderSize = 0;                                        //枠なしに設定
                        button_h.Text = "<H>";                                                        //ボタンのテキスト
                        button_h.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);                  //フォントの設定
                        button_h.Name = name;                                                          //ボタンのNameの設定
                        flowLayoutPanel_body.Controls.Add(button_h);
                        addBodyCount++;                                                                 //BODYの個数のカウント
                        dic.Add(button_h.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "h");
                        OpenedName.Add(addBodyCount, button_h.Name.ToString());
                        button_h.Click += btnclick(button_h.Name, "h", dic[button_h.Name], addHCount, button_h);                  //追加したボタンにイベントを追加
                        break;
                    //テキスト
                    case 1:
                        addPCount++;
                        Button button_p = new Button();
                        button_p.Size = new Size(122, 54);
                        button_p.ForeColor = Color.FromArgb(90, 92, 79);
                        button_p.BackColor = Color.FromArgb(211, 214, 195);
                        button_p.FlatStyle = FlatStyle.Flat;
                        button_p.FlatAppearance.BorderSize = 0;
                        button_p.Text = "<P>";
                        button_p.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_p.Name = name;
                        flowLayoutPanel_body.Controls.Add(button_p);
                        addBodyCount++;
                        dic.Add(button_p.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "p");
                        OpenedName.Add(addBodyCount, button_p.Name.ToString());
                        button_p.Click += btnclick(button_p.Name, "p", dic[button_p.Name], addPCount, button_p);
                        break;
                    //強調
                    case 2:
                        addEmCount++;
                        Button button_em = new Button();
                        button_em.Size = new Size(122, 54);
                        button_em.ForeColor = Color.FromArgb(90, 92, 79);
                        button_em.BackColor = Color.FromArgb(211, 214, 195);
                        button_em.FlatStyle = FlatStyle.Flat;
                        button_em.FlatAppearance.BorderSize = 0;
                        button_em.Text = "<EM>";
                        button_em.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_em.Name = name;
                        flowLayoutPanel_body.Controls.Add(button_em);
                        addBodyCount++;
                        dic.Add(button_em.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "em");
                        OpenedName.Add(addBodyCount, button_em.Name.ToString());
                        button_em.Click += btnclick(button_em.Name, "em", dic[button_em.Name], addEmCount, button_em);
                        break;
                    //ハイパーテキスト
                    case 3:
                        addUrlCount++;
                        Button button_url = new Button();
                        button_url.Size = new Size(122, 54);
                        button_url.ForeColor = Color.FromArgb(90, 92, 79);
                        button_url.BackColor = Color.FromArgb(211, 214, 195);
                        button_url.FlatStyle = FlatStyle.Flat;
                        button_url.FlatAppearance.BorderSize = 0;
                        button_url.Text = "<URL>";
                        button_url.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_url.Name = name;
                        flowLayoutPanel_body.Controls.Add(button_url);
                        addBodyCount++;
                        dic.Add(button_url.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "url");
                        OpenedName.Add(addBodyCount, button_url.Name.ToString());
                        button_url.Click += btnclick(button_url.Name, "url", dic[button_url.Name], addUrlCount, button_url);
                        break;
                    //太字
                    case 4:
                        addBCount++;
                        Button button_b = new Button();
                        button_b.Size = new Size(122, 54);
                        button_b.ForeColor = Color.FromArgb(90, 92, 79);
                        button_b.BackColor = Color.FromArgb(211, 214, 195);
                        button_b.FlatStyle = FlatStyle.Flat;
                        button_b.FlatAppearance.BorderSize = 0;
                        button_b.Text = "<B>";
                        button_b.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_b.Name = name;
                        flowLayoutPanel_body.Controls.Add(button_b);
                        addBodyCount++;
                        dic.Add(button_b.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "b");
                        OpenedName.Add(addBodyCount, button_b.Name.ToString());
                        button_b.Click += btnclick(button_b.Name, "b", dic[button_b.Name], addBCount, button_b);
                        break;
                    //順序ありリスト
                    case 5:
                        addOlCount++;
                        Button button_ol = new Button();
                        button_ol.Size = new Size(122, 54);
                        button_ol.ForeColor = Color.FromArgb(90, 92, 79);
                        button_ol.BackColor = Color.FromArgb(211, 214, 195);
                        button_ol.FlatStyle = FlatStyle.Flat;
                        button_ol.FlatAppearance.BorderSize = 0;
                        button_ol.Text = "<OL>";
                        button_ol.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_ol.Name = name;
                        flowLayoutPanel_body.Controls.Add(button_ol);
                        dic.Add(button_ol.Name, addBodyCount);
                        addBodyCount++;
                        OpenedTag.Add(addBodyCount, "ol");
                        OpenedName.Add(addBodyCount, button_ol.Name.ToString());
                        button_ol.Click += btnclick(button_ol.Name, "ol", dic[button_ol.Name], addOlCount, button_ol);
                        break;
                    //順序なしリスト
                    case 6:
                        addUlCount++;
                        Button button_ul = new Button();
                        button_ul.Size = new Size(122, 54);
                        button_ul.ForeColor = Color.FromArgb(90, 92, 79);
                        button_ul.BackColor = Color.FromArgb(211, 214, 195);
                        button_ul.FlatStyle = FlatStyle.Flat;
                        button_ul.FlatAppearance.BorderSize = 0;
                        button_ul.Text = "<UL>";
                        button_ul.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_ul.Name = name;
                        flowLayoutPanel_body.Controls.Add(button_ul);
                        dic.Add(button_ul.Name, addBodyCount);
                        addBodyCount++;
                        OpenedTag.Add(addBodyCount, "ul");
                        OpenedName.Add(addBodyCount, button_ul.Name.ToString());
                        button_ul.Click += btnclick(button_ul.Name, "ul", dic[button_ul.Name], addUlCount, button_ul);
                        break;
                    //画像
                    case 7:
                        addImgCount++;
                        Button button_img = new Button();
                        button_img.Size = new Size(122, 54);
                        button_img.ForeColor = Color.FromArgb(90, 92, 79);
                        button_img.BackColor = Color.FromArgb(211, 214, 195);
                        button_img.FlatStyle = FlatStyle.Flat;
                        button_img.FlatAppearance.BorderSize = 0;
                        button_img.Text = "<IMG>";
                        button_img.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_img.Name = name;
                        flowLayoutPanel_body.Controls.Add(button_img);
                        addBodyCount++;
                        dic.Add(button_img.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "img");
                        OpenedName.Add(addBodyCount, button_img.Name.ToString());
                        button_img.Click += btnclick(button_img.Name, "img", dic[button_img.Name], addImgCount, button_img);
                        break;

                    //テーブル
                    case 8:
                        Button button_table = new Button();
                        button_table.Size = new Size(122, 54);
                        button_table.ForeColor = Color.FromArgb(90, 92, 79);
                        button_table.BackColor = Color.FromArgb(211, 214, 195);
                        button_table.FlatStyle = FlatStyle.Flat;
                        button_table.FlatAppearance.BorderSize = 0;
                        button_table.Text = "<TABLE>";
                        button_table.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                        button_table.Name = name;
                        flowLayoutPanel_body.Controls.Add(button_table);
                        addBodyCount++;
                        dic.Add(button_table.Name, addBodyCount);
                        OpenedTag.Add(addBodyCount, "table");
                        OpenedName.Add(addBodyCount, button_table.Name.ToString());
                        button_table.Click += btnclick(button_table.Name, "table", dic[button_table.Name], addTableCount, button_table);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                OutputErrorLog(ex);
            }

        }

        //ログ出力
        private void OutputErrorLog(Exception ex)
        {
            // 書き込み設定
            System.IO.StreamWriter sw = new StreamWriter(
             this.FilePath + "\\log\\errorlog_" + DateTime.Now.ToString("yyyyMMdd") + ".txt",   // 出力先ファイル名
             true,                                                           // 追加書き込み
             System.Text.Encoding.GetEncoding("UTF-8"));                 // 文字コード

            // ログ出力
            //sw.SetOut(sw); // 出力先（Outプロパティ）を設定
            sw.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] message: " + ex.Message);
            sw.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] stack trace: " + ex.StackTrace);
            sw.WriteLine(ex.StackTrace);
            sw.WriteLine();

            // ファイルを閉じる
            sw.Dispose();
        }

        //フォルダの存在チェック　なければ作成
        private void CheckFolder()
        {
            try
            {
                if (File.Exists(FilePath + "\\HTML") == false)
                {
                    Directory.CreateDirectory(FilePath + "\\HTML");
                }
                if (File.Exists(FilePath + "\\CSV") == false)
                {
                    Directory.CreateDirectory(FilePath + "\\CSV");
                }
                if (File.Exists(FilePath + "\\log") == false)
                {
                    Directory.CreateDirectory(FilePath + "\\log");
                }
            }
            catch(Exception ex)
            {
                OutputErrorLog(ex);
            }
            
        }

        //在間くん作成プログラム統合部分-----------------------------------------------

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFile(this.FileName);
            SaveToTEXT(this.FileName);
        }

        private void SaveToTEXT(string fn)
        {
            string path = Directory.GetCurrentDirectory() + "\\HTML\\" + fn + "TEMP" + ".txt"; 
            StreamWriter file = new StreamWriter(path, false, Encoding.UTF8);
            for (int i = 0; i < text_box.Length ; i++)
            {
                file.WriteLine(string.Format("{0}", text_box[i]));

            }
            file.Close();
        }

        private Tutorial_Parts tuto = null;
        //チュートリアルボタン
        private void button1_Click(object sender, EventArgs e)
        {
            //フォームが表示されているかの判定  
            if (this.tuto == null || this.tuto.IsDisposed)
                this.tuto = new Tutorial_Parts(this);

            //チュートリアルは起動済みか判定
            if (!this.tuto.Visible)
            {
                //起動していない…チュートリアルを起動
                Tutorial_Parts tuto = new Tutorial_Parts(this);
                this.tuto.Show();
            }
            else
            {
                //起動済み…メッセージ表示
                MessageBox.Show("すでにチュートリアルを起動しています");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void html_delete()
        {
            //CSVが保存されていない場合の処理
            if (File.Exists(this.FilePath + "\\CSV\\" + FileName) == false)
            {
                webBrowser1.Navigate("about:blank");
                Reset();
                //File.Delete(this.FilePath + "\\HTML\\" + FileName);          //新規作成したHTMLを破棄する
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
