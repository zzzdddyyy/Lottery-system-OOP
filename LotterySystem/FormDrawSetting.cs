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

namespace LotterySystem
{
    public partial class FormDrawSetting : Form
    {
        //全局变量
        private int actionFlag = 0;//标识添加还是修改
        private PrizeServices objPrizeService = new PrizeServices();//实例化
        public FormDrawSetting()
        {
            InitializeComponent();
            //把奖品总数为空
            lblTotalPrize.Text =Convert.ToString("0") ;
            //初始化窗体数据
            txtDrawTitle.Text = Program.startDrawTitle;//标题
            if (Program.drawOrder) rbLargeToSmall.Checked = true;//抽奖顺序
            else rbSmallToLarge.Checked = true;
            if (Program.IsAllowTimes) rbAllowTwoTimes.Checked = true;//是否允许重复抽奖
            else rbDenyTwoTimes.Checked = true;
            //奖品明细区禁用
            gboxPrize.Enabled = false;
            //初始化全局变量objListPrize
            if (Program.objListPrize == null)//如果Program.objListPrize没有数据，就加载自定义的初始化数据
            {
                Program.objListPrize = new List<Prize>();
                LoadIntialData();
                dgvPrize.DataSource = null;
                dgvPrize.AutoGenerateColumns = false;
                dgvPrize.DataSource = Program.objListPrize;
                //加载明细
                txtPrizeID.Text = dgvPrize.Rows[0].Cells[0].Value.ToString();
                txtPrizeRank.Text = dgvPrize.Rows[0].Cells[1].Value.ToString();
                txtPrizeCounts.Text = dgvPrize.Rows[0].Cells[2].Value.ToString();
                txtPrizeName.Text = dgvPrize.Rows[0].Cells[3].Value.ToString();
                //计算总数
                lblTotalPrize.Text = Convert.ToString("0");
                lblTotalPrize.Text = PrizeCounts(Program.objListPrize).ToString();
            }
            else//如果有数据，直接加载全局变量Program.objListPrize数据
            {
                dgvPrize.DataSource = null;
                dgvPrize.AutoGenerateColumns = false;
                dgvPrize.DataSource = Program.objListPrize;
                //加载明细
                txtPrizeID.Text = dgvPrize.Rows[0].Cells[0].Value.ToString();
                txtPrizeRank.Text = dgvPrize.Rows[0].Cells[1].Value.ToString();
                txtPrizeCounts.Text = dgvPrize.Rows[0].Cells[2].Value.ToString();
                txtPrizeName.Text = dgvPrize.Rows[0].Cells[3].Value.ToString();
                //计算总数
                lblTotalPrize.Text = Convert.ToString("0");
                lblTotalPrize.Text = PrizeCounts(Program.objListPrize).ToString();
            }
           
        }



        //控件事件
        private void button8_Click(object sender, EventArgs e)//关闭设置
        {
            Close();
        }

        private void FormDrawSetting_FormClosing(object sender, FormClosingEventArgs e)//把主窗体中代表打开抽奖设置窗体的的变量为空
        {
            FormMain.objFrmDrawSetting = null;
        }

        private void btnSaveBasicSetting_Click(object sender, EventArgs e)
        {
            //判断抽奖标题是否存在
            if (string.IsNullOrWhiteSpace(txtDrawTitle.Text))
            {
                MessageBox.Show("请输入抽奖标题！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDrawTitle.Focus();
                return;
            }
            //为全局变量赋值
            //[1]标题
            Program.startDrawTitle = txtDrawTitle.Text.Trim();
            //[2]抽奖顺序
            Program.drawOrder = rbSmallToLarge.Checked == true ? false : true;
            //[3]重复抽奖
            Program.IsAllowTimes = rbDenyTwoTimes.Checked == true ? false : true;
            MessageBox.Show("设置成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)//为添加新奖品做准备
        {
            //禁用按钮
            DisableButton();
            //禁用奖品ID输入框
            txtPrizeID.Enabled = false;
            //自动生成奖品ID
            txtPrizeID.Text = objPrizeService.GetNewPrizeID(Program.objListPrize);
            //清空文本框
            txtPrizeRank.Text = string.Empty;
            txtPrizeName.Text = string.Empty;
            txtPrizeCounts.Text = string.Empty;
            //奖品级别获得焦点
            txtPrizeRank.Focus();
            //修改actionFlag
            actionFlag = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)//为修改奖品信息做准备
        {
            //禁用按钮
            DisableButton();
            //禁用奖品ID输入框
            txtPrizeID.Enabled = false;
            //奖品级别获得焦点
            txtPrizeCounts.Focus();
            //修改actionFlag
            actionFlag = 2;
        }

        private void btnDelete_Click(object sender, EventArgs e)//删除
        {
            if (dgvPrize.Rows.Count == 0)
            {
                MessageBox.Show("请先添加奖品信息！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (dgvPrize.CurrentRow.Selected == false) return;
            else
            {
                string info = "是否要删除【" + dgvPrize.CurrentRow.Cells[1].Value.ToString() + ":" + dgvPrize.CurrentRow.Cells[3].Value.ToString() + "】的信息？";
                DialogResult dialogResult = MessageBox.Show(info, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    objPrizeService.DeletePrize(dgvPrize.CurrentRow.Cells[0].Value.ToString(), Program.objListPrize);
                    //刷新数据
                    //刷新
                    LoadPrizeInfo(Program.objListPrize);
                    //更新数量
                    //把奖品总数为空,然后重新计算Program.objListPrize中所有项的数量
                    lblTotalPrize.Text = Convert.ToString("0");
                    lblTotalPrize.Text = PrizeCounts(Program.objListPrize).ToString();
                    //控制按钮
                    EnableButton();
                    MessageBox.Show("奖品删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else return;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)//提交添加|修改
        {
            //【1】数据校验
            if (!ValidataInput()) return;
            //【2】封装数据
            Prize objPrize = new Prize()
            {
                PrizeID = int.Parse(txtPrizeID.Text.Trim()),
                PrizeRank = txtPrizeRank.Text.Trim(),
                PrizeCounts =txtPrizeCounts.Text.Trim(),
                PrizeName = txtPrizeName.Text.Trim()
            };
            //【3】提交添加或者修改
            switch (actionFlag)
            {
                case 1://ADD
                    objPrizeService.AddPrize(objPrize, Program.objListPrize);
                    //刷新
                    LoadPrizeInfo(Program.objListPrize);
                    //更新数量
                    lblTotalPrize.Text = (int.Parse(lblTotalPrize.Text) + int.Parse(objPrize.PrizeCounts)).ToString();
                    //控制按钮
                    EnableButton();
                    MessageBox.Show("奖品添加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2://modify
                    //修改前把要修改的奖品数量减掉
                    //执行修改
                    objPrizeService.UpdatePrize(objPrize, Program.objListPrize);
                    //刷新
                    LoadPrizeInfo(Program.objListPrize);
                    //更新数量
                    //把奖品总数为空,然后重新计算Program.objListPrize中所有项的数量
                    lblTotalPrize.Text = Convert.ToString("0");
                    lblTotalPrize.Text = PrizeCounts(Program.objListPrize).ToString();
                    //控制按钮
                    EnableButton();
                    MessageBox.Show("奖品修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
        }

        private void btuCancel_Click(object sender, EventArgs e)//取消操作
        {
            //启用按钮
            EnableButton();
            LoadPrizeInfo(Program.objListPrize);
        }

        private void dgvPrize_SelectionChanged(object sender, EventArgs e)//明细信息随选择行变化而变化
        {
            if (dgvPrize.Rows.Count == 0) return;
            else if (dgvPrize.CurrentRow.Selected == false)//若没选中，展示第一行
            {
                try
                {
                    txtPrizeID.Text = dgvPrize.Rows[0].Cells[0].Value.ToString();
                    txtPrizeRank.Text = dgvPrize.Rows[0].Cells[1].Value.ToString();
                    txtPrizeCounts.Text = dgvPrize.Rows[0].Cells[2].Value.ToString();
                    txtPrizeName.Text = dgvPrize.Rows[0].Cells[3].Value.ToString();
                }
                catch 
                {

                    return;
                }
            }
            else//展示选中行
            {
                try
                {
                    txtPrizeID.Text = dgvPrize.CurrentRow.Cells[0].Value.ToString();
                    txtPrizeRank.Text = dgvPrize.CurrentRow.Cells[1].Value.ToString();
                    txtPrizeCounts.Text = dgvPrize.CurrentRow.Cells[2].Value.ToString();
                    txtPrizeName.Text = dgvPrize.CurrentRow.Cells[3].Value.ToString();
                }
                catch
                {
                    return;
                }

            }
        }

        //用户自定义事件
        private void DisableButton()
        {
            //禁用
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //启用
            gboxPrize.Enabled = true;
        }
        private void EnableButton()
        {
            //启用
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            //禁用
            gboxPrize.Enabled = false;
        }
        private void LoadPrizeInfo(List<Prize> objListPrize)//展示数据
        {
            //刷新
            dgvPrize.DataSource = null;
            dgvPrize.AutoGenerateColumns = false;
            dgvPrize.DataSource = objListPrize;
            //加载到明细
            if (objListPrize==null|objListPrize.Count==0)
            {
                //清空文本框
                txtPrizeRank.Text = string.Empty;
                txtPrizeName.Text = string.Empty;
                txtPrizeCounts.Text = string.Empty;
                txtPrizeID.Text = string.Empty;
                return;
            }
            else
            {
                txtPrizeID.Text = objListPrize[0].PrizeID.ToString();
                txtPrizeRank.Text = objListPrize[0].PrizeRank.ToString();
                txtPrizeCounts.Text = objListPrize[0].PrizeCounts.ToString();
                txtPrizeName.Text = objListPrize[0].PrizeName.ToString();
            }
        }
        private bool ValidataInput()//校验奖品输入信息
        {
            //级别不能为空
            if (string.IsNullOrWhiteSpace(txtPrizeRank.Text))
            {
                MessageBox.Show("奖品级别不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrizeRank.Focus();
                return false;
            }

            //级别不能重复
            if (actionFlag == 1)
            {
                if (objPrizeService.IsExistPrizeRank(txtPrizeRank.Text.Trim(), Program.objListPrize))
                {
                    MessageBox.Show("奖品等级不能重复！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrizeRank.Focus();
                    return false;
                }
            }
            //输入数量[1-9]
            if (string.IsNullOrWhiteSpace(txtPrizeCounts.Text))
            {
                MessageBox.Show("奖品数量不能重复！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrizeCounts.Focus();
                return false;
            }
            if (!CheckInput.IsNumber(txtPrizeCounts.Text.Trim()))
            {
                MessageBox.Show("奖品数量必须是1-9的整数！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrizeCounts.Focus();
                return false;
            }
            //奖品名称
            if (string.IsNullOrWhiteSpace(txtPrizeName.Text))
            {
                MessageBox.Show("奖品名称不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrizeName.Focus();
                return false;
            }
            //以上情况都满足
            return true;
        }
        private void LoadIntialData()//初始化，默认输入讲评信息
        {
            Program.objListPrize.Add(new Prize { PrizeID = 1, PrizeRank = "特等奖", PrizeCounts = "1", PrizeName = "AWM" });
            Program.objListPrize.Add(new Prize { PrizeID = 2, PrizeRank = "一等奖", PrizeCounts = "3", PrizeName = "98K" });
            Program.objListPrize.Add(new Prize { PrizeID = 3, PrizeRank = "二等奖", PrizeCounts = "5", PrizeName = "M416" });
            Program.objListPrize.Add(new Prize { PrizeID =4, PrizeRank = "三等奖", PrizeCounts = "10", PrizeName = "M16A4" });
        }
        private int PrizeCounts(List<Prize>objListPrize)
        {
            //更新数量
            //把奖品总数为空,然后重新计算Program.objListPrize中所有项的数量
            
            int count = 0;
            for (int i = 0; i < objListPrize.Count; i++)
            {
                count += int.Parse(objListPrize[i].PrizeCounts);
            }
            return count;
        }//计算奖品数量

    }
}
