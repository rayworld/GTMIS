using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using GTMIS.Model;
using Ray.Framework.CustomDotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GTMIS.SystemAdmin.Dict
{
    public partial class FrmDictManager : Office2007Form
    {
        public FrmDictManager()
        {
            InitializeComponent();
        }

        private static BLL.BLL_T_SysDictType bllSysDictType = new BLL.BLL_T_SysDictType();
        private static BLL.BLL_T_SysDictData bllSysDictData = new BLL.BLL_T_SysDictData();

        private static List<T_SysDictType> clist = (List<T_SysDictType>)null;
        private static List<T_SysDictType> allList = (List<T_SysDictType>)null;

        private static string baseCondition = "";
        private static string queryCondition = "";
        private static string queryGroup = "";
        private static string modelName = "T_SysDictData";
        private static string primaryKey = "FDictDataId";
        private static string columnList = "[FDictDataId] AS 条目编号,[FDispName] AS 显示为 ,[FDictValue] AS 实际值 ,[FCreateBy] AS 创建者 ,[FCreateDate] AS 创建时间";
        private static int pageSize = 2;
        //private static int maxRecCount = 100;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTestManager_Load(object sender, System.EventArgs e)
        {
            //绑定树控件
            BindingRootTreeNode();

            //加载分页控件
            pager2.OnPageIndexChanged += new System.EventHandler(this.Pager2_OnPageIndexChanged);
        }

        #region 树控件
        /// <summary>
        /// 绑定根节点
        /// </summary>
        private void BindingRootTreeNode()
        {
            List<T_SysDictType> lSysDictType = bllSysDictType.GetModelList("FParentId = 0");
            if (lSysDictType.Count > 0)
            {
                foreach (T_SysDictType model in lSysDictType)
                {
                    Node rootNode = new Node(model.FTypeName) { Tag = model.FDictTypeId, Expanded = true };
                    allList = bllSysDictType.GetModelList("");
                    NodesBind(rootNode);
                    advTree1.Nodes.Add(rootNode);
                }
            }
            else
            {
                CustomDesktopAlert.H2("无数据");
            }

        }

        /// <summary>
        /// //递归绑定子区域 
        /// </summary>
        /// <param name="childNode"></param>
        private static void NodesBind(Node childNode)
        {
            //lambda 表达式
            if (allList != null)
            {
                clist = allList.Where(r => r.FParentId == int.Parse(childNode.Tag.ToString())).ToList();

                foreach (T_SysDictType c in clist)
                {
                    Node childNode1 = new Node(c.FTypeName) { Tag = c.FDictTypeId, Expanded = true };

                    NodesBind(childNode1);

                    childNode.Nodes.Add(childNode1);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdvTree1_Click(object sender, System.EventArgs e)
        {
            string selectedNodeTag = advTree1.SelectedNode.Tag.ToString();
            baseCondition = string.Format("FDictTypeId = {0}" , selectedNodeTag);
            queryCondition = baseCondition;
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
        }

        /// <summary>
        /// 计算记录总数并更新数据源
        /// </summary>
        private void RefreshGridView()
        {
            pager2.PageSize = pageSize;
            int iCount = bllSysDictData.GetRecCount(modelName, queryCondition);

            pager2.RefreshPager(iCount);
            DataGridViewX1.DataSource = bllSysDictData.GetListByPage(modelName, primaryKey, pager2.PageIndex, pager2.PageSize, "", columnList, queryCondition, queryGroup);

            //清空默认表格的选择
            DataGridViewX1.Rows[0].Selected = false;

        }


        #endregion

        #region 表格控件
        private void DataGridViewX1_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
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
        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            FrmDictDetail frm = new FrmDictDetail
            {
                DictDataId = -1,
                DictTypeId = int.Parse(advTree1.SelectedNode.Tag.ToString()),
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshGridView();
            }
        }

        #endregion

        #region 修改
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (DataGridViewX1.SelectedRows.Count == 1)
            {
                //CustomDesktopAlert.H2(DataGridViewX1.SelectedRows[0].Cells["部门编号"].Value.ToString());
                int selectedRowId = int.Parse(DataGridViewX1.SelectedRows[0].Cells["条目编号"].Value.ToString());
                FrmDictDetail frm = new FrmDictDetail
                {
                    DictDataId = selectedRowId,
                    DictTypeId = int.Parse(advTree1.SelectedNode.Tag.ToString()),
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

        #region 查询
        private void ButtonQuery_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(baseCondition))
            {
                string queryString = TextBoxX_QueryString.Text;
                if (!string.IsNullOrEmpty(queryString))
                {
                    queryCondition = baseCondition + string.Format(" AND [FDispName] LIKE '%{0}%' ", queryString);
                    pager2.PageIndex = 1;
                    RefreshGridView();
                }
                else
                {
                    CustomDesktopAlert.H2("请输入查询条件！");
                } 
            }
            else
            {
                CustomDesktopAlert.H2("请先选择字典类型！");
            }
        }

        private void ButtonClean_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(baseCondition))
            {
                TextBoxX_QueryString.Text = "";
                queryCondition = baseCondition + TextBoxX_QueryString.Text;
                pager2.PageIndex = 1;
                RefreshGridView();
            }
            else
            {
                CustomDesktopAlert.H2("请先选择字典类型！");
            }
        }

        #endregion

        #region 删除
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("你真的要删除这些记录码？", "系统信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (DataGridViewX1.Rows.Count > 0)
                {
                    string selectedRows = "";
                    foreach (DataGridViewRow dr in DataGridViewX1.Rows)
                    {
                        if (dr.Selected == true)
                        {
                            selectedRows += dr.Cells["条目编号"].Value + ",";
                        }
                    }
                    if (selectedRows.Length > 0)
                    {
                        selectedRows = selectedRows.Substring(0, selectedRows.Length - 1);
                        if (bllSysDictData.DeleteList(selectedRows) == true)
                        {
                            CustomDesktopAlert.H2("记录编号" + selectedRows + "删除成功！");
                            RefreshGridView();
                        }
                    }
                }
            }
        }
        #endregion
    }
}
