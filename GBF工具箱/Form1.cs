using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace GBF工具箱
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.label1.Text = DateTime.Now.ToString();
            label17.Text = "100%";//label初始
            label18.Text = "100%";//label初始
            userviewbox.Text = richTextBox2.Text;//fs初始

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 攒井计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bool choose = false;
            int bjs;
            int SingleExtract;
            int TenExtract;
            int SumBjs;
            float rate = 0;

            try
            {
                //空值为0
                if (this.textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                if (this.textBox2.Text == "")
                {
                    textBox2.Text = "0";
                }
                if (this.textBox3.Text == "")
                {
                    textBox3.Text = "0";
                }
                bjs = Convert.ToInt32(this.textBox1.Text);
                SingleExtract = Convert.ToInt32(this.textBox2.Text);
                TenExtract = Convert.ToInt32(this.textBox3.Text);
                SumBjs = bjs + SingleExtract * 300 + TenExtract * 3000;
                rate = (float)SumBjs * 100 / 90000; //攒井进度
                choose = true;
            }
            catch
            {
                this.label6.Visible = true;
                this.label7.Visible = true;
                progressBar1.Value = 0;
                label6.Text = "别闹了";
                label7.Text = "请输入正确的数值";
            }


            if (choose == true)
            {
                this.label6.Visible = true;
                this.label7.Visible = true;
                pictureBox2.Visible = true;
                label6.Text = "你的攒井进度为" + rate.ToString("0.000") + "%";

                //各种情况
                if (0 <= rate && rate < 10)
                {
                    label7.Text = "10%都没到，不要停下来啊，拆井人";
                    pictureBox2.Image = GBF工具箱.Properties.Resources.stamp32;
                }
                else
                if (10 <= rate && rate <= 30)
                {
                    label7.Text = "你已经在路上了";
                    pictureBox2.Image = GBF工具箱.Properties.Resources.stamp32;
                }
                else
                if (30 < rate && rate <= 50)
                {
                    label7.Text = "已经过30%啦，再忍忍，别拆啦";
                    pictureBox2.Image = GBF工具箱.Properties.Resources.stamp33;
                }
                else
                if (50 < rate && rate <= 80)
                {
                    label7.Text = "已经过50%啦，等KMR哥哥多送点，就#了";
                    pictureBox2.Image = GBF工具箱.Properties.Resources.stamp34;
                }
                else
                if (80 < rate && rate < 100)
                {
                    label7.Text = "已经过80%啦，快把暴晒的群友都屏蔽";
                    pictureBox2.Image = GBF工具箱.Properties.Resources.stamp35;
                }
                else
                if (100 <= rate && rate < 1000)
                {
                    label7.Text = "六限、季限、贵族、性欲全来！！！";
                    pictureBox2.Image = GBF工具箱.Properties.Resources.stamp1;
                    rate = 100;
                }
                else
                if (1000 <= rate)
                {
                    label7.Text = "蟹蟹兄弟，已经1000%了";
                    pictureBox2.Image = GBF工具箱.Properties.Resources.stamp124;
                    rate = 100;
                }
                else
                if (rate < 0)
                {
                    pictureBox2.Visible = false;
                    progressBar1.Value = 0;
                    label6.Text = "别闹了";
                    label7.Text = "请输入正确的数值";
                }

                progressBar1.Value = Convert.ToInt32(rate);

            }



        }

        #region 网页标签
        /// <summary>
        /// 用户选择浏览器
        /// </summary>
        private string browsers()
        {
            //string browser = comboBox1.Text;
            string browser = "";
            switch (comboBox1.Text)
            {
                case "谷歌浏览器":
                    browser = "chrome";
                    break;
                case "火狐浏览器":
                    browser = "firefox";
                    break;
                case "IE":
                    browser = "iexplore";
                    break;
                case "360浏览器":
                    browser = "360Browser";
                    break;
                case "系统默认":
                    browser = "";
                    break;
            }
            return browser;
        }
        /// <summary>
        /// 打开网页
        /// </summary>
        /// <param name="url"></param>
        private void OpenWed(string url)
        {

            try
            {

                System.Diagnostics.Process.Start(browsers(), @url);

            }
            catch
            {
                System.Diagnostics.Process.Start(url);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //OpenWed("https://tbw.346lab.org/");
            OpenWed("https://gbf-raidfinder.teemo.name/");
       
        }


        private void button3_Click(object sender, EventArgs e)
        {
            OpenWed("http://gbf.huijiwiki.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenWed("https://xn--bck3aza1a2if6kra4ee0hf.gamewith.jp/");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenWed("https://gacha.danmu9.com/");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenWed("http://game.granbluefantasy.jp/#shop");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenWed("http://game.granbluefantasy.jp/#quest/assist");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenWed("http://game.granbluefantasy.jp/#party/index/0/npc/0");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenWed("http://game.granbluefantasy.jp/#list");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenWed("http://game.granbluefantasy.jp/#item");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenWed("http://game.granbluefantasy.jp/#quest/multi/0");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenWed("http://game.granbluefantasy.jp/#quest/extra");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //转世
            OpenWed("http://game.granbluefantasy.jp/#arcarum2/index_force");
        }

        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            //实时时间 必要组件
            this.label1.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer1.Start();




        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        #region fs打点

        int MainHp;
        int WingHp;
        /// <summary>
        /// 特动基于本体的主要信息判断
        /// </summary>
        /// <param name="MainHp"></param>
        /// <param name="WingHp"></param>
        public void FsHpMsg(int MainHp, int WingHp)
        {
            int choose = -1;

            if (MainHp == 100 && WingHp == 100)
            {
                choose = 0;
            }
            else if ((MainHp <= 95 && 90 <= MainHp))
            {
                choose = 1;
            }
            else if ((MainHp <= 85 && 75 < MainHp))
            {
                choose = 2;
            }
            else if ((MainHp <= 75 && 70 < MainHp) && 50 <= WingHp)
            {
                choose = 3;
            }
            else if ((MainHp <= 75 && 70 < MainHp) && 0 < WingHp)
            {
                choose = 4;
            }
            else if ((MainHp <= 70 && 60 < MainHp))
            {
                choose = 5;
            }
            else if ((MainHp <= 60 && 55 < MainHp))
            {
                choose = 6;
            }
            else if ((MainHp == 55))
            {
                choose = 7;
            }
            else if ((MainHp <= 50 && 35 < MainHp))
            {
                choose = 8;
            }
            else if ((MainHp <= 35 && 25 < MainHp) && 0 < WingHp)
            {
                choose = 9;
            }
            else if ((MainHp <= 35 && 25 < MainHp) && 0 == WingHp) //翅膀击杀情况
            {
                choose = 10;
            }
            else if (MainHp <= 25 && 20 < MainHp)
            {
                choose = 11;
            }
            else if (MainHp <= 20 && 15 < MainHp)
            {
                choose = 12;
            }
            else if (MainHp <= 15 && 10 < MainHp)
            {
                choose = 13;
            }
            else if (MainHp <= 10 && 3 < MainHp)
            {
                choose = 14;
            }
            else if (MainHp <= 3 && 0 < MainHp)
            {
                choose = 15;
            }
            else if (MainHp == 0)
            {
                choose = 16;
            }



            switch (choose)
            {
                case 0:
                    userviewbox.Text = richTextBox2.Text;
                    break;
                case 1:
                    userviewbox.Text = richTextBox3.Text;
                    break;
                case 2:
                    userviewbox.Text = richTextBox4.Text;
                    break;
                case 3:
                    userviewbox.Text = richTextBox5.Text;
                    break;
                case 4:
                    userviewbox.Text = richTextBox6.Text;
                    break;
                case 5:
                    userviewbox.Text = richTextBox7.Text;
                    break;
                case 6:
                    userviewbox.Text = richTextBox8.Text;
                    break;
                case 7:
                    userviewbox.Text = richTextBox9.Text;
                    break;
                case 8:
                    userviewbox.Text = richTextBox10.Text;
                    break;
                case 9:
                    userviewbox.Text = richTextBox11.Text;
                    break;
                case 10:
                    userviewbox.Text = richTextBox10.Text;
                    break;
                case 11:
                    userviewbox.Text = richTextBox12.Text;
                    break;
                case 12:
                    userviewbox.Text = richTextBox13.Text;
                    break;
                case 13:
                    userviewbox.Text = richTextBox14.Text;
                    break;
                case 14:
                    userviewbox.Text = richTextBox15.Text;
                    break;
                case 15:
                    userviewbox.Text = richTextBox16.Text;
                    break;
                case 16:
                    userviewbox.Text = richTextBox17.Text;
                    break;


            }
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //trackbar 本体数值绑定
            //if (trackBar2.Value <= 11)
            //{
            //    trackBar1.Value = 0;
            //    this.label18.Text = "0%";
            //    progressBar2.Value = 0;
            //    trackBar1.Enabled = false;
            //}
            //else
            //{
            //    trackBar1.Enabled = true;
            //    this.label18.Text = (trackBar1.Value * 10).ToString() + "%";
            //    progressBar2.Value = trackBar1.Value;
            //}
            label17.Text = (trackBar2.Value * 5).ToString() + "%";

            progressBar3.Value = trackBar2.Value;

            MainHp = trackBar2.Value;
            WingHp = trackBar1.Value;
            FsMessage();

            if (WingHp <= 50 && (MainHp <= 50 && MainHp > 35))
            {
                //richTextBox10.Text = "55%时\n立即满豆\n\n解除路西法的\n福音的黑翼\n----------------------------------------------------";
                userviewbox.Text = richTextBox9.Text;
                if (MainHp <= 50 && 35 < MainHp)
                {
                    button14.Visible = false;
                }
            }
            else if(WingHp==0)
                {
                richTextBox11.Text = richTextBox9.Text;
                button14.Visible = false;
            }
            else
            { FsMessage(); }

        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //trackbar 翅膀数值绑定

            this.label18.Text = (trackBar1.Value * 10).ToString() + "%";
            progressBar2.Value = trackBar1.Value;

            FsMessage();

            if ((WingHp <= 70 && WingHp > 50) && MainHp > 50)
            {
                userviewbox.Text = richTextBox18.Text;
            }
            else if (WingHp <= 50 && MainHp > 50)
            {
                userviewbox.Text = richTextBox19.Text;

            }
            else if (WingHp == 0)
            {


            }
            else
            {
                FsMessage();
            }

            //翅膀十二试炼按钮
            if (WingHp <= 50 && MainHp > 50)
            {
                button14.Visible = true;
            }
            else
            {
                button14.Visible = false;
            }


        }
        /// <summary>
        /// 相关的血量-信息判断
        /// </summary>
        public void FsMessage()
        {

            MainHp = trackBar2.Value * 5;
            WingHp = trackBar1.Value * 10;

            //if (MainHp<=55)
            //{
            //    WingHp = 0;
            //}
            if ((MainHp <= 50 && 35 < MainHp) && WingHp > 50)
            {
                button14.Visible = true;
            }
            else
            { button14.Visible = false; }

            if (MainHp == 0)
            {
                pictureBox4.Visible = true;
            }
            else
            { pictureBox4.Visible = false; }

            FsHpMsg(MainHp, WingHp);

        }




        #endregion

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(this);
        }



        private void label20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://gbf.huijiwiki.com/wiki/Boss/%E8%B7%AF%E8%A5%BF%E6%B3%95Hard");
        }
    }

}
