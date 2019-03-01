using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace LotterySystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)//退出系统
        {
            Close();
        }
        #region 打开抽奖人员界面
        public static FormPerson objFrmPerson = null;
        private void btnPerson_Click(object sender, EventArgs e)//打开名单
        {
            if (objFrmPerson == null)
            {
                objFrmPerson = new FormPerson();
                objFrmPerson.Show();
            }
            else
            {
                objFrmPerson.Activate();
                objFrmPerson.WindowState = FormWindowState.Normal;
            }      
        }
        #endregion
        #region 打开奖项设置界面
        public static FormDrawSetting objFrmDrawSetting = null;
        private void btnDrawSetting_Click(object sender, EventArgs e)//奖项设置哦
        {
           if(objFrmDrawSetting == null)
            {
                objFrmDrawSetting = new FormDrawSetting();
                objFrmDrawSetting.Show();
            }
            else
            {
                objFrmDrawSetting.Activate();
                objFrmDrawSetting.WindowState = FormWindowState.Normal;
            }
        }
        #endregion
        #region 打开开始抽奖界面
        public static FormStartDraw objFrmStartDraw = null;
        private void btnStartDraw_Click(object sender, EventArgs e)
        {
            //判断窗口是否存在&&是否满足开始抽奖条件
            if (!IsReadyDraw()) return;
            if(objFrmStartDraw == null)
            {
                objFrmStartDraw = new FormStartDraw();
                objFrmStartDraw.Show();
            }
            else
            {
                objFrmStartDraw.Activate();
                objFrmStartDraw.WindowState = FormWindowState.Normal;
            }
        }
        #endregion
        #region 打开抽奖结果页面
        public static FormDrawResult objFrmDrawResult = null;
        private void btnDrawResult_Click(object sender, EventArgs e)
        {
            if (!IsReadyQuery()) return;
            if( objFrmDrawResult == null)
            {
                objFrmDrawResult = new FormDrawResult();
                objFrmDrawResult.Show();
            }
            else
            {
                objFrmDrawResult.Activate();
                objFrmDrawResult.WindowState = FormWindowState.Normal;
            }
        }

        #endregion
        private bool IsReadyDraw()
        {
            //人员导入
            if (Program.objListPerson == null)
            {
                MessageBox.Show("抽奖人员未导入，无法进行抽奖！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Program.startDrawTitle))
            {
                MessageBox.Show("抽奖标题未设置，无法进行抽奖！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (Program.objListPrize == null)
            {
                MessageBox.Show("奖品信息未添加，无法进行抽奖！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
            //奖品设置
        }//判断是否可以开始抽奖
        private bool IsReadyQuery()
        {
            if (Program.objListLuckyPerson == null)
            {
                MessageBox.Show("没有获奖人员信息，请先进行抽奖！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }//判断可以查询

    }
}
