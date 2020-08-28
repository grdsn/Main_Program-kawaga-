
using Microsoft.WindowsAPICodePack.Shell;
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
    public partial class Img_Parts : Form
    {
        string img_name;
        OpenFileDialog ofd = new OpenFileDialog();
        public Img_Parts()
        {
            InitializeComponent();
        }

        /*
         * 起動時に画像ファイルを指定させ、
         * プレビュー画面を表示する
         */
        private void Img_Parts_Load(object sender, EventArgs e)
        {
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                img_name = ofd.FileName;
            }
            pcb_preview.Image = CreateThumbnail(img_name, 1);
        }
        public string ShowMiniForm()
        {

            Img_Parts f = new Img_Parts();
            string receiveText;
            f.ShowDialog();
            if (f.img_name != "")
            {
                receiveText = "<img src=\"" + f.img_name + "\">"; //画像HTML
            }
            else
            {
                receiveText = "-1";
            }
            f.Dispose();
            return receiveText;　//HTML文を返す

        }

        private Bitmap CreateThumbnail(string path, int scale)
        {
            // ファイルが存在した場合
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                ShellFile shellFile = ShellFile.FromFilePath(path);
                Bitmap bmp = shellFile.Thumbnail.Bitmap;
                int w = (int)(bmp.Width * scale);
                int h = (int)(bmp.Height * scale);
                return bmp;
            }

            // ファイルが存在しない場合はデフォルト表示
            return WindowsFormsApp1.Properties.Resources.Message;
        }

        /*
         * 画面を閉じ,画像を反映する
         */
        private void AddConfirm_Click(object sender, EventArgs e)
        {
            Close(); //画面を閉じる
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            img_name = "";
            Close();
        }
    }
}
