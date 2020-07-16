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
        System.IO.StreamWriter writer = null;
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
            //ddddd
        {
            //素材項目の追加
            string[] s1 = { "見出し", "テキスト", "テキストの強調","ハイパーテキスト","太字", "順序のあるリスト","順序のないリスト" };
            foreach (string item in s1)
            {
                parts_list.Items.Add(item);
            }
        }
            int test;
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
         * パーツを選択し、各部品に分岐させる
         */
        private void parts_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string result;
            Text_parts tp = new Text_parts(); //テキスト
            EM_Parts ep = new EM_Parts(); //テキストの強調
            Hyper_Parts hpp = new Hyper_Parts(); //ハイパーテキスト
            Img_Parts ip = new Img_Parts(); //画像
            OL_Parts op = new OL_Parts(); //順序のあるリスト
            UL_Parts up = new UL_Parts(); //順序のないリスト
            H_Parts hp = new H_Parts(); //見出し
            B_Parts bp = new B_Parts();

            // 選択されている部品の名前を取り込む
            
             sel = parts_list.SelectedItem.ToString();
             
            if (sel == "テキスト") 
            {
                result = tp.ShowMiniForm();
                writer_html(result,0);
                cnt++; //次の行へ
            }

            if (sel == "テキストの強調")
            {
                result = ep.ShowMiniForm();
                writer_html(result,0);
                cnt++; //次の行へ
            }

            if (sel == "ハイパーテキスト")
            {
                result = hpp.ShowMiniForm();
                writer_html(result,0);
                cnt++; //次の行へ
            }

            if(sel == "画像")
            {
                result = ip.ShowMiniForm();
                writer_html(result,0);
                cnt++; //次の行へ
            }

            if (sel == "順序のあるリスト")
            {
                result = op.ShowMiniForm();
                writer_html(result,0);
                cnt++; //次の行へ
            }

            if (sel == "順序のないリスト")
            {
                result = up.ShowMiniForm();
                writer_html(result,0);
                cnt++; //次の行へ
            }

            if (sel == "見出し")
            {
                result = hp.ShowMiniForm();
                writer_html(result,0);
                cnt++; //次の行へ
            }
            if (sel == "太字")
            {
                result = bp.ShowMiniForm();
                writer_html(result,0);
                cnt++; //次の行へ
            }

            Browser_show(); //結果を画面上に表示
        }

        /*
         * フォーム内のブラウザを更新する
         */
        private void Browser_show()
        {
            webBrowser1.Navigate("c:/Users/S3a2/Desktop/index.html");
        }

        /*
         * タブを変更した場合
         */
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HTML_show(); //ソースコードを表示
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

        private void parts_list_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;

            e.Graphics.DrawImage(Image.FromFile(@"C:\Program Files\Internet Explorer\images\bing.ico"), e.Bounds.X, e.Bounds.Y);
            e.Graphics.DrawString(parts_list.Items[e.Index].ToString(),
                                  new Font(parts_list.Items[e.Index].ToString(), 12),
                                  new SolidBrush(Color.Black),
                                  e.Bounds.X + Image.FromFile(@"C:\Program Files\Internet Explorer\images\bing.ico").Width,
                                  e.Bounds.Y);
        }

        private void parts_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
