namespace LotterySystem
{
    partial class FormStartDraw
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCurrentRank = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartOrStop = new System.Windows.Forms.Button();
            this.lblLuckyPerson = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lboxperson = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(69, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(365, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "【大吉大利，今晚吃鸡！】";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentRank
            // 
            this.lblCurrentRank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentRank.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentRank.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCurrentRank.Location = new System.Drawing.Point(76, 178);
            this.lblCurrentRank.Name = "lblCurrentRank";
            this.lblCurrentRank.Size = new System.Drawing.Size(606, 50);
            this.lblCurrentRank.TabIndex = 2;
            this.lblCurrentRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(69, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "现在抽：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartOrStop
            // 
            this.btnStartOrStop.BackColor = System.Drawing.Color.Red;
            this.btnStartOrStop.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartOrStop.ForeColor = System.Drawing.Color.Yellow;
            this.btnStartOrStop.Location = new System.Drawing.Point(270, 260);
            this.btnStartOrStop.Name = "btnStartOrStop";
            this.btnStartOrStop.Size = new System.Drawing.Size(222, 222);
            this.btnStartOrStop.TabIndex = 0;
            this.btnStartOrStop.Text = "开始抽奖";
            this.btnStartOrStop.UseVisualStyleBackColor = false;
            this.btnStartOrStop.Click += new System.EventHandler(this.btnStartOrStop_Click);
            this.btnStartOrStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStartOrStop_KeyDown);
            // 
            // lblLuckyPerson
            // 
            this.lblLuckyPerson.BackColor = System.Drawing.Color.DarkBlue;
            this.lblLuckyPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLuckyPerson.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLuckyPerson.ForeColor = System.Drawing.Color.HotPink;
            this.lblLuckyPerson.Location = new System.Drawing.Point(75, 531);
            this.lblLuckyPerson.Name = "lblLuckyPerson";
            this.lblLuckyPerson.Size = new System.Drawing.Size(607, 50);
            this.lblLuckyPerson.TabIndex = 3;
            this.lblLuckyPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(71, 686);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "操作提示：开始抽奖：F1 停止/开始：Space";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboxperson
            // 
            this.lboxperson.BackColor = System.Drawing.Color.Green;
            this.lboxperson.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lboxperson.ForeColor = System.Drawing.Color.Black;
            this.lboxperson.FormattingEnabled = true;
            this.lboxperson.ItemHeight = 25;
            this.lboxperson.Location = new System.Drawing.Point(760, 101);
            this.lboxperson.Name = "lboxperson";
            this.lboxperson.Size = new System.Drawing.Size(469, 604);
            this.lboxperson.TabIndex = 1;
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
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormStartDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lboxperson);
            this.Controls.Add(this.btnStartOrStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLuckyPerson);
            this.Controls.Add(this.lblCurrentRank);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStartDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStartDraw";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStartDraw_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentRank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartOrStop;
        private System.Windows.Forms.Label lblLuckyPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lboxperson;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
    }
}