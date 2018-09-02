using DevComponents.DotNetBar;
using Ray.Framework.CustomDotNetBar;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTMIS.SystemAdmin.Role
{
    public partial class FrmRoleManager : Office2007Form
    {
        CheckBox HeaderCheckBox = null;
        private static BLL.BLL_T_SysRole bllSysRole = new BLL.BLL_T_SysRole();

        private static string queryCondition = "";
        private static string queryGroup = "";
        private static string modelName = "T_SysRole";
        private static string primaryKey = "FRoleId";
        private static string columnList = "[FRoleID]  as 角色编号 ,[FRoleName] as 角色名称 ,[FRoleDesc] as 描述 ,[FCreateBy] AS 创建者 ,[FCreateDate] AS 创建时间";
        private static int pageSize = 50;


        public FrmRoleManager()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                HeaderCheckBox = new CheckBox
                {
                    Size = new Size(15, 15)
                };
                this.DataGridViewX1.Controls.Add(HeaderCheckBox);

                HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
                HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
                DataGridViewX1.CurrentCellDirtyStateChanged += new EventHandler(DataGridViewX1_CurrentCellDirtyStateChanged);
                DataGridViewX1.CellPainting += new DataGridViewCellPaintingEventHandler(DataGridViewX1_CellPainting);
            }
        }

        private void FrmRoleManager_Load(object sender, System.EventArgs e)
        {
            //加载分页控件
            pager2.OnPageIndexChanged += new System.EventHandler(this.Pager2_OnPageIndexChanged);

            //加载列表
            RefreshGridView();
        }

        #region 表格控件

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBox_Click((CheckBox)sender);
        }

        /// <summary>
        /// 提交更新当前单元格状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewX1_CurrentCellDirtyStateChanged(object sender, System.EventArgs e)
        {
            if (DataGridViewX1.CurrentCell is DataGridViewCheckBoxCell)
            {
                DataGridViewX1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewX1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ColumnIndex"></param>
        /// <param name="RowIndex"></param>
        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            Rectangle oRectangle = this.DataGridViewX1.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);
            Point oPoint = new Point
            {
                X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1,
                Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1
            };
            HeaderCheckBox.Location = oPoint;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="HCheckBox"></param>
        private void HeaderCheckBox_Click(CheckBox HCheckBox)
        {
            foreach (DataGridViewRow Row in DataGridViewX1.Rows)
            {
                ((System.Windows.Forms.DataGridViewCheckBoxCell)Row.Cells["chkSelect"]).Value = HCheckBox.Checked;
            }
            DataGridViewX1.RefreshEdit();
        }

        private void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                HeaderCheckBox_Click((CheckBox)sender);
        }

        /// <summary>
        /// 格式化显示内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DataGridViewX1.Columns["创建时间"].Index)   //格式化日期
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("yyyy-MM-dd");
                }
            }
        }

        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewX1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            DataGridViewTextBoxColumn dgv_Text = new DataGridViewTextBoxColumn();
            for (int i = 0; i < DataGridViewX1.Rows.Count; i++)
            {
                int j = pager2.PageSize * (pager2.PageIndex - 1) + i + 1;
                DataGridViewX1.Rows[i].HeaderCell.Value = j.ToString();
            }
        }


        #endregion

        #region 新增
        private void ButtonInsert_Click(object sender, System.EventArgs e)
        {
            FrmRoleDetail frm = new FrmRoleDetail
            {
                Roleid = -1,
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshGridView();
            }
        }
        #endregion

        #region 编辑
        private void ButtonEdit_Click(object sender, System.EventArgs e)
        {
            if (DataGridViewX1.SelectedRows.Count == 1)
            {
                int selectedRowId = int.Parse(DataGridViewX1.SelectedRows[0].Cells["角色编号"].Value.ToString());
                FrmRoleDetail frm = new FrmRoleDetail
                {
                    Roleid = selectedRowId,
                    StartPosition = FormStartPosition.CenterParent
                };

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGridView();
                }
            }
            else if (DataGridViewX1.SelectedRows.Count > 1)
            {
                CustomDesktopAlert.H2("只能选择一行编辑");
            }
            else
            {
                CustomDesktopAlert.H2("请先选择要编辑的行");
            }
        }
        #endregion

        #region 删除
        private void ButtonDelete_Click(object sender, System.EventArgs e)
        {
            if (MessageBoxEx.Show("你真的要删除这些记录码？", "系统信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (DataGridViewX1.Rows.Count > 0)
                {
                    string selectedRows = "";
                    foreach (DataGridViewRow dr in DataGridViewX1.Rows)
                    {
                        //checkbox 未选择时，单元个的值为空
                        if ((dr.Cells[0].Value != null) && (bool)(dr.Cells[0].Value) == true)
                        {
                            selectedRows += dr.Cells["角色编号"].Value + ",";
                        }
                    }
                    if (selectedRows.Length > 0)
                    {
                        selectedRows = selectedRows.Substring(0, selectedRows.Length - 1);
                        if (bllSysRole.DeleteList(selectedRows) == true)
                        {
                            CustomDesktopAlert.H2("记录编号" + selectedRows + "删除成功！");
                            //pager2.PageIndex = 1;
                            //删除事件，要重新计算RecCount
                            RefreshGridView();
                        }
                    }
                }
            }
            //清空全选
            HeaderCheckBox.Checked = false;
        }
        #endregion

        #region 查询
        private void ButtonQuery_Click(object sender, System.EventArgs e)
        {
            string queryString = TextBoxX_QueryString.Text;
            queryCondition = string.Format(" [FRoleName] LIKE '%{0}%' ", queryString);
            pager2.PageIndex = 1;
            RefreshGridView();
        }

        private void ButtonClean_Click(object sender, System.EventArgs e)
        {
            TextBoxX_QueryString.Text = "";
            queryCondition = TextBoxX_QueryString.Text;
            pager2.PageIndex = 1;
            RefreshGridView();
        }
        #endregion

        #region 分页

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pager2_OnPageIndexChanged(object sender, EventArgs e)
        {
            RefreshGridView();
            HeaderCheckBox.Checked = false;

        }

        /// <summary>
        /// 计算记录总数并更新数据源
        /// </summary>
        private void RefreshGridView()
        {
            pager2.PageSize = pageSize;
            int iCount = bllSysRole.GetRecCount(modelName, queryCondition);

            pager2.RefreshPager(iCount);
            DataGridViewX1.DataSource = bllSysRole.GetListByPage(modelName, primaryKey, pager2.PageIndex, pager2.PageSize, "", columnList, queryCondition, queryGroup);

        }


        #endregion


    }
}