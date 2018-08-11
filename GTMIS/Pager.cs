using System;
using System.Windows.Forms;

namespace GTMIS.Controls
{
    public partial class Pager : UserControl
    {
        #region 构造函数
        private Pager()
        {
            InitializeComponent();
        }

        public Pager(int pageSize,int pageIndex,int recCount)
        {
            InitializeComponent();
            PageSize = pageSize;
            PageIndex = pageIndex;
            RecCount = recCount;
            RefreshData();
        }

        #endregion

        #region 属性

        public int PageSize { get; set; }

        public int PageIndex { get; set; }

        public int RecCount { get; set; }

        private int pageCount;
        public int PageCount
        {
            get
            {
                if (PageSize == 0)
                {
                    pageCount = 0;
                    throw new DivideByZeroException("每页记录数为0");
                }
                else
                {
                    pageCount = RecCount % PageSize == 0 ? RecCount / PageSize: RecCount / PageSize + 1;
                }
                return pageCount;                
            }
        }

        #endregion

        #region 页码变化触发事件

        public event EventHandler PageIndexChanged;

        #endregion

        #region 分页事件
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            RefreshData();
        }


        /// <summary>
        /// 末页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLast_Click(object sender, EventArgs e)
        {

            PageIndex = PageCount;
            RefreshData();

        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            PageIndex -= 1;
            RefreshData();
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            PageIndex += 1;
            RefreshData();
        }


        #endregion

        #region  私有过程
        private void RefreshData()
        {
            ///this.btnGo.Text = this.JumpText;
            this.LabelPagerState.Text = string.Format("{0}/{1} 页  共 {2} 条记录，每页 {3} 条", PageIndex.ToString(),
                this.PageCount.ToString(), RecCount.ToString(), PageSize.ToString());

            PageIndexChanged?.Invoke(this, null);//当前分页数字改变时，触发委托事件

            ButtonFirst.Enabled = true;
            ButtonPrev.Enabled = true;
            ButtonNext.Enabled = true;
            ButtonLast.Enabled = true;

            if (PageCount == 1)//有且仅有一页
            {                
                ButtonFirst.Enabled = false;
                ButtonPrev.Enabled = false;
                ButtonNext.Enabled = false;
                ButtonLast.Enabled = false;
                ///this.btnGo.Enabled = false;
            }
            else if (PageIndex <= 1)//第一页
            {
                PageIndex = 1;
                ButtonFirst.Enabled = false;
                ButtonPrev.Enabled = false;
            }
            else if (PageIndex >= PageCount)//最后一页
            {
                PageIndex = PageCount;
                ButtonNext.Enabled = false;
                ButtonLast.Enabled = false;
            }
        }
        #endregion
    }
    
}
