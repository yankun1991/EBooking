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
    /// <summary>
    /// 登录界面
    /// </summary>
    public partial class Login : Form
    {
        public static string tbnIdentify;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbnIdentify = RandomNum();
            this.tbIdentify2.Text = RandomNum();
        }

        /// <summary>
        /// 用户登录：普通用户，管理员，供应商，分销商
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = this.tbUserName.Text;
            string userPassWord = this.tbPassWord.Text;
            string Identify=this.tbIdentify1.Text;
            string userType = this.comboBox1.Text;
            if (userType == "普通用户")
            {
                if (Identify == tbnIdentify)
                {
                    if (UserAccess.Loin(userName, userPassWord))
                    {
                        int USId = UserAccess.Select(userName);
                        if (USId != 0)
                        {
                            this.Visible = false;
                            Homepage homePage = new Homepage(USId);
                            homePage.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码不正确");
                    }
                }
                else
                {
                    MessageBox.Show("验证码输入有误！");
                }
            }
            else if (userType =="管理员")
            {
                if (Identify == tbnIdentify)
                {
                    if (AdminAccess.Loin(userName, userPassWord))
                    {
                        int USId = Convert.ToInt32(userName);
                        if (USId != 0)
                        {
                            this.Visible = false;
                            SupperUser supperUser = new SupperUser(USId);
                            supperUser.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码不正确");
                    }
                }
                else
                {
                    MessageBox.Show("验证码输入有误！");
                }
            
            }
            else if (userType =="供应商")
            {
                if (Identify == tbnIdentify)
                {
                    if (SupplierAccess.Loin(userName, userPassWord))
                    {
                        int USId = SupplierAccess.Select(userName);
                        if (USId != 0)
                        {
                            this.Visible = false;
                            SupplierUser supplierUser = new SupplierUser(USId);
                            supplierUser.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码不正确");
                    }
                }
                else
                {
                    MessageBox.Show("验证码输入有误！");
                }
            
            }
            else if (userType =="分销商")
            {
                if (Identify == tbnIdentify)
                {
                    if (DistributorAccess.Loin(userName, userPassWord))
                    {
                        int USId = DistributorAccess.Select(userName);
                        if (USId != 0)
                        {
                            this.Visible = false;
                            DistributorUser distributorUser = new DistributorUser(USId);
                            distributorUser.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码不正确");
                    }
                }
                else
                {
                    MessageBox.Show("验证码输入有误！");
                }
            
            }
            else
            {
                MessageBox.Show("请选择用户类型");
            }
        }
        /// <summary>
        /// 随机生成验证码
        /// </summary>
        /// <returns></returns>
        private string RandomNum()
        {
            char[] constant = { '0', '1', '2', '3', '4', '5', '6', '7', '8', 
                                  '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                                  'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 
                                  'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            StringBuilder str = new StringBuilder(36);
            Random rd = new Random();
            for (int i = 0; i < 4  ; i++)
            {
                str.Append(constant[rd.Next(36)]);
            }
            return str.ToString();
        }

        /// <summary>
        /// 当点击随机码时改变验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbIdentify2_Click(object sender, EventArgs e)
        {
            tbnIdentify = RandomNum();
            this.tbIdentify2.Text = RandomNum();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Homepage homePage = new Homepage();
            homePage.Show();
        }
    }
}
