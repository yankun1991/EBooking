using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eBooking.Models;
using System.Net;
using eBooking.DBAccess;

namespace eBooking
{
    public partial class Register : Form
    {
        public static string Identify;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Identify = RandomNum();
            this.tbnIdentify2.Text = Identify;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string userName = this.tbUserName.Text;
            string mail = this.tbMail.Text;
            string passWord1 = this.tbUserPassWord1.Text;
            string passWord2 = this.tbUserPassWord2.Text;
            string identify = this.tbnIdentify1.Text;
            string phoneNum = this.tbPhoneNumber.Text;
            User user = new User();
            bool agree = this.checkBox1.Checked;
            if (agree)
            {
                if (identify==Identify)
                {
                    if (passWord1 == passWord2)
                    {
                        user.USName = userName;
                        user.USEmail = mail;
                        user.USPassWord = passWord1;
                        user.USPhone = phoneNum;
                        user.USRegisterTime = DateTime.Now;
                        user.USLastLoginTime = DateTime.Now;
                        user.USLastLoginIp = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
                        user.USValid = 1;
                        if (UserAccess.Add(user))
                        {
                            MessageBox.Show("注册成功！");
                              Homepage homePage = new Homepage(UserAccess.Select(userName));
                              homePage.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次填写的密码不一致！");
                    }
                }
                else
                {
                    MessageBox.Show("验证码填写有误");
                }
            }
            else
            {
                MessageBox.Show("请勾选同意！");
            }
        }

        private string RandomNum()
        {
            char[] constant = { '0', '1', '2', '3', '4', '5', '6', '7', '8', 
                                  '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                                  'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 
                                  'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            StringBuilder str = new StringBuilder(36);
            Random rd = new Random();
            for (int i = 0; i < 6; i++)
            {
                str.Append(constant[rd.Next(36)]);
            }
            return str.ToString();
        }

        private void tbnIdentify2_Click(object sender, EventArgs e)
        {
            Identify = RandomNum();
            this.tbnIdentify2.Text = Identify;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Homepage homePage = new Homepage();
            homePage.Show();
        }


    }
}
