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
    /// 门票预订
    /// </summary>
    public partial class TicketInfo : Form
    {
        public Scenery scenery= new Scenery();
        public int UserId=-1;
        public TicketInfo()
        {
            InitializeComponent();
        }
        #region 初始化构造函数
        public TicketInfo(int userId)
        {
            InitializeComponent();
            UserId = userId;

        }
        public TicketInfo(Scenery sceneryInfo, int userId)
        {
            scenery = sceneryInfo;
            UserId = userId;
            InitializeComponent();
            if (scenery != null)
            {
                this.lbSceneryName2.Text = scenery.SYName;
                this.lbPrice2.Text = scenery.SYPrice + "";
            }
        } 
        #endregion
        /// <summary>
        /// 界面加载时初始化景点数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicketInfo_Load(object sender, EventArgs e)
        {
            this.pbImage.Image = Image.FromFile(scenery.SYImagSrc, false);
            this.tbIntroduce.Text = scenery.SYIntroduec;
            this.lbSceneryName2.Text = scenery.SYName;
            this.lbPrice2.Text = scenery.SYPrice + "";
            this.lbTicketNum2.Text = scenery.SYUseNum + "/" + scenery.SYTotal;
        }
       /// <summary>
       /// 门票预订
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btBook_Click(object sender, EventArgs e)
        {
            if (scenery.SYUseNum >= scenery.SYTotal)
            {
                MessageBox.Show("当前时间的门票已售罄！");
            }
            else
            {
                Oreder order = new Oreder();
                order.TKType = this.cbTicketType.SelectedIndex;
                order.TKReserveTime = DateTime.Now;
                order.TKUseTime = Convert.ToDateTime(this.dtpUseTime.Text);
                order.TKNum = Convert.ToInt32(this.nudTicketNum.Value);
                order.TKUserId = UserId;
                order.TKSupplier = scenery.SYSupplier;
                order.TKImagSrc = scenery.SYImagSrc;
                order.TKPrice = Convert.ToInt32(this.lbPrice2.Text);
                order.TKSYId = scenery.SYId;
                #region  订票验证
                if (order.TKNum != 0)
                {
                    if (UserId != -1)
                    {
                        if (SceneryAccess.ShowSceneryByUseTime(order.TKUseTime))
                        {
                            if (this.cbTicketType.SelectedIndex != -1)
                            {
                                if (OrderAccess.AddOrder(order))
                                {
                                    #region MyRegion
                                    if (DistributorAccess.SelectById(UserId))
                                    {
                                        this.Visible = false;
                                        DistributorUser distributorUser = new DistributorUser(UserId);
                                        distributorUser.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("预订成功！");
                                        this.Visible = false;
                                        Homepage homePage = new Homepage(UserId);
                                        homePage.Show();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("订票失败！");
                                }
                                    #endregion
                            }
                            else
                            {
                                MessageBox.Show("请选择票型");
                            }
                        }
                        else
                        {
                            MessageBox.Show("当前门票暂时没有上线，请晚些时候再来！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请登录后再订票！");
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("请选择预订数量！");
                }
            }
        }
        /// <summary>
        /// 对返回按钮执行的动作进行判断：是用户预订还是分销商预订
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReturn_Click(object sender, EventArgs e)
        {
            if (DistributorAccess.SelectById(UserId))
            {
                this.Visible = false;
                DistributorUser distributorUser = new DistributorUser(UserId);
                distributorUser.Show();
            }
            else
            {
                this.Visible = false;
                Homepage homePage = new Homepage(UserId);
                homePage.Show();
            }
        }

    }
}
