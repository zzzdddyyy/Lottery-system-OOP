namespace LotterySystem
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnDrawSetting = new System.Windows.Forms.Button();
            this.btnStartDraw = new System.Windows.Forms.Button();
            this.btnDrawResult = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("华文中宋", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(342, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "【大吉大利，今晚吃鸡！】";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPerson
            // 
            this.btnPerson.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPerson.FlatAppearance.BorderSize = 3;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.Font = new System.Drawing.Font("方正舒体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPerson.ForeColor = System.Drawing.Color.White;
            this.btnPerson.Location = new System.Drawing.Point(253, 194);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(150, 150);
            this.btnPerson.TabIndex = 0;
            this.btnPerson.Text = "抽奖名单";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnDrawSetting
            // 
            this.btnDrawSetting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDrawSetting.FlatAppearance.BorderSize = 3;
            this.btnDrawSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawSetting.Font = new System.Drawing.Font("方正舒体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDrawSetting.ForeColor = System.Drawing.Color.White;
            this.btnDrawSetting.Location = new System.Drawing.Point(437, 194);
            this.btnDrawSetting.Name = "btnDrawSetting";
            this.btnDrawSetting.Size = new System.Drawing.Size(150, 150);
            this.btnDrawSetting.TabIndex = 1;
            this.btnDrawSetting.Text = "抽奖设置 ";
            this.btnDrawSetting.UseVisualStyleBackColor = true;
            this.btnDrawSetting.Click += new System.EventHandler(this.btnDrawSetting_Click);
            // 
            // btnStartDraw
            // 
            this.btnStartDraw.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartDraw.FlatAppearance.BorderSize = 3;
            this.btnStartDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartDraw.Font = new System.Drawing.Font("方正舒体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartDraw.ForeColor = System.Drawing.Color.White;
            this.btnStartDraw.Location = new System.Drawing.Point(621, 194);
            this.btnStartDraw.Name = "btnStartDraw";
            this.btnStartDraw.Size = new System.Drawing.Size(150, 150);
            this.btnStartDraw.TabIndex = 2;
            this.btnStartDraw.Text = "开始抽奖";
            this.btnStartDraw.UseVisualStyleBackColor = true;
            this.btnStartDraw.Click += new System.EventHandler(this.btnStartDraw_Click);
            // 
            // btnDrawResult
            // 
            this.btnDrawResult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDrawResult.FlatAppearance.BorderSize = 3;
            this.btnDrawResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawResult.Font = new System.Drawing.Font("方正舒体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDrawResult.ForeColor = System.Drawing.Color.White;
            this.btnDrawResult.Location = new System.Drawing.Point(805, 194);
            this.btnDrawResult.Name = "btnDrawResult";
            this.btnDrawResult.Size = new System.Drawing.Size(150, 150);
            this.btnDrawResult.TabIndex = 3;
            this.btnDrawResult.Text = "中奖名单";
            this.btnDrawResult.UseVisualStyleBackColor = true;
            this.btnDrawResult.Click += new System.EventHandler(this.btnDrawResult_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(948, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDrawResult);
            this.Controls.Add(this.btnStartDraw);
            this.Controls.Add(this.btnDrawSetting);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnDrawSetting;
        private System.Windows.Forms.Button btnStartDraw;
        private System.Windows.Forms.Button btnDrawResult;
        private System.Windows.Forms.Button btnClose;
    }
}

