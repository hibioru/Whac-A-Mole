using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打地鼠_草稿_
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            开始游戏 开始游戏 = new 开始游戏();
            开始游戏.ShowDialog();

            if (开始游戏.DialogResult == DialogResult.OK) 
            {
                开始游戏.Dispose();
                Application.Run(new 游戏主界面());
            }

            else if (开始游戏.DialogResult == DialogResult.Cancel) 
            {
                开始游戏.Dispose();
                return;
            }
            

          
        }
    }
}
