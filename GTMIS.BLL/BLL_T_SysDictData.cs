using System;
using System.Collections.Generic;
using System.Data;
namespace GTMIS.BLL
{
    //T_SysDictData
    public partial class BLL_T_SysDictData
    {

        private readonly GTMIS.DAL.DAL_T_SysDictData dal = new GTMIS.DAL.DAL_T_SysDictData();
        public BLL_T_SysDictData()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FDictDataId)
        {
            return dal.Exists(FDictDataId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(GTMIS.Model.T_SysDictData model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysDictData model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FDictDataId)
        {

            return dal.Delete(FDictDataId);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string FDictDataIdlist)
        {
            return dal.DeleteList(FDictDataIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysDictData GetModel(int FDictDataId)
        {

            return dal.GetModel(FDictDataId);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public GTMIS.Model.T_SysDictData GetModelByCache(int FDictDataId)
        //{

        //    string CacheKey = "T_SysDictDataModel-" + FDictDataId;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(FDictDataId);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (GTMIS.Model.T_SysDictData)objModel;
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
        public List<GTMIS.Model.T_SysDictData> GetModelList(string strWhere)
        {
            DataTable dt = dal.GetList(strWhere);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysDictData> DataTableToList(DataTable dt)
        {
            List<GTMIS.Model.T_SysDictData> modelList = new List<GTMIS.Model.T_SysDictData>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                GTMIS.Model.T_SysDictData model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new GTMIS.Model.T_SysDictData();
                    if (dt.Rows[n]["FDictDataId"].ToString() != "")
                    {
                        model.FDictDataId = int.Parse(dt.Rows[n]["FDictDataId"].ToString());
                    }
                    if (dt.Rows[n]["FDictTypeId"].ToString() != "")
                    {
                        model.FDictTypeId = int.Parse(dt.Rows[n]["FDictTypeId"].ToString());
                    }
                    model.FDispName = dt.Rows[n]["FDispName"].ToString();
                    model.FDictValue = dt.Rows[n]["FDictValue"].ToString();
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