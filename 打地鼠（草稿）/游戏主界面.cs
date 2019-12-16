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
    public partial class 游戏主界面 : Form
    {
        int time = 0;//时间
        int count = 0;//得分
        int uncount = 0;//失误
        int num = 0;//控制图片的出现
        int pat = 0;//判断是得分还是失误
        public 游戏主界面()
        {
            InitializeComponent();
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
                textBox1.Text = "";
                MessageBox.Show("请输入时间!");

            }
            label3.Text = "游戏得分：0";
            label5.Text = "游戏失误：0";
            try 
            {
                timer1.Enabled = true;            
                progressBar1.Maximum = Convert.ToInt32(textBox1.Text);
                progressBar1.Value = Convert.ToInt32(textBox1.Text);
            }
            
            catch
            {   
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            
                timer1.Enabled = false;
                MessageBox.Show("请选择难度！");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random a = new Random();
            int num = a.Next(6);
            switch (num)
            {
                case (1):
                    p1.Visible = true;
                    break;

                case (2):
                    p2.Visible = true;
                    break;
                    
                case (3):
                    p3.Visible = true;
                    break;
                    
                case (4):
                    p4.Visible = true;
                    break;
                   
                case (5):
                    p5.Visible = true;
                    break;
                  
                case (6):
                    p6.Visible = true;
                    break;
                    
            }
            if (pat == 1)
            {
                pat = 0;
            }
            else
            {
                compare();
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
            p1.Image = imageList2.Images[0];
            pat = 1;
            compare();
            p1.Visible = false;
            p1.Image = imageList1.Images[0];
        }

        private void p5_Click(object sender, EventArgs e)
        {
            p5.Image = imageList2.Images[0];
            pat = 1;
            compare();
            p5.Visible = false;
            p5.Image = imageList1.Images[0];
        }

        private void p4_Click(object sender, EventArgs e)
        {
            p4.Image = imageList2.Images[0];
            pat = 1;
            compare();
            p4.Visible = false;
            p4.Image = imageList1.Images[0];
        }

        private void p2_Click(object sender, EventArgs e)
        {
            p2.Image = imageList2.Images[0];
            pat = 1;
            compare();
            p2.Visible = false;
            p2.Image = imageList1.Images[0];
        }

        private void p3_Click(object sender, EventArgs e)
        {
            p3.Image = imageList2.Images[0];
            pat = 1;
            compare();
            p3.Visible = false;
            p3.Image = imageList1.Images[0];
        }

        private void p6_Click(object sender, EventArgs e)
        {
            p6.Image = imageList2.Images[0];
            pat = 1;
            compare();
            p6.Visible = false;
            p6.Image = imageList1.Images[0];
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                timer1.Interval = 1000;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                timer1.Interval = 700;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                timer1.Interval = 400;
            }
        }
        private void compare()
        {
            int result = pat;
            switch (result)
            { 
                case 0 :
                    uncount++;
                    label5.Text = "游戏失误：" + uncount;
                    break;
                case 1:
                    count++;
                    label3.Text = "游戏得分：" + count;
                    break;
            }
        }
    }
}

