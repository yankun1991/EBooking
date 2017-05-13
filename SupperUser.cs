using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eBooking.DBAccess;

namespace eBooking
{
    public partial class SupperUser : Form
    {
        #region 成员变量声明
        public DataSet SPds = new DataSet();
        public DataSet DTds = new DataSet();
        public DataSet RLds = new DataSet();
        public DataSet ACds = new DataSet();
        public DataSet RPds = new DataSet();
        public DataSet ASds = new DataSet();
        public DataSet SYds = new DataSet();
        public int DTId;
        public int SPId;
        public int ACId;
        public int RLId;
        public int RPId;
        public int ASId;
        public int SYId = 0;
        public int indexer = -1;
        public int UserId; 
        #endregion


        public SupperUser(int userId)
        {
            UserId = userId;
            InitializeComponent();
            InitializeDataSet();
            this.lbUser.Text = UserId + "";
        }
        public SupperUser()
        {
            InitializeComponent();
            InitializeDataSet();
        }


        /// <summary>
        /// 界面加载时初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin_Load(object sender, EventArgs e)
        {
            this.applySceneryTableAdapter.Fill(this.ebookingDataSet6.ApplyScenery);
        }

        #region 数据操作
        private void lbSupplierAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddSPorDT addDPorDT = new AddSPorDT(UserId);
            addDPorDT.Show();
        }

        private void lbRoleAdd_Click(object sender, EventArgs e)
        {
            RoleAdd roleAdd = new RoleAdd(UserId);
            this.Visible = false;
            roleAdd.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RoleAdd roleAdd = new RoleAdd(UserId);
            roleAdd.Show();
        }


        private void lbDistribute_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddSPorDT addDPorDT = new AddSPorDT(UserId);
            addDPorDT.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddSPorDT addDPorDT = new AddSPorDT(UserId);
            addDPorDT.Show();
        } 
        #endregion

        #region 根据鼠标的单击选择当前行进行对应的操作
        private void label2_Click(object sender, EventArgs e)
        {
            if (indexer != -1)
            {
                DialogResult dr = MessageBox.Show("确定删除？", "确定", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dataGridView1.DataSource = SPds.Tables[0];
                    bool isSuccess = SupplierAccess.DeleteSupplier(SPId);
                    if (isSuccess)
                    {
                        MessageBox.Show("供应商删除成功");
                    }
                    DataSet ds = SupplierAccess.Select();
                    dataGridView1.DataSource = ds.Tables[0];
                    if (ds != null)
                    {
                        this.Refresh();
                    }
                }
            }
        }


        private void lbCancleDistribute_Click(object sender, EventArgs e)
        {
            if (indexer != -1)
            {
                DialogResult dr = MessageBox.Show("确定删除？", "确定", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dataGridView1.DataSource = DTds.Tables[0];
                    bool isSuccess = DistributorAccess.DeleteDistribute(DTId);
                    if (isSuccess)
                    {
                        MessageBox.Show("分销商删除成功");
                    }
                    DataSet ds = DistributorAccess.Select();                  
                    if (ds != null)
                    {
                        dataGridView2.DataSource = ds.Tables[0];
                        this.Refresh();
                    }
                }
            }
        }


        private void lbRoleCanale_Click(object sender, EventArgs e)
        {
            if (indexer != -1)
            {
                DialogResult dr = MessageBox.Show("确定删除？", "确定", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dataGridView3.DataSource = RLds.Tables[0];
                    bool isSuccess = RoleAccess.DeleteRole(RLId);
                    if (isSuccess)
                    {
                        MessageBox.Show("角色删除成功");
                    }
                    DataSet ds = RoleAccess.ShowRole();
                    dataGridView3.DataSource = ds.Tables[0];
                    if (ds != null)
                    {
                        this.Refresh();
                    }
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int index = dataGridView3.CurrentRow.Index;
                DTId = Convert.ToInt32(dataGridView3.Rows[index].Cells["角色ID"].Value);
                this.tbRoleId.Text = DTId + "";
                indexer = e.RowIndex;
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int index = dataGridView2.CurrentRow.Index;
                DTId = Convert.ToInt32(dataGridView2.Rows[index].Cells["分销商ID"].Value);
                this.tbDistributeId.Text = DTId + "";
                indexer = e.RowIndex;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int index = dataGridView1.CurrentRow.Index;
                SPId = Convert.ToInt32(dataGridView1.Rows[index].Cells["供应商ID"].Value);
                this.tbSupplierId.Text = SPId + "";
                indexer = e.RowIndex;
            }
        }


        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int index = dataGridView4.CurrentRow.Index;
                SPId = Convert.ToInt32(dataGridView4.Rows[index].Cells["用户ID"].Value);
                this.tbAdminId.Text = SPId + "";
                indexer = e.RowIndex;
            }
        }
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int index = dataGridView5.CurrentRow.Index;
                DTId = Convert.ToInt32(dataGridView5.Rows[index].Cells["角色产品ID"].Value);
                this.tbRoleProduct.Text = DTId + "";
                indexer = e.RowIndex;
            }
        }


        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int index = dataGridView7.CurrentRow.Index;
                SYId = Convert.ToInt32(dataGridView7.Rows[index].Cells["景点ID"].Value);
                this.tbSceneryId.Text = SYId + "";
                indexer = e.RowIndex;
            }
        }
        private void lbRoleProductdelete_Click(object sender, EventArgs e)
        {
            if (indexer != -1)
            {
                DialogResult dr = MessageBox.Show("确定删除？", "确定", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dataGridView5.DataSource = RPds.Tables[0];
                    bool isSuccess = RoleProductAccess.DeleteRoleProduct(RPId);
                    if (isSuccess)
                    {
                        MessageBox.Show("角色产品删除成功");
                    }
                    DataSet ds = RoleProductAccess.ShowRoleProduct();
                    dataGridView5.DataSource = ds.Tables[0];
                    if (ds != null)
                    {
                        this.Refresh();
                    }
                }
            }
        }

        private void lbDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (indexer != -1)
            {
                DialogResult dr = MessageBox.Show("确定删除？", "确定", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dataGridView4.DataSource = ACds.Tables[0];
                    bool isSuccess = AdminAccess.DeleteSupperUser(SPId);
                    if (isSuccess)
                    {
                        MessageBox.Show("管理员删除成功");
                    }
                    DataSet ds = AdminAccess.ShowSupperUser();
                    dataGridView3.DataSource = ds.Tables[0];
                    if (ds != null)
                    {
                        this.Refresh();
                    }
                    this.Refresh();
                }
            }
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int index = dataGridView6.CurrentRow.Index;
                ASId = Convert.ToInt32(dataGridView6.Rows[index].Cells["记录ID"].Value);
                this.tbAPId.Text = ASId + "";
                indexer = e.RowIndex;
            }
        }
        #endregion

        /// <summary>
        /// 界面显示初始化
        /// </summary>
        private void InitializeDataSet()
        {
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView2.AutoGenerateColumns = true;
            this.dataGridView3.AutoGenerateColumns = true;
            this.dataGridView4.AutoGenerateColumns = true;
            this.dataGridView5.AutoGenerateColumns = true;
            this.dataGridView6.AutoGenerateColumns = true;
            this.dataGridView7.AutoGenerateColumns = true;
            SPds = SupplierAccess.Select();
            DTds = DistributorAccess.Select();
            ACds = AdminAccess.ShowSupperUser();
            RLds = RoleAccess.ShowRole();
            ASds = ApplySceneryAccess.selectForApply();
            RPds = RoleProductAccess.ShowRoleProduct();
            SYds = SceneryAccess.ShowSceneryForSupper();
            if (SPds != null)
            {
                dataGridView1.DataSource = SPds.Tables[0];
            }
            if (DTds != null)
            {
                dataGridView2.DataSource = DTds.Tables[0];
            }
            if (RLds != null)
            {
                dataGridView3.DataSource = RLds.Tables[0];
            }
            if (ACds != null)
            {
                dataGridView4.DataSource = ACds.Tables[0];
            }
            if (RPds != null)
            {
                dataGridView5.DataSource = RPds.Tables[0];
            }
            if (ASds != null)
            {
                dataGridView6.DataSource = ASds.Tables[0];
            }
            if (SYds != null)
            {
                dataGridView7.DataSource=SYds.Tables[0];
            }
        }

        /// <summary>
        /// 返回登录界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label11_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Show();
        }

        /// <summary>
        /// 分销商申请批准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbAgreeApply_Click(object sender, EventArgs e)
        {
            if (ApplySceneryAccess.AgreeAP(ASId))
            {
                MessageBox.Show("申请已批准！");
                this.Refresh();
            }
            else
            {
                MessageBox.Show("申请批准失败");
            }
        }

        /// <summary>
        /// 景点审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label13_Click(object sender, EventArgs e)
        {
            if (SYId != 0)
            {
                if (SceneryAccess.SceneryPass(SYId))
                {
                    MessageBox.Show("审核通过");
                }
                else
                {
                    MessageBox.Show("审核失败");
                }
            }
            else
            {
                MessageBox.Show("请选择景点ID，然后进行审核....");
            }
        }


    }
}
