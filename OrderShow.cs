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
    public partial class OrderShow : Form
    {
        public DataTable dTable = new DataTable();
        public DataSet dataSet = new DataSet();
        public int UserID;
        public  int indexer = -1;
        public int TKId;
        public OrderShow()
        {
            InitializeComponent();
        }
        public OrderShow(DataSet ds,int userId)
        {
            dataSet = ds;
            UserID = userId;
            InitializeComponent();
           this.dataGridView1.AutoGenerateColumns = true;
        }

        private void OrderShow_Load(object sender, EventArgs e)
        {
            this.lbUserName.Text = UserID + "";
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Homepage homePage = new Homepage(UserID);
            homePage.Show();
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
                TKId=Convert.ToInt32(dataGridView1.Rows[index].Cells["用户名"].Value);
                this.tbDeleteShow.Text = TKId + "";
                indexer = e.RowIndex;
            } 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (indexer != -1) 
            { 
                DialogResult dr=MessageBox.Show("确定删除？","确定",MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dataGridView1.DataSource = dTable;
                    bool isSuccess = OrderAccess.DeleteOrder(TKId);
                    if (isSuccess)
                    {
                        MessageBox.Show("订单删除成功");
                    }
                    DataSet ds = OrderAccess.ShowOrder(UserID);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (ds != null)
                    {
                        this.Refresh();
                    }
                }
            } 
        }
    }
}
