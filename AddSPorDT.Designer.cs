namespace eBooking
{
    partial class AddSPorDT
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.cbRoleId = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ebookingDataSet1 = new eBooking.EbookingDataSet1();
            this.tbDistributeName = new System.Windows.Forms.TextBox();
            this.tbDistributeId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSupplierRemark = new System.Windows.Forms.TextBox();
            this.tbSupplierPassWord = new System.Windows.Forms.TextBox();
            this.tbSupplierLocation = new System.Windows.Forms.TextBox();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.tbSupplierId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbAdminPassWord = new System.Windows.Forms.TextBox();
            this.tbAdminId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.roleTableAdapter = new eBooking.EbookingDataSet1TableAdapters.RoleTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookingDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.tbRemark);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.tbPassWord);
            this.tabPage1.Controls.Add(this.cbRoleId);
            this.tabPage1.Controls.Add(this.tbDistributeName);
            this.tabPage1.Controls.Add(this.tbDistributeId);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "分销商添加";
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(119, 224);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(157, 61);
            this.tbRemark.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "备注：";
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(119, 171);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(157, 21);
            this.tbPassWord.TabIndex = 11;
            // 
            // cbRoleId
            // 
            this.cbRoleId.DataSource = this.roleBindingSource;
            this.cbRoleId.DisplayMember = "RLId";
            this.cbRoleId.FormattingEnabled = true;
            this.cbRoleId.Location = new System.Drawing.Point(119, 121);
            this.cbRoleId.Name = "cbRoleId";
            this.cbRoleId.Size = new System.Drawing.Size(157, 20);
            this.cbRoleId.TabIndex = 9;
            this.cbRoleId.ValueMember = "RLId";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.ebookingDataSet1;
            // 
            // ebookingDataSet1
            // 
            this.ebookingDataSet1.DataSetName = "EbookingDataSet1";
            this.ebookingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDistributeName
            // 
            this.tbDistributeName.Location = new System.Drawing.Point(119, 81);
            this.tbDistributeName.Name = "tbDistributeName";
            this.tbDistributeName.Size = new System.Drawing.Size(157, 21);
            this.tbDistributeName.TabIndex = 8;
            // 
            // tbDistributeId
            // 
            this.tbDistributeId.Location = new System.Drawing.Point(119, 33);
            this.tbDistributeId.Name = "tbDistributeId";
            this.tbDistributeId.Size = new System.Drawing.Size(157, 21);
            this.tbDistributeId.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(232, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "返回";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(115, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "添加";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "分销商角色：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "分销商名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "分销商ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tbSupplierRemark);
            this.tabPage2.Controls.Add(this.tbSupplierPassWord);
            this.tabPage2.Controls.Add(this.tbSupplierLocation);
            this.tabPage2.Controls.Add(this.tbSupplierName);
            this.tabPage2.Controls.Add(this.tbSupplierId);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "供应商添加";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(233, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 21);
            this.label15.TabIndex = 11;
            this.label15.Text = "返回";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(125, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 21);
            this.label14.TabIndex = 10;
            this.label14.Text = "添加";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // tbSupplierRemark
            // 
            this.tbSupplierRemark.Location = new System.Drawing.Point(115, 194);
            this.tbSupplierRemark.Multiline = true;
            this.tbSupplierRemark.Name = "tbSupplierRemark";
            this.tbSupplierRemark.Size = new System.Drawing.Size(194, 48);
            this.tbSupplierRemark.TabIndex = 9;
            // 
            // tbSupplierPassWord
            // 
            this.tbSupplierPassWord.Location = new System.Drawing.Point(115, 72);
            this.tbSupplierPassWord.Name = "tbSupplierPassWord";
            this.tbSupplierPassWord.Size = new System.Drawing.Size(194, 21);
            this.tbSupplierPassWord.TabIndex = 8;
            // 
            // tbSupplierLocation
            // 
            this.tbSupplierLocation.Location = new System.Drawing.Point(115, 113);
            this.tbSupplierLocation.Name = "tbSupplierLocation";
            this.tbSupplierLocation.Size = new System.Drawing.Size(194, 21);
            this.tbSupplierLocation.TabIndex = 7;
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(115, 155);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(194, 21);
            this.tbSupplierName.TabIndex = 6;
            // 
            // tbSupplierId
            // 
            this.tbSupplierId.Location = new System.Drawing.Point(115, 34);
            this.tbSupplierId.Name = "tbSupplierId";
            this.tbSupplierId.Size = new System.Drawing.Size(194, 21);
            this.tbSupplierId.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "备注：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "供应商名称：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "供应商所在地：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "供应商密码：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "供应商ID：";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.tbAdminPassWord);
            this.tabPage3.Controls.Add(this.tbAdminId);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(442, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "添加管理员";
            // 
            // tbAdminPassWord
            // 
            this.tbAdminPassWord.Location = new System.Drawing.Point(166, 163);
            this.tbAdminPassWord.Name = "tbAdminPassWord";
            this.tbAdminPassWord.Size = new System.Drawing.Size(126, 21);
            this.tbAdminPassWord.TabIndex = 5;
            // 
            // tbAdminId
            // 
            this.tbAdminId.Location = new System.Drawing.Point(166, 108);
            this.tbAdminId.Name = "tbAdminId";
            this.tbAdminId.Size = new System.Drawing.Size(126, 21);
            this.tbAdminId.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label19.Location = new System.Drawing.Point(116, 239);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 21);
            this.label19.TabIndex = 3;
            this.label19.Text = "添加";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label18.Location = new System.Drawing.Point(229, 239);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 21);
            this.label18.TabIndex = 2;
            this.label18.Text = "返回";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(94, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "密码：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(94, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "管理员Id：";
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // AddSPorDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(489, 404);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddSPorDT";
            this.Text = "AddSPorDT";
            this.Load += new System.EventHandler(this.AddSPorDT_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookingDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRoleId;
        private System.Windows.Forms.TextBox tbDistributeName;
        private System.Windows.Forms.TextBox tbDistributeId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private EbookingDataSet1 ebookingDataSet1;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private EbookingDataSet1TableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSupplierRemark;
        private System.Windows.Forms.TextBox tbSupplierPassWord;
        private System.Windows.Forms.TextBox tbSupplierLocation;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.TextBox tbSupplierId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbAdminPassWord;
        private System.Windows.Forms.TextBox tbAdminId;
    }
}