namespace projiect01
{
    partial class Form1
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
            this.ServerButton = new System.Windows.Forms.Button();
            this.OwnerIPV4adress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OwnerPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GoalPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GoalIPV4adress = new System.Windows.Forms.TextBox();
            this.ClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerButton
            // 
            this.ServerButton.Location = new System.Drawing.Point(111, 94);
            this.ServerButton.Name = "ServerButton";
            this.ServerButton.Size = new System.Drawing.Size(89, 44);
            this.ServerButton.TabIndex = 0;
            this.ServerButton.Text = "启动监听";
            this.ServerButton.UseVisualStyleBackColor = true;
            this.ServerButton.Click += new System.EventHandler(this.ServerButton_Click);
            // 
            // OwnerIPV4adress
            // 
            this.OwnerIPV4adress.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OwnerIPV4adress.Location = new System.Drawing.Point(111, 6);
            this.OwnerIPV4adress.Name = "OwnerIPV4adress";
            this.OwnerIPV4adress.ReadOnly = true;
            this.OwnerIPV4adress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OwnerIPV4adress.Size = new System.Drawing.Size(159, 29);
            this.OwnerIPV4adress.TabIndex = 1;
            this.OwnerIPV4adress.Text = "255.255.255.255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "IPV4地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口号";
            // 
            // OwnerPort
            // 
            this.OwnerPort.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OwnerPort.Location = new System.Drawing.Point(111, 43);
            this.OwnerPort.Name = "OwnerPort";
            this.OwnerPort.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OwnerPort.Size = new System.Drawing.Size(159, 29);
            this.OwnerPort.TabIndex = 3;
            this.OwnerPort.Text = "8080";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(485, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "目标端口号";
            // 
            // GoalPort
            // 
            this.GoalPort.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoalPort.Location = new System.Drawing.Point(630, 43);
            this.GoalPort.Name = "GoalPort";
            this.GoalPort.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.GoalPort.Size = new System.Drawing.Size(159, 29);
            this.GoalPort.TabIndex = 8;
            this.GoalPort.Text = "8080";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(464, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "目标IPV4地址";
            // 
            // GoalIPV4adress
            // 
            this.GoalIPV4adress.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoalIPV4adress.Location = new System.Drawing.Point(630, 6);
            this.GoalIPV4adress.Name = "GoalIPV4adress";
            this.GoalIPV4adress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.GoalIPV4adress.Size = new System.Drawing.Size(159, 29);
            this.GoalIPV4adress.TabIndex = 6;
            this.GoalIPV4adress.Text = "255.255.255.255";
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(630, 94);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(89, 44);
            this.ClientButton.TabIndex = 5;
            this.ClientButton.Text = "建立连接";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoalPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GoalIPV4adress);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OwnerPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OwnerIPV4adress);
            this.Controls.Add(this.ServerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ServerButton;
        private System.Windows.Forms.TextBox OwnerIPV4adress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OwnerPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GoalPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GoalIPV4adress;
        private System.Windows.Forms.Button ClientButton;
    }
}

