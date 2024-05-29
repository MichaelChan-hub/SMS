using Common;
using SMS.BLL;
using SMS.Models.UIModels;
using SMS.UserControls;
using SMS.Utilities;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Pages
{
    public partial class StoreTemperature : UIPage
    {
        public StoreTemperature()
        {
            InitializeComponent();
        }
        SRegionTemperBLL rtBLL = new SRegionTemperBLL();

        private void StoreTemperature_Load(object sender, EventArgs e)
        {
            FormUtility.LoadCboStores(cboStores);//加载仓库列表

            LoadSRegionBoxList();
        }

        /// <summary>
        /// 查询分区盒子列表
        /// </summary>
        private void LoadSRegionBoxList()
        {
            int storeId = cboStores.SelectedValue.GetInt();
            List<StoreRegionBoxModel> boxList = rtBLL.FindRegionBoxList(storeId);
            //将boxList 包装成分区盒子，显示在列表中
            ShowSRegionBoxList(boxList);
        }
        /// <summary>
        /// 将boxList 包装成分区盒子，显示在列表中
        /// </summary>
        private void ShowSRegionBoxList(List<StoreRegionBoxModel> boxList)
        {
            flpRegionList.Controls.Clear();
            if (boxList.Count > 0)
            {
                foreach (var box in boxList)
                {
                    UStoreRegionBox rBox = new UStoreRegionBox();
                    rBox.UBoxSource = box;
                    //if (box.TemperState != 1)
                    //{
                    //    //就会显示升温或降温按钮-----注册事件---调整温度
                    //    rBox.SetTemperature += SetTemperature;//订阅事件
                    //}
                    //rBox.Margin = new Padding(10, 20, 10, 20);
                    flpRegionList.Controls.Add(rBox);
                    
                }
            }
        }

        /// <summary>
        /// 升温或降温事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetTemperature(object sender, UStoreRegionArgs e)
        {
            ShowSetTemperaturePage(e);
        }

        private void ShowSetTemperaturePage(UStoreRegionArgs e)
        {
            //FrmSetSRegionTemperature fSetTemper = new FrmSetSRegionTemperature();
            //fSetTemper.Tag = new RegionTemperData()
            //{
            //    SRegionId = e.SRegionId,
            //    TemperState = e.TemperState,
            //    LowTemperature = e.LowTemperature,
            //    HighTemperature = e.HighTemperature,
            //    SId = e.SId
            //};
            ////订阅刷新事件
            //fSetTemper.ReloadRegion += ReloadRegion;
            //fSetTemper.Show();
        }



        private void uiButton1_Click(object sender, EventArgs e)
        {
            LoadSRegionBoxList();
        }


        /// <summary>
        /// 检测温度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {            
            Task.Run(() =>
            {
                Task.Run(() => {
                    this.Invoke(new Action(() =>
                    {
                        this.ShowInfoDialog("开始读取，请稍后。。。");
                    }));
                    Thread.Sleep(1000);
                    //读取数据的过程
                    this.Invoke(new Action(() =>
                    {
                        this.ShowInfoDialog("读取中，请稍后。。。");
                    }));
                    Thread.Sleep(1000);
                    try
                    {
                        this.Invoke(new Action(() =>
                        {
                            List<StoreRegionBoxModel> boxList = rtBLL.ReadRegionTemperData();//读取数据，更新到数据库，并返回更新后的数据
                            if (boxList.Count != 0)
                            {
                                ShowSRegionBoxList(boxList);
                                this.ShowInfoDialog("检测完成！");
                            }
                            else
                            {
                                this.ShowErrorDialog("检测失败，请检查设备！");
                            }
                        }));
                    }
                    catch (Exception ex)
                    {
                        this.ShowErrorDialog("检测", "检测出现异常！");
                    }

                });
            });
        }
    }
}
