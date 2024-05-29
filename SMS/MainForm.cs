using SMS.Pages;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SMS
{
    public partial class MainForm : UIHeaderMainFooterFrame
    {

        System.Timers.Timer timer = null;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                InitStatusInfo();
            }
        }

        //初始化
        private void InitStatusInfo()
        {

            var storeManage = new StoreManage();
            var regionManage = new RegionManage();
            var productManage = new ProductManage();
            var productInStore = new ProductInStore();
            var storeTemperature = new StoreTemperature();

            //uiTabControl1.MainPage = mainPage.Text = "冷库管理";


            Header.TabControl = MainTabControl;

            //添加页面
            AddPage(storeManage, 1001);
            AddPage(regionManage, 1002);
            AddPage(productManage, 1003);
            AddPage(productInStore, 1004);
            AddPage(storeTemperature, 1005);
            //设置Header节点索引
            Header.CreateNode("冷库管理", 1001);
            Header.CreateNode("冷库分区", 1002);
            Header.CreateNode("仓储管理", 1003);
            Header.CreateNode("物品入库", 1004);
            Header.CreateNode("冷库温控", 1005);

            //初始化底部状态栏信息
            string? uName = this.Tag.ToString();
            uiSymbolLabel2.Text += uName;

            //时间  动态时间条--- 计时器  （Timers.Timer）
            uiSymbolLabel1.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                this.uiSymbolLabel1.Text = "时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.ShowAskDialog("退出系统？", "确定退出系统吗？"))
            {
                if (timer != null)
                    timer.Stop();
                //this.Close();
                //Application.ExitThread();
            }
            else
                e.Cancel = true;
        }



    }
}
