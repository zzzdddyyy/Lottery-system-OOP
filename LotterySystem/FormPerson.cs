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
using Common;
using DAL;

namespace LotterySystem
{
    public partial class FormPerson : Form
    {
        //全局变量
        private string filePath = string.Empty;//存放选择的文件路径
        private List<Person> objListQuery = new List<Person>();//存放查询结果ListQuery
        private PersonServices objPersonServices = new PersonServices();//针对人员的功能
        private int actionFlag = 0;//表示动作是新增还是修改-----0--》添加；1---》修改
        public FormPerson()
        {
            InitializeComponent();
            //清空lblTotalPerson
            lblTatalPerson.Text = string.Empty;
            //禁用明细区
            gboxDetail.Enabled = false;
            //默认加载数据到dataGridList中，只要主程序没有结束，就会显示在人员名单中，不用重新导入数据 
            dgvPerson.DataSource = null;//刷新
            dgvPerson.AutoGenerateColumns = false;
            dgvPerson.DataSource = Program.objListPerson;
        }
        //模块01：导入和呈现数据：选择文件--》读入到List----》展示到DateGridView中---》展示明细

         //控件方法
        private void btnClose_Click(object sender, EventArgs e)//退出程序
        {
            Close();
        }
        private void FormPerson_FormClosing(object sender, FormClosingEventArgs e)//把主窗体的全局变量为空
        {
            FormMain.objFrmPerson = null;
        }
        private void btnImport_Click(object sender, EventArgs e)//导入数据
        {
            //选择导入文件
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV文件|*CSV|TXT文件|*txt|所有文件|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
            }
            //读取文件List
            try
            {
                Program.objListPerson = FileOperator.ReadFile(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show("读取文件出错，具体原因：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //(绑定)展示到dateGridView中
            dgvPerson.DataSource = null;//先刷新
            dgvPerson.AutoGenerateColumns = false;
            dgvPerson.DataSource = Program.objListPerson;
            //更新总人数
            lblTatalPerson.Text = Program.objListPerson.Count.ToString();
            //默认显示第一行信息到明细栏
            if (dgvPerson.Rows.Count == 0)
            {
                return;
            }
            else
            {
                txtPersonID.Text = dgvPerson.Rows[0].Cells[0].Value.ToString();
                txtPersonName.Text = dgvPerson.Rows[0].Cells[1].Value.ToString();
                txtPersonMobile.Text = dgvPerson.Rows[0].Cells[2].Value.ToString();
            }
        }
        private void dgvPerson_SelectionChanged(object sender, EventArgs e)//明细栏展示信息随选择行变化
        {
            if (dgvPerson.Rows.Count == 0) return;//如果没有数据，返回
            else if(dgvPerson.CurrentRow.Selected == false)//如果没有选中，。默认展示第一行
            {
                try
                {
                    txtPersonID.Text = dgvPerson.Rows[0].Cells[0].Value.ToString();
                    txtPersonName.Text = dgvPerson.Rows[0].Cells[1].Value.ToString();
                    txtPersonMobile.Text = dgvPerson.Rows[0].Cells[2].Value.ToString();
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
                    txtPersonID.Text = dgvPerson.CurrentRow.Cells[0].Value.ToString();
                    txtPersonName.Text = dgvPerson.CurrentRow.Cells[1].Value.ToString();
                    txtPersonMobile.Text = dgvPerson.CurrentRow.Cells[2].Value.ToString();
                }
                catch 
                {

                    return;
                }
            }
        }


        //模块02：抽奖人员数据查询----按姓名|按手机号 所有人员：ProgramListPerson-------->满足条件的人员：objListQuery
        private void txtQueryByName_TextChanged(object sender, EventArgs e)//按姓名查询
        {
            //[1]清空objListQuery
            objListQuery.Clear();
            //[2]获取满足条件的Person
            objListQuery = objPersonServices.GetAllPersonByName(txtQueryByName.Text.Trim(), Program.objListPerson);
            //[3]绑定到dataGridView中
            dgvPerson.DataSource = null;
            dgvPerson.AutoGenerateColumns = false;
            dgvPerson.DataSource = objListQuery;
        }
        private void txtQueryByMobile_TextChanged(object sender, EventArgs e)//按手机号码查询
        {
            //[1]清空objListQuery
            objListQuery.Clear();
            //[2]获取满足条件的Person
            objListQuery = objPersonServices.GetAllPersonByMobile(txtQueryByMobile.Text.Trim(), Program.objListPerson);
            //[3]绑定到dataGridView中
            dgvPerson.DataSource = null;
            dgvPerson.AutoGenerateColumns = false;
            dgvPerson.DataSource = objListQuery;
        }


        //模块03：抽奖人员信息的增、删、改------》List<Person>里面-----objListPerson----->更新dataGridView中
        private void btnAdd_Click(object sender, EventArgs e)//为新增人员做准备,提交按钮为最终添加
        {
            //控制按钮
            DisableButton();
            //禁用PersonID---->自增---自动填充
            txtPersonID.Enabled = false;
            txtPersonID.Text = objPersonServices.GetNewPersonID(Program.objListPerson);
            //清空明细文本框
            txtPersonName.Text = string.Empty;
            txtPersonMobile.Text = string.Empty;
            //姓名文本框获得焦点
            txtPersonName.Focus();
            //修改actionFlag
            actionFlag = 1;
        }
        private void btnUpdate_Click(object sender, EventArgs e)//为修改做准备提交按钮为最终修改
        {
            //控制按钮
            DisableButton();
            //禁用PersonID---->PersonID不能修改
            txtPersonID.Enabled = false;

            //姓名文本框获得焦点
            txtPersonName.Focus();
            //修改actionFlag
            actionFlag = 2;
        }
        private void btnSubmite_Click(object sender, EventArgs e)//提交新增、修改
        {
            //【1】判断输入是否合法
            if (string.IsNullOrWhiteSpace(txtPersonName.Text))
            {
                MessageBox.Show("姓名不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPersonName.Focus();
                return;
            }
            if (!CheckInput.IsChinese(txtPersonName.Text))
            {
                MessageBox.Show("姓名必须是汉字，请重新输入！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPersonName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPersonMobile.Text))
            {
                MessageBox.Show("手机号码不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPersonMobile.Focus();
                return;
            }
            if (!CheckInput.IsMobileNumber(txtPersonMobile.Text))
            {
                MessageBox.Show("手机号码不合法（11位数字），请重新输入！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPersonMobile.Focus();
                return;
            }
            //【2】封装类
            Person objPerson = new Person()
            {
                PersonId = Convert.ToInt32(txtPersonID.Text.Trim()),
                PersonName = txtPersonName.Text.Trim(),
                PersonMobile = txtPersonMobile.Text.Trim()
            };
            //【3】提交！！！
            switch (actionFlag)
            {
                case 1:
                    {
                        //提交添加
                        objPersonServices.AddPerson(objPerson, Program.objListPerson);
                        //展示在DataGridView中
                        dgvPerson.DataSource = null;
                        dgvPerson.AutoGenerateColumns = false;
                        dgvPerson.DataSource = Program.objListPerson;
                        //展示明细----》新增的这一行
                        txtPersonID.Text = dgvPerson.Rows[dgvPerson.Rows.Count - 1].Cells[0].Value.ToString();
                        txtPersonName.Text= dgvPerson.Rows[dgvPerson.Rows.Count - 1].Cells[1].Value.ToString();
                        txtPersonMobile.Text= dgvPerson.Rows[dgvPerson.Rows.Count - 1].Cells[2].Value.ToString();
                        //更新总人数
                        lblTatalPerson.Text = (int.Parse(lblTatalPerson.Text) + 1).ToString();
                        //启用按钮
                        EnableButton();
                        //提示成功
                        MessageBox.Show("新增人员成功！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 2:
                    {
                        //提交修改
                        objPersonServices.UpdatePerson(objPerson, Program.objListPerson);
                        //展示在DataGridView中
                        dgvPerson.DataSource = null;
                        dgvPerson.AutoGenerateColumns = false;
                        dgvPerson.DataSource = Program.objListPerson;
                        //启用按钮
                        EnableButton();
                        //提示成功
                        MessageBox.Show("修改人员信息成功！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)//取消修改
        {
            //启用Button
            EnableButton();
            //如果是添加，明细展示最后一条
            if (dgvPerson.Rows.Count == 0) return;
            if (actionFlag == 1)
            {
                txtPersonID.Text = dgvPerson.Rows[0].Cells[0].Value.ToString();
                txtPersonName.Text= dgvPerson.Rows[0].Cells[1].Value.ToString();
                txtPersonMobile.Text= dgvPerson.Rows[0].Cells[2].Value.ToString();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPerson.Rows.Count == 0) return;
            else if (dgvPerson.CurrentRow.Selected == false) return;
            else
            {
                string info = "您确定要删除【编号为：" + dgvPerson.CurrentRow.Cells[0].Value.ToString() + "姓名为：" 
                    + dgvPerson.CurrentRow.Cells[1].Value.ToString() + "】的信息吗？";
                DialogResult result = MessageBox.Show(info, "提示消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //执行删除
                    objPersonServices.DeletePerson(dgvPerson.CurrentRow.Cells[0].Value.ToString(), Program.objListPerson);
                    //更新DataGridView
                    dgvPerson.DataSource = null;
                    dgvPerson.AutoGenerateColumns = false;
                    dgvPerson.DataSource = Program.objListPerson;
                    //更新明细
                    txtPersonID.Text = dgvPerson.Rows[0].Cells[0].Value.ToString();
                    txtPersonName.Text = dgvPerson.Rows[0].Cells[1].Value.ToString();
                    txtPersonMobile.Text = dgvPerson.Rows[0].Cells[2].Value.ToString();
                    //修改总人数
                    lblTatalPerson.Text = (int.Parse(lblTatalPerson.Text) - 1).ToString();
                    //启用按钮
                    EnableButton();
                    //提示成功
                    MessageBox.Show("删除人员成功！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else return;
            }
        }
        //【04】修改后保存信息---------思路：删除原先所有数据-----把program.objListPerson的信息写入
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileOperator.WriteFile(filePath, Program.objListPerson))
                {
                    MessageBox.Show("保存完成！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存数据失败！具体原因：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //用户自定义方法
        private void DisableButton()
        {
            //禁用按钮
            btnImport.Enabled = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            //启用Person明细
            gboxDetail.Enabled = true;
        }
        private void EnableButton()
        {
            //启用按钮
            btnImport.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            //禁用Person明细
            gboxDetail.Enabled = false;
        }


    }
}
