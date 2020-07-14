using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        {

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
        public void writer_html(string input)
        {
            text_box[cnt] = input;           
            writer = new System.IO.StreamWriter(@"c:\Users\S3a2\Desktop\index.html", false, System.Text.Encoding.Default); 
            writer.Write("<DOCTYPE! HTML>");
            writer.Write("<HTML>");
                writer.Write("<head>"+"<title>" + Title.Text + "</title></head>"); //タイトルの定義
                writer.Write("<body>");
                   for(int i = 0; i<= cnt; i++)
                    {
                       writer.Write("<div class=\"" + i + "\"><p>" + text_box[i] + "</p></div>"); //HTMLコードを追加する
                    }
                writer.Write("</body>");
            writer.Write("</HTML>"); 
            writer.Close();
            
        }

        /*
         *  最下部のHTMLタグを削除する
         */
        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            if (cnt >0)
            {
                cnt--;
                writer_html("");
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

            // 選択されている部品の名前を取り込む
            
             sel = parts_list.SelectedItem.ToString();
             
            if (sel == "テキスト") 
            {
                result = tp.ShowMiniForm();
                writer_html(result);
                cnt++; //次の行へ
            }

            if (sel == "テキストの強調")
            {
                result = ep.ShowMiniForm();
                writer_html(result);
                cnt++; //次の行へ
            }

            if (sel == "ハイパーテキスト")
            {
                result = hpp.ShowMiniForm();
                writer_html(result);
                cnt++; //次の行へ
            }

            if(sel == "画像")
            {
                result = ip.ShowMiniForm();
                writer_html(result);
                cnt++; //次の行へ
            }

            if (sel == "順序のあるリスト")
            {
                result = op.ShowMiniForm();
                writer_html(result);
                cnt++; //次の行へ
            }

            if (sel == "順序のないリスト")
            {
                result = up.ShowMiniForm();
                writer_html(result);
                cnt++; //次の行へ
            }

            if (sel == "見出し")
            {
                result = hp.ShowMiniForm();
                writer_html(result);
                cnt++; //次の行へ
            }
            if (sel == "太字")
            {
                
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

        private void parts_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }
    }
}
