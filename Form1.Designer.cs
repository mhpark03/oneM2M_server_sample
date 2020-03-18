﻿namespace HttpServer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetCSEBase = new System.Windows.Forms.Button();
            this.btnGetRemoteCSE = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnSetRemoteCSE = new System.Windows.Forms.Button();
            this.btnMEFAuth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSvcSvrCd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSvcSvrNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSvcCd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEnrmtKeyId = new System.Windows.Forms.Label();
            this.lbEnrmtKey = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbToken = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbEntityId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelRemoteCSE = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDataRetrive = new System.Windows.Forms.Button();
            this.cboneM2MModel = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbContainer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDeviceCTN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSeverIP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSeverPort = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetCSEBase
            // 
            this.btnGetCSEBase.Location = new System.Drawing.Point(23, 33);
            this.btnGetCSEBase.Name = "btnGetCSEBase";
            this.btnGetCSEBase.Size = new System.Drawing.Size(119, 23);
            this.btnGetCSEBase.TabIndex = 0;
            this.btnGetCSEBase.Text = "CSEBase 조회";
            this.btnGetCSEBase.UseVisualStyleBackColor = true;
            this.btnGetCSEBase.Click += new System.EventHandler(this.btnGetCSEBase_Click);
            // 
            // btnGetRemoteCSE
            // 
            this.btnGetRemoteCSE.Location = new System.Drawing.Point(24, 73);
            this.btnGetRemoteCSE.Name = "btnGetRemoteCSE";
            this.btnGetRemoteCSE.Size = new System.Drawing.Size(119, 23);
            this.btnGetRemoteCSE.TabIndex = 0;
            this.btnGetRemoteCSE.Text = "CSR 조회";
            this.btnGetRemoteCSE.UseVisualStyleBackColor = true;
            this.btnGetRemoteCSE.Click += new System.EventHandler(this.btnGetRemoteCSE_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(472, 114);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(126, 23);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "데이터 보내기";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(113, 115);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(353, 21);
            this.tbData.TabIndex = 4;
            this.tbData.Text = "1234";
            // 
            // btnSetRemoteCSE
            // 
            this.btnSetRemoteCSE.Location = new System.Drawing.Point(349, 101);
            this.btnSetRemoteCSE.Name = "btnSetRemoteCSE";
            this.btnSetRemoteCSE.Size = new System.Drawing.Size(118, 46);
            this.btnSetRemoteCSE.TabIndex = 0;
            this.btnSetRemoteCSE.Text = "CSR 생성";
            this.btnSetRemoteCSE.UseVisualStyleBackColor = true;
            this.btnSetRemoteCSE.Click += new System.EventHandler(this.btnSetRemoteCSE_Click);
            // 
            // btnMEFAuth
            // 
            this.btnMEFAuth.Location = new System.Drawing.Point(33, 127);
            this.btnMEFAuth.Name = "btnMEFAuth";
            this.btnMEFAuth.Size = new System.Drawing.Size(215, 23);
            this.btnMEFAuth.TabIndex = 0;
            this.btnMEFAuth.Text = "MEF 인증";
            this.btnMEFAuth.UseVisualStyleBackColor = true;
            this.btnMEFAuth.Click += new System.EventHandler(this.btnMEFAuth_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "서버 SEQ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSvcSvrCd
            // 
            this.tbSvcSvrCd.Location = new System.Drawing.Point(99, 20);
            this.tbSvcSvrCd.Name = "tbSvcSvrCd";
            this.tbSvcSvrCd.Size = new System.Drawing.Size(100, 21);
            this.tbSvcSvrCd.TabIndex = 7;
            this.tbSvcSvrCd.Text = "300";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "서버 NUM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSvcSvrNum
            // 
            this.tbSvcSvrNum.Location = new System.Drawing.Point(99, 47);
            this.tbSvcSvrNum.Name = "tbSvcSvrNum";
            this.tbSvcSvrNum.Size = new System.Drawing.Size(100, 21);
            this.tbSvcSvrNum.TabIndex = 7;
            this.tbSvcSvrNum.Text = "1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "서비스코드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSvcCd
            // 
            this.tbSvcCd.Location = new System.Drawing.Point(99, 74);
            this.tbSvcCd.Name = "tbSvcCd";
            this.tbSvcCd.Size = new System.Drawing.Size(100, 21);
            this.tbSvcCd.TabIndex = 7;
            this.tbSvcCd.Text = "CATM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEnrmtKeyId);
            this.groupBox1.Controls.Add(this.btnMEFAuth);
            this.groupBox1.Controls.Add(this.tbSvcCd);
            this.groupBox1.Controls.Add(this.lbEnrmtKey);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbToken);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbEntityId);
            this.groupBox1.Controls.Add(this.tbSvcSvrCd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSvcSvrNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(652, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 169);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEF";
            // 
            // lbEnrmtKeyId
            // 
            this.lbEnrmtKeyId.Location = new System.Drawing.Point(317, 101);
            this.lbEnrmtKeyId.Name = "lbEnrmtKeyId";
            this.lbEnrmtKeyId.Size = new System.Drawing.Size(304, 16);
            this.lbEnrmtKeyId.TabIndex = 8;
            this.lbEnrmtKeyId.Text = "svr.enrmtKeyId";
            this.lbEnrmtKeyId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEnrmtKey
            // 
            this.lbEnrmtKey.Location = new System.Drawing.Point(317, 25);
            this.lbEnrmtKey.Name = "lbEnrmtKey";
            this.lbEnrmtKey.Size = new System.Drawing.Size(304, 16);
            this.lbEnrmtKey.TabIndex = 6;
            this.lbEnrmtKey.Text = "svr.enrmtKey";
            this.lbEnrmtKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(205, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "svr.enrmtKey =";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbToken
            // 
            this.lbToken.Location = new System.Drawing.Point(317, 79);
            this.lbToken.Name = "lbToken";
            this.lbToken.Size = new System.Drawing.Size(320, 16);
            this.lbToken.TabIndex = 6;
            this.lbToken.Text = "svr.token";
            this.lbToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(202, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "svr.enrmtKeyId = ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(205, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "svr.token =";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbEntityId
            // 
            this.lbEntityId.Location = new System.Drawing.Point(317, 52);
            this.lbEntityId.Name = "lbEntityId";
            this.lbEntityId.Size = new System.Drawing.Size(304, 16);
            this.lbEntityId.TabIndex = 6;
            this.lbEntityId.Text = "svr.entityId";
            this.lbEntityId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(205, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "svr.entityId =";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(12, 12);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(634, 716);
            this.tbLog.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSeverPort);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbSeverIP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnDelRemoteCSE);
            this.groupBox2.Controls.Add(this.btnGetCSEBase);
            this.groupBox2.Controls.Add(this.btnSetRemoteCSE);
            this.groupBox2.Controls.Add(this.btnGetRemoteCSE);
            this.groupBox2.Location = new System.Drawing.Point(654, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 163);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CSE";
            // 
            // btnDelRemoteCSE
            // 
            this.btnDelRemoteCSE.Location = new System.Drawing.Point(193, 73);
            this.btnDelRemoteCSE.Name = "btnDelRemoteCSE";
            this.btnDelRemoteCSE.Size = new System.Drawing.Size(118, 23);
            this.btnDelRemoteCSE.TabIndex = 2;
            this.btnDelRemoteCSE.Text = "CSR 삭제";
            this.btnDelRemoteCSE.UseVisualStyleBackColor = true;
            this.btnDelRemoteCSE.Click += new System.EventHandler(this.btnDelRemoteCSE_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnDataRetrive);
            this.groupBox3.Controls.Add(this.cboneM2MModel);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbContainer);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbDeviceCTN);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbData);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Location = new System.Drawing.Point(654, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 163);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "oneM2M Device DATA";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(21, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 22);
            this.label13.TabIndex = 15;
            this.label13.Text = "DATA(text)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDataRetrive
            // 
            this.btnDataRetrive.Location = new System.Drawing.Point(339, 88);
            this.btnDataRetrive.Name = "btnDataRetrive";
            this.btnDataRetrive.Size = new System.Drawing.Size(127, 23);
            this.btnDataRetrive.TabIndex = 14;
            this.btnDataRetrive.Text = "데이터 확인 (DB)";
            this.btnDataRetrive.UseVisualStyleBackColor = true;
            this.btnDataRetrive.Click += new System.EventHandler(this.btnDataRetrive_Click);
            // 
            // cboneM2MModel
            // 
            this.cboneM2MModel.FormattingEnabled = true;
            this.cboneM2MModel.Items.AddRange(new object[] {
            "AMM5400LG"});
            this.cboneM2MModel.Location = new System.Drawing.Point(113, 20);
            this.cboneM2MModel.Name = "cboneM2MModel";
            this.cboneM2MModel.Size = new System.Drawing.Size(205, 20);
            this.cboneM2MModel.TabIndex = 13;
            this.cboneM2MModel.Text = "AMM5400LG";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(21, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "모델명";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbContainer
            // 
            this.tbContainer.Location = new System.Drawing.Point(114, 88);
            this.tbContainer.Name = "tbContainer";
            this.tbContainer.Size = new System.Drawing.Size(205, 21);
            this.tbContainer.TabIndex = 10;
            this.tbContainer.Text = "TEST";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(21, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "폴더명";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDeviceCTN
            // 
            this.tbDeviceCTN.Location = new System.Drawing.Point(113, 55);
            this.tbDeviceCTN.Name = "tbDeviceCTN";
            this.tbDeviceCTN.Size = new System.Drawing.Size(205, 21);
            this.tbDeviceCTN.TabIndex = 8;
            this.tbDeviceCTN.Text = "01222990847";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(21, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "CTN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(654, 602);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(613, 111);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LwM2M Device DATA";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "상태조회(단말)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(19, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 22);
            this.label14.TabIndex = 17;
            this.label14.Text = "DATA(text)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 21);
            this.textBox2.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(21, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 22);
            this.label11.TabIndex = 13;
            this.label11.Text = "Device EntityID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(352, 21);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "1234";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "데이터 보내기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbSeverIP
            // 
            this.tbSeverIP.Location = new System.Drawing.Point(115, 102);
            this.tbSeverIP.Name = "tbSeverIP";
            this.tbSeverIP.Size = new System.Drawing.Size(206, 21);
            this.tbSeverIP.TabIndex = 12;
            this.tbSeverIP.Text = "http://172.17.224.57";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(22, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "서비스서버 IP";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSeverPort
            // 
            this.tbSeverPort.Location = new System.Drawing.Point(116, 127);
            this.tbSeverPort.Name = "tbSeverPort";
            this.tbSeverPort.Size = new System.Drawing.Size(205, 21);
            this.tbSeverPort.TabIndex = 14;
            this.tbSeverPort.Text = "8180";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(23, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 22);
            this.label15.TabIndex = 13;
            this.label15.Text = "서비스서버 port";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 740);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "NB-IoT HTTP Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCSEBase;
        private System.Windows.Forms.Button btnGetRemoteCSE;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnSetRemoteCSE;
        private System.Windows.Forms.Button btnMEFAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSvcSvrCd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSvcSvrNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSvcCd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEnrmtKey;
        private System.Windows.Forms.Label lbToken;
        private System.Windows.Forms.Label lbEntityId;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbEnrmtKeyId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbDeviceCTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelRemoteCSE;
        private System.Windows.Forms.TextBox tbContainer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboneM2MModel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDataRetrive;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSeverPort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSeverIP;
        private System.Windows.Forms.Label label10;
    }
}

