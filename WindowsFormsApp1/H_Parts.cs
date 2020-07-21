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
    public partial class H_Parts : Form
    {
        private string[] argumentValues;
        public static string text_return;
        public H_Parts()
        {
            InitializeComponent();
        }

        private void H_Parts_Load(object sender, EventArgs e)
        {

        }

        public string ShowMiniForm()
        {
            string receiveText = "";
            H_Parts f = new H_Parts();
            f.ShowDialog();
            int size = int.Parse(f.size_box.Text); //階層を指定
            if (size <= 6)
            {
                receiveText = "<h" + size + ">" + f.Title_Add.Text + "</h" + size + ">"; //HTML文
            }
            else
            {
                MessageBox.Show("1～6までの範囲で指定してください。");
            }
            f.Dispose();
            return receiveText; //HTML文を返す

        }

        /*
         * 追加ボタンを押した場合の処理
         */
        private void AddConfirm_Click(object sender, EventArgs e)
        {
            Close(); //画面を閉じ反映させる
        }
    }
}
