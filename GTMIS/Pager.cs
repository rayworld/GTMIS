using System;
using System.Windows.Forms;

namespace GTMIS.Controls
{
    public partial class Pager : UserControl
    {
        #region 构造函数
        public Pager()
        {
            InitializeComponent();
        }
        #endregion

        #region 属性

        private int pageSize = 10;
        private int pageIndex = 1;
        private int recCount = 0;
        private int pageCount = 0;


        public int PageSize { get => pageSize; set => pageSize = value; }
        public int PageIndex { get => pageIndex; set => pageIndex = value; }
        public int RecCount { get => recCount; set => recCount = value; }

        public int PageCount
        {
            get
            {
                if (pageSize == 0)
                {
                    return 0;
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

        public event EventHandler OnPageIndexChanged;

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
            RefreshPager(true);
        }


        /// <summary>
        /// 末页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLast_Click(object sender, EventArgs e)
        {

            PageIndex = PageCount;
            RefreshPager(true);

        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            PageIndex -= 1;
            RefreshPager(true);
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            PageIndex += 1;
            RefreshPager(true);
        }


        #endregion

        #region  私有过程

        public void RefreshPager(int iCount)
        {
            recCount = iCount;
            RefreshPager(false);
        }

        private  void RefreshPager(bool callEvent)
        {
            ///this.btnGo.Text = this.JumpText;
            this.LabelPagerState.Text = string.Format("{0}/{1} 页  共 {2} 条记录，每页 {3} 条", PageIndex.ToString(),
                this.PageCount.ToString(), RecCount.ToString(), PageSize.ToString());

            if(callEvent && OnPageIndexChanged != null)
            {
                OnPageIndexChanged(this,null);
            }            

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
