using System;
using System.Collections.Generic;
using System.Data;
using GTMIS.Model;

namespace GTMIS.BLL
{
    //T_SysDictType
    public partial class BLL_T_SysDictType
    {

        private readonly GTMIS.DAL.DAL_T_SysDictType dal = new GTMIS.DAL.DAL_T_SysDictType();
        public BLL_T_SysDictType()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FDictTypeId)
        {
            return dal.Exists(FDictTypeId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(GTMIS.Model.T_SysDictType model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysDictType model)
        {
            return dal.Update(model);
        }

        public List<T_SysDept> GetList(int v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FDictTypeId)
        {

            return dal.Delete(FDictTypeId);
        }

        public List<T_SysDictType> GetModelList(int v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string FDictTypeIdlist)
        {
            return dal.DeleteList(FDictTypeIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysDictType GetModel(int FDictTypeId)
        {

            return dal.GetModel(FDictTypeId);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public GTMIS.Model.T_SysDictType GetModelByCache(int FDictTypeId)
        //{

        //    string CacheKey = "T_SysDictTypeModel-" + FDictTypeId;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(FDictTypeId);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (GTMIS.Model.T_SysDictType)objModel;
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
        //public DataTable GetList(int Top, string strWhere, string filedOrder)
        //{
        //    return dal.GetList(Top, strWhere, filedOrder);
        //}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysDictType> GetModelList(string strWhere)
        {
            DataTable dt = dal.GetList(strWhere);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysDictType> DataTableToList(DataTable dt)
        {
            List<GTMIS.Model.T_SysDictType> modelList = new List<GTMIS.Model.T_SysDictType>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                GTMIS.Model.T_SysDictType model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new GTMIS.Model.T_SysDictType();
                    if (dt.Rows[n]["FDictTypeId"].ToString() != "")
                    {
                        model.FDictTypeId = int.Parse(dt.Rows[n]["FDictTypeId"].ToString());
                    }
                    model.FTypeName = dt.Rows[n]["FTypeName"].ToString();
                    if (dt.Rows[n]["FParentId"].ToString() != "")
                    {
                        model.FParentId = int.Parse(dt.Rows[n]["FParentId"].ToString());
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

        /// <summary>
        /// 调用分页过程，通用分页
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="tableName"></param>
        /// <param name="primaryKey"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="queryOrder"></param>
        /// <param name="queryFieldName"></param>
        /// <param name="queryCondition"></param>
        /// <param name="queryGroup"></param>
        /// <returns></returns>
        public DataTable GetListByPage(string tableName, string primaryKey, int pageIndex, int pageSize, string queryOrder, string queryFieldName, string queryCondition, string queryGroup)
        {
            return dal.GetListByPage(tableName, primaryKey, pageIndex, pageSize, queryOrder, queryFieldName, queryCondition, queryGroup);
        }

        /// <summary>
        /// 得到指定条件下的记录数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="queryCondition"></param>
        /// <returns></returns>
        public int GetRecCount(string tableName, string queryCondition)
        {
            return dal.GetRecCount(tableName, queryCondition);
        }

        /// <summary>
        ///  通过名称查询编号
        /// </summary>
        /// <param name="nameField"></param>
        /// <returns></returns>
        public int GetDeptIdByName(string nameField)
        {
            return dal.GetDeptIdByName(nameField);
        }
        #endregion

    }
}