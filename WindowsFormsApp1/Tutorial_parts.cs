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


/*
* チュートリアル機能
*  担当：伊賀
*/
namespace WindowsFormsApp1
{
    /*
     * チュートリアル画面表示
     */
    public partial class Tutorial_Parts : Form
    {
        main mn;

        //定義
        String tutoBar = "";      //タイトルバー
        String tutoTitle = "";    //タイトル欄
        String tutoPrev = "";        //プレビュー（見出し、本文）
        int sw = 1;                 //スイッチ。次へボタン押下時のフラグ管理
        String fileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\webkun.html";    //HTMLの保存先のパス

        /*
         * チュートリアルの画面表示
         */
        public Tutorial_Parts(main m)
        {
            // メイン・フォームへの参照を保存
            mn = m;

            //内容を画面反映する
            InitializeComponent();

            //テキストの表示
            labelTitle.Text = "チュートリアルへようこそ!";                   //見出し部分
            labelText.Text = "それではかんたんなHTMLを作っていきましょう";   //本文の部分
        }

        /* 
        * 「次へ」ボタン押下時の処理
        */
        private void btnNext_Click_1()
        {
            //定義
            tutoBar = mn.Text; //タイトルバー    
            tutoTitle = mn.Title.Text;    //タイトル欄
            tutoPrev = mn.webBrowser1.DocumentText;        //プレビュー（見出し、本文）

            //チュートリアル終了
            if (sw == 0) //「次へ」ボタンが「終了」になった後、クリックしたか判定
            {
                this.Close();
            }

            if (sw == 7) //'HTML完成！'表示後「次へ」をクリックしたか判定
            {
                //テキストの表示
                labelTitle.ForeColor = Color.Gray; //タイトル文字を灰色にする
                labelText.Text = "HTML作成に慣れてきたら、プレビューボタンから\nHTMLのコード分析をおすすめします。"; //本文の部分

                //ボタンのテキスト変更
                btnNext.Text = "終了";

                //チュートリアルを進める
                sw = 0;
            }

            // ６.終了
            if (sw == 6) //名前を付けた後に「次へ」をクリックしたか判定
            {
                //テキストの表示
                labelTitle.ForeColor = Color.Black; //タイトル文字を黒色にする
                labelTitle.Text = "HTML完成！"; //見出し部分
                labelText.Text = "お疲れ様です！\nタグや文章を変えて、自分だけのページに\n挑戦してみてください！"; //本文の部分

                sw = 7;
            }

            // ５.名前をつけて保存
            if (sw == 5)
            {
                //テキストの表示
                labelTitle.ForeColor = Color.Black; //タイトル文字を黒色にする
                labelTitle.Text = "５.名前をつけて保存"; //見出し部分
                labelText.Text = "最後に変更を保存しましょう\n名前を付けて保存ボタンを選んで\nお好きな名前で保存してください"; //本文の部分
                //labelText.Text = "最後に変更を保存しましょう\n名前を付けて保存ボタンを選んで\n'webkun.html'という名前で保存してください"; //本文の部分

                //if (System.IO.File.Exists(fileName))      //kantan.htmlが作成済みか判定
                //{
                //テキストの表示
                //labelTitle.Text = "５.名前をつけて保存"; //見出し部分
                //labelText.Text = "HTMLの保存が終わりましたね！\n基本的にHTMLの名前は\n半角英文字で入力します"; //本文の部分

                //チュートリアルを進める
                sw = 6;
                //}
            }

            // ４.本文作成
            if (sw == 4) //新規作成後に「次へ」をクリックしたか判定
            {
                //テキストの表示
                labelTitle.ForeColor = Color.Black; //タイトル文字を黒色にする
                labelTitle.Text = "４．本文作成"; //見出し部分
                labelText.Text = "いよいよ記事の本文作成です\n素材の欄からテキストアイコンを選んで\n'チュートリアルの体験中'と入力してください"; //本文の部分

                if (tutoPrev.Contains("チュートリアルの体験中")) //本文が入力されたか判定
                {
                    //テキストの表示
                    labelTitle.ForeColor = Color.Gray; //タイトル文字を灰色にする
                    labelTitle.Text = "４．本文作成(完了！)"; //見出し部分
                    labelText.Text = "かんたんウェブ君では本文を改行できます\nぜひ使ってみてくださいね"; //本文の部分

                    ////チュートリアルを進める
                    sw = 5;
                }
            }

            // ３．見出し作成
            if (sw == 3) //タイトル入力後に「次へ」をクリックしたか判定
            {
                //テキストの表示
                labelTitle.ForeColor = Color.Black; //タイトル文字を黒色にする
                labelTitle.Text = "３．見出し作成"; //見出し部分
                labelText.Text = "続いて見出しを作成しましょう！\n素材の欄から見出しアイコンを選んで\n'かんたんウェブ君'と入力してください"; //本文の部分

                if (tutoPrev.Contains("<h1>かんたんウェブ君</h1>")) //見出しを入力したか判定
                {
                    //テキストの表示
                    labelTitle.ForeColor = Color.Gray; //タイトル文字を灰色にする
                    labelTitle.Text = "３．見出し作成(完了！)"; //見出し部分
                    labelText.Text = "いいですね！プレビューに反映されました\n見出しは記事の内容が分かるように\n設定しましょう";

                    //チュートリアルを進める
                    sw = 4;
                }
            }

            //２.タイトル作成
            if (sw == 2) //新規作成済みか判定
            {
                //テキストの表示
                labelTitle.ForeColor = Color.Black; //タイトル文字を黒色にする
                labelTitle.Text = "２．タイトルの作成";                                                            //見出し部分
                labelText.Text = "次にタイトルを考えてみましょう！\nタイトル欄に'はじめまして'と入力してください"; //本文の部分

                if (tutoTitle == "はじめまして")    //タイトル入力済か判定
                {
                    //テキストの表示
                    labelTitle.ForeColor = Color.Gray; //タイトル文字を灰色にする
                    labelTitle.Text = "２．タイトルの作成(完了！)";
                    labelText.Text = "これでタイトルはブラウザのタブに表示されます"; //本文の部分

                    //チュートリアルを進める
                    sw = 3;
                }
            }

            // １．新規作成
            if (sw == 1) //最初に「次へ」をクリックしたか判定
            {
                //テキストの表示
                labelTitle.Text = "１．新規作成";                                                    //見出し部分
                labelText.Text = "新しいHTMLを作成しましょう！\n新規作成ボタンをクリックして下さい"; //本文の部分

                if (tutoBar == "かんたんWeb君 - 新規作成")    //新規作成済みか判定
                {
                    //テキストの表示
                    labelTitle.ForeColor = Color.Gray; //タイトル文字を灰色にする
                    labelTitle.Text = "１．新規作成(完了！)";
                    labelText.Text = "新規作成ボタンを押すことで\n空のHTMLを作成できます"; //本文の部分

                    //チュートリアルを進める
                    sw = 2;
                }
            }
        }

        /*
         * チュートリアル
         */
        

        private void Tutorial_Parts_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //メッセージの表示
            DialogResult dr = MessageBox.Show("チュートリアルを終了しますか？", "終了",
        MessageBoxButtons.YesNo);

            //チュートリアルを終了するか判定
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                //はい…チュートリアルを終了(空白)
            }
            else
            {
                //いいえ…チュートリアル続行
                e.Cancel = true;
            }
        }

        private void Tutorial_Parts_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext_Click_1();
        }
    }
}
