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
    public partial class RoleAdd : Form
    {
        public int UserId;
        public RoleAdd()
        {
            InitializeComponent();
        }
        public RoleAdd(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int RoleId = Convert.ToInt32(this.tbRoleId.Text);
            int ModeOfSalary = Convert.ToInt32(this.cbBrokerage.SelectedIndex);
            int ProductId = Convert.ToInt32(this.tbProductId.Text);
            Role role = new Role();
            role.RLId = RoleId;
            role.RLModelOfsalary = ModeOfSalary;
            role.RLProductId = ProductId;
            if (RoleAccess.AddRole(role))
            {
                MessageBox.Show("角色添加成功！");
            }
            else
            {
                MessageBox.Show("角色添加失败！");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SupperUser admin = new SupperUser(UserId);
            admin.Show();
        }

        private void RoleAdd_Load(object sender, EventArgs e)
        {
            this.sceneryTableAdapter1.Fill(this.ebookingDataSet5.Scenery);
            this.sceneryTableAdapter.Fill(this.ebookingDataSet4.Scenery);
            this.roleTableAdapter.Fill(this.ebookingDataSet2.Role);
        }
        /// <summary>
        /// 添加角色产品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label7_Click(object sender, EventArgs e)
        {
            int roleProductId = Convert.ToInt32(this.cbRoleProductId.SelectedValue);
            int productId = Convert.ToInt32(this.cbProduct.SelectedValue);
            string productName = this.tbProductName.Text;
            RoleProduct roleProduct = new RoleProduct();
            roleProduct.RPId = roleProductId;
            roleProduct.RPProductId = productId;
            roleProduct.RPProductName = productName;
            if (RoleProductAccess.AddRoleProduct(roleProduct))
            {
                MessageBox.Show("角色产品添加成功！");
            }
            else
            {
                MessageBox.Show("角色产品添加失败！");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SupperUser supperUser = new SupperUser(UserId);
            supperUser.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sceneryTableAdapter.FillBy(this.ebookingDataSet4.Scenery);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sceneryTableAdapter.FillBy1(this.ebookingDataSet4.Scenery);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
