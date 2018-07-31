using System;
using System.Collections.Generic;
using System.Data;

namespace GTMIS.BLL
{
    //T_SysDept
    public partial class BLL_T_SysDept
    {

        private readonly DAL.DAL_T_SysDept dal = new GTMIS.DAL.DAL_T_SysDept();
        public BLL_T_SysDept()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FDeptID)
        {
            return dal.Exists(FDeptID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(GTMIS.Model.T_SysDept model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysDept model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FDeptID)
        {

            return dal.Delete(FDeptID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string FDeptIDlist)
        {
            return dal.DeleteList(FDeptIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysDept GetModel(int FDeptID)
        {

            return dal.GetModel(FDeptID);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public GTMIS.Model.T_SysDept GetModelByCache(int FDeptID)
        //{

        //    string CacheKey = "T_SysDeptModel-" + FDeptID;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(FDeptID);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (GTMIS.Model.T_SysDept)objModel;
        //}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataTable GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysDept> GetModelList(int Top, string strWhere, string filedOrder)
        {
            DataTable dt = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysDept> DataTableToList(DataTable dt)
        {
            List<GTMIS.Model.T_SysDept> modelList = new List<GTMIS.Model.T_SysDept>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                GTMIS.Model.T_SysDept model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new GTMIS.Model.T_SysDept();
                    if (dt.Rows[n]["FDeptID"].ToString() != "")
                    {
                        model.FDeptID = int.Parse(dt.Rows[n]["FDeptID"].ToString());
                    }
                    model.FDeptName = dt.Rows[n]["FDeptName"].ToString();
                    if (dt.Rows[n]["FParentID"].ToString() != "")
                    {
                        model.FParentID = int.Parse(dt.Rows[n]["FParentID"].ToString());
                    }
                    if (dt.Rows[n]["FOrder"].ToString() != "")
                    {
                        model.FOrder = int.Parse(dt.Rows[n]["FOrder"].ToString());
                    }
                    model.FCreateBy = dt.Rows[n]["FCreateBy"].ToString();
                    if (dt.Rows[n]["FCreateDate"].ToString() != "")
                    {
                        model.FCreateDate = DateTime.Parse(dt.Rows[n]["FCreateDate"].ToString());
                    }


                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetAllList()
        {
            return GetList("");
        }
        #endregion
    }
}