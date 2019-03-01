using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Models;
using DAL;

namespace LotterySystem
{
    public partial class FormDrawResult : Form
    {
        //定义查询列表变量
        List<LuckyPerson> objListQueryLucky = new List<LuckyPerson>();
        //实例化中奖人员功能,以便调用 LuckyPersonServices 类中的功能
        private LuckyPersonServices objLuckyPersonServvices = new LuckyPersonServices();
        public FormDrawResult()
        {
            InitializeComponent();
            //初始化dgvLuckyPerson
            //刷新
            dgvLuckyPerson.DataSource = null;
            dgvLuckyPerson.AutoGenerateColumns = false;
            dgvLuckyPerson.DataSource = Program.objListLuckyPerson;
        }

        private void btnClose_Click(object sender, EventArgs e)//关闭抽奖结果页面
        {
            Close();
        }

        private void FormDrawResult_FormClosing(object sender, FormClosingEventArgs e)//关闭页面时，把全局变量objFrmDrawResult为空
        {
            FormMain.objFrmDrawResult = null;
        }

        private void txtQueryLuckyName_TextChanged(object sender, EventArgs e)//按照姓名查询
        {
            //[1]清空objListQueryLucky
            objListQueryLucky.Clear();
            //[2]获取满足条件的Person
            objListQueryLucky = objLuckyPersonServvices.GetLuckyPersonByName(txtQueryLuckyName.Text.Trim(), Program.objListLuckyPerson);
            //[3]绑定到dataGridView中
            dgvLuckyPerson.DataSource = null;
            dgvLuckyPerson.AutoGenerateColumns = false;
            dgvLuckyPerson.DataSource = objListQueryLucky;

        }

        private void txtQueryLuckyMobile_TextChanged(object sender, EventArgs e)//按照电话号码查询
        {
            //[1]清空objListQueryLucky
            objListQueryLucky.Clear();
            //[2]获取满足条件的Person
            objListQueryLucky = objLuckyPersonServvices.GetLuckyPersonByMobile(txtQueryLuckyMobile.Text.Trim(), Program.objListLuckyPerson);
            //[3]绑定到dataGridView中
            dgvLuckyPerson.DataSource = null;
            dgvLuckyPerson.AutoGenerateColumns = false;
            dgvLuckyPerson.DataSource = objListQueryLucky;
        }
    }
}
