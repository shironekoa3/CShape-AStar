namespace GetShortest
{
    partial class FrmMain
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
            this.btnInitPanel = new System.Windows.Forms.Button();
            this.plMain = new System.Windows.Forms.Panel();
            this.btnSetStart = new System.Windows.Forms.Button();
            this.btnSetObs = new System.Windows.Forms.Button();
            this.btnSetEnd = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.picTip1 = new System.Windows.Forms.PictureBox();
            this.lblTip1 = new System.Windows.Forms.Label();
            this.lblTip2 = new System.Windows.Forms.Label();
            this.picTip2 = new System.Windows.Forms.PictureBox();
            this.lblTip3 = new System.Windows.Forms.Label();
            this.picTip3 = new System.Windows.Forms.PictureBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.btnClearTip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTip3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInitPanel
            // 
            this.btnInitPanel.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInitPanel.Location = new System.Drawing.Point(12, 506);
            this.btnInitPanel.Name = "btnInitPanel";
            this.btnInitPanel.Size = new System.Drawing.Size(97, 34);
            this.btnInitPanel.TabIndex = 0;
            this.btnInitPanel.Text = "初始化面板";
            this.btnInitPanel.UseVisualStyleBackColor = true;
            this.btnInitPanel.Click += new System.EventHandler(this.btnInitPanel_Click);
            // 
            // plMain
            // 
            this.plMain.Location = new System.Drawing.Point(12, 41);
            this.plMain.Margin = new System.Windows.Forms.Padding(0);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(750, 450);
            this.plMain.TabIndex = 1;
            // 
            // btnSetStart
            // 
            this.btnSetStart.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetStart.Location = new System.Drawing.Point(132, 506);
            this.btnSetStart.Name = "btnSetStart";
            this.btnSetStart.Size = new System.Drawing.Size(86, 34);
            this.btnSetStart.TabIndex = 0;
            this.btnSetStart.Text = "设置起点";
            this.btnSetStart.UseVisualStyleBackColor = true;
            this.btnSetStart.Click += new System.EventHandler(this.btnSetStart_Click);
            // 
            // btnSetObs
            // 
            this.btnSetObs.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetObs.Location = new System.Drawing.Point(224, 506);
            this.btnSetObs.Name = "btnSetObs";
            this.btnSetObs.Size = new System.Drawing.Size(105, 34);
            this.btnSetObs.TabIndex = 0;
            this.btnSetObs.Text = "设置障碍物";
            this.btnSetObs.UseVisualStyleBackColor = true;
            this.btnSetObs.Click += new System.EventHandler(this.btnSetObs_Click);
            // 
            // btnSetEnd
            // 
            this.btnSetEnd.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetEnd.Location = new System.Drawing.Point(335, 506);
            this.btnSetEnd.Name = "btnSetEnd";
            this.btnSetEnd.Size = new System.Drawing.Size(86, 34);
            this.btnSetEnd.TabIndex = 0;
            this.btnSetEnd.Text = "设置终点";
            this.btnSetEnd.UseVisualStyleBackColor = true;
            this.btnSetEnd.Click += new System.EventHandler(this.btnSetEnd_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(687, 506);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 34);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "执行";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // picTip1
            // 
            this.picTip1.BackColor = System.Drawing.Color.Lime;
            this.picTip1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTip1.Location = new System.Drawing.Point(12, 9);
            this.picTip1.Margin = new System.Windows.Forms.Padding(0);
            this.picTip1.Name = "picTip1";
            this.picTip1.Size = new System.Drawing.Size(20, 20);
            this.picTip1.TabIndex = 6;
            this.picTip1.TabStop = false;
            // 
            // lblTip1
            // 
            this.lblTip1.AutoSize = true;
            this.lblTip1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTip1.Location = new System.Drawing.Point(35, 11);
            this.lblTip1.Name = "lblTip1";
            this.lblTip1.Size = new System.Drawing.Size(42, 16);
            this.lblTip1.TabIndex = 7;
            this.lblTip1.Text = "起点";
            // 
            // lblTip2
            // 
            this.lblTip2.AutoSize = true;
            this.lblTip2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTip2.Location = new System.Drawing.Point(129, 11);
            this.lblTip2.Name = "lblTip2";
            this.lblTip2.Size = new System.Drawing.Size(59, 16);
            this.lblTip2.TabIndex = 9;
            this.lblTip2.Text = "障碍物";
            // 
            // picTip2
            // 
            this.picTip2.BackColor = System.Drawing.Color.Black;
            this.picTip2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTip2.Location = new System.Drawing.Point(106, 9);
            this.picTip2.Margin = new System.Windows.Forms.Padding(0);
            this.picTip2.Name = "picTip2";
            this.picTip2.Size = new System.Drawing.Size(20, 20);
            this.picTip2.TabIndex = 8;
            this.picTip2.TabStop = false;
            // 
            // lblTip3
            // 
            this.lblTip3.AutoSize = true;
            this.lblTip3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTip3.Location = new System.Drawing.Point(235, 11);
            this.lblTip3.Name = "lblTip3";
            this.lblTip3.Size = new System.Drawing.Size(42, 16);
            this.lblTip3.TabIndex = 11;
            this.lblTip3.Text = "终点";
            // 
            // picTip3
            // 
            this.picTip3.BackColor = System.Drawing.Color.Red;
            this.picTip3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTip3.Location = new System.Drawing.Point(212, 9);
            this.picTip3.Margin = new System.Windows.Forms.Padding(0);
            this.picTip3.Name = "picTip3";
            this.picTip3.Size = new System.Drawing.Size(20, 20);
            this.picTip3.TabIndex = 10;
            this.picTip3.TabStop = false;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(778, 41);
            this.txtTip.Multiline = true;
            this.txtTip.Name = "txtTip";
            this.txtTip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTip.Size = new System.Drawing.Size(198, 450);
            this.txtTip.TabIndex = 13;
            // 
            // btnClearTip
            // 
            this.btnClearTip.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearTip.Location = new System.Drawing.Point(778, 506);
            this.btnClearTip.Name = "btnClearTip";
            this.btnClearTip.Size = new System.Drawing.Size(93, 34);
            this.btnClearTip.TabIndex = 14;
            this.btnClearTip.Text = "清空信息";
            this.btnClearTip.UseVisualStyleBackColor = true;
            this.btnClearTip.Click += new System.EventHandler(this.btnClearTip_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 571);
            this.Controls.Add(this.btnClearTip);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTip3);
            this.Controls.Add(this.picTip3);
            this.Controls.Add(this.lblTip2);
            this.Controls.Add(this.picTip2);
            this.Controls.Add(this.lblTip1);
            this.Controls.Add(this.picTip1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSetEnd);
            this.Controls.Add(this.btnSetObs);
            this.Controls.Add(this.btnSetStart);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.btnInitPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A*";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTip3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitPanel;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Button btnSetStart;
        private System.Windows.Forms.Button btnSetObs;
        private System.Windows.Forms.Button btnSetEnd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox picTip1;
        private System.Windows.Forms.Label lblTip1;
        private System.Windows.Forms.Label lblTip2;
        private System.Windows.Forms.PictureBox picTip2;
        private System.Windows.Forms.Label lblTip3;
        private System.Windows.Forms.PictureBox picTip3;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnClearTip;
    }
}

