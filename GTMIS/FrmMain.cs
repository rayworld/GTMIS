﻿using DevComponents.DotNetBar;
using Ray.Framework.Config;
using Ray.Framework.CustomDotNetBar;
using Ray.Framework.WindowManage;
using System;
using System.Drawing;
using System.Windows.Forms;
using GTMIS.SystemAdmin.Role;
using GTMIS.SystemAdmin.Organization;
using GTMIS.SystemAdmin.Dict;
using GTMIS.SystemAdmin.User;


namespace GTMIS
{
    public partial class FrmMain : Office2007Form
    {
        public FrmMain()
        {
            //全屏后不遮挡任务栏
            this.StartPosition = FormStartPosition.Manual;
            InitializeComponent();
            //全屏后不遮挡任务栏
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            //必加，不加也不会实现
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        #region 事件

        /// <summary>
        /// 启动程序时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.ribbonControl1.TitleText = ConfigHelper.ReadValueByKey(ConfigHelper.ConfigurationFile.AppConfig, "AppName");
            //获取窗口样式
            GetStyleSetting();
            //LoadModule();
            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
            else
            {
                this.Close();
            }

            //SetMdiForm("机构管理", typeof(FrmOrganizationManager));
            //SetMdiForm("权限管理", typeof(FrmRoleManager));
            //SetMdiForm("权限管理", typeof(FrmTestManager));

            SetMdiForm("数据字典", typeof(FrmDictManager));
        }

        /// <summary>
        /// 改变样式命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppCommandTheme_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
                // Using StyleManager change the style and color tinting
                if (StyleManager.IsMetro(style))
                {
                    // More customization is needed for Metro
                    // Capitalize App Button and tab
                    //buttonFile.Text = buttonFile.Text.ToUpper();
                    //foreach (BaseItem item in RibbonControl.Items)
                    //{
                    //    // Ribbon Control may contain items other than tabs so that needs to be taken in account
                    //    RibbonTabItem tab = item as RibbonTabItem;
                    //    if (tab != null)
                    //        tab.Text = tab.Text.ToUpper();
                    //}

                    //buttonFile.BackstageTabEnabled = true; // Use Backstage for Metro

                    ribbonControl1.RibbonStripFont = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    if (style == eStyle.Metro)
                        StyleManager.MetroColorGeneratorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.DarkBlue;

                    // Adjust size of switch button to match Metro styling
                    //switchButtonItem1.SwitchWidth = 16;
                    //switchButtonItem1.ButtonWidth = 48;
                    //switchButtonItem1.ButtonHeight = 19;

                    // Adjust tab strip style
                    //tabStrip1.Style = eTabStripStyle.Metro;

                    StyleManager.Style = style; // BOOM
                }
                else
                {
                    // If previous style was Metro we need to update other properties as well
                    //if (StyleManager.IsMetro(StyleManager.Style))
                    //{
                    //    ribbonControl1.RibbonStripFont = null;
                    //    // Fix capitalization App Button and tab
                    //    //buttonFile.Text = ToTitleCase(buttonFile.Text);
                    //foreach (BaseItem item in RibbonControl.Items)
                    //{
                    //    // Ribbon Control may contain items other than tabs so that needs to be taken in account
                    //    RibbonTabItem tab = item as RibbonTabItem;
                    //    if (tab != null)
                    //        tab.Text = ToTitleCase(tab.Text);
                    //}
                    //    // Adjust size of switch button to match Office styling
                    //    switchButtonItem1.SwitchWidth = 28;
                    //    switchButtonItem1.ButtonWidth = 62;
                    //    switchButtonItem1.ButtonHeight = 20;
                    //}
                    // Adjust tab strip style
                    //tabStrip1.Style = eTabStripStyle.Office2007Document;
                    StyleManager.ChangeStyle(style, Color.Empty);
                    //if (style == eStyle.Office2007Black || style == eStyle.Office2007Blue || style == eStyle.Office2007Silver || style == eStyle.Office2007VistaGlass)
                    //    buttonFile.BackstageTabEnabled = false;
                    //else
                    //    buttonFile.BackstageTabEnabled = true;
                }
            }
            else if (source.CommandParameter is Color)
            {
                if (StyleManager.IsMetro(StyleManager.Style))
                    StyleManager.MetroColorGeneratorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, (Color)source.CommandParameter);
                else
                    StyleManager.ColorTint = (Color)source.CommandParameter;
            }
            //保存用户设置
            ConfigHelper.UpdateOrCreateAppSetting(ConfigHelper.ConfigurationFile.AppConfig, "FormStyle", source.CommandParameter.ToString());
        }

        #endregion

        #region 私有过程

        //private void LoadModule()
        //{
        //    string myModules = ConfigHelper.ReadValueByKey(ConfigHelper.ConfigurationFile.AppConfig, "Modules");
        //    if (!string.IsNullOrWhiteSpace( myModules))
        //    {
        //        string[] myModule = myModules.Split(';');
        //        foreach (string module in myModule)
        //        {
        //            if (module.ToLower() == ModuleName.edi.ToString())
        //            {
        //                ribbonTabItem2.Visible = true;
        //                ribbonTabItem2.Select();
        //            }
        //            else if (module.ToLower() == ModuleName.edi2.ToString())
        //            {
        //                //ribbonTabItem1.Visible = true;
        //                //ribbonTabItem1.Select();
        //            }
        //            else if (module.ToLower() == ModuleName.ds9208_镜片.ToString())
        //            {
        //                //ribbonTabItem3.Visible = true;
        //                //ribbonTabItem3.Select();
        //            }
        //            else
        //            {
        //                CustomDesktopAlert.H2(module.ToLower() + "不能识别的应用模块！");
        //            }
        //        }

        //    }
        //    else
        //    {
        //        CustomDesktopAlert.H2("应用程序加载模块出错！");
        //    }
        //}


        /// <summary>
        /// 创建或者显示一个多文档界面页面
        /// </summary>
        /// <param name="caption">窗体标题</param>
        /// <param name="formType">窗体类型</param>
        public void SetMdiForm(string caption, Type formType)
        {
            bool IsOpened = false;

            //遍历现有的Tab页面，如果存在，那么设置为选中即可
            foreach (SuperTabItem tabitem in NavTabControl.Tabs)
            {
                if (tabitem.Name == caption)
                {
                    NavTabControl.SelectedTab = tabitem;
                    IsOpened = true;
                    break;
                }
            }

            //如果在现有Tab页面中没有找到，那么就要初始化了Tab页面了
            if (!IsOpened)
            {
                //为了方便管理，调用LoadMdiForm函数来创建一个新的窗体，并作为MDI的子窗体
                //然后分配给SuperTab控件，创建一个SuperTabItem并显示
                DevComponents.DotNetBar.Office2007Form form = ChildWinManagement.LoadMdiForm(this, formType)
                    as DevComponents.DotNetBar.Office2007Form;

                SuperTabItem tabItem = NavTabControl.CreateTab(caption);
                tabItem.Name = caption;
                tabItem.Text = caption;

                form.FormBorderStyle = FormBorderStyle.None;
                form.TopLevel = false;
                form.Visible = true;
                form.Dock = DockStyle.Fill;
                //tabItem.Icon = form.Icon;
                tabItem.AttachedControl.Controls.Add(form);

                NavTabControl.SelectedTab = tabItem;
            }
        }

        /// <summary>
        /// 窗体加载时，检查样式
        /// </summary>
        private void GetStyleSetting()
        {
            this.styleManager1.ManagerStyle = (eStyle)Enum.Parse(typeof(eStyle), ConfigHelper.ReadValueByKey(ConfigHelper.ConfigurationFile.AppConfig, "FormStyle"));
            string managerStyle = this.styleManager1.ManagerStyle.ToString();
            for (int i = 0; i < buttonItem1.SubItems.Count - 1; i++)
            {
                if (managerStyle is string && managerStyle == buttonItem1.SubItems[i].CommandParameter.ToString())
                {
                    ButtonItem bi = (ButtonItem)buttonItem1.SubItems[i];
                    bi.Checked = true;
                }
            }

        }



        #endregion

        private void ButtonDept_Click(object sender, EventArgs e)
        {
            SetMdiForm("机构管理", typeof(FrmOrganizationManager));
        }

        private void ButtonPremission_Click(object sender, EventArgs e)
        {
            SetMdiForm("权限管理", typeof(FrmDictManager));
        }

        private void ButtonRole_Click(object sender, EventArgs e)
        {
            SetMdiForm("角色管理", typeof(FrmRoleManager));
        }

        private void ButtonUser_Click(object sender, EventArgs e)
        {
            SetMdiForm("用户管理", typeof(FrmUserManager));
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            SetMdiForm("数据字典", typeof(FrmDictManager));
        }
    }
}