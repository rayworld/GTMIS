using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Ray.Framework.Config;
using Ray.Framework.CustomDotNetBar;
using System;
using System.Data;

namespace GTMIS.SystemAdmin.Organization
{
    public partial class FrmOrganizationDetail : Office2007Form
    {
        public FrmOrganizationDetail()
        {
            InitializeComponent();
        }

        private static int deptid = -1;
        Model.T_SysDept mSysDept = new Model.T_SysDept();
        BLL.BLL_T_SysDept bSysDept = new BLL.BLL_T_SysDept();


        public int Deptid { get => deptid; set => deptid = value; }

        private void FrmOrganizationDetail_Load(object sender, EventArgs e)
        {
            //取得样式
            styleManager1.ManagerStyle = (eStyle)Enum.Parse(typeof(eStyle), ConfigHelper.ReadValueByKey(ConfigHelper.ConfigurationFile.AppConfig, "FormStyle"));

            if (Deptid != -1)
            {
                this.Text = "编辑机构部门";
                ButtonSave.Text = "更新";
                mSysDept = bSysDept.GetModel(deptid);
                if (mSysDept != null)
                {
                    TextBoxDeptName.Text = mSysDept.FDeptName;
                    TextBoxOrder.Text = mSysDept.FOrder.ToString();
                    TextBoxCreateBy.Text = mSysDept.FCreateBy;
                    TextBoxCreateDate.Text = mSysDept.FCreateDate.ToString();
                    BindComboBoxEx(ComboBoxParentId, bSysDept.GetAllList(), "FDeptName", "FParentId", mSysDept.FParentID);

                }
            }
            else
            {
                this.Text = "新建机构部门";
                ButtonSave.Text = "保存";
                TextBoxCreateBy.Text = "Admin";
                TextBoxCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                BindComboBoxEx(ComboBoxParentId, bSysDept.GetAllList(), "FDeptName", "FParentId");

            }
        }

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
            mSysDept = new Model.T_SysDept
            {
                FDeptName = TextBoxDeptName.Text.Trim(),
                FParentID = bSysDept.GetDeptIdByName(ComboBoxParentId.Text),                
                FOrder = int.Parse(TextBoxOrder.Text),
                FCreateBy = TextBoxCreateBy.Text,
                FCreateDate = DateTime.Parse(TextBoxCreateDate.Text)
            };
            CustomDesktopAlert.H2(mSysDept.FParentID.ToString());
            if (this.Deptid != -1)//编辑模式
            {
                mSysDept.FDeptID = deptid;
                if (bSysDept.Update(mSysDept) == true)
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
                if (bSysDept.Add(mSysDept) > 0)
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