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
        string[] text_box = new string[10000]; //HTMLタグ格納用
        int cnt = 0; //タグ数カウント
        string sel; //選択した部品の名前を格納
        Boolean HTML_flg = false;//ソースコード表示判定用
        System.IO.StreamWriter writer = null;
        public main()
        {
            InitializeComponent();
        }

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

            lvi = new ListViewItem("順序のあるリスト");
            lvi.ImageIndex = 5;
            partsList.Items.Add(lvi);

            lvi = new ListViewItem("順序のないリスト");
            lvi.ImageIndex = 6;
            partsList.Items.Add(lvi);

            lvi = new ListViewItem("画像");
            lvi.ImageIndex = 7;
            partsList.Items.Add(lvi);
        }
           
        /*
         * ブラウザ内の情報を更新する
         */
        private void Result_Btn_Click(object sender, EventArgs e)
        {
            Browser_show();　//結果を画面上に表示
        }

        /*
         *HTMLを書き出すためのプログラム
         */
        public void writer_html(string input,int flag)
        {
            if (flag == 0)
            {
                text_box[cnt] = input;
                writer = new System.IO.StreamWriter(@"c:\Users\S3a2\Desktop\index.html", false, System.Text.Encoding.UTF8);
                writer.Write("<DOCTYPE! HTML>");
                writer.Write("<HTML>"); //HTML開始
                writer.Write("<head>" + "<title>" + Title.Text + "</title></head>"); //タイトルの定義
                writer.Write("<body>");
                for (int i = 0; i <= cnt; i++)
                {
                    writer.Write("<div class=\"" + i + "\">" + text_box[i] + "</div>"); //HTMLコードを追加する
                }
                writer.Write("</body>");
                writer.Write("</HTML>"); //HTML終了
                writer.Close();
            }
            else
            {
                //配列内のデータを初期化
                for(int i = 0; i <=cnt; i++)
                {
                    text_box[cnt] = "";
                }
                writer = new System.IO.StreamWriter(@"c:\Users\S3a2\Desktop\index.html", false, System.Text.Encoding.UTF8);
                writer.Write("");
                cnt = 0;
                writer.Close(); //閉じる
            }
            
        }

        /*
         *  最下部のHTMLタグを削除する
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
         * フォーム内のブラウザを更新する
         */
        private void Browser_show()
        {
            webBrowser1.Navigate("c:/Users/S3a2/Desktop/index.html");
        }

        /*
         *初期化処理
         */
        private void resetBtn_Click(object sender, EventArgs e)
        {
            writer_html("", 1);//画面データを削除   
            HTML_show();//リセット完了後のHTMLソースを出力
            Browser_show(); //リセット完了後のブラウザ画面を出力
        }

        /*
         * HTMLソースコードを表示する
         */
        private void HTML_show()
        {  
            StreamReader st = new StreamReader(@"C:\Users\S3a2\Desktop\index.html", Encoding.GetEncoding("UTF-8"));　//StreamReaderでファイルの内容を読み込む
            HTMLBOX.Text = st.ReadToEnd(); //streamReader内のテキストを書き込む
            st.Close();//終了
        }


        private void HTMLBtn_Click(object sender, EventArgs e)
        {
            if (HTML_flg == false)
            {
                HTMLBOX.Visible = true; //HTMLソースコード用のテキストボックスを有効化
                HTMLBtn.Text = "プレビュー表示";
                HTML_show(); //ソースコードを表示
                HTML_flg = true; //次回クリック時にブラウザ画面にもどる
            }
            else
            {
                HTMLBOX.Visible = false;　//HTMLソースコード用のテキストボックスを無効化
                HTMLBtn.Text = "ソースコード表示";
                HTML_flg = false; //再びソースコード表示可にする
            }
        }

        private string Create_parts_num()
        {
            if (partsList.SelectedItems.Count > 0)
            {
                return partsList.SelectedItems[0].Index.ToString();
            }
            return "error";
        }

        /*
         * パーツを選択し、各部品に分岐させる
         */
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            string result;
            Text_parts tp = new Text_parts(); //テキスト
            EM_Parts ep = new EM_Parts(); //テキストの強調
            Hyper_Parts hpp = new Hyper_Parts(); //ハイパーテキスト
            Img_Parts ip = new Img_Parts(); //画像
            OL_Parts op = new OL_Parts(); //順序のあるリスト
            UL_Parts up = new UL_Parts(); //順序のないリスト
            H_Parts hp = new H_Parts(); //見出し
            B_Parts bp = new B_Parts(); //太字

            // 選択されている部品の名前を取り込む
            sel = Create_parts_num();


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

            if (sel == "7")　//画像
            {
                result = ip.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }

            if (sel == "5") //順序のあるリスト
            {
                result = op.ShowMiniForm();
                writer_html(result, 0);
                cnt++; //次の行へ
            }

            if (sel == "6") //順序のないリスト
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

            Browser_show(); //結果を画面上に表示


        }

    }
}
