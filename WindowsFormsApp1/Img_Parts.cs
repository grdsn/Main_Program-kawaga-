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
    public partial class Img_Parts : Form
    {
        string img_name;
        OpenFileDialog ofd = new OpenFileDialog();
        public Img_Parts()
        {
            InitializeComponent();
        }

        private void Img_Parts_Load(object sender, EventArgs e)
        {

        }
        public string ShowMiniForm()
        {

            Img_Parts f = new Img_Parts();
            f.ShowDialog();

            string receiveText = "<img src=\"" + f.img_name + "\">"; //画像HTML
            f.Dispose();
            return receiveText;　//HTML文を返す

        }

        /*
         * エクスプローラーを開きファイルを指定させる
         */
        private void File_Open_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img_name = ofd.FileName; //アドレスを返す
            }
        }
    }
}
