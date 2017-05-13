using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using eBooking.Models;
using eBooking.DBAccess;

namespace eBooking
{
    public partial class Homepage : Form
    {
        private List<string> imageLists = new List<string>();

        private string path = Application.StartupPath;
        public static int UserId = -1;
        public static int PageNum;
        public static int Sum;
     //   public static int count;
        public Homepage()
        {
            InitializeComponent();
            Sum = SceneryAccess.SceneryCount();
            if (Sum % 12 == 0)
            {
                Sum = Sum / 12;
            }
            else
            {
                Sum = Sum / 12 + 1;
            }
        }
        public Homepage(int userID)
        {
            InitializeComponent();
            UserId = userID;
            this.lbLoginstate.Text = userID+"";
            Sum = SceneryAccess.SceneryCount();
            if (Sum % 12 == 0)
            {
                Sum = Sum / 12;
            }
            else
            {
                Sum = Sum / 12 + 1;
            }
        }

        private void SceneryShow_Load(object sender, EventArgs e)
        {
            BindTreeView();
            if (treeView1.Nodes.Count > 0)
            {
                treeView1.Nodes[0].Expand();
            }
            List<Scenery> sceneryList = new List<Scenery>();
            sceneryList = SceneryAccess.ShowImag(1);
            if (sceneryList.Count != 0 && sceneryList != null)
            {
                for (int i = 0; i <sceneryList.Count; i++)
                {
                    Scenery scenery = new Scenery();
                    scenery=sceneryList[i];
                    switch (i)
                    {
                        case 0: this.pictureBox1.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label1.Text = scenery.SYName;
                            break;
                        case 1: this.pictureBox2.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label2.Text = scenery.SYName;
                            break;
                        case 2: this.pictureBox3.Image = Image.FromFile(scenery.SYImagSrc, false);
                             label3.Text = scenery.SYName;
                             break;
                        case 3: this.pictureBox4.Image = Image.FromFile(scenery.SYImagSrc, false);
                             label4.Text = scenery.SYName;
                             break;
                        case 4: this.pictureBox5.Image = Image.FromFile(scenery.SYImagSrc, false);
                             label5.Text = scenery.SYName;
                             break;
                        case 5: this.pictureBox6.Image = Image.FromFile(scenery.SYImagSrc, false);
                             label6.Text = scenery.SYName;
                             break;
                        case 6: this.pictureBox7.Image = Image.FromFile(scenery.SYImagSrc, false);
                             label7.Text = scenery.SYName;
                             break;
                        case 7: this.pictureBox8.Image = Image.FromFile(scenery.SYImagSrc, false);
                             label8.Text = scenery.SYName;
                             break;
                        case 8: this.pictureBox9.Image = Image.FromFile(scenery.SYImagSrc, false);
                             label9.Text = scenery.SYName;
                             break;
                        case 9: this.pictureBox10.Image = Image.FromFile(scenery.SYImagSrc, false);
                             label10.Text = scenery.SYName;
                             break;
                        case 10: this.pictureBox11.Image = Image.FromFile(scenery.SYImagSrc, false);
                             label11.Text = scenery.SYName;break;
                        case 11: this.pictureBox12.Image = Image.FromFile(scenery.SYImagSrc, false);
                             label12.Text = scenery.SYName;
                             break;
                    }
                    this.pictureBox1.Image = Image.FromFile(scenery.SYImagSrc, false);
                }
            }
        }
        private void BindTreeView()
        {
            treeView1.LabelEdit = false;//不可编辑
            //添加结点
            TreeNode root = new TreeNode();
            root.Text = "热门目的地";
            //一级
            TreeNode node1 = new TreeNode();
            node1.Text = "青岛";
            TreeNode node2 = new TreeNode();
            node2.Text = "苏州";
            TreeNode node3 = new TreeNode();
            node3.Text = "杭州";
            TreeNode node4 = new TreeNode();
            node4.Text = "北京";
            TreeNode node5 = new TreeNode();
            node5.Text = "上海";
            TreeNode node6 = new TreeNode();
            node6.Text = "海南";
            //二级
            TreeNode node11 = new TreeNode();
            node11.Text = "崂山";
            TreeNode node12 = new TreeNode();
            node12.Text = "极地海洋世界";
            TreeNode node13 = new TreeNode();
            node13.Text = "栈桥";
            TreeNode node14 = new TreeNode();
            node14.Text = "金沙滩";
            TreeNode node21 = new TreeNode();
            node21.Text = "周庄";
            TreeNode node22 = new TreeNode();
            node22.Text = "拙政园";
            TreeNode node23 = new TreeNode();
            node23.Text = "虎丘";
            TreeNode node24 = new TreeNode();
            node24.Text = "寒山寺";
            TreeNode node31 = new TreeNode();
            node31.Text = "西湖";
            TreeNode node41 = new TreeNode();
            node41.Text = "圆明园";
            TreeNode node51 = new TreeNode();
            node51.Text = "东方明珠";
            TreeNode node61 = new TreeNode();
            node61.Text = "三亚";
            //二级加入一级
            node1.Nodes.Add(node11);
            node1.Nodes.Add(node12);
            node1.Nodes.Add(node13);
            node1.Nodes.Add(node14);
            node2.Nodes.Add(node21);
            node2.Nodes.Add(node22);
            node2.Nodes.Add(node23);
            node2.Nodes.Add(node24);
            node3.Nodes.Add(node31);
            node4.Nodes.Add(node41);
            node5.Nodes.Add(node51);
            node6.Nodes.Add(node61);
            //一级加入根
            root.Nodes.Add(node1);
            root.Nodes.Add(node2);
            root.Nodes.Add(node3);
            root.Nodes.Add(node4);
            root.Nodes.Add(node5);
            root.Nodes.Add(node6);
            //
            treeView1.Nodes.Add(root);
            if (treeView1.Nodes.Count > 0) 
                treeView1.Nodes[0].Expand();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
               string searchInfo = treeView1.SelectedNode.Text;
               showScenery(searchInfo);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            Login login = new Login();
            login.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchInfo = this.tbSerach.Text;
             showScenery(searchInfo);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Register register = new Register();
            register.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
             showScenery(label1.Text );
        }
        private void showScenery(string sceneryName)
        {
            Scenery scenery = new Scenery();
            List<Scenery> sceneryList = new List<Scenery>();
            sceneryList = SceneryAccess.Search(sceneryName);
            if (sceneryList.Count != 0 && sceneryList != null)
            {
                for (int i = 0; i < sceneryList.Count; i++)
                {
                    scenery = sceneryList[i];
                }
                this.Visible = false;
                TicketInfo ticketInfo = new TicketInfo(scenery, UserId);
                ticketInfo.Show();
            }
            else
            {
                MessageBox.Show("暂时没有您要找的景点");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showScenery(label2.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            showScenery(label3.Text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            showScenery(label4.Text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            showScenery(label5.Text);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            showScenery(label6.Text);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            showScenery(label7.Text);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            showScenery(label8.Text);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            showScenery(label9.Text);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            showScenery(label10.Text);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            showScenery(label11.Text);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            showScenery(label12.Text);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (UserId != -1)
            {
                User user = new User();
                user = UserAccess.Select(UserId);
                this.Visible = false;
                UserInfo userInfo = new UserInfo(user);
                userInfo.Show();
            }
            else
            {
                MessageBox.Show("请登录后再查看个人信息....");
            }
        }

        private void lbIndex_Click(object sender, EventArgs e)
        {
            PageNum = 1;
            ShowImage(PageNum);
        }

        private void lbNext_Click(object sender, EventArgs e)
        {
            switch (PageNum)
            {
                case 2: this.lbNext.ForeColor = System.Drawing.Color.Pink; break;
                case 3: this.lbNext.ForeColor = System.Drawing.Color.Yellow; break;
                case 4: this.lbNext.ForeColor = System.Drawing.Color.Orange; break;
                case 5: this.lbNext.ForeColor = System.Drawing.Color.Red; break;
                default: this.lbNext.ForeColor = System.Drawing.Color.Blue; break;
            }
            if (Sum >= PageNum)
            {
                PageNum = PageNum + 1;
                ShowImage(PageNum);
            }
            else
            {
                MessageBox.Show("这是最后一页了...");
            }
        }
        private void ShowImage(int pageNum)
        {
            List<Scenery> sceneryList = new List<Scenery>();
            sceneryList = SceneryAccess.ShowImag(pageNum);
            if (sceneryList.Count != 0 && sceneryList != null)
            {
                for (int i = 0; i < sceneryList.Count; i++)
                {
                    Scenery scenery = new Scenery();
                    scenery = sceneryList[i];
                    switch (i)
                    {
                        case 0: this.pictureBox1.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label1.Text = scenery.SYName;
                            break;
                        case 1: this.pictureBox2.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label2.Text = scenery.SYName;
                            break;
                        case 2: this.pictureBox3.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label3.Text = scenery.SYName;
                            break;
                        case 3: this.pictureBox4.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label4.Text = scenery.SYName;
                            break;
                        case 4: this.pictureBox5.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label5.Text = scenery.SYName;
                            break;
                        case 5: this.pictureBox6.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label6.Text = scenery.SYName;
                            break;
                        case 6: this.pictureBox7.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label7.Text = scenery.SYName;
                            break;
                        case 7: this.pictureBox8.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label8.Text = scenery.SYName;
                            break;
                        case 8: this.pictureBox9.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label9.Text = scenery.SYName;
                            break;
                        case 9: this.pictureBox10.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label10.Text = scenery.SYName;
                            break;
                        case 10: this.pictureBox11.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label11.Text = scenery.SYName; break;
                        case 11: this.pictureBox12.Image = Image.FromFile(scenery.SYImagSrc, false);
                            label12.Text = scenery.SYName;
                            break;
                    }
                    this.pictureBox1.Image = Image.FromFile(scenery.SYImagSrc, false);
                }
            }
        
        }
    }
}
