using System;
using System.Collections.Generic;
using System.Data;

namespace GTMIS.BLL
{
    //T_SysPremission
    public partial class BLL_T_SysPremission
    {

        private readonly GTMIS.DAL.DAL_T_SysPremission dal = new GTMIS.DAL.DAL_T_SysPremission();
        public BLL_T_SysPremission()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FPremissionID)
        {
            return dal.Exists(FPremissionID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(GTMIS.Model.T_SysPremission model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysPremission model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FPremissionID)
        {

            return dal.Delete(FPremissionID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysPremission GetModel(int FPremissionID)
        {

            return dal.GetModel(FPremissionID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        ///public GTMIS.Model.T_SysPremission GetModelByCache(int FPremissionID)
        ///{
        ///	
        ///	string CacheKey = "T_SysPremissionModel-" + FPremissionID;
        ///	object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        ///	if (objModel == null)
        ///	{
        ///		try
        ///		{
        ///			objModel = dal.GetModel(FPremissionID);
        ///			if (objModel != null)
        ///			{
        ///				int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        ///				Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        ///			}
        ///		}
        ///		catch{}
        ///	}
        ///	return (GTMIS.Model.T_SysPremission)objModel;
        ///}

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
        public List<GTMIS.Model.T_SysPremission> GetModelList(int Top, string strWhere, string filedOrder)
        {
            DataTable dt = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysPremission> DataTableToList(DataTable dt)
        {
            List<GTMIS.Model.T_SysPremission> modelList = new List<GTMIS.Model.T_SysPremission>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                GTMIS.Model.T_SysPremission model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new GTMIS.Model.T_SysPremission();
                    if (dt.Rows[n]["FPremissionID"].ToString() != "")
                    {
                        model.FPremissionID = int.Parse(dt.Rows[n]["FPremissionID"].ToString());
                    }
                    if (dt.Rows[n]["FModuleID"].ToString() != "")
                    {
                        model.FModuleID = int.Parse(dt.Rows[n]["FModuleID"].ToString());
                    }
                    model.FPremissionName = dt.Rows[n]["FPremissionName"].ToString();
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