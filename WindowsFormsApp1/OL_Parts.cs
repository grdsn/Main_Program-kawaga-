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
    public partial class OL_Parts : Form
    {
        bool cancel_flg = false; 
        public int RowCount { get; set; }
        int count;
        public OL_Parts()
        {
            InitializeComponent();
        }

        private void OL_Parts_Load(object sender, EventArgs e)
        {
            Add_Text.Select();
            Add_Text.KeyDown += new KeyEventHandler(Add_Text_KeyDown);
        }

        public string ShowMiniForm()
        {
            string receiveText;
            OL_Parts f = new OL_Parts();
            f.ShowDialog();
            f.Dispose();
            string[] add_list = f.OL_box.Items.Cast<string>().ToArray(); //追加するリスト項目を取得
            
            if (f.cancel_flg == false && add_list.Length > 0)
            {
                receiveText = "  <ol>" + "\r\n"; //順序のあるリスト「開始」
                for (int i = 0; i < f.count; i++)
                {
                    receiveText += "    <li>" + add_list[i] + "</li>" + "\r\n"; //順序のあるリスト「項目」
                }
                receiveText += "  </ol>";　//順序のあるリスト「終了」
            }
            else
            {
                receiveText = "-1";
            }
            
            return receiveText; //HTML文を返す


        }

        /*
         * 追加ボタンを押した場合の処理
         */
        private void AddConfirm_Click(object sender, EventArgs e)
        {
            Close(); //画面を閉じ反映させる
        }

        /*
         * リスト追加ボタンを押した場合の処理
         */
        private void Add_button_Click(object sender, EventArgs e)
        {
            if(Add_Text.Text != "")
            {
                AddText();
            }     
        }

        /*
         * OL_box内に要素を追加する処理
         */
        private void AddText()
        {
            OL_box.Items.Add(Add_Text.Text); //OL_box内に要素を追加
            count = OL_box.Items.Count; //要素数を取得
            Add_Text.Text = "";
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancel_flg = true;
            Close();
        }

        private void OL_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //エンターキー、エスケープキー対応
        private void Add_Text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Add_button_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                cancel_btn_Click(this, new EventArgs());
            }
        }
    }
}
