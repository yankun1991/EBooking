using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eBooking.DBAccess;
using eBooking.Models;

namespace eBooking
{
    public partial class DistributorUser : Form
    {
        public int indexer = -1;
        public DataSet DTds = new DataSet();
        public DataSet OAds= new DataSet();
        public DataSet SYds = new DataSet();
        public DataSet ASds1 = new DataSet();
        public DataSet ASds2 = new DataSet();
        public int SYId = -1;
        public int DTId = -1;
        public int ORId = -1;
        public string SceneryName;
        public DistributorUser()
        {
            InitializeComponent();
            InitializeData();
        }
        public DistributorUser(int userId)
        {
            InitializeComponent();
            DTId = userId;
            this.lbUser.Text = DTId + "";
            InitializeData();
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
                SYId = Convert.ToInt32(dataGridView1.Rows[index].Cells["景点ID"].Value);
                SceneryName = dataGridView1.Rows[index].Cells["景点名称"].Value.ToString() ;
                this.tbSceneryName.Text = SceneryName;
                indexer = e.RowIndex;
            } 
        }

        private void InitializeData()
        {
                this.dataGridView1.AutoGenerateColumns = true;
                DTds = SceneryAccess.selectForDistributor(DTId);
                if (DTds != null)
                {
                    dataGridView1.DataSource = DTds.Tables[0];
                }
                this.dataGridView2.AutoGenerateColumns = true;
                OAds = OrderAccess.ShowOrderForDistributor(DTId);
                if (OAds != null)
                {
                this.dataGridView2.DataSource=OAds.Tables[0];
                }
                this.dataGridView3.AutoGenerateColumns = true;
                SYds = SceneryAccess.ShowScenery();
                if (SYds != null)
                { 
                  this.dataGridView3.DataSource=SYds.Tables[0];
                }
                this.dataGridView4.AutoGenerateColumns = true;
                ASds1 = ApplySceneryAccess.selectForApply(DTId);
                if (ASds1 != null)
                {
                    this.dataGridView4.DataSource = ASds1.Tables[0];
                }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            if (indexer != -1)
            {
                Scenery scenery = new Scenery();
                scenery = SceneryAccess.SelectById(SYId);
                TicketInfo ticketInfo = new TicketInfo(scenery,DTId);
                ticketInfo.Show();
            }
            else
            {
                MessageBox.Show("请选择要预订的门票");
                DistributorUser distributor = new DistributorUser(DTId);
                distributor.Show();
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
                ORId = Convert.ToInt32(dataGridView2.Rows[index].Cells["订单ID"].Value);
                this.tbTicketId.Text = ORId + "";
                indexer = e.RowIndex;
            } 
        }

        private void lbCancleTicket_Click(object sender, EventArgs e)
        {
            if (indexer != -1)
            {
                DialogResult dr = MessageBox.Show("确定删除景点ID为" + ORId + "订单吗?", "确定", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bool isSuccess = OrderAccess.DeleteOrder(DTId);
                    if (isSuccess)
                    {
                        MessageBox.Show("景点删除成功");
                    }
                    DataSet ds =OrderAccess.ShowOrderForDistributor(DTId);
                    if (ds != null)
                    {
                        dataGridView2.DataSource = ds.Tables[0];
                        this.Refresh();
                    }
                }
            } 
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Show();
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
                SYId = Convert.ToInt32(dataGridView3.Rows[index].Cells["景点ID"].Value);
                this.tbSceneryId.Text = SYId + "";
                indexer = e.RowIndex;
            } 
        }

        private void lbSceneryApply_Click(object sender, EventArgs e)
        {
            ApplyScenery applyScenery = new ApplyScenery();
            applyScenery.ASSYId = SYId;
            applyScenery.ASDTId = DTId;
            if (ApplySceneryAccess.AddApply(applyScenery))
            {
                MessageBox.Show("申请成功！等待审批...");
            }
            else
            {
                MessageBox.Show("申请失败！请重新申请....");
            }
        }

        private void DistributorUser_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (this.tbTicketId.Text != null)
            {
                int state;
                state = UserAccess.PayOffForDistributor(DTId, Convert.ToInt32(this.tbTicketId.Text));
                switch (state)
                {
                    case 0: MessageBox.Show("支付失败...."); break;
                    case 1: MessageBox.Show("账户余额不足...."); break;
                    case 2: MessageBox.Show("支付成功"); break;
                    default: MessageBox.Show("请等会在尝试支付..."); break;
                }
                this.Refresh();
            }
        }

        private void DistributorUser_MouseClick(object sender, MouseEventArgs e)
        {
            InitializeData();
        }
    }
}
