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
    public partial class EM_Parts : Form
    {
        public EM_Parts()
        {
            InitializeComponent();
        }

        private void EM_Parts_Load(object sender, EventArgs e)
        {
            TextAdd.KeyDown += new KeyEventHandler(TextAdd_KeyDown);
        }

        public string ShowMiniForm()
        {

            EM_Parts f = new EM_Parts();
            string receiveText;
            f.ShowDialog();
            if(f.TextAdd.Text != "")
            {
                receiveText = "<em>" + f.TextAdd.Text.Replace("\r\n", "<br>") + "</em>";　//HTML文
            }
            else
            {
                receiveText = "-1";
            }
            f.Dispose();
            return receiveText; //HTML文を返す

        }

        private void TextAdd_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * 追加ボタン処理
         */
        private void AddConfirm_Click(object sender, EventArgs e)
        {
            Close(); //画面を閉じ内容を反映
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            TextAdd.Text = "";
            Close();
        }
        //エンターキー、エスケープキー対応
        private void TextAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AddConfirm_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                cancel_btn_Click(this, new EventArgs());
            }
        }
    }
}
