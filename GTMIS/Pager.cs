﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ray.Framework.DBUtility;

namespace GTMIS
{
    /// <summary>
    /// 申明委托
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public delegate int EventPagingHandler(EventPagingArg e);
    /// <summary>
    /// 分页控件呈现
    /// </summary>
    public partial class Pager : UserControl
    {
        public Pager()
        {
            InitializeComponent();
        }

        public event EventPagingHandler EventPaging;
        /// <summary>
        /// 每页显示记录数
        /// </summary>
        private int _pageSize = 20;
        /// <summary>
        /// 每页显示记录数
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value;
                GetPageCount();
            }
        }

        private int _nMax = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        public int NMax
        {
            get { return _nMax; }
            set
            {
                _nMax = value;
                GetPageCount();
            }
        }

        private int _pageCount = 0;
        /// <summary>
        /// 页数=总记录数/每页显示记录数
        /// </summary>
        public int PageCount
        {
            get { return _pageCount; }
            set { _pageCount = value; }
        }

        private int _pageCurrent = 0;
        /// <summary>
        /// 当前页号
        /// </summary>
        public int PageCurrent
        {
            get { return _pageCurrent; }
            set { _pageCurrent = value; }
        }

        public BindingNavigator ToolBar
        {
            get { return this.bindingNavigator; }
        }

        private void GetPageCount()
        {
            if (this.NMax > 0)
            {
                this.PageCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.NMax) / Convert.ToDouble(this.PageSize)));
            }
            else
            {
                this.PageCount = 0;
            }
        }

        /// <summary>
        /// 翻页控件数据绑定的方法
        /// </summary>
        public void Bind()
        {
            if (this.EventPaging != null)
            {
                this.NMax = this.EventPaging(new EventPagingArg(this.PageCurrent));
            }

            if (this.PageCurrent > this.PageCount)
            {
                this.PageCurrent = this.PageCount;
            }
            if (this.PageCount == 1)
            {
                this.PageCurrent = 1;
            }
            lblPageCount.Text = this.PageCount.ToString();
            this.lblMaxPage.Text = "共" + this.NMax.ToString() + "条记录";
            this.txtCurrentPage.Text = this.PageCurrent.ToString();

            if (this.PageCurrent == 1)
            {
                this.btnPrev.Enabled = false;
                this.btnFirst.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
                btnFirst.Enabled = true;
            }

            if (this.PageCurrent == this.PageCount)
            {
                this.btnLast.Enabled = false;
                this.btnNext.Enabled = false;
            }
            else
            {
                btnLast.Enabled = true;
                btnNext.Enabled = true;
            }

            if (this.NMax == 0)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            PageCurrent = 1;
            this.Bind();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            PageCurrent -= 1;
            if (PageCurrent <= 0)
            {
                PageCurrent = 1;
            }
            this.Bind();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.PageCurrent += 1;
            if (PageCurrent > PageCount)
            {
                PageCurrent = PageCount;
            }
            this.Bind();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            PageCurrent = PageCount;
            this.Bind();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (this.txtCurrentPage.Text != null && txtCurrentPage.Text != "")
            {
                if (Int32.TryParse(txtCurrentPage.Text, out _pageCurrent))
                {
                    this.Bind();
                }
                else
                {
                    //Common.MessageProcess.ShowError("输入数字格式错误！");
                }
            }
        }

        private void txtCurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Bind();
            }
        }

    }
    /// <summary>
    /// 自定义事件数据基类
    /// </summary>
    public class EventPagingArg : EventArgs
    {
        private readonly int _intPageIndex;
        public EventPagingArg(int PageIndex)
        {
            _intPageIndex = PageIndex;
        }
    }
    /// <summary>
    /// 数据源提供
    /// </summary>
    public class PageData
    {
        private int _PageSize = 10;
        private int _PageIndex = 1;
        private int _PageCount = 0;
        private int _TotalCount = 0;
        private string _TableName;//表名
        private string _QueryFieldName = "*";//表字段FieldStr
        private string _OrderStr = string.Empty; //排序_SortStr
        private string _QueryCondition = string.Empty;//查询的条件 RowFilter
        private string _PrimaryKey = string.Empty;//主键
        private bool _isQueryTotalCounts = true;//是否查询总的记录条数
        /// <summary>
        /// 是否查询总的记录条数
        /// </summary>
        public bool IsQueryTotalCounts
        {
            get { return _isQueryTotalCounts; }
            set { _isQueryTotalCounts = value; }
        }
        /// <summary>
        /// 显示页数
        /// </summary>
        public int PageSize
        {
            get
            {
                return _PageSize;

            }
            set
            {
                _PageSize = value;
            }
        }
        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex
        {
            get
            {
                return _PageIndex;
            }
            set
            {
                _PageIndex = value;
            }
        }
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                return _PageCount;
            }
        }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalCount
        {
            get
            {
                return _TotalCount;
            }
        }
        /// <summary>
        /// 表名，包括视图
        /// </summary>
        public string TableName
        {
            get
            {
                return _TableName;
            }
            set
            {
                _TableName = value;
            }
        }
        /// <summary>
        /// 表字段FieldStr
        /// </summary>
        public string QueryFieldName
        {
            get
            {
                return _QueryFieldName;
            }
            set
            {
                _QueryFieldName = value;
            }
        }
        /// <summary>
        /// 排序字段
        /// </summary>
        public string OrderStr
        {
            get
            {
                return _OrderStr;
            }
            set
            {
                _OrderStr = value;
            }
        }
        /// <summary>
        /// 查询条件
        /// </summary>
        public string QueryCondition
        {
            get
            {
                return _QueryCondition;
            }
            set
            {
                _QueryCondition = value;
            }
        }
        /// <summary>
        /// 主键
        /// </summary>
        public string PrimaryKey
        {
            get
            {
                return _PrimaryKey;
            }
            set
            {
                _PrimaryKey = value;
            }
        }
        public DataSet QueryDataTable()
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@Tables", SqlDbType.VarChar, 255),
                    new SqlParameter("@PrimaryKey" , SqlDbType.VarChar , 255),
                    new SqlParameter("@Sort", SqlDbType.VarChar , 255 ),
                    new SqlParameter("@CurrentPage", SqlDbType.Int),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@Fields", SqlDbType.VarChar, 255),
                    new SqlParameter("@Filter", SqlDbType.VarChar,1000),
                    new SqlParameter("@Group" ,SqlDbType.VarChar , 1000 )
                    };
            parameters[0].Value = _TableName;
            parameters[1].Value = _PrimaryKey;
            parameters[2].Value = _OrderStr;
            parameters[3].Value = PageIndex;
            parameters[4].Value = PageSize;
            parameters[5].Value = _QueryFieldName;
            parameters[6].Value = _QueryCondition;
            parameters[7].Value = string.Empty;
            //DataSet ds = DbHelperSQL.RunProcedure("SP_Pagination", parameters, "dd");
            DataSet ds = SqlHelper.ExecuteDataSet(connectionString,CommandType.StoredProcedure, "SP_Pagination", parameters);
            if (_isQueryTotalCounts)
            {
                _TotalCount = GetTotalCount();
            }
            if (_TotalCount == 0)
            {
                _PageIndex = 0;
                _PageCount = 0;
            }
            else
            {
                _PageCount = _TotalCount % _PageSize == 0 ? _TotalCount / _PageSize : _TotalCount / _PageSize + 1;
                if (_PageIndex > _PageCount)
                {
                    _PageIndex = _PageCount;

                    parameters[4].Value = _PageSize;

                    ds = QueryDataTable();
                }
            }
            return ds;
        }

        public int GetTotalCount()
        {
            string strSql = " select count(1) from " + _TableName;
            if (_QueryCondition != string.Empty)
            {
                strSql += " where " + _QueryCondition;
            }
            return int.Parse(SqlHelper.ExecuteScalar(strSql).ToString());
        }
    }
}
