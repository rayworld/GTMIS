using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using GTMIS.Model;
using Ray.Framework.Config;
using System;
using System.Data;

namespace GTMIS.SystemAdmin.User
{
    public partial class FrmUserDetail : Office2007Form
    {
        public FrmUserDetail()
        {
            InitializeComponent();
        }

        private static int userId = -1;
        private static int deptId = 0;

        T_SysUser mSysUser = new T_SysUser();
        T_SysDept mSysDept = new T_SysDept();
        T_SysRole mSysRole = new T_SysRole();

        BLL.BLL_T_SysUser bSysUser = new BLL.BLL_T_SysUser();
        BLL.BLL_T_SysDept bSysDept = new BLL.BLL_T_SysDept();
        BLL.BLL_T_SysRole bSysRole = new BLL.BLL_T_SysRole();

        public int UserId { get => userId; set => userId = value; }
        public int DeptId { get => deptId; set => deptId = value; }

        private void FrmUserDetail_Load(object sender, System.EventArgs e)
        {
            //取得样式
            styleManager1.ManagerStyle = (eStyle)Enum.Parse(typeof(eStyle), ConfigHelper.ReadValueByKey(ConfigHelper.ConfigurationFile.AppConfig, "FormStyle"));

            if (UserId != -1)
            {
                this.Text = "编辑用户信息";
                ButtonSave.Text = "更新";
                mSysUser = bSysUser.GetModel(userId);
                if (mSysUser != null)
                {
                    TextBoxUserName.Text = mSysUser.FUserName;
                    TextBoxPassword.Text = mSysUser.FPassword;
                    TextBoxCreateBy.Text = mSysUser.CreateBy;
                    TextBoxCreateDate.Text = mSysUser.CreateDate.ToString();
                    BindComboBoxEx(ComboBoxDeptName, bSysDept.GetAllList(), "FDeptName", "FDeptId", mSysDept.FDeptID);
                    BindComboBoxEx(ComboBoxRoleName, bSysRole.GetAllList(), "FRoleName", "FRoleId", mSysRole.FRoleID);

                }
            }
            else
            {
                this.Text = "新建用户";
                ButtonSave.Text = "保存";
                TextBoxCreateBy.Text = "Admin";
                TextBoxCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                BindComboBoxEx(ComboBoxDeptName, bSysDept.GetAllList(), "FDeptName", "FDeptId");
                BindComboBoxEx(ComboBoxRoleName, bSysRole.GetAllList(), "FRoleName", "FRoleId");
            }
        }

        #region 私有过程

        /// <summary>
        /// 绑定一个ComboBoxEx控件，并绑定值
        /// </summary>
        /// <param name="comboBox">ComboBoxEx控件</param>
        /// <param name="dtDataSource">列表数据来源</param>
        /// <param name="dispPart">显示值所在的列</param>
        /// <param name="valuePart">实际值所在的列</param>
        /// <param name="valueId">实际值</param>
        private void BindComboBoxEx(ComboBoxEx comboBox, DataTable dtDataSource, string dispPart, string valuePart, int valueId)
        {
            comboBox.DataSource = dtDataSource;
            comboBox.DisplayMember = dispPart;
            comboBox.ValueMember = valuePart;
            if (valueId != 0)
            {
                int selectedIndex = 0;
                for (int i = 0; i < dtDataSource.Rows.Count; i++)
                {
                    if (valueId.ToString() == dtDataSource.Rows[i][0].ToString())
                    {
                        selectedIndex = i;
                        break;
                    }
                }
                comboBox.SelectedIndex = selectedIndex;
            }
        }

        /// <summary>
        /// 重载 只显示候选列，不绑定值
        /// </summary>
        /// <param name="comboBox">ComboBoxEx控件</param>
        /// <param name="dtDataSource">列表数据来源</param>
        /// <param name="dispPart">显示值所在的列</param>
        /// <param name="valuePart">实际值所在的列</param>
        private void BindComboBoxEx(ComboBoxEx comboBox, DataTable dtDataSource, string dispPart, string valuePart)
        {
            BindComboBoxEx(comboBox, dtDataSource, dispPart, valuePart, 0);
        }

        #endregion



    }
}
