using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace LotterySystem
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
            Application.Run(new FormMain());
        }
        //定义全局静态变量
        //【1】人员信息中所有人的信息明细
        public static List<Person> objListPerson = null;
        //【2】抽奖设置----标题
        public static string startDrawTitle = null;
        //【3】抽奖设置---小奖到大奖？false--->小---》大；ture--->大--->小
        public static bool drawOrder = false;
        //【4】抽奖设置---允许重复？
        public static bool IsAllowTimes = false;
        //【5】抽奖设置---奖品信息明细
        public static List<Prize> objListPrize = null;
        //【6】开始抽奖---中奖者信息
        public static List<LuckyPerson> objListLuckyPerson = null;
        //【7】记录中奖人员信息的文件路径
        public static string LuckyPersonPath = ".\\result.txt"; 
    }
}
