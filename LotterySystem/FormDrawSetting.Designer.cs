namespace LotterySystem
{
    partial class FormDrawSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrawSetting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveBasicSetting = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbDenyTwoTimes = new System.Windows.Forms.RadioButton();
            this.rbAllowTwoTimes = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSmallToLarge = new System.Windows.Forms.RadioButton();
            this.rbLargeToSmall = new System.Windows.Forms.RadioButton();
            this.txtDrawTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPrize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPrize = new System.Windows.Forms.DataGridView();
            this.gboxPrize = new System.Windows.Forms.GroupBox();
            this.txtPrizeCounts = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrizeName = new System.Windows.Forms.TextBox();
            this.txtPrizeRank = new System.Windows.Forms.TextBox();
            this.txtPrizeID = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.btuCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrize)).BeginInit();
            this.gboxPrize.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 710);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveBasicSetting);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtDrawTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(324, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "抽奖基本设置";
            // 
            // btnSaveBasicSetting
            // 
            this.btnSaveBasicSetting.BackColor = System.Drawing.Color.Blue;
            this.btnSaveBasicSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveBasicSetting.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveBasicSetting.ForeColor = System.Drawing.Color.White;
            this.btnSaveBasicSetting.Location = new System.Drawing.Point(707, 110);
            this.btnSaveBasicSetting.Name = "btnSaveBasicSetting";
            this.btnSaveBasicSetting.Size = new System.Drawing.Size(98, 33);
            this.btnSaveBasicSetting.TabIndex = 5;
            this.btnSaveBasicSetting.Text = "保存设置";
            this.btnSaveBasicSetting.UseVisualStyleBackColor = false;
            this.btnSaveBasicSetting.Click += new System.EventHandler(this.btnSaveBasicSetting_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbDenyTwoTimes);
            this.panel2.Controls.Add(this.rbAllowTwoTimes);
            this.panel2.Location = new System.Drawing.Point(150, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 40);
            this.panel2.TabIndex = 4;
            // 
            // rbDenyTwoTimes
            // 
            this.rbDenyTwoTimes.AutoSize = true;
            this.rbDenyTwoTimes.Checked = true;
            this.rbDenyTwoTimes.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbDenyTwoTimes.ForeColor = System.Drawing.Color.Black;
            this.rbDenyTwoTimes.Location = new System.Drawing.Point(30, 7);
            this.rbDenyTwoTimes.Name = "rbDenyTwoTimes";
            this.rbDenyTwoTimes.Size = new System.Drawing.Size(76, 26);
            this.rbDenyTwoTimes.TabIndex = 2;
            this.rbDenyTwoTimes.TabStop = true;
            this.rbDenyTwoTimes.Text = "不允许";
            this.rbDenyTwoTimes.UseVisualStyleBackColor = true;
            // 
            // rbAllowTwoTimes
            // 
            this.rbAllowTwoTimes.AutoSize = true;
            this.rbAllowTwoTimes.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbAllowTwoTimes.ForeColor = System.Drawing.Color.Black;
            this.rbAllowTwoTimes.Location = new System.Drawing.Point(231, 7);
            this.rbAllowTwoTimes.Name = "rbAllowTwoTimes";
            this.rbAllowTwoTimes.Size = new System.Drawing.Size(60, 26);
            this.rbAllowTwoTimes.TabIndex = 2;
            this.rbAllowTwoTimes.Text = "允许";
            this.rbAllowTwoTimes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSmallToLarge);
            this.panel1.Controls.Add(this.rbLargeToSmall);
            this.panel1.Location = new System.Drawing.Point(150, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 40);
            this.panel1.TabIndex = 3;
            // 
            // rbSmallToLarge
            // 
            this.rbSmallToLarge.AutoSize = true;
            this.rbSmallToLarge.Checked = true;
            this.rbSmallToLarge.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbSmallToLarge.ForeColor = System.Drawing.Color.Black;
            this.rbSmallToLarge.Location = new System.Drawing.Point(30, 7);
            this.rbSmallToLarge.Name = "rbSmallToLarge";
            this.rbSmallToLarge.Size = new System.Drawing.Size(124, 26);
            this.rbSmallToLarge.TabIndex = 2;
            this.rbSmallToLarge.TabStop = true;
            this.rbSmallToLarge.Text = "从小奖到大奖";
            this.rbSmallToLarge.UseVisualStyleBackColor = true;
            // 
            // rbLargeToSmall
            // 
            this.rbLargeToSmall.AutoSize = true;
            this.rbLargeToSmall.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbLargeToSmall.ForeColor = System.Drawing.Color.Black;
            this.rbLargeToSmall.Location = new System.Drawing.Point(231, 7);
            this.rbLargeToSmall.Name = "rbLargeToSmall";
            this.rbLargeToSmall.Size = new System.Drawing.Size(124, 26);
            this.rbLargeToSmall.TabIndex = 2;
            this.rbLargeToSmall.Text = "从大奖到小奖";
            this.rbLargeToSmall.UseVisualStyleBackColor = true;
            // 
            // txtDrawTitle
            // 
            this.txtDrawTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDrawTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDrawTitle.ForeColor = System.Drawing.Color.Yellow;
            this.txtDrawTitle.Location = new System.Drawing.Point(150, 25);
            this.txtDrawTitle.Name = "txtDrawTitle";
            this.txtDrawTitle.Size = new System.Drawing.Size(650, 29);
            this.txtDrawTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "重复抽奖：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "抽奖顺序：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "抽奖标题：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrize
            // 
            this.lblTotalPrize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPrize.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrize.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPrize.Location = new System.Drawing.Point(449, 187);
            this.lblTotalPrize.Name = "lblTotalPrize";
            this.lblTotalPrize.Size = new System.Drawing.Size(60, 35);
            this.lblTotalPrize.TabIndex = 5;
            this.lblTotalPrize.Text = "30";
            this.lblTotalPrize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(319, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "奖品总数：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPrize
            // 
            this.dgvPrize.AllowUserToAddRows = false;
            this.dgvPrize.AllowUserToDeleteRows = false;
            this.dgvPrize.AllowUserToResizeColumns = false;
            this.dgvPrize.AllowUserToResizeRows = false;
            this.dgvPrize.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrize.ColumnHeadersHeight = 27;
            this.dgvPrize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvPrize.EnableHeadersVisualStyles = false;
            this.dgvPrize.GridColor = System.Drawing.Color.Black;
            this.dgvPrize.Location = new System.Drawing.Point(324, 225);
            this.dgvPrize.Name = "dgvPrize";
            this.dgvPrize.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPrize.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrize.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvPrize.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrize.RowTemplate.Height = 27;
            this.dgvPrize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrize.Size = new System.Drawing.Size(800, 400);
            this.dgvPrize.TabIndex = 7;
            this.dgvPrize.SelectionChanged += new System.EventHandler(this.dgvPrize_SelectionChanged);
            // 
            // gboxPrize
            // 
            this.gboxPrize.Controls.Add(this.txtPrizeCounts);
            this.gboxPrize.Controls.Add(this.label7);
            this.gboxPrize.Controls.Add(this.label6);
            this.gboxPrize.Controls.Add(this.label9);
            this.gboxPrize.Controls.Add(this.label8);
            this.gboxPrize.Controls.Add(this.txtPrizeName);
            this.gboxPrize.Controls.Add(this.txtPrizeRank);
            this.gboxPrize.Controls.Add(this.txtPrizeID);
            this.gboxPrize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxPrize.Location = new System.Drawing.Point(324, 631);
            this.gboxPrize.Name = "gboxPrize";
            this.gboxPrize.Size = new System.Drawing.Size(800, 110);
            this.gboxPrize.TabIndex = 8;
            this.gboxPrize.TabStop = false;
            this.gboxPrize.Text = "奖品信息明细";
            // 
            // txtPrizeCounts
            // 
            this.txtPrizeCounts.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrizeCounts.ForeColor = System.Drawing.Color.Orange;
            this.txtPrizeCounts.Location = new System.Drawing.Point(681, 22);
            this.txtPrizeCounts.Name = "txtPrizeCounts";
            this.txtPrizeCounts.Size = new System.Drawing.Size(80, 32);
            this.txtPrizeCounts.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(555, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "奖品数量：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(279, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "奖品级别：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(23, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "奖品名称：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(23, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "奖品编号：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrizeName
            // 
            this.txtPrizeName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrizeName.ForeColor = System.Drawing.Color.Orange;
            this.txtPrizeName.Location = new System.Drawing.Point(150, 72);
            this.txtPrizeName.Name = "txtPrizeName";
            this.txtPrizeName.Size = new System.Drawing.Size(611, 32);
            this.txtPrizeName.TabIndex = 3;
            // 
            // txtPrizeRank
            // 
            this.txtPrizeRank.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrizeRank.ForeColor = System.Drawing.Color.Orange;
            this.txtPrizeRank.Location = new System.Drawing.Point(405, 22);
            this.txtPrizeRank.Name = "txtPrizeRank";
            this.txtPrizeRank.Size = new System.Drawing.Size(100, 32);
            this.txtPrizeRank.TabIndex = 1;
            // 
            // txtPrizeID
            // 
            this.txtPrizeID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrizeID.ForeColor = System.Drawing.Color.Orange;
            this.txtPrizeID.Location = new System.Drawing.Point(149, 24);
            this.txtPrizeID.Name = "txtPrizeID";
            this.txtPrizeID.Size = new System.Drawing.Size(80, 32);
            this.txtPrizeID.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(1223, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 14;
            this.button8.Text = "×";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btuCancel
            // 
            this.btuCancel.AutoSize = true;
            this.btuCancel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btuCancel.FlatAppearance.BorderSize = 0;
            this.btuCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btuCancel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btuCancel.ForeColor = System.Drawing.Color.White;
            this.btuCancel.Location = new System.Drawing.Point(1149, 696);
            this.btuCancel.Name = "btuCancel";
            this.btuCancel.Size = new System.Drawing.Size(119, 42);
            this.btuCancel.TabIndex = 1;
            this.btuCancel.Text = "取消";
            this.btuCancel.UseVisualStyleBackColor = false;
            this.btuCancel.Click += new System.EventHandler(this.btuCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1149, 630);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 42);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1149, 495);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 42);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1149, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 42);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1149, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 42);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(539, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(585, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "添加奖品注意事项：从大奖到小奖依次添加";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PrizeID";
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "奖品编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PrizeRank";
            this.Column2.FillWeight = 284.5361F;
            this.Column2.HeaderText = "奖品级别";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PrizeCounts";
            this.Column3.FillWeight = 15.46393F;
            this.Column3.HeaderText = "奖品数量";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "PrizeName";
            this.Column4.HeaderText = "奖品名称";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FormDrawSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btuCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gboxPrize);
            this.Controls.Add(this.dgvPrize);
            this.Controls.Add(this.lblTotalPrize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDrawSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDrawSetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDrawSetting_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrize)).EndInit();
            this.gboxPrize.ResumeLayout(false);
            this.gboxPrize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLargeToSmall;
        private System.Windows.Forms.RadioButton rbAllowTwoTimes;
        private System.Windows.Forms.RadioButton rbDenyTwoTimes;
        private System.Windows.Forms.RadioButton rbSmallToLarge;
        private System.Windows.Forms.TextBox txtDrawTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveBasicSetting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalPrize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPrize;
        private System.Windows.Forms.GroupBox gboxPrize;
        private System.Windows.Forms.TextBox txtPrizeCounts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrizeRank;
        private System.Windows.Forms.TextBox txtPrizeID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrizeName;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btuCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}