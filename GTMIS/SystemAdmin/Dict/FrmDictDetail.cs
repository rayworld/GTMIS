using DevComponents.DotNetBar;
using GTMIS.Model;
using Ray.Framework.Config;
using Ray.Framework.CustomDotNetBar;
using System;

namespace GTMIS.SystemAdmin.Dict
{
    public partial class FrmDictDetail : Office2007Form
    {
        public FrmDictDetail()
        {
            InitializeComponent();
        }

        private static int dictDataId = -1;
        private static int dictTypeId = 0;

        T_SysDictData mSysDictData = new T_SysDictData();
        BLL.BLL_T_SysDictData bSysDictData = new BLL.BLL_T_SysDictData();


        public int DictDataId { get => dictDataId; set => dictDataId = value; }
        public int DictTypeId { get => dictTypeId; set => dictTypeId = value; }

        private void FrmOrganizationDetail_Load(object sender, EventArgs e)
        {
            //取得样式
            styleManager1.ManagerStyle = (eStyle)Enum.Parse(typeof(eStyle), ConfigHelper.ReadValueByKey(ConfigHelper.ConfigurationFile.AppConfig, "FormStyle"));

            if (DictDataId != -1)
            {
                this.Text = "编辑字典项";
                ButtonSave.Text = "更新";
                mSysDictData = bSysDictData.GetModel(dictDataId);
                if (mSysDictData != null)
                {
                    TextBoxDeptName.Text = mSysDictData.FDispName;
                    TextBoxOrder.Text = mSysDictData.FDictValue.ToString();
                    TextBoxCreateBy.Text = mSysDictData.FCreateBy;
                    TextBoxCreateDate.Text = mSysDictData.FCreateDate.ToString();
                 }
            }
            else
            {
                this.Text = "新建字典项";
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
            mSysDictData = new T_SysDictData()
            {
                FDispName = TextBoxDeptName.Text,
                FDictValue = TextBoxOrder.Text,
                FDictTypeId = DictTypeId,
                FCreateBy = TextBoxCreateBy.Text,
                FCreateDate = DateTime.Parse(TextBoxCreateDate.Text.ToString())
            };

            if (this.DictDataId != -1)//编辑模式
            {
                mSysDictData.FDictDataId = dictDataId;
                if (bSysDictData.Update(mSysDictData) == true)
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
                if (bSysDictData.Add(mSysDictData) > 0)
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