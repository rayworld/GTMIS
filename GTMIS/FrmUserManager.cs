using DevComponents.AdvTree;
using DevComponents.DotNetBar;
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

        Node rootNode = new Node("中国")
        {
            Tag = 1,
            Expanded =true
            
        };
        private BLL.BLL_T_SysDept bllSysDept = new BLL.BLL_T_SysDept();
        private static List<T_SysDept> clist = (List<T_SysDept>)null;
        private static List<T_SysDept> allList = (List<T_SysDept>)null;
        
        private void FrmUserManager_Load(object sender, System.EventArgs e)
        {
            //加载树
            allList = bllSysDept.GetModelList(5000, "", "FOrder ASC");
            NodesBind(rootNode);
            advTree1.Nodes.Add(rootNode);
            //加载列表
            dataGridViewX1.DataSource = bllSysDept.GetList(5000,"","fDeptid");
            
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

        private void advTree1_Click(object sender, System.EventArgs e)
        {
            MessageBoxEx.Show(advTree1.SelectedNode.Tag.ToString());
        }
    }
}