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
    /// <summary>
    /// 供应商
    /// </summary>
    public partial class SupplierUser : Form
    {
        public DataSet SYds = new DataSet();
        public int SYId=-1;
        public int indexer = -1;
        public int UserId = -1;
        #region 初始化构造函数
        public SupplierUser()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = true;
            SYds = SceneryAccess.ShowScenery();
            if (SYds != null)
            {
                this.dataGridView1.DataSource = SYds.Tables[0];
            }

        }
        public SupplierUser(int userId)
        {
            InitializeComponent();
            UserId = userId;
            this.dataGridView1.AutoGenerateColumns = true;
            SYds = SceneryAccess.ShowSceneryById(UserId);
            if (SYds != null)
            {
                this.dataGridView1.DataSource = SYds.Tables[0];
            }
            this.lbUser.Text = UserId + "";
        } 
        #endregion

        /// <summary>
        /// 增加景点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SceneryAdd sceneryAdd = new SceneryAdd(UserId);
            sceneryAdd.Show();
        }
        /// <summary>
        /// 根据鼠标的点击选出当前行的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int index = dataGridView1.CurrentRow.Index;
                SYId = Convert.ToInt32(dataGridView1.Rows[index].Cells["景点ID"].Value);
                this.tbSceneryId.Text = SYId + "";
                indexer = e.RowIndex;
            } 
        }
        /// <summary>
        /// 景点删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbDelete_Click(object sender, EventArgs e)
        {
            if (indexer != -1)
            {
                DialogResult dr = MessageBox.Show("确定删除景点ID为" + SYId + "景点吗?", "确定", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dataGridView1.DataSource = SYds.Tables[0];
                    bool isSuccess = SceneryAccess.DeleteScenery(SYId);
                    if (isSuccess)
                    {
                        MessageBox.Show("景点删除成功");
                    }
                    DataSet ds = SceneryAccess.ShowScenery();
                    dataGridView1.DataSource = ds.Tables[0];
                    if (ds != null)
                    {
                        this.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的景点....");
            }
        }
        /// <summary>
        /// 景点更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbUpdate_Click(object sender, EventArgs e)
        {
            if (SYId != -1)
            {
                this.Visible = false;
                SceneryAdd sceneryAdd = new SceneryAdd(UserId,SYId);
                sceneryAdd.Show();
            }
        }
        /// <summary>
        /// 返回登录界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Show();
        }
    }
}
