using DevComponents.DotNetBar;
using System;
using Ray.Framework.Config;
using Ray.Framework.CustomDotNetBar;

namespace GTMIS.SystemAdmin.Role
{
    public partial class FrmRoleDetail : Office2007Form
    {
        public FrmRoleDetail()
        {
            InitializeComponent();
        }

        private static int roleid = -1;
        Model.T_SysRole mSysRole = new Model.T_SysRole();
        BLL.BLL_T_SysRole bSysRole = new BLL.BLL_T_SysRole();


        public int Roleid { get => roleid; set => roleid = value; }

        private void FrmOrganizationDetail_Load(object sender, EventArgs e)
        {
            //取得样式
            styleManager1.ManagerStyle = (eStyle)Enum.Parse(typeof(eStyle), ConfigHelper.ReadValueByKey(ConfigHelper.ConfigurationFile.AppConfig, "FormStyle"));

            if (Roleid != -1)
            {
                this.Text = "编辑角色";
                ButtonSave.Text = "更新";
                mSysRole = bSysRole.GetModel(roleid);
                if (mSysRole != null)
                {
                    TextBoxDeptName.Text = mSysRole.FRoleName;
                    TextBoxOrder.Text = mSysRole.FRoleDesc;
                    TextBoxCreateBy.Text = mSysRole.FCreateBy;
                    TextBoxCreateDate.Text = mSysRole.FCreateDate.ToString();
                 }
            }
            else
            {
                this.Text = "新建角色";
                ButtonSave.Text = "保存";
                TextBoxCreateBy.Text = "Admin";
                TextBoxCreateDate.Text =DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 保存更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            mSysRole = new Model.T_SysRole
            {
                FRoleName = TextBoxDeptName.Text.Trim(),
                FRoleDesc = TextBoxOrder.Text.Trim(),
                FCreateBy = TextBoxCreateBy.Text,
                FCreateDate = !string.IsNullOrEmpty(TextBoxCreateDate.Text) ? DateTime.Parse(TextBoxCreateDate.Text) : DateTime.Now
            };

            if (this.Roleid != -1)//编辑模式
            {
                mSysRole.FRoleID = roleid;
                if (bSysRole.Update(mSysRole) == true)
                {
                    CustomDesktopAlert.H2("编辑记录成功！");
                }
                else
                {
                    CustomDesktopAlert.H2("编辑记录失败！");
                }
            }
            else//插入模式
            {
                if (bSysRole.Add(mSysRole) > 0)
                {
                    CustomDesktopAlert.H2("新增记录成功！");
                }
                else
                {
                    CustomDesktopAlert.H2("新增记录失败");
                }
            }
            this.Close();
        }
    }
}