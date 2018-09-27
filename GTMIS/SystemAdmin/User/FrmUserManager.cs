using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using GTMIS.Model;
using Ray.Framework.CustomDotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GTMIS.SystemAdmin.User
{
    public partial class FrmUserManager : Office2007Form
    {
        public FrmUserManager()
        {
            InitializeComponent();
        }

        private static BLL.BLL_T_SysDept bllSysDept = new BLL.BLL_T_SysDept();
        private static BLL.BLL_T_SysUser bllSysDictData = new BLL.BLL_T_SysUser();

        private static List<T_SysDept> clist = (List<T_SysDept>)null;
        private static List<T_SysDept> allList = (List<T_SysDept>)null;

        private static string baseCondition = "";
        private static string queryCondition = "";
        private static string queryGroup = "";
        private static string modelName = "T_SysUser";
        private static string primaryKey = "FUserId";
        private static string columnList = " [FUserID] AS 用户编号 ,[FUserName] AS 用户名 ,[FPassword] AS 密码,[FRoleID] AS 角色编号,[FDeptID] AS 部门编号,[CreateBy] AS 创建者,[CreateDate] AS 创建时间 ";
        private static int pageSize = 50;

        //private static int maxRecCount = 100;

        private void FrmUserManager_Load(object sender, System.EventArgs e)
        {
            BindingRootTreeNode();

            //加载分页控件
            pager2.OnPageIndexChanged += new System.EventHandler(this.Pager2_OnPageIndexChanged);

            //加载列表
            //RefreshGridView();
        }

        #region 树控件

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdvTree1_Click(object sender, EventArgs e)
        {
            string selectedNodeTag = advTree1.SelectedNode.Tag.ToString();
            baseCondition = string.Format("FDeptId = {0}", selectedNodeTag);
            queryCondition = baseCondition;
            RefreshGridView();
        }

        /// <summary>
        /// 刷新树控件
        /// </summary>
        private void RefreshTreeView()
        {
            advTree1.Nodes.Clear();
            BindingRootTreeNode();
        }

        /// <summary>
        /// 绑定根节点
        /// </summary>
        private void BindingRootTreeNode()
        {
            List<T_SysDept> lSysDept = bllSysDept.GetModelList("FParentId = 0");
            if (lSysDept.Count > 0)
            {
                foreach (T_SysDept model in lSysDept)
                {
                    Node rootNode = new Node(model.FDeptName) { Tag = model.FDeptID, Expanded = true };
                    allList = bllSysDept.GetModelList("");
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
                clist = allList.Where(r => r.FParentID == int.Parse(childNode.Tag.ToString())).ToList();

                foreach (T_SysDept c in clist)
                {
                    Node childNode1 = new Node(c.FDeptName) { Tag = c.FDeptID, Expanded = true };

                    NodesBind(childNode1);

                    childNode.Nodes.Add(childNode1);
                }
            }
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
            if (DataGridViewX1.Rows.Count > 0)
            {
                DataGridViewX1.Rows[0].Selected = false;
            }
        }

        #endregion

        #region 新增
        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            FrmUserDetail frm = new FrmUserDetail
            {
                UserId = -1,
                DeptId = int.Parse(advTree1.SelectedNode.Tag.ToString()),
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefreshGridView();
            }
        }
        #endregion
    }
}
