using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eBooking.Models;
using eBooking.DBAccess;

namespace eBooking
{  
    public partial class UserInfo : Form
    {
        public DataTable dTable = new DataTable();
        public DataSet dataSet = new DataSet();
        public int indexer = -1;
        public int TKId;
        public int UserId = -1;
        public UserInfo()
        {
            InitializeComponent();
        }
        public UserInfo(User user)
        {
            UserId = user.USId;
            InitializeComponent();
            this.lbUserName2.Text = user.USName;
            this.lbLastLoginIP2.Text = user.USLastLoginIp;
            this.lbLastLoginTime2.Text = user.USLastLoginTime+"";
            this.lbUserCount2.Text = user.USCount + "";
            this.lbUserGrade2.Text = user.USGrade + "";
            this.lbUserMail2.Text = user.USEmail;
            this.tbRemark.Text = user.USRemark;
            this.lbUserPhone2.Text = user.USPhone;
            InitializeData();

        }
        private void UserInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
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
                TKId = Convert.ToInt32(dataGridView1.Rows[index].Cells["用户名"].Value);
                this.tbOrderShow.Text = TKId + "";
                indexer = e.RowIndex;
            } 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (indexer != -1)
            {
                DialogResult dr = MessageBox.Show("确定删除？", "确定", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dataGridView1.DataSource = dTable;
                    bool isSuccess = OrderAccess.DeleteOrder(TKId);
                    if (isSuccess)
                    {
                        MessageBox.Show("订单删除成功");
                    }
                    DataSet ds = OrderAccess.ShowOrder(UserId);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (ds != null)
                    {
                        this.Refresh();
                    }
                }
            }
        }
        private void InitializeData()
        {
            DataSet ds1 = OrderAccess.ShowOrder(UserId);
            if (ds1 != null)
            {
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.DataSource = ds1.Tables[0];
            }
            DataSet ds2 = OrderAccess.ShowOrderOfDate(UserId);
            if (ds2 != null)
            {
                this.dataGridView2.AutoGenerateColumns = true;
                this.dataGridView2.DataSource = ds2.Tables[0];
            }
        }

        private void lbReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Homepage homePage = new Homepage(UserId);
            homePage.Show();
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
                TKId = Convert.ToInt32(dataGridView2.Rows[index].Cells["订单号"].Value);
                this.tbOrderId.Text = TKId + "";
                indexer = e.RowIndex;
            } 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (TKId != -1)
            {
                string Content = this.tbContent.Text;
                if (OrderAccess.RemarkOrder(TKId, Content))
                {
                    if (UserId != -1)
                    {
                        UserAccess.CountofUpdate(UserId);
                        MessageBox.Show("点评成功...");
                    }
                }
                else
                {
                    MessageBox.Show("您已经点评过了...");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (this.tbOrderShow.Text != null)
            {
                int state;
                state = UserAccess.PayOffForUser(UserId,Convert.ToInt32(this.tbOrderShow.Text));
                switch (state)
                {
                    case 0: MessageBox.Show("支付失败...."); break;
                    case 1: MessageBox.Show("账户余额不足...."); break;
                    case 2: MessageBox.Show("支付成功");  break;
                    default: MessageBox.Show("请等会在尝试支付..."); break;
                }
                this.Refresh();
            }
        }
    }
}
