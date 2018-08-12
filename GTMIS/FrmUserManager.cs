using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using GTMIS.Controls;
using GTMIS.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GTMIS
{
    public partial class FrmUserManager : Office2007Form
    {
        public FrmUserManager()
        {
            InitializeComponent();
        }

        private static BLL.BLL_T_SysDept bllSysDept = new BLL.BLL_T_SysDept();
        private static List<T_SysDept> clist = (List<T_SysDept>)null;
        private static List<T_SysDept> allList = (List<T_SysDept>)null;

        private static string queryCondition = "";
        private static string queryGroup = "";
        private static string modelName = "T_SysDept";
        private static string primaryKey = "FDeptId";
        private static int pageSize = 2;
        private static int pageIndex = 1;
        private static int recCount = bllSysDept.GetRecCount(modelName, queryCondition);

        private static Pager pager1 = new GTMIS.Controls.Pager(pageSize, pageIndex, recCount)
        {
            Dock = System.Windows.Forms.DockStyle.Bottom
        };

        Node rootNode = new Node("中国")
        {
            Tag = 1,
            Expanded =true            
        };
        
        private void FrmUserManager_Load(object sender, System.EventArgs e)
        {
            //加载树
            allList = bllSysDept.GetModelList(5000, "", "FOrder ASC");
            NodesBind(rootNode);
            advTree1.Nodes.Add(rootNode);

            //加载列表
            //dataGridViewX1.DataSource = bllSysDept.GetListByPage(modelName,primaryKey, pageIndex, pageSize, "", null, queryCondition, queryGroup);
            //dataGridViewX1.Columns[0].HeaderText = "部门编号";
            //dataGridViewX1.Columns[5].HeaderText = "创建时间";
            dataGridViewX1.AllowUserToAddRows = false;

            //加载分页控件
            pager1.PageIndexChanged += new System.EventHandler(this.Pager1_PageIndexChanged);
            panelEx1.Controls.Add(pager1);
            LoadData();
            
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
                    Node childNode1 = new Node(c.FDeptName)
                    {
                        Tag = c.FDeptID,
                        Expanded = true
                    };

                    NodesBind(childNode1);

                    childNode.Nodes.Add(childNode1);
                }
            }
        }

        private void AdvTree1_Click(object sender, System.EventArgs e)
        {
            //MessageBoxEx.Show(advTree1.SelectedNode.Tag.ToString());
        }


        private void Pager1_PageIndexChanged(object sender, System.EventArgs e)
        {
            pageIndex = pager1.PageIndex ; 
            LoadData();
        }

        private void LoadData()
        {
            //pager1.RecCount = bllSysDept.GetRecCount(modelName, queryCondition);
            dataGridViewX1.DataSource = bllSysDept.GetListByPage(modelName, primaryKey, pageIndex, pageSize, "", null, queryCondition, queryGroup);
        }
    }
}