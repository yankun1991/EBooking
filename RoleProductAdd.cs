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
    public partial class RoleProductAdd : Form
    {
        public RoleProductAdd()
        {
            InitializeComponent();
        }

        private void RoleProductAdd_Load(object sender, EventArgs e)
        {
           
            this.roleTableAdapter.Fill(this.ebookingDataSet.Role);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int roleProductId = Convert.ToInt32(this.cbRoleProductId.SelectedValue);
            int productId = Convert.ToInt32(this.tbProductId.Text);
            RoleProduct roleProduct = new RoleProduct();
            roleProduct.RPId = roleProductId;
            roleProduct.RPProductId = productId;
            if (RoleProductAccess.AddRoleProduct(roleProduct))
            {
                MessageBox.Show("角色产品添加成功！");
            }
            else
            {
                MessageBox.Show("角色产品添加失败！");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SupperUser admin = new SupperUser();
            admin.Show();
        }
    }
}
