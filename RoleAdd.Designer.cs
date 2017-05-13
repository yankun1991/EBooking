namespace eBooking
{
    partial class RoleAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.cbBrokerage = new System.Windows.Forms.ComboBox();
            this.tbRoleId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.sceneryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ebookingDataSet4 = new eBooking.EbookingDataSet4();
            this.cbRoleProductId = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ebookingDataSet2 = new eBooking.EbookingDataSet2();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roleTableAdapter = new eBooking.EbookingDataSet2TableAdapters.RoleTableAdapter();
            this.sceneryTableAdapter = new eBooking.EbookingDataSet4TableAdapters.SceneryTableAdapter();
            this.ebookingDataSet5 = new eBooking.EbookingDataSet5();
            this.sceneryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sceneryTableAdapter1 = new eBooking.EbookingDataSet5TableAdapters.SceneryTableAdapter();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sceneryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookingDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookingDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookingDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "角色ID：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbProductId);
            this.groupBox1.Controls.Add(this.cbBrokerage);
            this.groupBox1.Controls.Add(this.tbRoleId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分销角色添加";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(140, 181);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(103, 125);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Size = new System.Drawing.Size(113, 21);
            this.tbProductId.TabIndex = 5;
            // 
            // cbBrokerage
            // 
            this.cbBrokerage.FormattingEnabled = true;
            this.cbBrokerage.Items.AddRange(new object[] {
            "按比例",
            "网上价",
            "优惠价",
            "内部价"});
            this.cbBrokerage.Location = new System.Drawing.Point(103, 69);
            this.cbBrokerage.Name = "cbBrokerage";
            this.cbBrokerage.Size = new System.Drawing.Size(113, 20);
            this.cbBrokerage.TabIndex = 4;
            this.cbBrokerage.Text = "请选择";
            // 
            // tbRoleId
            // 
            this.tbRoleId.Location = new System.Drawing.Point(103, 30);
            this.tbRoleId.Name = "tbRoleId";
            this.tbRoleId.Size = new System.Drawing.Size(113, 21);
            this.tbRoleId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "角色产品ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "佣金模式:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(303, 279);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(295, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "分销角色添加";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.tbProductName);
            this.tabPage2.Controls.Add(this.cbProduct);
            this.tabPage2.Controls.Add(this.cbRoleProductId);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(295, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "角色产品添加";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(116, 134);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(124, 21);
            this.tbProductName.TabIndex = 10;
            // 
            // cbProduct
            // 
            this.cbProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sceneryBindingSource, "SYId", true));
            this.cbProduct.DataSource = this.sceneryBindingSource1;
            this.cbProduct.DisplayMember = "SYId";
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(116, 90);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(124, 20);
            this.cbProduct.TabIndex = 9;
            this.cbProduct.ValueMember = "SYId";
            // 
            // sceneryBindingSource
            // 
            this.sceneryBindingSource.DataMember = "Scenery";
            this.sceneryBindingSource.DataSource = this.ebookingDataSet4;
            // 
            // ebookingDataSet4
            // 
            this.ebookingDataSet4.DataSetName = "EbookingDataSet4";
            this.ebookingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbRoleProductId
            // 
            this.cbRoleProductId.DataSource = this.roleBindingSource;
            this.cbRoleProductId.DisplayMember = "RLProductID";
            this.cbRoleProductId.FormattingEnabled = true;
            this.cbRoleProductId.Location = new System.Drawing.Point(116, 44);
            this.cbRoleProductId.Name = "cbRoleProductId";
            this.cbRoleProductId.Size = new System.Drawing.Size(124, 20);
            this.cbRoleProductId.TabIndex = 8;
            this.cbRoleProductId.ValueMember = "RLProductID";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.ebookingDataSet2;
            // 
            // ebookingDataSet2
            // 
            this.ebookingDataSet2.DataSetName = "EbookingDataSet2";
            this.ebookingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(162, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "返回";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(57, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "添加";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "产品ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "产品名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "角色产品ID:";
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // sceneryTableAdapter
            // 
            this.sceneryTableAdapter.ClearBeforeFill = true;
            // 
            // ebookingDataSet5
            // 
            this.ebookingDataSet5.DataSetName = "EbookingDataSet5";
            this.ebookingDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sceneryBindingSource1
            // 
            this.sceneryBindingSource1.DataMember = "Scenery";
            this.sceneryBindingSource1.DataSource = this.ebookingDataSet5;
            // 
            // sceneryTableAdapter1
            // 
            this.sceneryTableAdapter1.ClearBeforeFill = true;
            // 
            // RoleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(353, 315);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoleAdd";
            this.Text = "分销产品角色添加";
            this.Load += new System.EventHandler(this.RoleAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sceneryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookingDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookingDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookingDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.ComboBox cbBrokerage;
        private System.Windows.Forms.TextBox tbRoleId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRoleProductId;
        private EbookingDataSet2 ebookingDataSet2;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private EbookingDataSet2TableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.TextBox tbProductName;
        private EbookingDataSet4 ebookingDataSet4;
        private System.Windows.Forms.BindingSource sceneryBindingSource;
        private EbookingDataSet4TableAdapters.SceneryTableAdapter sceneryTableAdapter;
        private EbookingDataSet5 ebookingDataSet5;
        private System.Windows.Forms.BindingSource sceneryBindingSource1;
        private EbookingDataSet5TableAdapters.SceneryTableAdapter sceneryTableAdapter1;
    }
}