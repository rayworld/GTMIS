﻿using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using GTMIS.Model;
using Ray.Framework.CustomDotNetBar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GTMIS
{
    public partial class FrmUserManager : Office2007Form
    {
        CheckBox HeaderCheckBox = null;

        public FrmUserManager()
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

        private static BLL.BLL_T_SysDept bllSysDept = new BLL.BLL_T_SysDept();
        private static List<T_SysDept> clist = (List<T_SysDept>)null;
        private static List<T_SysDept> allList = (List<T_SysDept>)null;

        private static string queryCondition = "";
        private static string queryGroup = "";
        private static string modelName = "T_SysDept";
        private static string primaryKey = "FDeptId";
        private static string columnList = "[FDeptId] AS 部门编号,[FDeptName] AS 部门名称 ,[FParentID] AS 上级编号 ,[FOrder] AS 排序 ,[FCreateBy] AS 创建者 ,[FCreateDate] AS 创建时间";
        private static int pageSize = 50;
        
        private void FrmUserManager_Load(object sender, System.EventArgs e)
        {
            //加载树
            Node rootNode = new Node("中国") { Tag = 1, Expanded = true };
            allList = bllSysDept.GetModelList(5000, "", "FOrder ASC");
            NodesBind(rootNode);
            advTree1.Nodes.Add(rootNode);

            //加载分页控件
            //pager1 = new GTMIS.Controls.Pager(){Dock = System.Windows.Forms.DockStyle.Bottom };
            pager2.OnPageIndexChanged += new System.EventHandler(this.Pager2_PageIndexChanged);
            //panelEx1.Controls.Add(pager1);

            //加载列表
            RefreshData();
      
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
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
        private void HeaderCheckBoxClick(CheckBox HCheckBox)
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
                HeaderCheckBoxClick((CheckBox)sender);
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
                clist = allList.Where(r => r.FParentID == int.Parse(childNode.Tag.ToString())).ToList();

                foreach (T_SysDept c in clist)
                {
                    Node childNode1 = new Node(c.FDeptName) { Tag = c.FDeptID, Expanded = true };

                    NodesBind(childNode1);

                    childNode.Nodes.Add(childNode1);
                }
            }
        }

        private void AdvTree1_Click(object sender, System.EventArgs e)
        {
            //MessageBoxEx.Show(advTree1.SelectedNode.Tag.ToString());
        }

        private void Pager2_PageIndexChanged(object sender, System.EventArgs e)
        {
            RefreshData();
            HeaderCheckBox.Checked = false;
        }

        /// <summary>
        /// 计算记录总数并更新数据源
        /// </summary>
        private void RefreshData()
        {
            pager2.PageSize = pageSize;
            int iCount = bllSysDept.GetRecCount(modelName, queryCondition);
            CustomDesktopAlert.H2(pager2.PageSize.ToString());
            pager2.RefreshPager(iCount);
            DataGridViewX1.DataSource = bllSysDept.GetListByPage(modelName, primaryKey, pager2.PageIndex,pager2.PageSize,"", columnList, queryCondition, queryGroup);

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

        #region 删除
        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
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
                            selectedRows += dr.Cells["部门编号"].Value + ",";
                        }
                    }
                    if (selectedRows.Length > 0)
                    {
                        selectedRows = selectedRows.Substring(0, selectedRows.Length - 1);
                        if (bllSysDept.DeleteList(selectedRows) == true)
                        {
                            CustomDesktopAlert.H2("记录编号" + selectedRows + "删除成功！");
                            //删除事件，要重新计算RecCount
                            pager2.RecCount = bllSysDept.GetRecCount(modelName, queryCondition);
                            if (pager2.PageCount == pager2.RecCount / pager2.PageSize && pager2.PageIndex > 1)
                            {
                                pager2.PageIndex -= 1;
                            }

                            RefreshData();

                        };
                    }

                }
            }
        }
        #endregion

        #region 格式化列
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
        #endregion

        #region 查询
        /// <summary>
        /// 设置查询条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonQuery_Click(object sender, EventArgs e)
        {
            string queryString = TextBoxX_QueryString.Text;
            queryCondition = string.Format(" [FDeptName] LIKE '%{0}%' ",queryString);
            pager2.PageIndex = 1;
            RefreshData();
        }

        /// <summary>
        /// 清空查询条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClean_Click(object sender, EventArgs e)
        {
            TextBoxX_QueryString.Text = "";
            queryCondition = TextBoxX_QueryString.Text;
            pager2.PageIndex = 1;
            RefreshData();
        }
        #endregion
    }
}