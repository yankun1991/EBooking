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
    /// 景点添加
    /// </summary>
    public partial class SceneryAdd : Form
    {
        private string Path;
        public int SYId = -1;
        public int UserId;
        Scenery scenery = new Scenery();
        #region 构造函数初始化
        public SceneryAdd(int userId)
        {
            InitializeComponent();
            UserId = userId;
            this.tbSupplierId.Text = UserId + "";
        }
        public SceneryAdd(int userId,int syId)
        {
            InitializeComponent();
            SYId = syId;
            UserId = userId;
            this.tbSupplierId.Text = syId + "";
            this.tbSupplierId.Text = UserId + "";
        } 
        #endregion
        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                if (file.FileName!= "")
                {
                    Path = file.FileName;
                    pictureBox1.Image = Image.FromFile(Path);
                 }
            }

        }

        /// <summary>
        /// 景点更新或添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string SceneryName = this.tbSceneryName.Text;
            int Supplier = Convert.ToInt32(this.tbSupplierId.Text);
            int price = Convert.ToInt32(this.tbPrice.Text);
            string Introduce = this.tbIntroduce.Text;
            int TotalNum=Convert.ToInt32(this.tbTKTotalNum.Text);
            DateTime useTime= Convert.ToDateTime(this.dtpTKUseTime.Text);
            string path = Path;
            if (this.button2.Text == "更新")
            {
                Scenery scenery = new Scenery();
                scenery.SYName = SceneryName;
                scenery.SYSupplier = Supplier;
                scenery.SYPrice = price;
                scenery.SYIntroduec = Introduce;
                scenery.SYImagSrc = path;
                scenery.SYTotal = TotalNum;
                scenery.SYUseTime = useTime;
                scenery.SYId = SYId;
                if (SceneryAccess.SceneryUpdateForSupplier(scenery))
                {
                    MessageBox.Show("更新成功");
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
            }
            else
            {
                Scenery scenery = new Scenery();
                scenery.SYName = SceneryName;
                scenery.SYSupplier = Supplier;
                scenery.SYPrice = price;
                scenery.SYIntroduec = Introduce;
                scenery.SYImagSrc = path;
                scenery.SYTotal = TotalNum;
                scenery.SYUseTime = useTime;
                if (SceneryAccess.SceneryAdd(scenery))
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
        }

        /// <summary>
        /// 界面加载时若景点ID不为-1说明是景点更新，置添加按钮上的文字为更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SceneryAdd_Load(object sender, EventArgs e)
        {
            if (SYId != -1)
            {
                this.button2.Text = "更新";
                Initlize();
            }
        }

        /// <summary>
        /// 返回供应商界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SupplierUser supplierUser = new SupplierUser(UserId);
            supplierUser.Show();
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        private void Initlize()
        {
            scenery = SceneryAccess.SelectById(SYId);
            this.tbSceneryName.Text = scenery.SYName;
            this.tbIntroduce.Text = scenery.SYIntroduec;
            this.tbPrice.Text = scenery.SYPrice + "";
            this.tbSupplierId.Text = scenery.SYSupplier+"";
            this.tbTKTotalNum.Text = scenery.SYTotal + "";
            this.dtpTKUseTime.Text = scenery.SYUseTime + "";
            Path = scenery.SYImagSrc;
            if (Path != null)
            {
                pictureBox1.Image = Image.FromFile(Path);
            }
        }
    }
}
