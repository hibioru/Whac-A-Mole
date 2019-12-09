using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打地鼠_草稿_
{
    public partial class Form1 : Form
    {
        int time = 0;//时间
        int count = 0;//得分
        int uncount = 0;//失误
        int num = 0;//控制图片的出现
        int pat = 0;//判断得分
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            p6.Image = imageList1.Images[1];
            pat = 1;
            if (pat == 1)
            {
                count++;
                label3.Text = "游戏得分:" + count;
                pat = 0;
            }
            else
            {
                uncount++;
                label3.Text = "游戏得分:" + count;
                label5.Text = "游戏失误:" + uncount;
            }
            p6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //游戏开始的按钮，大概效果就是按下之后按钮隐藏，所有图片隐藏，游戏时间和得分为0，timer全部不动。
            button1.Visible = false;
            timer1.Enabled = true;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            p6.Visible = false;
            count = 0;
            pat = 0;
            try
            {
                time = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                textBox1 .Text  ="";
                MessageBox.Show("错误");
                Application.Exit();
            }
            label3.Text = "游戏得分：0";
            label5.Text = "游戏失误：0";
            if (timer1.Enabled == true)
            {
                progressBar1.Maximum = Convert.ToInt32(textBox1.Text);
                progressBar1.Value = Convert.ToInt32(textBox1.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a = new Random();
            int num = a.Next(6);
            switch (num)
            {
                case(1):
                    p1.Visible = true;
                    break;
                    p1.Visible = false;
                    break;
                case(2):
                    p2.Visible = true;
                    break;
                    p2.Visible = false;
                    break;
                case(3):
                    p3.Visible = true;
                    break;
                    p3.Visible = false;
                    break;
                case(4):
                    p4.Visible = true;
                    break;
                    p4.Visible = false;
                    break;
                case(5):
                    p5.Visible = true;
                    break;
                    p5.Visible = false;
                    break;
                case(6):
                    p6.Visible = true;
                    break;
                    p6.Visible = false;
                    break;
            }
            if (time >= 1)
            {
                time--;
                progressBar1.Value = time;
            }
            else
            {
                time = 0;
                progressBar1.Value = time;
            }
            timer2.Enabled = true;
        }

        private void p1_Click(object sender, EventArgs e)
        {
            p1.Image = imageList1.Images[1];
            pat = 1;
            if (pat == 1)
            {
                count++;
                label3.Text = "游戏得分:" + count;
                pat = 0;
                p1.Visible = false;
            }
            else
            {
                uncount++;
                label3.Text = "游戏得分:" + count;
                label5.Text = "游戏失误:" + uncount;
                p1.Visible = false;
            }

        }

        private void p5_Click(object sender, EventArgs e)
        {
            p5.Image = imageList1.Images[1];
            pat = 1;
            if (pat == 1)
            {
                count++;
                label3.Text = "游戏得分:" + count;
                pat = 0;
                p5.Visible = false;
            }
            else
            {
                uncount++;
                label3.Text = "游戏得分:" + count;
                label5.Text = "游戏失误:" + uncount;
                p5.Visible = false;
            }
        }

        private void p4_Click(object sender, EventArgs e)
        {
            p4.Image = imageList1.Images[1];
            pat = 1;
            if (pat == 1)
            {
                count++;
                label3.Text = "游戏得分:" + count;
                pat = 0;
                p4.Visible = false;
            }
            else
            {
                uncount++;
                label3.Text = "游戏得分:" + count;
                label5.Text = "游戏失误:" + uncount;
                p4.Visible = false;
            }

        }

        private void p2_Click(object sender, EventArgs e)
        {
            p2.Image = imageList1.Images[1];
            pat = 1;
            if (pat == 1)
            {
                count++;
                label3.Text = "游戏得分:" + count;
                pat = 0;
                p2.Visible = false;
            }
            else
            {
                uncount++;
                label3.Text = "游戏得分:" + count;
                label5.Text = "游戏失误:" + uncount;
                p2.Visible = false;
            }

        }

        private void p3_Click(object sender, EventArgs e)
        {
            p3.Image = imageList1.Images[1];
            pat = 1;
            if (pat == 1)
            {
                count++;
                label3.Text = "游戏得分:" + count;
                pat = 0;
                p3.Visible = false;
            }
            else
            {
                uncount++;
                label3.Text = "游戏得分:" + count;
                label5.Text = "游戏失误:" + uncount;
                p3.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                timer1.Enabled = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p6.Visible = false;
                button1.Visible = true;
                button1.Text = "再来一次";
            }
            else
            {
                time--;
                progressBar1.Value = time;
            }
        }
    }
}
