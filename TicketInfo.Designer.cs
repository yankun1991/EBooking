namespace eBooking
{
    partial class TicketInfo
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbIntroduce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSceneryName1 = new System.Windows.Forms.Label();
            this.lbTicketNum1 = new System.Windows.Forms.Label();
            this.dtpUseTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btBook = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTicketType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTicketNum = new System.Windows.Forms.NumericUpDown();
            this.lbSceneryName2 = new System.Windows.Forms.Label();
            this.lbPrice1 = new System.Windows.Forms.Label();
            this.lbPrice2 = new System.Windows.Forms.Label();
            this.lbTicketNum2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicketNum)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(24, 36);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(162, 121);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // tbIntroduce
            // 
            this.tbIntroduce.Location = new System.Drawing.Point(217, 53);
            this.tbIntroduce.Multiline = true;
            this.tbIntroduce.Name = "tbIntroduce";
            this.tbIntroduce.Size = new System.Drawing.Size(204, 104);
            this.tbIntroduce.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "景点简介：";
            // 
            // lbSceneryName1
            // 
            this.lbSceneryName1.AutoSize = true;
            this.lbSceneryName1.Location = new System.Drawing.Point(24, 181);
            this.lbSceneryName1.Name = "lbSceneryName1";
            this.lbSceneryName1.Size = new System.Drawing.Size(59, 12);
            this.lbSceneryName1.TabIndex = 3;
            this.lbSceneryName1.Text = "景点名称:";
            // 
            // lbTicketNum1
            // 
            this.lbTicketNum1.AutoSize = true;
            this.lbTicketNum1.Location = new System.Drawing.Point(26, 209);
            this.lbTicketNum1.Name = "lbTicketNum1";
            this.lbTicketNum1.Size = new System.Drawing.Size(95, 12);
            this.lbTicketNum1.TabIndex = 4;
            this.lbTicketNum1.Text = "当前已售卖张数:";
            // 
            // dtpUseTime
            // 
            this.dtpUseTime.Location = new System.Drawing.Point(231, 200);
            this.dtpUseTime.Name = "dtpUseTime";
            this.dtpUseTime.Size = new System.Drawing.Size(200, 21);
            this.dtpUseTime.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "出发时间：";
            // 
            // btBook
            // 
            this.btBook.Location = new System.Drawing.Point(112, 347);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(75, 23);
            this.btBook.TabIndex = 7;
            this.btBook.Text = "预订";
            this.btBook.UseVisualStyleBackColor = true;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(232, 347);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(75, 23);
            this.btReturn.TabIndex = 8;
            this.btReturn.Text = "返回";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "门票类型：";
            // 
            // cbTicketType
            // 
            this.cbTicketType.FormattingEnabled = true;
            this.cbTicketType.Items.AddRange(new object[] {
            "成人票",
            "儿童票",
            "学生票"});
            this.cbTicketType.Location = new System.Drawing.Point(112, 261);
            this.cbTicketType.Name = "cbTicketType";
            this.cbTicketType.Size = new System.Drawing.Size(121, 20);
            this.cbTicketType.TabIndex = 10;
            this.cbTicketType.Text = "请选择";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "购买张数：";
            // 
            // nudTicketNum
            // 
            this.nudTicketNum.Location = new System.Drawing.Point(112, 299);
            this.nudTicketNum.Name = "nudTicketNum";
            this.nudTicketNum.Size = new System.Drawing.Size(120, 21);
            this.nudTicketNum.TabIndex = 12;
            // 
            // lbSceneryName2
            // 
            this.lbSceneryName2.AutoSize = true;
            this.lbSceneryName2.Location = new System.Drawing.Point(89, 180);
            this.lbSceneryName2.Name = "lbSceneryName2";
            this.lbSceneryName2.Size = new System.Drawing.Size(53, 12);
            this.lbSceneryName2.TabIndex = 13;
            this.lbSceneryName2.Text = "景点名称";
            // 
            // lbPrice1
            // 
            this.lbPrice1.AutoSize = true;
            this.lbPrice1.Location = new System.Drawing.Point(26, 234);
            this.lbPrice1.Name = "lbPrice1";
            this.lbPrice1.Size = new System.Drawing.Size(41, 12);
            this.lbPrice1.TabIndex = 14;
            this.lbPrice1.Text = "票价：";
            // 
            // lbPrice2
            // 
            this.lbPrice2.AutoSize = true;
            this.lbPrice2.Location = new System.Drawing.Point(73, 234);
            this.lbPrice2.Name = "lbPrice2";
            this.lbPrice2.Size = new System.Drawing.Size(0, 12);
            this.lbPrice2.TabIndex = 15;
            // 
            // lbTicketNum2
            // 
            this.lbTicketNum2.AutoSize = true;
            this.lbTicketNum2.Location = new System.Drawing.Point(122, 209);
            this.lbTicketNum2.Name = "lbTicketNum2";
            this.lbTicketNum2.Size = new System.Drawing.Size(41, 12);
            this.lbTicketNum2.TabIndex = 16;
            this.lbTicketNum2.Text = "label5";
            // 
            // TicketInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(494, 390);
            this.Controls.Add(this.lbTicketNum2);
            this.Controls.Add(this.lbPrice2);
            this.Controls.Add(this.lbPrice1);
            this.Controls.Add(this.lbSceneryName2);
            this.Controls.Add(this.nudTicketNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTicketType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpUseTime);
            this.Controls.Add(this.lbTicketNum1);
            this.Controls.Add(this.lbSceneryName1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIntroduce);
            this.Controls.Add(this.pbImage);
            this.Name = "TicketInfo";
            this.Text = "景点详情";
            this.Load += new System.EventHandler(this.TicketInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicketNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbIntroduce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSceneryName1;
        private System.Windows.Forms.Label lbTicketNum1;
        private System.Windows.Forms.DateTimePicker dtpUseTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBook;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTicketType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTicketNum;
        private System.Windows.Forms.Label lbSceneryName2;
        private System.Windows.Forms.Label lbPrice1;
        private System.Windows.Forms.Label lbPrice2;
        private System.Windows.Forms.Label lbTicketNum2;
    }
}