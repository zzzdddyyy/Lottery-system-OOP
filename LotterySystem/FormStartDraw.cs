using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using Common;
/// <summary>
/// 思路：先把中奖List<LuckyPerson>表建好，再往里面填充数据
/// </summary>

namespace LotterySystem
{
    public partial class FormStartDraw : Form
    {
        //中奖人员方法类
        private LuckyPersonServices objLuckyPersonServices = new LuckyPersonServices();
        //抽奖人员方法类
        private PersonServices objPersonServices = new PersonServices();
        private bool IsCurrentRankEnd = false;//表示当前级别奖品是否抽奖结束
        private bool IsAllRankEnd = false;//表示所有奖品是否抽完
        private int sumPrize = 0;//标识奖品总数
        private int sumDrawCounts = 0;//当前抽了多少奖，每等级抽完归零
        private int totalDrawTimes = 0;//截至目前总共抽了多少次奖，不归零
        public FormStartDraw()
        {
            //初始化窗口数据
            InitializeComponent();
            //显示标题
            lblTitle.Text = "【" + Program.startDrawTitle + "】";
            //构建中奖（未知成员）空表
            if (Program.objListLuckyPerson == null)
            {
                //初始化中奖List
                Program.objListLuckyPerson=objLuckyPersonServices.Initialize(Program.objListPrize, Program.drawOrder);
                //初始化奖品总数
                sumPrize = Program.objListLuckyPerson.Count;
            }
 
        }

        private void btnClose_Click(object sender, EventArgs e)//关闭开始抽奖界面
        {
            if (!IsAllRankEnd)
            {
                MessageBox.Show("抽奖未完成，请继续抽奖！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("退出抽奖，是否保存中奖人员记录？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //保存
                FileOperator.SaveLuckyPerson(Program.LuckyPersonPath, Program.objListLuckyPerson);
                MessageBox.Show("保存成功，您可以到中奖人员信息界面查阅！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                DialogResult re = MessageBox.Show("确定不保存吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    Close();
                }
                else
                {
                    //保存
                    //保存
                    FileOperator.SaveLuckyPerson(Program.LuckyPersonPath, Program.objListLuckyPerson);
                    MessageBox.Show("保存成功，您可以到中奖人员信息界面查阅！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }

        }

        private void FormStartDraw_FormClosing(object sender, FormClosingEventArgs e)//全局变量objFrmStartDraw 为空
        {
            FormMain.objFrmStartDraw = null;
        }

        private void btnStartOrStop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 112)//112==F1

            {
                if (IsAllRankEnd)
                {
                    MessageBox.Show("抽奖结束！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //清空中奖者列表
                lboxperson.Items.Clear();
                //初始化奖品Label
                lblCurrentRank.Text = Program.objListLuckyPerson[totalDrawTimes].PrizeRank + "        奖品：" + Program.objListLuckyPerson[totalDrawTimes].PrizeName +
                    "         共" + Program.objListLuckyPerson[sumDrawCounts].PrizeCount + "名";
                //向ListBox里面写入当前抽奖信息：
                lboxperson.Items.Add(Program.objListLuckyPerson[totalDrawTimes].PrizeRank + "         共" + Program.objListLuckyPerson[totalDrawTimes].PrizeCount + "名");
                //控制当前是否结束标签-----false
                IsCurrentRankEnd = false;
                //当前级别抽奖次数归零
                sumDrawCounts = 0;
                //显示当前级别抽奖结束
            }
        }

        private void btnStartOrStop_Click(object sender, EventArgs e)
        {
            //判断是否按了F1
            if (string.IsNullOrWhiteSpace(lblCurrentRank.Text))
            {
                string info = "请先按F1启动抽取" + Program.objListLuckyPerson[sumDrawCounts].PrizeRank + "的程序！";
                MessageBox.Show(info, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //判断当前抽奖是否结束
            if (IsAllRankEnd)
            {
                string info = "所有奖品已全部抽完，可在中奖结果中查询中奖信息！";
                MessageBox.Show(info, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //判断当前级别奖品是否抽完
            if (IsCurrentRankEnd)
            {
                string info = Program.objListLuckyPerson[totalDrawTimes - 1].PrizeRank + "已全部抽完，中奖人员见右边列表---->！";
                MessageBox.Show(info, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //开始执行事件
            if (btnStartOrStop.Text.Contains("开始"))
            {
                //字体变成结束
                btnStartOrStop.Text = "停止";
                //开始跳动（计时器工作）
                timer1.Enabled = true;
            }
            //停止事件
            else
            {
                //字体变成开始
                btnStartOrStop.Text = "开始";
                //停止跳动（计时器停止工作）
                timer1.Enabled = false;
                //当前级别抽奖数加一
                sumDrawCounts += 1;
                //截至目前抽奖数加一
                totalDrawTimes++;
                //把中奖人员信息填入右边的box
                lboxperson.Items.Add(sumDrawCounts + "、"+lblLuckyPerson.Text);
                //中奖人员信息写入：Program.objListLuckyPerson
                objLuckyPersonServices.WritePersonInfo(lblLuckyPerson.Text, Program.objListLuckyPerson[totalDrawTimes - 1]);
                //如果不允许重复抽奖，就把该人员信息从objPerson中删除
                if (!Program.IsAllowTimes)
                {
                    //从objPerson中删除
                    objPersonServices.DeleteLuckyPersonFromListPerson(lblLuckyPerson.Text, Program.objListPerson);
                }
                //判断当前级别抽奖是否结束
                if (sumDrawCounts == int.Parse(Program.objListLuckyPerson[totalDrawTimes - 1].PrizeCount))
                {
                    //当前级别结束
                    IsCurrentRankEnd = true;
                    string info = Program.objListLuckyPerson[totalDrawTimes - 1].PrizeRank + "已全部抽完，恭喜以上获奖者！";
                    lblCurrentRank.Text = info;
                }
                if(totalDrawTimes== sumPrize)
                {
                    //所有抽奖结束
                    IsAllRankEnd = true;
                }
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLuckyPerson.Text = objPersonServices.GetOnePerson(Program.objListPerson);
        }


        //自定义事件

    }
}
