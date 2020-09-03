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
        private string name = "";
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
        public Dictionary<String, String> dic2 = new Dictionary<string, string>() { { "", "" } };
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
        public int addH1Count = 0;
        public int addDivCount = 0;
        public int addTableCount = 0;
        public int addImgCount = 0;
        public int addUrlCount = 0;
        public int addTextboxCount = 0;
        public int addButtonCount = 0;
        public int addNavCount = 0;
        public int addInputCount = 1;
        public int addSmallCount = 0;
        public int addLinkCount = 0;
        public int inputedCount = 1;

        //inputタグのフラグ
        public int inputflg = 0;
        public int inputedflg = 0;
        public int inputeditflg = 0;

        //入れ替え時のインデックス保持用
        public int cont1 = 0;
        public int cont2 = 0;
        //入れ替え時の部品コントロール保持用
        Control ctrl1;
        Control ctrl2;

        //作業状態系
        List<string> listTag = new List<string>();
        List<string> listName = new List<string>();

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

        private void Start_Visible()
        {
            SaveAsButton.Visible = true; //名前を付けて保存ボタン
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
            String destinationPath = get_Path(); //相対パスで指定
            if (flag == 0) //配列にデータを追加する
            {
                MessageBox.Show(cnt.ToString());
                text_box[cnt] = input;
                writer = new System.IO.StreamWriter(destinationPath, false, System.Text.Encoding.UTF8);
                writer.Write("<DOCTYPE! HTML>\r\n");
                writer.Write("<HTML>\r\n"); //HTML開始
                writer.Write("<head>\r\n" + "<title>" + Title.Text + "</title>\r\n</head>\r\n"); //タイトルの定義
                writer.Write("<body>\r\n");
                for (int i = 0; i <= cnt; i++)
                {
                    if(text_box[i] != "-1")
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
            create_new = true;
            open_flg = true;
            Start_Visible();
        }
        /*
         * TEXTファイルからHTMLデータを生成
         */
        private void TEXTToHTML(string name)
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
                MessageBox.Show(line);
                text_box[cnt] = line;
                cnt++;
            }
        }

        /*
         * ファイル新規作成
         */
        private void MenuItemFileNew_Click(object sender, EventArgs e)
        {
            FileName_Parts fnp = new FileName_Parts();
            if (!Edited)
            {
                //テキストボックスの内容をクリア
                HTMLBOX.Clear();
                // ファイル名（フルパス）
                this.FileName = fnp.ShowMiniForm() + ".html";　//ファイル名を指定させる

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
                    this.FileName = fnp.ShowMiniForm() + ".html"; //ファイル名を指定させる

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
            //this.FileName = value;
            UpdateStatus(FileName, false);
            MessageBox.Show(value);
            Browser_show();

        }

        private void LoadFile(string value, string name) {
            //変数の初期化
            Reset();

            //統合時関係ないかも
            /*openFileDialog1.Filter = "CSVファイル | *.csv";
            openFileDialog1.InitialDirectory = @"C:\Users\s3a2\Desktop";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            title = openFileDialog1.SafeFileName;
            */
            //---

            // csvファイルのパス
            //var filePath = openFileDialog1.FileName;
            var filePath = Directory.GetCurrentDirectory() + "\\CSV\\" + name + ".csv";

            // csvファイルの読込
            StreamReader reader = new StreamReader(File.OpenRead(filePath));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                listTag.Add(values[0]);
                listName.Add(values[1]);

            }

            reader.Close();
            OpenProcess();
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
            String path = Directory.GetCurrentDirectory();
            //csv---
            var filePath = path + "\\CSV\\" + value + ".csv";   //パスは変える (作業ファイル名.csv)
            // csvに出力するデータ
            for (int i = 0; i < OpenedTag.Count; i++)
            {
                int keyflag = 0;
                Array.Resize(ref csv1, csv1.Length + 1);
                Array.Resize(ref csv2, csv2.Length + 1);
                foreach (var key in OpenedTag.Keys)
                {
                    if (addLinkCount > 0)
                    {
                        keyflag = 1;
                        int tmp = i;
                        i += 1000;
                        csv1[i - 1000] = OpenedTag[i];
                        csv2[i - 1000] = OpenedName[i];
                        i = tmp;
                        addLinkCount--;
                        break;
                    }
                }
                if (keyflag == 0)
                {
                    csv1[i] = OpenedTag[i+1];
                    csv2[i] = OpenedName[i+1];
                }
                else
                {
                    keyflag = 0;
                }

            }
            // csvファイルの書き込み
            StreamWriter file = new StreamWriter(filePath, false, Encoding.UTF8);
            for (int i = 0; i < csv1.Length; i++)

                file.WriteLine(string.Format("{0},{1}", csv1[i], csv2[i])); // データ部出力


            file.Close();
            //---csv
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
            MenuItemFileNew_Click(sender, e);
            //title += "（変更あり）";
            Start_Visible();
            create_new = true;
        }


        /*
         * HTMLソースコードを表示する(かわが)
         */
        private void HTML_show()
        {
            
                String destinationPath = get_Path(); //相対パスで指定 (デスクトップに保存)
                StreamReader st = new StreamReader(destinationPath, Encoding.GetEncoding("UTF-8")); //StreamReaderでファイルの内容を読み込む
                HTMLBOX.Text = st.ReadToEnd(); //streamReader内のテキストを書き込む
                st.Close();//終了
            
       
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
                HTML_show(); //ソースコードを表示
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
            AddTag(int.Parse(Create_parts_num()));
            UpdateStatus(FileName, true); //変更あり状態に変更する

            
        }

        //在間くん作成プログラム統合部分-----------------------------------------------
        
        private void Reset()
        {
            this.flowLayoutPanel_body.Controls.Clear();
            this.flowLayoutPanel_head.Controls.Clear();
            this.flowLayoutPanel_input.Controls.Clear();

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
            dic2.Clear();
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
            addH1Count = 0;
            addDivCount = 0;
            addTableCount = 0;
            addImgCount = 0;
            addUrlCount = 0;
            addTextboxCount = 0;
            addButtonCount = 0;
            addNavCount = 0;
            addInputCount = 1;
            addSmallCount = 0;
            addLinkCount = 0;
            inputedCount = 1;

            //inputタグのフラグ
            inputflg = 0;
            inputedflg = 0;
            inputeditflg = 0;

            //入れ替え時のインデックス保持用
            cont1 = 0;
            cont2 = 0;
            //作業状態系
            listTag.Clear();
            listName.Clear();

            //ボタンイベントの有無
            button_event = false;

        }


        //タグツリーのボタン表示の切り替え
        public void ButtonVisible()
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
                    this.button_swap.Visible = false;
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
                    this.button_swap.Visible = false;
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
                    this.button_swap.Visible = false;
                    this.groupInput.Visible = false;
                    this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                    this.label2.BackColor = Color.FromArgb(238, 106, 34);
                    editflg = 0;
                    contflg = 0;
                    break;
                //削除ボタン
                case 5:
                    if (inputeditflg == 1)
                    {
                        break;
                    }
                    else
                    {
                        this.groupHead.Visible = false;
                        this.groupBody.Visible = true;
                        this.groupInput.Visible = false;
                        this.group_tag.BackColor = Color.FromName("Brown");
                        this.label2.BackColor = Color.FromName("Brown");
                        contflg = 0;
                        break;
                    }
                //編集ボタン
                case 6:
                    this.button_delete.Visible = true;
                    this.button_swap.Visible = true;
                    this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                    this.label2.BackColor = Color.FromArgb(238, 106, 34);
                    contflg = 0;
                    break;
                //入れ替え
                case 7:
                    this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                    this.label2.BackColor = Color.FromArgb(238, 106, 34);
                    break;
                //インプット
                case 8:
                    this.button_body2.Visible = true;
                    this.button_head1.Visible = false;
                    this.groupBody.Visible = false;
                    this.groupHead.Visible = false;
                    this.groupInput.Visible = true;
                    this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                    this.label2.BackColor = Color.FromArgb(238, 106, 34);
                    editflg = 0;
                    break;
                //例外
                default:
                    this.group_tag.Visible = true;
                    this.groupHead.Visible = false;
                    this.groupBody.Visible = false;
                    this.groupInput.Visible = false;
                    this.button_delete.Visible = false;
                    this.button_swap.Visible = false;
                    this.group_tag.BackColor = Color.FromArgb(238, 106, 34);
                    this.label2.BackColor = Color.FromArgb(238, 106, 34);
                    editflg = 0;
                    contflg = 0;
                    break;

            }
        }

        //---タグツリーのHEADボタン処理
        private void button_head1_Click_1(object sender, EventArgs e)
        {
            flg = 1;
            ButtonVisible();
        }

       
        //---

        //---タグツリーのタグツリーのBODYボタン処理
        private void button_body1_Click_1(object sender, EventArgs e)
        {
            flg = 2;
            button_head1.Visible = false;
            button_body2.Visible = true;
            ButtonVisible();
        }

        private void button_body2_Click_1(object sender, EventArgs e)
        {
            flg = 2;
            ButtonVisible();
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
                editflg = 1;
                flg = 6;
                ButtonVisible();
            }
            else
            {
                editflg = 0;
                flg = 2;
                ButtonVisible();
            }
        }
        //---

        //---動的ボタンのイベント(引数：部品名、部品の種類、追加カウント、アイテムカウント、部品)
        private EventHandler btnclick(String name, String getkind, int BodyCount, int itemCount, Control cont)
        {
            return delegate (object sender2, EventArgs e2)
            {

                if (flg != 6 && flg != 5 && flg != 7)
                {   //通常時の処理

                    //<input>のグループ化が行われているか
                    if (inputedflg == 0)    //未グループ化
                    {
                        switch (getkind)
                        {
                            /* プロパティ系
                            case "h1":
                                property_text.Text = "class :" + name;
                                break;
                            case "div":
                                property_text.Text = "class :" + name;
                                break;
                            case "table":
                                property_text.Text = "class :" + name;
                                break;
                            case "img":
                                property_text.Text = "class :" + name;
                                break;
                            case "url":
                                property_text.Text = "class :" + name;
                                break;
                            case "textbox":
                                property_text.Text = "class :" + name;
                                break;
                            case "button":
                                property_text.Text = "class :" + name;
                                break;
                            case "nav":
                                property_text.Text = "class :" + name;
                                break;*/
                            case "input":   //<input>部品を押したらgroup_inputに切り替え
                                flg = 8;
                                ButtonVisible();
                                break;
                            /*case "small":
                                property_text.Text = "class :" + name;
                                break;*/
                            default:
                                break;
                        }
                    }
                    else if (inputedflg == 1)   //グループ化
                    {
                        switch (getkind)
                        {
                            /*case "h1":
                                property_text.Text = "class :" + name;
                                break;
                            case "div":
                                property_text.Text = "class :" + name;
                                break;
                            case "table":
                                property_text.Text = "class :" + name;
                                break;
                            case "img":
                                property_text.Text = "class :" + name;
                                break;
                            case "url":
                                property_text.Text = "class :" + name;
                                break;
                            case "textbox":     //inputグループ内の部品のプロパティをinput内テキストボックスに表示
                                property_text2.Text = "class :" + name;
                                break;
                            case "button":      //inputグループ内の部品のプロパティをinput内テキストボックスに表示
                                property_text2.Text = "class :" + name;
                                break;*/
                            case "input":   //<input>部品を押したらgroup_inputに切り替え
                                flg = 8;
                                ButtonVisible();
                                break;
                            /*case "nav":
                                property_text.Text = "class :" + name;
                                break;
                            case "small":
                                property_text.Text = "class :" + name;
                                break;*/
                            default:
                                break;
                        }
                    }
                }//通常時
                else if (flg == 6)   //編集時
                {
                    switch (getkind)    //switch文にして、追加コンテンツ対策
                    {
                        case "input":   //inputグループ内の編集を可能にする
                            flg = 8;
                            ButtonVisible();
                            flg = 6;
                            break;
                    }
                }//flg==6編集時
                else if (flg == 5)
                {   //削除ボタン

                    if (getkind == "input")
                    {
                        flg = 8;
                        ButtonVisible();
                        flg = 5;
                    }
                    Control[] controls = Controls.Find(name, true);
                    foreach (Control control in controls)
                    {   //部品の削除処理
                        if (control.Name == "input_" + addInputCount)
                        {
                            DialogResult result = MessageBox.Show("この部品を削除すると、中に入っている部品も消されますが、よろしいですか？", "注意！", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                            if (result == DialogResult.Yes)
                            {
                                inputedflg = 0;
                                inputflg = 0;
                                for (int i = inputedCount; i >= 1; i--)
                                {
                                    Control[] controls2 = Controls.Find("textbox_" + i, true);
                                    foreach (Control control2 in controls2)
                                    {
                                        OpenedName.Remove(flowLayoutPanel_input.Controls.GetChildIndex(control2) + 1);
                                        OpenedTag.Remove(flowLayoutPanel_input.Controls.GetChildIndex(control2) + 1);
                                        this.Controls.Remove(control2);
                                        control2.Dispose();
                                    }
                                    Control[] controls3 = Controls.Find("button_" + i, true);
                                    foreach (Control control3 in controls3)
                                    {
                                        OpenedName.Remove(flowLayoutPanel_input.Controls.GetChildIndex(control3) + 1);
                                        OpenedTag.Remove(flowLayoutPanel_input.Controls.GetChildIndex(control3) + 1);
                                        this.Controls.Remove(control3);
                                        control3.Dispose();
                                    }
                                }
                                inputedCount = 1;
                                flg = 5;
                                ButtonVisible();

                            }
                            else if (result == DialogResult.No)
                            {
                                break;
                            }
                        }
                        else if (control.Name == "link_" + addLinkCount)
                        {

                        }
                        this.Controls.Remove(control);
                        OpenedName.Remove(dic[name]);
                        OpenedTag.Remove(dic[name]);
                        dic.Remove(name);
                        control.Dispose();
                        reset_cls();
                    }

                }//flg==5削除
                else if (flg == 7)
                {


                    //bodyグループ入れ替え処理
                    switch (contflg)
                    {   //選択回数
                        //1回目
                        case 0:
                            name1 = name;   //一つ目の部品の名前を保持
                            ctrl1 = cont;   //部品のコントロールを保持
                            if (flowLayoutPanel_body.Visible == true)
                            {
                                cont1 = flowLayoutPanel_body.Controls.GetChildIndex(cont);  //Body部品のFlowLayoutPanelのインデックスを保持
                            }
                            else if (flowLayoutPanel_input.Visible == true)
                            {
                                cont1 = flowLayoutPanel_input.Controls.GetChildIndex(cont);  //input部品のFlowLayoutPanelのインデックスを保持
                            }

                            contflg = 1;    //選択カウントを設定
                            break;
                        //二回目
                        case 1:
                            ctrl2 = cont;   //二つ目の部品の名前を保持
                            if (flowLayoutPanel_body.Visible == true)
                            {
                                cont2 = flowLayoutPanel_body.Controls.GetChildIndex(cont);  //Body部品のFlowLayoutPanelのインデックスを保持
                            }
                            else if (flowLayoutPanel_input.Visible == true)
                            {
                                cont2 = flowLayoutPanel_input.Controls.GetChildIndex(cont);  //input部品のFlowLayoutPanelのインデックスを保持
                            }
                            SwapControls(cont1, cont2, ctrl1, ctrl2);       //入れ替えメソッドの実行
                            contflg = 0;    //初期化
                            break;
                        default:
                            break;
                    }


                }//flg==7入れ替え
            };
        }
        //---

        //削除ボタン
        private void button_delete_Click_1(object sender, EventArgs e)
        {
            flg = 5;
            ButtonVisible();
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
        private void SwapControls(int x, int y, Control ctrl1, Control ctrl2)
        {


            //入れ替え処理
            if (flowLayoutPanel_body.Visible == true)
            {
                flowLayoutPanel_body.SuspendLayout();
                flowLayoutPanel_body.Controls.SetChildIndex(ctrl1, y);
                flowLayoutPanel_body.Controls.SetChildIndex(ctrl2, x);
                flowLayoutPanel_body.ResumeLayout();
            }
            else if (flowLayoutPanel_input.Visible == true)
            {
                flowLayoutPanel_input.SuspendLayout();
                flowLayoutPanel_input.Controls.SetChildIndex(ctrl1, y);
                flowLayoutPanel_input.Controls.SetChildIndex(ctrl2, x);
                flowLayoutPanel_input.ResumeLayout();
            }

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
        //---

        //---インプット系部品のグループ化
        private void GroupingInput(int textCount, int buttonCount)
        {
            DialogResult result = MessageBox.Show("ボタンやテキストボックスなどの部品をまとめますか？", "Inputへのグループ化", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                inputedflg = 1;
                inputflg = 1;
                flg = 8;
                ButtonVisible();
                contflg = 0;
                try
                {
                    for (int i = textCount; i >= 1; i--)
                    {
                        Control[] controls1 = this.flowLayoutPanel_body.Controls.Find(dic2["textbox_" + i], true);
                        foreach (Control control in controls1)
                        {
                            this.flowLayoutPanel_input.Controls.Add(control);
                        }
                        inputedCount++;
                    }
                    for (int i = buttonCount; i >= 1; i--)
                    {
                        Control[] controls2 = this.flowLayoutPanel_body.Controls.Find(dic2["button_" + i], true);
                        foreach (Control control in controls2)
                        {
                            this.flowLayoutPanel_input.Controls.Add(control);
                        }
                        inputedCount++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("対象部品が追加されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else if (result == DialogResult.No)
            {
                inputedflg = 0;
                inputflg = 0;
            }
        }

        
        //作業ファイルを開いたときの処理
        private void OpenProcess()
        {
            int lc = 0;
            while (lc != listTag.Count)
            {
                //読み込んだcsvファイルを元にタグツリーの部品の生成
                switch (listTag[lc])
                {
                    //
                    case "h1":
                        AddTag(0, listName[lc]);
                        break;
                    case "div":
                        AddTag(1, listName[lc]);
                        break;
                    case "table":
                        AddTag(2, listName[lc]);
                        break;
                    case "img":
                        AddTag(3, listName[lc]);
                        break;
                    case "url":
                        AddTag(4, listName[lc]);
                        break;
                    case "textbox":
                        AddTag(5, listName[lc]);
                        break;
                    case "button":
                        AddTag(6, listName[lc]);
                        break;
                    case "nav":
                        AddTag(7, listName[lc]);
                        break;
                    case "input":
                        AddTag(8, listName[lc]);
                        break;
                    case "small":
                        AddTag(9, listName[lc]);
                        break;
                    case "link":
                        AddTag(10, listName[lc]);
                        break;
                }
                lc++;
            }

        }

        //タグツリーの部品追加処理（通常時）
        private void AddTag(int Index)
        {
            //タグツリーのBODYグループに部品のボタンを追加
            switch (Index)
            {
                //見出し
                case 0:
                    addH1Count++;                                                                   //見出し個数のカウント
                    Button button_h1 = new Button();                                                //新規ボタンのインスタンス                    //ボタンの配置場所の設定
                    button_h1.Size = new Size(122, 54);                                             //ボタンのサイズ
                    button_h1.ForeColor = Color.FromArgb(90, 92, 79);                               //ボタンの文字色の設定
                    button_h1.BackColor = Color.FromArgb(211, 214, 195);                              //ボタンの背景色の設定
                    button_h1.FlatStyle = FlatStyle.Flat;                                           //枠のスタイルの設定
                    button_h1.FlatAppearance.BorderSize = 0;                                        //枠なしに設定
                    button_h1.Text = "<H1>";                                                        //ボタンのテキスト
                    button_h1.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);                  //フォントの設定
                    button_h1.Name = "h1_" + addH1Count;                                            //ボタンのNameの設定
                    flowLayoutPanel_body.Controls.Add(button_h1);
                    addBodyCount++;                                                                 //BODYの個数のカウント
                    dic.Add(button_h1.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "h1");
                    OpenedName.Add(addBodyCount, button_h1.Name.ToString());
                    button_h1.Click += btnclick(button_h1.Name, "h1", dic[button_h1.Name], addH1Count, button_h1);                  //追加したボタンにイベントを追加
                    break;
                //文
                case 1:
                    addDivCount++;
                    Button button_div = new Button();
                    button_div.Size = new Size(122, 54);
                    button_div.ForeColor = Color.FromArgb(90, 92, 79);
                    button_div.BackColor = Color.FromArgb(211, 214, 195);
                    button_div.FlatStyle = FlatStyle.Flat;
                    button_div.FlatAppearance.BorderSize = 0;
                    button_div.Text = "TEXT";
                    button_div.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_div.Name = "text_" + addDivCount;
                    flowLayoutPanel_body.Controls.Add(button_div);
                    addBodyCount++;
                    dic.Add(button_div.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "text");
                    OpenedName.Add(addBodyCount, button_div.Name.ToString());
                    button_div.Click += btnclick(button_div.Name, "text", dic[button_div.Name], addDivCount, button_div);
                    break;
                //強調
                case 2:
                    addTableCount++;
                    Button button_table = new Button();
                    button_table.Size = new Size(122, 54);
                    button_table.ForeColor = Color.FromArgb(90, 92, 79);
                    button_table.BackColor = Color.FromArgb(211, 214, 195);
                    button_table.FlatStyle = FlatStyle.Flat;
                    button_table.FlatAppearance.BorderSize = 0;
                    button_table.Text = "<EM>";
                    button_table.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_table.Name = "em_" + addTableCount;
                    flowLayoutPanel_body.Controls.Add(button_table);
                    addBodyCount++;
                    dic.Add(button_table.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "em");
                    OpenedName.Add(addBodyCount, button_table.Name.ToString());
                    button_table.Click += btnclick(button_table.Name, "em", dic[button_table.Name], addTableCount, button_table);
                    break;
                //ハイパーリンク
                case 3:
                    addImgCount++;
                    Button button_img = new Button();
                    button_img.Size = new Size(122, 54);
                    button_img.ForeColor = Color.FromArgb(90, 92, 79);
                    button_img.BackColor = Color.FromArgb(211, 214, 195);
                    button_img.FlatStyle = FlatStyle.Flat;
                    button_img.FlatAppearance.BorderSize = 0;
                    button_img.Text = "<A>";
                    button_img.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_img.Name = "a_" + addImgCount;
                    flowLayoutPanel_body.Controls.Add(button_img);
                    addBodyCount++;
                    dic.Add(button_img.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "a");
                    OpenedName.Add(addBodyCount, button_img.Name.ToString());
                    button_img.Click += btnclick(button_img.Name, "a", dic[button_img.Name], addImgCount, button_img);
                    break;
                //太字
                case 4:
                    addUrlCount++;
                    Button button_url = new Button();
                    button_url.Size = new Size(122, 54);
                    button_url.ForeColor = Color.FromArgb(90, 92, 79);
                    button_url.BackColor = Color.FromArgb(211, 214, 195);
                    button_url.FlatStyle = FlatStyle.Flat;
                    button_url.FlatAppearance.BorderSize = 0;
                    button_url.Text = "<B>";
                    button_url.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_url.Name = "b_" + addUrlCount;
                    flowLayoutPanel_body.Controls.Add(button_url);
                    addBodyCount++;
                    dic.Add(button_url.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "b");
                    OpenedName.Add(addBodyCount, button_url.Name.ToString());
                    button_url.Click += btnclick(button_url.Name, "b", dic[button_url.Name], addUrlCount, button_url);
                    break;
                //テーブル
                case 5:
                    addTextboxCount++;
                    Button button_textBox = new Button();
                    button_textBox.Size = new Size(122, 54);
                    button_textBox.ForeColor = Color.FromArgb(90, 92, 79);
                    button_textBox.BackColor = Color.FromArgb(211, 214, 195);
                    button_textBox.FlatStyle = FlatStyle.Flat;
                    button_textBox.FlatAppearance.BorderSize = 0;
                    button_textBox.Text = "<TABLE>";
                    button_textBox.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
                    button_textBox.Name = "table_" + addTextboxCount;
                    if (inputflg == 0)
                    {
                        flowLayoutPanel_body.Controls.Add(button_textBox);
                        dic.Add(button_textBox.Name, addBodyCount);
                    }
                    else if (inputflg == 1)
                    {
                        flowLayoutPanel_input.Controls.Add(button_textBox);
                        dic.Add(button_textBox.Name, flowLayoutPanel_input.Controls.GetChildIndex(button_textBox));
                    }
                    addBodyCount++;
                    dic2.Add("table_" + addTextboxCount, button_textBox.Name);
                    OpenedTag.Add(addBodyCount, "table");
                    OpenedName.Add(addBodyCount, button_textBox.Name.ToString());
                    button_textBox.Click += btnclick(button_textBox.Name, "table", dic[button_textBox.Name], addTextboxCount, button_textBox);
                    break;
                //順序のあるリスト
                case 6:
                    addButtonCount++;
                    Button button_Button = new Button();
                    button_Button.Size = new Size(122, 54);
                    button_Button.ForeColor = Color.FromArgb(90, 92, 79);
                    button_Button.BackColor = Color.FromArgb(211, 214, 195);
                    button_Button.FlatStyle = FlatStyle.Flat;
                    button_Button.FlatAppearance.BorderSize = 0;
                    button_Button.Text = "<OL>";
                    button_Button.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
                    button_Button.Name = "ol_" + addButtonCount;
                    if (inputflg == 0)
                    {
                        flowLayoutPanel_body.Controls.Add(button_Button);
                        dic.Add(button_Button.Name, addBodyCount);
                    }
                    else if (inputflg == 1)
                    {
                        flowLayoutPanel_input.Controls.Add(button_Button);
                        dic.Add(button_Button.Name, flowLayoutPanel_input.Controls.GetChildIndex(button_Button));
                    }
                    addBodyCount++;
                    dic2.Add("ol_" + addButtonCount, button_Button.Name);
                    OpenedTag.Add(addBodyCount, "ol");
                    OpenedName.Add(addBodyCount, button_Button.Name.ToString());
                    button_Button.Click += btnclick(button_Button.Name, "ol", dic[button_Button.Name], addButtonCount, button_Button);
                    break;
                //順序のないリスト
                case 7:
                    addNavCount++;
                    Button button_Nav = new Button();
                    button_Nav.Size = new Size(122, 54);
                    button_Nav.ForeColor = Color.FromArgb(90, 92, 79);
                    button_Nav.BackColor = Color.FromArgb(211, 214, 195);
                    button_Nav.FlatStyle = FlatStyle.Flat;
                    button_Nav.FlatAppearance.BorderSize = 0;
                    button_Nav.Text = "<UL>";
                    button_Nav.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_Nav.Name = "ul_" + addNavCount;
                    flowLayoutPanel_body.Controls.Add(button_Nav);
                    addBodyCount++;
                    dic.Add(button_Nav.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "ul");
                    OpenedName.Add(addBodyCount, button_Nav.Name.ToString());
                    button_Nav.Click += btnclick(button_Nav.Name, "ul", dic[button_Nav.Name], addButtonCount, button_Nav);
                    break;

                //画像
                case 8:
                    Button button_Input = new Button();
                    button_Input.Size = new Size(122, 54);
                    button_Input.ForeColor = Color.FromArgb(90, 92, 79);
                    button_Input.BackColor = Color.FromArgb(211, 214, 195);
                    button_Input.FlatStyle = FlatStyle.Flat;
                    button_Input.FlatAppearance.BorderSize = 0;
                    button_Input.Text = "<IMG>";
                    button_Input.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_Input.Name = "img_" + addInputCount;
                    if (inputedCount == 1)
                    {
                        if (inputedflg != 1)
                        {
                            flowLayoutPanel_body.Controls.Add(button_Input);
                            addBodyCount++;
                            dic.Add(button_Input.Name, addBodyCount);
                            OpenedTag.Add(addBodyCount, "img");
                            OpenedName.Add(addBodyCount, button_Input.Name.ToString());
                            button_Input.Click += btnclick(button_Input.Name, "img", dic[button_Input.Name], addInputCount, button_Input);
                            GroupingInput(addTextboxCount, addButtonCount);
                            inputedCount++;
                        }
                    }
                    else if (inputedCount >= 2 && inputedflg != 1)
                    {
                        GroupingInput(addTextboxCount, addButtonCount);
                    }
                    else
                    {
                        MessageBox.Show("すでに追加されています。");
                        break;
                    }

                    break;
                //スモール
                case 9:
                    addSmallCount++;
                    Button button_Small = new Button();
                    button_Small.Size = new Size(122, 54);
                    button_Small.ForeColor = Color.FromArgb(90, 92, 79);
                    button_Small.BackColor = Color.FromArgb(211, 214, 195);
                    button_Small.FlatStyle = FlatStyle.Flat;
                    button_Small.FlatAppearance.BorderSize = 0;
                    button_Small.Text = "<SMALL>";
                    button_Small.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_Small.Name = "small_" + addSmallCount;
                    flowLayoutPanel_body.Controls.Add(button_Small);
                    addBodyCount++;
                    dic.Add(button_Small.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "small");
                    OpenedName.Add(addBodyCount, button_Small.Name.ToString());
                    button_Small.Click += btnclick(button_Small.Name, "small", dic[button_Small.Name], addButtonCount, button_Small);
                    break;
                //リンク
                case 10:
                    addLinkCount++;
                    Button button_Link = new Button();
                    button_Link.Size = new Size(122, 54);
                    button_Link.ForeColor = Color.FromArgb(90, 92, 79);
                    button_Link.BackColor = Color.FromArgb(211, 214, 195);
                    button_Link.FlatStyle = FlatStyle.Flat;
                    button_Link.FlatAppearance.BorderSize = 0;
                    button_Link.Text = "<LINK>";
                    button_Link.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_Link.Name = "link_" + addLinkCount;
                    flowLayoutPanel_head.Controls.Add(button_Link);
                    addBodyCount++;
                    dic.Add(button_Link.Name, addHeadCount + 999);
                    OpenedTag.Add(addHeadCount + 999, "link");
                    OpenedName.Add(addHeadCount + 999, button_Link.Name.ToString());
                    button_Link.Click += btnclick(button_Link.Name, "link", dic[button_Link.Name], addButtonCount, button_Link);
                    break;
                default:
                    break;
            }
        }
        //タグツリーの部品追加処理（作業ファイルを開いたとき）
        private void AddTag(int Index, String name)
        {
            //タグツリーのBODYグループに部品のボタンを追加
            switch (Index)
            {
                //見出し
                case 0:
                    addH1Count++;                                                                   //見出し個数のカウント
                    Button button_h1 = new Button();                                                //新規ボタンのインスタンス                    //ボタンの配置場所の設定
                    button_h1.Size = new Size(122, 54);                                             //ボタンのサイズ
                    button_h1.ForeColor = Color.FromArgb(90, 92, 79);                               //ボタンの文字色の設定
                    button_h1.BackColor = Color.FromArgb(211, 214, 195);                            //ボタンの背景色の設定
                    button_h1.FlatStyle = FlatStyle.Flat;                                           //枠のスタイルの設定
                    button_h1.FlatAppearance.BorderSize = 0;                                        //枠なしに設定
                    button_h1.Text = "<H1>";                                                        //ボタンのテキスト
                    button_h1.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);                  //フォントの設定
                    button_h1.Name = name;                                                          //ボタンのNameの設定
                    flowLayoutPanel_body.Controls.Add(button_h1);
                    addBodyCount++;                                                                 //BODYの個数のカウント
                    dic.Add(button_h1.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "h1");
                    OpenedName.Add(addBodyCount, button_h1.Name.ToString());
                    button_h1.Click += btnclick(button_h1.Name, "h1", dic[button_h1.Name], addH1Count, button_h1);                  //追加したボタンにイベントを追加
                    break;
                //文
                case 1:
                    addDivCount++;
                    Button button_div = new Button();
                    button_div.Size = new Size(122, 54);
                    button_div.ForeColor = Color.FromArgb(90, 92, 79);
                    button_div.BackColor = Color.FromArgb(211, 214, 195);
                    button_div.FlatStyle = FlatStyle.Flat;
                    button_div.FlatAppearance.BorderSize = 0;
                    button_div.Text = "<DIV>";
                    button_div.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_div.Name = name;
                    flowLayoutPanel_body.Controls.Add(button_div);
                    addBodyCount++;
                    dic.Add(button_div.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "div");
                    OpenedName.Add(addBodyCount, button_div.Name.ToString());
                    button_div.Click += btnclick(button_div.Name, "div", dic[button_div.Name], addDivCount, button_div);
                    break;
                //表
                case 2:
                    addTableCount++;
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
                //画像
                case 3:
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
                //URL
                case 4:
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
                //テキストボックス
                case 5:
                    addTextboxCount++;
                    Button button_textBox = new Button();
                    button_textBox.Size = new Size(122, 54);
                    button_textBox.ForeColor = Color.FromArgb(90, 92, 79);
                    button_textBox.BackColor = Color.FromArgb(211, 214, 195);
                    button_textBox.FlatStyle = FlatStyle.Flat;
                    button_textBox.FlatAppearance.BorderSize = 0;
                    button_textBox.Text = "<TEXTBOX>";
                    button_textBox.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
                    button_textBox.Name = name;
                    if (inputflg == 0)
                    {
                        flowLayoutPanel_body.Controls.Add(button_textBox);
                        dic.Add(button_textBox.Name, addBodyCount);
                    }
                    else if (inputflg == 1)
                    {
                        flowLayoutPanel_input.Controls.Add(button_textBox);
                        dic.Add(button_textBox.Name, flowLayoutPanel_input.Controls.GetChildIndex(button_textBox));
                    }
                    addBodyCount++;
                    dic2.Add("textbox_" + addTextboxCount, button_textBox.Name);
                    OpenedTag.Add(addBodyCount, "textbox");
                    OpenedName.Add(addBodyCount, button_textBox.Name.ToString());
                    button_textBox.Click += btnclick(button_textBox.Name, "textbox", dic[button_textBox.Name], addTextboxCount, button_textBox);
                    break;
                //ボタン
                case 6:
                    addButtonCount++;
                    Button button_Button = new Button();
                    button_Button.Size = new Size(122, 54);
                    button_Button.ForeColor = Color.FromArgb(90, 92, 79);
                    button_Button.BackColor = Color.FromArgb(211, 214, 195);
                    button_Button.FlatStyle = FlatStyle.Flat;
                    button_Button.FlatAppearance.BorderSize = 0;
                    button_Button.Text = "<BUTTON>";
                    button_Button.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
                    button_Button.Name = name;
                    if (inputflg == 0)
                    {
                        flowLayoutPanel_body.Controls.Add(button_Button);
                        dic.Add(button_Button.Name, addBodyCount);
                    }
                    else if (inputflg == 1)
                    {
                        flowLayoutPanel_input.Controls.Add(button_Button);
                        dic.Add(button_Button.Name, flowLayoutPanel_input.Controls.GetChildIndex(button_Button));
                    }
                    addBodyCount++;
                    dic2.Add("button_" + addButtonCount, button_Button.Name);
                    OpenedTag.Add(addBodyCount, "button");
                    OpenedName.Add(addBodyCount, button_Button.Name.ToString());
                    button_Button.Click += btnclick(button_Button.Name, "button", dic[button_Button.Name], addButtonCount, button_Button);
                    break;
                //ナビ
                case 7:
                    addNavCount++;
                    Button button_Nav = new Button();
                    button_Nav.Size = new Size(122, 54);
                    button_Nav.ForeColor = Color.FromArgb(90, 92, 79);
                    button_Nav.BackColor = Color.FromArgb(211, 214, 195);
                    button_Nav.FlatStyle = FlatStyle.Flat;
                    button_Nav.FlatAppearance.BorderSize = 0;
                    button_Nav.Text = "<NAV>";
                    button_Nav.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_Nav.Name = name;
                    flowLayoutPanel_body.Controls.Add(button_Nav);
                    addBodyCount++;
                    dic.Add(button_Nav.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "nav");
                    OpenedName.Add(addBodyCount, button_Nav.Name.ToString());
                    button_Nav.Click += btnclick(button_Nav.Name, "nav", dic[button_Nav.Name], addButtonCount, button_Nav);
                    break;

                //インプット
                case 8:
                    Button button_Input = new Button();
                    button_Input.Size = new Size(122, 54);
                    button_Input.ForeColor = Color.FromArgb(90, 92, 79);
                    button_Input.BackColor = Color.FromArgb(211, 214, 195);
                    button_Input.FlatStyle = FlatStyle.Flat;
                    button_Input.FlatAppearance.BorderSize = 0;
                    button_Input.Text = "<INPUT>";
                    button_Input.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_Input.Name = name;
                    if (inputedCount == 1)
                    {
                        if (inputedflg != 1)
                        {
                            flowLayoutPanel_body.Controls.Add(button_Input);
                            addBodyCount++;
                            dic.Add(button_Input.Name, addBodyCount);
                            OpenedTag.Add(addBodyCount, "input");
                            OpenedName.Add(addBodyCount, button_Input.Name.ToString());
                            button_Input.Click += btnclick(button_Input.Name, "input", dic[button_Input.Name], addInputCount, button_Input);
                            GroupingInput(addTextboxCount, addButtonCount);
                            inputedCount++;
                        }
                    }
                    else if (inputedCount >= 2 && inputedflg != 1)
                    {
                        GroupingInput(addTextboxCount, addButtonCount);
                    }
                    else
                    {
                        MessageBox.Show("すでに追加されています。");
                        break;
                    }

                    break;
                //スモール
                case 9:
                    addSmallCount++;
                    Button button_Small = new Button();
                    button_Small.Size = new Size(122, 54);
                    button_Small.ForeColor = Color.FromArgb(90, 92, 79);
                    button_Small.BackColor = Color.FromArgb(211, 214, 195);
                    button_Small.FlatStyle = FlatStyle.Flat;
                    button_Small.FlatAppearance.BorderSize = 0;
                    button_Small.Text = "<SMALL>";
                    button_Small.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_Small.Name = name;
                    flowLayoutPanel_body.Controls.Add(button_Small);
                    addBodyCount++;
                    dic.Add(button_Small.Name, addBodyCount);
                    OpenedTag.Add(addBodyCount, "small");
                    OpenedName.Add(addBodyCount, button_Small.Name.ToString());
                    button_Small.Click += btnclick(button_Small.Name, "small", dic[button_Small.Name], addButtonCount, button_Small);
                    break;
                //リンク
                case 10:
                    addLinkCount++;
                    Button button_Link = new Button();
                    button_Link.Size = new Size(122, 54);
                    button_Link.ForeColor = Color.FromArgb(90, 92, 79);
                    button_Link.BackColor = Color.FromArgb(211, 214, 195);
                    button_Link.FlatStyle = FlatStyle.Flat;
                    button_Link.FlatAppearance.BorderSize = 0;
                    button_Link.Text = "<LINK>";
                    button_Link.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
                    button_Link.Name = name;
                    flowLayoutPanel_head.Controls.Add(button_Link);
                    addHeadCount++;
                    dic.Add(button_Link.Name, addHeadCount + 999);
                    OpenedTag.Add(addHeadCount + 999, "link");
                    OpenedName.Add(addHeadCount + 999, button_Link.Name.ToString());
                    button_Link.Click += btnclick(button_Link.Name, "link", dic[button_Link.Name], addButtonCount, button_Link);
                    break;
                default:
                    break;
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
