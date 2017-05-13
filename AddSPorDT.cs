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
    public partial class AddSPorDT : Form
    {
        public int UserId;
        public AddSPorDT()
        {
            InitializeComponent();
        }
        public AddSPorDT(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void AddSPorDT_Load(object sender, EventArgs e)
        {
            this.roleTableAdapter.Fill(this.ebookingDataSet1.Role);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            int distributeId = Convert.ToInt32(this.tbDistributeId.Text);
          //  string account = this.tbAccount.Text;
            string distributeName = this.tbDistributeName.Text;
            string passWord = this.tbPassWord.Text;
            int roleId = Convert.ToInt32(this.cbRoleId.SelectedValue);
            string remark = this.tbRemark.Text;
            Distributor distribute = new Distributor();
            distribute.DTId = distributeId;
        //    distribute.DTAccount = account;
            distribute.DTRoleId = roleId;
            distribute.DTName = distributeName;
            distribute.DTPassWord = passWord;
            distribute.DTRemark = remark;
            if (DistributorAccess.AddDistribute(distribute))
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SupperUser admin = new SupperUser(UserId);
            admin.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            int supplierId=Convert.ToInt32(this.tbSupplierId.Text);
            string SupplierName=this.tbSupplierName.Text;
            string location = this.tbSupplierLocation.Text;
            string passWord = this.tbSupplierPassWord.Text;
            string remark = this.tbSupplierRemark.Text;
            Supplier supplier = new Supplier();
            supplier.SPId = supplierId;
            supplier.SPLocation = location;
            supplier.SPName = SupplierName;
            supplier.SPRemark = remark;
            supplier.SPPassWord = passWord;
            if (SupplierAccess.AddSupplier(supplier))
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SupperUser admin = new SupperUser(UserId);
            admin.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            int adminId = Convert.ToInt32(this.tbAdminId.Text);
            string adminPassWord = this.tbAdminPassWord.Text;
            Admin admin = new Admin();
            admin.ACId = adminId;
            admin.ACPassWord = adminPassWord;
            if (AdminAccess.AddSupperUser(admin))
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SupperUser supperUser = new SupperUser(UserId);
            supperUser.Show();
        }
    }
}
