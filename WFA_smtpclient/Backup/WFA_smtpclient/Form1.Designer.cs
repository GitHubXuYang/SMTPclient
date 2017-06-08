namespace WFA_smtpclient
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tB_To = new System.Windows.Forms.TextBox();
            this.tB_subject = new System.Windows.Forms.TextBox();
            this.tB_From = new System.Windows.Forms.TextBox();
            this.tB_attachment = new System.Windows.Forms.TextBox();
            this.tB_Body = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_status = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_cc = new System.Windows.Forms.TextBox();
            this.tB_Smtp_server = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_Uid = new System.Windows.Forms.TextBox();
            this.tB_Pwd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tB_Port = new System.Windows.Forms.TextBox();
            this.ck_ssl = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bt_select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "发送邮件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB_To
            // 
            this.tB_To.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_To.Location = new System.Drawing.Point(168, 24);
            this.tB_To.Name = "tB_To";
            this.tB_To.Size = new System.Drawing.Size(400, 23);
            this.tB_To.TabIndex = 1;
            this.tB_To.Text = "yrwang@swjtu.cn";
            // 
            // tB_subject
            // 
            this.tB_subject.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_subject.Location = new System.Drawing.Point(168, 143);
            this.tB_subject.Name = "tB_subject";
            this.tB_subject.Size = new System.Drawing.Size(570, 23);
            this.tB_subject.TabIndex = 2;
            this.tB_subject.Tag = "";
            this.tB_subject.Text = "这是测试信息";
            // 
            // tB_From
            // 
            this.tB_From.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_From.Location = new System.Drawing.Point(168, 60);
            this.tB_From.Name = "tB_From";
            this.tB_From.Size = new System.Drawing.Size(400, 23);
            this.tB_From.TabIndex = 3;
            this.tB_From.Text = "swjtugx2005@gmail.com";
            // 
            // tB_attachment
            // 
            this.tB_attachment.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_attachment.Location = new System.Drawing.Point(168, 183);
            this.tB_attachment.Name = "tB_attachment";
            this.tB_attachment.Size = new System.Drawing.Size(570, 23);
            this.tB_attachment.TabIndex = 4;
            this.tB_attachment.TextChanged += new System.EventHandler(this.tB_attachment_TextChanged);
            // 
            // tB_Body
            // 
            this.tB_Body.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_Body.Location = new System.Drawing.Point(168, 250);
            this.tB_Body.Multiline = true;
            this.tB_Body.Name = "tB_Body";
            this.tB_Body.Size = new System.Drawing.Size(570, 130);
            this.tB_Body.TabIndex = 5;
            this.tB_Body.Text = "这是测试内容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "收件人地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "发件人地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "邮件标题";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "邮件内容";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(21, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "附件名称";
            // 
            // tB_status
            // 
            this.tB_status.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_status.Location = new System.Drawing.Point(168, 550);
            this.tB_status.Name = "tB_status";
            this.tB_status.Size = new System.Drawing.Size(400, 23);
            this.tB_status.TabIndex = 11;
            this.tB_status.Text = "未发送";
            this.tB_status.TextChanged += new System.EventHandler(this.tB_status_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(21, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "发件发送状态";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(21, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "邮件抄送";
            // 
            // tB_cc
            // 
            this.tB_cc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_cc.Location = new System.Drawing.Point(168, 101);
            this.tB_cc.Name = "tB_cc";
            this.tB_cc.Size = new System.Drawing.Size(570, 23);
            this.tB_cc.TabIndex = 14;
            this.tB_cc.Text = "y_r_wang@126.com";
            // 
            // tB_Smtp_server
            // 
            this.tB_Smtp_server.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_Smtp_server.Location = new System.Drawing.Point(168, 437);
            this.tB_Smtp_server.Name = "tB_Smtp_server";
            this.tB_Smtp_server.Size = new System.Drawing.Size(209, 23);
            this.tB_Smtp_server.TabIndex = 15;
            this.tB_Smtp_server.Text = "smtp.gmail.com";
            this.tB_Smtp_server.TextChanged += new System.EventHandler(this.tB_Smtp_server_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(21, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "SMTP服务器地址";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(21, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "用户名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(21, 511);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "密码";
            // 
            // tB_Uid
            // 
            this.tB_Uid.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_Uid.Location = new System.Drawing.Point(168, 477);
            this.tB_Uid.Name = "tB_Uid";
            this.tB_Uid.Size = new System.Drawing.Size(400, 23);
            this.tB_Uid.TabIndex = 19;
            this.tB_Uid.Text = "swjtugx2005@gmail.com";
            // 
            // tB_Pwd
            // 
            this.tB_Pwd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_Pwd.Location = new System.Drawing.Point(168, 508);
            this.tB_Pwd.Name = "tB_Pwd";
            this.tB_Pwd.Size = new System.Drawing.Size(400, 23);
            this.tB_Pwd.TabIndex = 20;
            this.tB_Pwd.Text = "swjtu.edu.cn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(393, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "SMTP服务器端口";
            // 
            // tB_Port
            // 
            this.tB_Port.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_Port.Location = new System.Drawing.Point(513, 434);
            this.tB_Port.Name = "tB_Port";
            this.tB_Port.Size = new System.Drawing.Size(70, 23);
            this.tB_Port.TabIndex = 22;
            this.tB_Port.Text = "25";
            // 
            // ck_ssl
            // 
            this.ck_ssl.AutoSize = true;
            this.ck_ssl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ck_ssl.Checked = true;
            this.ck_ssl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_ssl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ck_ssl.Location = new System.Drawing.Point(605, 438);
            this.ck_ssl.Name = "ck_ssl";
            this.ck_ssl.Size = new System.Drawing.Size(110, 18);
            this.ck_ssl.TabIndex = 24;
            this.ck_ssl.Text = "是否启用SSL";
            this.ck_ssl.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(735, 184);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(65, 23);
            this.bt_select.TabIndex = 25;
            this.bt_select.Text = "选择附件";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 581);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.ck_ssl);
            this.Controls.Add(this.tB_Port);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tB_Pwd);
            this.Controls.Add(this.tB_Uid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tB_Smtp_server);
            this.Controls.Add(this.tB_cc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tB_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_Body);
            this.Controls.Add(this.tB_attachment);
            this.Controls.Add(this.tB_From);
            this.Controls.Add(this.tB_subject);
            this.Controls.Add(this.tB_To);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tB_To;
        private System.Windows.Forms.TextBox tB_subject;
        private System.Windows.Forms.TextBox tB_From;
        private System.Windows.Forms.TextBox tB_attachment;
        private System.Windows.Forms.TextBox tB_Body;
        private System.Net.Mail.SmtpClient sc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_cc;
        private System.Windows.Forms.TextBox tB_Smtp_server;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_Uid;
        private System.Windows.Forms.TextBox tB_Pwd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tB_Port;
        private System.Windows.Forms.CheckBox ck_ssl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bt_select;
    }
}

