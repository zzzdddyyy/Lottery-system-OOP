namespace LotterySystem
{
    partial class FormPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerson));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxQuery = new System.Windows.Forms.GroupBox();
            this.txtQueryByMobile = new System.Windows.Forms.TextBox();
            this.txtQueryByName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxDetail = new System.Windows.Forms.GroupBox();
            this.txtPersonMobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTatalPerson = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSubmite = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboxQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.gboxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 699);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gboxQuery
            // 
            this.gboxQuery.Controls.Add(this.txtQueryByMobile);
            this.gboxQuery.Controls.Add(this.txtQueryByName);
            this.gboxQuery.Controls.Add(this.label4);
            this.gboxQuery.Controls.Add(this.label3);
            this.gboxQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxQuery.ForeColor = System.Drawing.Color.Black;
            this.gboxQuery.Location = new System.Drawing.Point(290, 30);
            this.gboxQuery.Name = "gboxQuery";
            this.gboxQuery.Size = new System.Drawing.Size(800, 85);
            this.gboxQuery.TabIndex = 1;
            this.gboxQuery.TabStop = false;
            this.gboxQuery.Text = "人员信息查询";
            // 
            // txtQueryByMobile
            // 
            this.txtQueryByMobile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueryByMobile.ForeColor = System.Drawing.Color.Orange;
            this.txtQueryByMobile.Location = new System.Drawing.Point(520, 26);
            this.txtQueryByMobile.Name = "txtQueryByMobile";
            this.txtQueryByMobile.Size = new System.Drawing.Size(200, 32);
            this.txtQueryByMobile.TabIndex = 1;
            this.txtQueryByMobile.TextChanged += new System.EventHandler(this.txtQueryByMobile_TextChanged);
            // 
            // txtQueryByName
            // 
            this.txtQueryByName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueryByName.ForeColor = System.Drawing.Color.Orange;
            this.txtQueryByName.Location = new System.Drawing.Point(150, 26);
            this.txtQueryByName.Name = "txtQueryByName";
            this.txtQueryByName.Size = new System.Drawing.Size(200, 32);
            this.txtQueryByName.TabIndex = 0;
            this.txtQueryByName.TextChanged += new System.EventHandler(this.txtQueryByName_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(395, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "手机号码：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(25, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓名：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.AllowUserToResizeColumns = false;
            this.dgvPerson.AllowUserToResizeRows = false;
            this.dgvPerson.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPerson.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvPerson.EnableHeadersVisualStyles = false;
            this.dgvPerson.GridColor = System.Drawing.Color.Black;
            this.dgvPerson.Location = new System.Drawing.Point(290, 175);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvPerson.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPerson.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvPerson.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPerson.RowTemplate.Height = 27;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(800, 434);
            this.dgvPerson.TabIndex = 2;
            this.dgvPerson.SelectionChanged += new System.EventHandler(this.dgvPerson_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PersonId";
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PersonName";
            this.Column2.FillWeight = 284.5361F;
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "PersonMobile";
            this.Column3.FillWeight = 15.46393F;
            this.Column3.HeaderText = "手机号码";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // gboxDetail
            // 
            this.gboxDetail.Controls.Add(this.txtPersonMobile);
            this.gboxDetail.Controls.Add(this.label7);
            this.gboxDetail.Controls.Add(this.label6);
            this.gboxDetail.Controls.Add(this.label5);
            this.gboxDetail.Controls.Add(this.txtPersonName);
            this.gboxDetail.Controls.Add(this.txtPersonID);
            this.gboxDetail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxDetail.Location = new System.Drawing.Point(290, 615);
            this.gboxDetail.Name = "gboxDetail";
            this.gboxDetail.Size = new System.Drawing.Size(800, 114);
            this.gboxDetail.TabIndex = 3;
            this.gboxDetail.TabStop = false;
            this.gboxDetail.Text = "人员信息明细";
            // 
            // txtPersonMobile
            // 
            this.txtPersonMobile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonMobile.ForeColor = System.Drawing.Color.Orange;
            this.txtPersonMobile.Location = new System.Drawing.Point(596, 47);
            this.txtPersonMobile.Name = "txtPersonMobile";
            this.txtPersonMobile.Size = new System.Drawing.Size(200, 32);
            this.txtPersonMobile.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(483, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "手机号码：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(247, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "姓名：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(8, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "工号：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonName.ForeColor = System.Drawing.Color.Orange;
            this.txtPersonName.Location = new System.Drawing.Point(330, 47);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(126, 32);
            this.txtPersonName.TabIndex = 1;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.ForeColor = System.Drawing.Color.Orange;
            this.txtPersonID.Location = new System.Drawing.Point(90, 47);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(145, 32);
            this.txtPersonID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(289, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "总人数：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTatalPerson
            // 
            this.lblTatalPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTatalPerson.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTatalPerson.ForeColor = System.Drawing.Color.Red;
            this.lblTatalPerson.Location = new System.Drawing.Point(388, 127);
            this.lblTatalPerson.Name = "lblTatalPerson";
            this.lblTatalPerson.Size = new System.Drawing.Size(60, 35);
            this.lblTatalPerson.TabIndex = 4;
            this.lblTatalPerson.Text = "30";
            this.lblTatalPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(1112, 175);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(119, 42);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "导入名单";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1112, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1112, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1112, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1112, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSubmite
            // 
            this.btnSubmite.AutoSize = true;
            this.btnSubmite.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSubmite.FlatAppearance.BorderSize = 0;
            this.btnSubmite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmite.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmite.ForeColor = System.Drawing.Color.White;
            this.btnSubmite.Location = new System.Drawing.Point(1112, 600);
            this.btnSubmite.Name = "btnSubmite";
            this.btnSubmite.Size = new System.Drawing.Size(119, 42);
            this.btnSubmite.TabIndex = 5;
            this.btnSubmite.Text = "提交";
            this.btnSubmite.UseVisualStyleBackColor = false;
            this.btnSubmite.Click += new System.EventHandler(this.btnSubmite_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1112, 685);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Blue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1223, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmite);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblTatalPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboxDetail);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.gboxQuery);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPerson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPerson_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboxQuery.ResumeLayout(false);
            this.gboxQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.gboxDetail.ResumeLayout(false);
            this.gboxDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gboxQuery;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.GroupBox gboxDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTatalPerson;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSubmite;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtQueryByMobile;
        private System.Windows.Forms.TextBox txtQueryByName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtPersonMobile;
    }
}