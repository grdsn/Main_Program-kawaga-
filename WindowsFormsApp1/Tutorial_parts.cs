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
        main mn;                //メインフォームの取得

        //定義
        String tutoBar = "";      //タイトルバー
        String tutoTitle = "";    //タイトル欄
        String tutoPrev = "";        //プレビュー（見出し、本文）
        int sw = 1;                 //スイッチ。次へボタン押下時のフラグ管理

        /*
         * チュートリアルの画面表示
         */
        public Tutorial_Parts(main m)
        {
            // メイン・フォームへの参照を保存
            mn = m;
            //this.Owner = mn;

            //内容を画面反映する
            InitializeComponent();

            // 進捗の初期化
            progressBar1.Value = 0;

            //テキストの表示
            labelTitle.Text = "チュートリアルへようこそ!";                   //見出し部分
            labelText.Text = "それではかんたんなHTMLを作っていきましょう";   //本文の部分

        }

        /* 
         * 「次へ」ボタン押下時の処理
         */
        private void btnNext_Click(object sender, EventArgs e)
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

            if (sw == 10) //'HTML完成！'表示後「次へ」をクリックしたか判定
            {
                //テキストの表示
                labelText.Text = "HTML作成に慣れてきたら、プレビューボタンから\nHTMLのコード分析をおすすめします。"; //本文の部分

                //ボタンのテキスト変更
                btnNext.Text = "終了";

                //チュートリアルを進める
                sw = 0;
            }

            // .終了
            if (sw == 9) //名前を付けた後に「次へ」をクリックしたか判定
            {
                //テキストの表示
                labelTitle.Text = "チュートリアル完了！"; //見出し部分
                labelText.Text = "お疲れ様です！\nタグや文章を変えて、自分だけのページに\n挑戦してみてください！"; //本文の部分

                //チュートリアルを進める
                sw = 10;
            }

            //６.タグツリーの編集（削除）
            if (sw == 8)
            {
                //テキストの表示
                labelTitle.Text = "６.タグツリーの編集(削除)"; //見出し部分
                labelText.Text = "1.BODYボタンを押して編集ボタンを押す\n2.削除ボタンを押す\n3.削除したいボタンを押す\n※今回はBODY下のボタンを全て削除して下さい"; //本文の部分

                if (tutoPrev.Contains("<h1>かんたんウェブ君</h1>") || tutoPrev.Contains("チュートリアルの体験中")) { }    //<h1>かんたんウェブ君</h1>とチュートリアルの体験中が存在するか判定 
                else     //追加した素材タグ(かんたん～、チュート～)がすべて消された時実行
                {
                    //テキストの表示
                    progressBar1.Value = 100;//進行状況を進める
                    lblBar.Text = "100%";    // 進行状況を進めるテキスト追加
                    labelTitle.Text = "６.タグツリーの編集(削除)"; //見出し部分
                    labelText.Text = "削除ボタンを押せば追加した素材を削除できます\n(ただしHTML、BODY、HEAD、TITLEはタグを入れるために\n必要なため削除はできません)"; //本文の部分

                    //チュートリアルを進める
                    sw = 9;
                }
            }

            //６.タグツリーの編集
            if (sw == 7)
            {
                //テキストの編集
                labelText.Text = "それでは練習として<BODY>の\n中にある素材を削除しましょう！";
                sw = 8;
            }

            //６.タグツリーの編集
            if (sw == 6)
            {
                //テキストの表示
                labelTitle.Text = "６．タグツリーの編集(削除)"; //見出し部分
                labelText.Text = "追加した素材を編集しましょう！\n左下にあるタグツリーの中の<BODY>をクリックした後に\n編集ボタンをクリックして下さい"; //本文の部分

                if (mn.editflg == 1)    //削除ボタンが有効か判定
                {
                    //テキストの表示
                    labelText.Text = "タグツリーのHTML、BODY、HEAD、\nTITLEをクリックした後に\n編集ボタンを押すと削除ができます"; //本文の部分
                    //labelText.Text = "タグツリーでは追加した素材の編集ができます！\n編集は並び替えと削除の２種類があります\nまずは、並び替え機能を見てみましょう！"; //本文の部分(並び替え機能搭載Ver)

                    //チュートリアルを進める
                    sw = 7;     //並び替え機能を搭載した場合 'sw=7' に変更
                }
            }

            // ５.名前をつけて保存
            if (sw == 5)
            {
                //テキストの表示
                labelTitle.Text = "５.上書き保存"; //見出し部分
                labelText.Text = "変更を保存しましょう！\n上書きボタンをクリックしてみて下さい"; //本文の部分

                if (tutoBar.IndexOf("変更あり") <= 0)
                {
                    //テキストの表示
                    progressBar1.Value = 75;//進行状況を進める
                    lblBar.Text = "75%";    // 進行状況を進めるテキスト追加
                    labelTitle.Text = "５.上書き保存"; //見出し部分
                    labelText.Text = "素材の追加や編集をしたら\n消えないように保存をおすすめします"; //本文の部分

                    //チュートリアルを進める
                    sw = 6;
                }
            }

            // ４.本文作成
            if (sw == 4) //新規作成後に「次へ」をクリックしたか判定
            {
                //テキストの表示
                labelTitle.Text = "４．本文作成"; //見出し部分
                labelText.Text = "いよいよ記事の本文追加です\n素材の欄からテキストアイコンを選んで\n'チュートリアルの体験中'と入力してください"; //本文の部分

                if (tutoPrev.Contains("チュートリアルの体験中")) //本文が入力されたか判定
                {
                    //テキストの表示
                    progressBar1.Value = 60;//進行状況を進める
                    lblBar.Text = "60%";    // 進行状況を進めるテキスト追加
                    labelTitle.Text = "４．本文作成"; //見出し部分
                    labelText.Text = "かんたんウェブ君では本文を改行できます\nぜひ使ってみてくださいね"; //本文の部分

                    //チュートリアルを進める
                    sw = 5;
                }
            }

            // ３．見出し作成
            if (sw == 3) //タイトル入力後に「次へ」をクリックしたか判定
            {
                //テキストの表示
                labelTitle.Text = "３．見出し作成"; //見出し部分
                labelText.Text = "続いて見出しを追加しましょう！\n素材の欄から見出しアイコンを選んで\n'かんたんウェブ君'と入力してください"; //本文の部分

                if (tutoPrev.Contains("<h1>かんたんウェブ君</h1>")) //見出しを入力したか判定
                {
                    //テキストの表示
                    progressBar1.Value = 45;//進行状況を進める
                    lblBar.Text = "45%";    // 進行状況を進めるテキスト追加
                    labelTitle.Text = "３．見出し作成"; //見出し部分
                    labelText.Text = "素材リストから文章や画像などが追加できます\n見出しは記事の内容が分かるように設定しましょう";

                    //チュートリアルを進める
                    sw = 4;
                }
            }

            //２.タイトル作成
            if (sw == 2) //新規作成済みか判定
            {
                //テキストの表示
                labelTitle.Text = "２．タイトルの作成";                                                            //見出し部分
                labelText.Text = "次にタイトルを考えてみましょう！\nタイトル欄に'はじめまして'と入力してください"; //本文の部分

                if (tutoTitle == "はじめまして")    //タイトル入力済か判定
                {
                    //テキストの表示
                    progressBar1.Value = 30;//進行状況を進める
                    lblBar.Text = "30%";    // 進行状況を進めるテキスト追加
                    labelTitle.Text = "２．タイトルの作成";
                    labelText.Text = "タイトルはブラウザのタブに表示されます"; //本文の部分

                    //チュートリアルを進める
                    sw = 3;
                }
            }

            // １．新規作成
            if (sw == 1) //最初に「次へ」をクリックしたか判定
            {
                //テキストの表示
                labelTitle.Text = "１．新規作成";                                                    //見出し部分
                labelText.Text = "新しいHTMLを作成しましょう！\n1.新規作成ボタンをクリック\n2.'webkun'と入力\n3.追加ボタンをクリック"; //本文の部分

                if (tutoBar.Contains("webkun"))     //'webkun'を新規作成済みか判定
                {
                    //テキストの表示
                    labelTitle.Text = "１．新規作成";
                    labelText.Text = "新規作成ボタンを押すことで\n空のHTMLを作成できます"; //本文の部分
                    progressBar1.Value = 15;//進行状況を進める
                    lblBar.Text = "15%";    // 進行状況を進めるテキスト追加

                    //チュートリアルを進める
                    sw = 2;
                }
            }
        }

        /*
         * チュートリアル終了時の処理
         */
        private void Tutorial_Parts_FormClosing(object sender, FormClosingEventArgs e)
        {
            //メッセージの表示
            DialogResult tutoDr = MessageBox.Show("チュートリアルを終了しますか？", "終了",
            MessageBoxButtons.YesNo);

            //if () { } チュートリアルのイベント　か　メインのイベントかを判断

            //チュートリアルを終了するか判定
            if (tutoDr == System.Windows.Forms.DialogResult.Yes)
            {
                //はい…チュートリアルを終了(Tutorial＿Partsの情報破棄)
                this.Dispose();
            }
            else
            {
                //いいえ…チュートリアル続行(終了をキャンセル)
                e.Cancel = true;
            }
        }

        /*
         * 一覧メニュー           途中を飛ばす場合は説明のみ・矛盾しないものだけ判定
         */
        private void mnI01_Click_1(object sender, EventArgs e)      //新規作成
        {
            sw = 1;
            progressBar1.Value = 0;//進行状況を進める
            lblBar.Text = "0%";    // 進行状況を進めるテキスト追加
            this.btnNext.PerformClick();  //次へボタンを押したことにする
        }

        private void mnI02_Click(object sender, EventArgs e)        //タイトル作成
        {
            sw = 2;
            progressBar1.Value = 15;//進行状況を進める
            lblBar.Text = "15%";    // 進行状況を進めるテキスト追加
            this.btnNext.PerformClick();  //次へボタンを押したことにする 
        }

        private void mnI03_Click(object sender, EventArgs e)        //見出し作成
        {
            sw = 3;
            this.btnNext.PerformClick();  //次へボタンを押したことにする
            progressBar1.Value = 30;//進行状況を進める
            lblBar.Text = "30%";    // 進行状況を進めるテキスト追加
        }

        private void mnI04_Click(object sender, EventArgs e)        //本文作成
        {
            sw = 4;
            this.btnNext.PerformClick();  //次へボタンを押したことにする 
            progressBar1.Value = 45;//進行状況を進める
            lblBar.Text = "45%";    // 進行状況を進めるテキスト追加
        }

        private void mnI05_Click(object sender, EventArgs e)        //上書き保存
        {
            sw = 5;
            this.btnNext.PerformClick();  //次へボタンを押したことにする 
            progressBar1.Value = 60;//進行状況を進める
            lblBar.Text = "60%";    // 進行状況を進めるテキスト追加
        }

        private void mnI06_Click(object sender, EventArgs e)        //タグツリーの編集
        {
            sw = 6;
            this.btnNext.PerformClick();  //次へボタンを押したことにする 
            progressBar1.Value = 75;//進行状況を進める
            lblBar.Text = "75%";    // 進行状況を進めるテキスト追加
        }

        private void mnI07_Click(object sender, EventArgs e)        //終了
        {
            sw = 9;
            this.btnNext.PerformClick();  //次へボタンを押したことにする 
            progressBar1.Value = 100;//進行状況を進める
            lblBar.Text = "100%";    // 進行状況を進めるテキスト追加
        }

        private void Tutorial_Parts_Load(object sender, EventArgs e)
        {

        }
    }
}


