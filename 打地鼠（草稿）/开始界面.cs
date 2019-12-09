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
    public partial class 初始界面 : Form
    {
        
        public 初始界面()
        {
            InitializeComponent();
            

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
