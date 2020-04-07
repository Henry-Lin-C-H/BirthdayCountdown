using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthDayCounting
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            var month = DateTime.Now.Month;
            var day = DateTime.Now.Day;
            var year = DateTime.Now.Year;

            var time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            var age = 0;

            bool birthAlready = false;
            if (month == 11)
            {
                if (day > 28) { birthAlready = true; }
            }
            else if (month > 11)
            {
                birthAlready = true;
            }
            else { birthAlready = false; }


            if (birthAlready) { year++; age = year - 1991; }
            else { age = year - 1 - 1991; }

            var birthday = new DateTime(year, 11, 28);
            var rema = new TimeSpan(birthday.Ticks - DateTime.Now.Ticks).Days;

            string version = Application.ProductVersion;

            if (DateTime.Now.Day == birthday.Day && DateTime.Now.Month == birthday.Month)
                { MessageBox.Show($"今天生日唷～\n{age + 1}歲生日快樂！", $"生日倒數計時器 V{version}"); }
            else { MessageBox.Show($"距離生日還有:{rema}天\n目前:{age}歲", $"生日倒數計時器 V{version}"); }
        }
    }
}
