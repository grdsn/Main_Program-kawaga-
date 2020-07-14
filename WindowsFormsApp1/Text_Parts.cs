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
        int in_cnt = 0;
        private string[] argumentValues;
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
            int test;

        }

        
        public string ShowMiniForm()
        {

            Text_parts f = new Text_parts();
            f.ShowDialog();
            string receiveText = f.TextAdd.Text.Replace("\r\n", "<br>"); //HTML文
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
       
               
         
 
        private void Main_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
