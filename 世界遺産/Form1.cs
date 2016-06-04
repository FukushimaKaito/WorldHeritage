using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)//海外
            {
                Random o = new Random();
                int x = o.Next(1,18);
                if (x == 1)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\pira.jpg");
                    label1.Text = "ギザのピラミッド";
                    label2.Text = "エジプト";
                }
                if (x == 2)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\koro.jpg");
                    label1.Text = "コロッセオ";
                    label2.Text = "イタリア（ローマ）";
                }
                if (x == 3)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\ma.jpg");
                    label1.Text = "マチュピチュ遺跡";
                    label2.Text = "ペルー";
                }
                if (x == 4)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\an.jpg");
                    label1.Text = "アンコールワット";
                    label2.Text = "カンボジア";
                }
                if (x == 5)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\na.jpg");
                    label1.Text = "ナスカの地上絵";
                    label2.Text = "ペルー";
                }
                if (x == 6)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\ga.jpg");
                    label1.Text = "アントニオガウディ-の作品群";
                    label2.Text = "スペイン";
                }
                if (x == 7)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\ka.jpg");
                    label1.Text = "ギョレメ国立公園およびカッパドキアの岩石遺跡群";
                    label2.Text = "トルコ";
                }
                if (x == 8)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\igu.jpg");
                    label1.Text = "イグアスの滝";
                    label2.Text = "ブラジル";
                }
                if (x == 9)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\ta.jpg");
                    label1.Text = "タージマハル";
                    label2.Text = "インド";
                }
                if (x == 10)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\mo.jpg");
                    label1.Text = "モンサンミシェルと湿地帯";
                    label2.Text = "フランス";
                }
                if (x == 11)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\bo.jpg");
                    label1.Text = "ボロブドゥール寺院遺跡群";
                    label2.Text = "インドネシア";
                }
                if (x == 12)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\a.jpg");
                    label1.Text = "アテナイのアクロポリス";
                    label2.Text = "ギリシャ";
                }
                if (x == 13)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\9.jpg");
                    label1.Text = "九寨溝（きゅうさいこう）";
                    label2.Text = "中華人民共和国";
                }
                if (x == 14)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\ba.jpg");
                    label1.Text = "万里の長城";
                    label2.Text = "中華人民共和国";
                }
                if (x == 15)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\gu.jpg");
                    label1.Text = "グランドキャニオン";
                    label2.Text = "アメリカ合衆国";
                }
                if (x == 16)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\gur.jpg");
                    label1.Text = "グレートバリアリーフ";
                    label2.Text = "オーストラリア";
                }
                if (x == 17)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\i.jpg");
                    label1.Text = "イースター島";
                    label2.Text = "チリ";
                }
            }
            else if(radioButton3.Checked)
            {
                Random kokunai =new Random();
                int y =kokunai.Next(1,17);
                if (y == 1)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\si.jpg");
                    label1.Text = "白神山地";
                    label2.Text = "青森県/秋田県";
                }
                if (y == 2)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\hi.jpg");
                    label1.Text = "平泉－仏国土（浄土）を表す建築・庭園及び考古学的遺跡群";
                    label2.Text = "岩手県平泉町";
                }
                if (y == 3)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\ni.jpg");
                    label1.Text = "日光の社寺";
                    label2.Text = "栃木県日光市";
                }
                if (y == 4)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\o.jpg");
                    label1.Text = "小笠原諸島";
                    label2.Text = "東京都小笠原村";
                }
                if (y == 5)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\i.jpg");
                    label1.Text = "石見銀山";
                    label2.Text = "島根県大田市";
                }
                if (y == 6)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\oki.jpg");
                    label1.Text = "琉球王国のグスク及び関連遺産群";
                    label2.Text = "沖縄県";
                }
                if (y == 7)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\na.jpg");
                    label1.Text = "古都奈良の文化財";
                    label2.Text = "奈良県奈良市";
                }
                if (y == 8)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\itsu.jpg");
                    label1.Text = "厳島神社";
                    label2.Text = "広島県廿日市市";
                }
                if (y == 9)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\gen.jpg");
                    label1.Text = "原爆ドーム";
                    label2.Text = "広島県広島市";
                }
                if (y == 10)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\kyo.jpg");
                    label1.Text = "古都京都の文化財";
                    label2.Text = "京都府/滋賀県";
                }
                if (y == 11)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\ho.jpg");
                    label1.Text = "法隆寺地域の仏教建造物";
                    label2.Text = "奈良県";
                }
                if (y == 12)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\him.jpg");
                    label1.Text = "姫路城";
                    label2.Text = "兵庫県姫路市";
                }
                if (y == 13)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\知床.jpg");
                    label1.Text = "知床";
                    label2.Text = "北海道";
                }
                if (y == 14)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\屋久島.jpg");
                    label1.Text = "屋久島";
                    label2.Text = "鹿児島県熊毛郡屋久島町";
                }
                if (y == 15)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\白川郷.jpg");
                    label1.Text = "白川郷・五箇山の合掌造り集落";
                    label2.Text = "岐阜県/富山県";
                }
                if (y == 16)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\紀伊山地の霊場と参詣道.jpg");
                    label1.Text = "紀伊山地の霊場と参詣道";
                    label2.Text = "和歌山県/奈良県/三重県";
                }
                
            }
            else if (textBox1.Text == "ピラミッド" || textBox1.Text == "piraniddo" || textBox1.Text == "エジプト")
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\pira.jpg");
                    label1.Text = "ギザのピラミッド";
                    label2.Text = "エジプト";
                }
            else if (textBox1.Text == "コロッセオ" || textBox1.Text == "korosseo" || textBox1.Text == "イタリア" || textBox1.Text == "ローマ" || textBox1.Text == "闘技場" || textBox1.Text == "コロッセウム")
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\koro.jpg");
                    label1.Text = "コロッセオ";
                    label2.Text = "イタリア（ローマ）";
                }
            else if (textBox1.Text == "ペルー" )
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\ma.jpg");
                    label1.Text = "マチュピチュ遺跡";
                    label2.Text = "ペルー";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\an.jpg");
                    label1.Text = "アンコールワット";
                    label2.Text = "カンボジア";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\na.jpg");
                    label1.Text = "ナスカの地上絵";
                    label2.Text = "ペルー";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\ga.jpg");
                    label1.Text = "アントニオガウディ-の作品群";
                    label2.Text = "スペイン";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\ka.jpg");
                    label1.Text = "ギョレメ国立公園およびカッパドキアの岩石遺跡群";
                    label2.Text = "トルコ";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\igu.jpg");
                    label1.Text = "イグアスの滝";
                    label2.Text = "ブラジル";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\ta.jpg");
                    label1.Text = "タージマハル";
                    label2.Text = "インド";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\mo.jpg");
                    label1.Text = "モンサンミシェルと湿地帯";
                    label2.Text = "フランス";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\bo.jpg");
                    label1.Text = "ボロブドゥール寺院遺跡群";
                    label2.Text = "インドネシア";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\a.jpg");
                    label1.Text = "アテナイのアクロポリス";
                    label2.Text = "ギリシャ";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\9.jpg");
                    label1.Text = "九寨溝（きゅうさいこう）";
                    label2.Text = "中華人民共和国";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\ba.jpg");
                    label1.Text = "万里の長城";
                    label2.Text = "中華人民共和国";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\gu.jpg");
                    label1.Text = "グランドキャニオン";
                    label2.Text = "アメリカ合衆国";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\gur.jpg");
                    label1.Text = "グレートバリアリーフ";
                    label2.Text = "オーストラリア";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\out\i.jpg");
                    label1.Text = "イースター島";
                    label2.Text = "チリ";
            }
            else if (textBox1.Text == "")

            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\si.jpg");
                    label1.Text = "白神山地";
                    label2.Text = "青森県/秋田県";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\hi.jpg");
                    label1.Text = "平泉－仏国土（浄土）を表す建築・庭園及び考古学的遺跡群";
                    label2.Text = "岩手県平泉町";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\ni.jpg");
                    label1.Text = "日光の社寺";
                    label2.Text = "栃木県日光市";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\o.jpg");
                    label1.Text = "小笠原諸島";
                    label2.Text = "東京都小笠原村";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\i.jpg");
                    label1.Text = "石見銀山";
                    label2.Text = "島根県大田市";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\oki.jpg");
                    label1.Text = "琉球王国のグスク及び関連遺産群";
                    label2.Text = "沖縄県";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\na.jpg");
                    label1.Text = "古都奈良の文化財";
                    label2.Text = "奈良県奈良市";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\itsu.jpg");
                    label1.Text = "厳島神社";
                    label2.Text = "広島県廿日市市";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\gen.jpg");
                    label1.Text = "原爆ドーム";
                    label2.Text = "広島県広島市";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\kyo.jpg");
                    label1.Text = "古都京都の文化財";
                    label2.Text = "京都府/滋賀県";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\ho.jpg");
                    label1.Text = "法隆寺地域の仏教建造物";
                    label2.Text = "奈良県";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\him.jpg");
                    label1.Text = "姫路城";
                    label2.Text = "兵庫県姫路市";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\知床.jpg");
                    label1.Text = "知床";
                    label2.Text = "北海道";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\屋久島.jpg");
                    label1.Text = "屋久島";
                    label2.Text = "鹿児島県熊毛郡屋久島町";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\白川郷.jpg");
                    label1.Text = "白川郷・五箇山の合掌造り集落";
                    label2.Text = "岐阜県/富山県";
                }
            else if (textBox1.Text == "")
            {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\kaito\Pictures\wonderfullplace\in\紀伊山地の霊場と参詣道.jpg");
                    label1.Text = "紀伊山地の霊場と参詣道";
                    label2.Text = "和歌山県/奈良県/三重県";
                }
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("http://ja.wikipedia.org/wiki/%E4%B8%96%E7%95%8C%E9%81%BA%E7%94%A3");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}