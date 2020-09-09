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
    public partial class Text_parts : Form
    {
        public static string text_return;
        main fm1 = new main();
        public Text_parts()
        {
            InitializeComponent();
        }

        private void Create_parts_Load(object sender, EventArgs e)
        {
            parts_name.Text = "テキストの追加";
 
            info_label.Text = "テキストを追加してください。";
            TextAdd.Visible = true;

            TextAdd.KeyDown += new KeyEventHandler(TextAdd_KeyDown);
            this.ActiveControl = this.TextAdd;
        }

        
        public string ShowMiniForm()
        {
            Text_parts f = new Text_parts();
            string receiveText;
            f.ShowDialog();
            if (TextAdd.Text == "")
            {
                receiveText = f.TextAdd.Text.Replace("\r\n", "<br>"); //HTML文
            }
            else
            {
                receiveText = "-1"; //HTML文
            }
            f.Dispose();
            return receiveText; //HTML文を返す

        }

        /*
         * 追加ボタンを押した場合の処理
         */
        private void AddConfirm_Click(object sender, EventArgs e)
        {
            Close();　//画面を閉じ内容を反映
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            TextAdd.Text = "";
            Close();
        }
        //エンターキー、エスケープキー対応
        private void TextAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                AddConfirm_Click(this, new EventArgs());
            }
            if(e.KeyCode == Keys.Escape)
            {
                cancel_btn_Click(this, new EventArgs());
            }
        }

        private void TextAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
