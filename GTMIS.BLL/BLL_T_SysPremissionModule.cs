﻿using System;
using System.Collections.Generic;
using System.Data;

namespace GTMIS.BLL
{
    //T_SysPremissionModule
    public partial class BLL_T_SysPremissionModule
    {

        private readonly GTMIS.DAL.DAL_T_SysPremissionModule dal = new GTMIS.DAL.DAL_T_SysPremissionModule();
        public BLL_T_SysPremissionModule()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FPremissionModuleID)
        {
            return dal.Exists(FPremissionModuleID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(GTMIS.Model.T_SysPremissionModule model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysPremissionModule model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FPremissionModuleID)
        {

            return dal.Delete(FPremissionModuleID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysPremissionModule GetModel(int FPremissionModuleID)
        {

            return dal.GetModel(FPremissionModuleID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        ///public GTMIS.Model.T_SysPremissionModule GetModelByCache(int FPremissionModuleID)
        ///{
        ///	
        ///	string CacheKey = "T_SysPremissionModuleModel-" + FPremissionModuleID;
        ///	object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        ///	if (objModel == null)
        ///	{
        ///		try
        ///		{
        ///			objModel = dal.GetModel(FPremissionModuleID);
        ///			if (objModel != null)
        ///			{
        ///				int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        ///				Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        ///			}
        ///		}
        ///		catch{}
        ///	}
        ///	return (GTMIS.Model.T_SysPremissionModule)objModel;
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
        public List<GTMIS.Model.T_SysPremissionModule> GetModelList(int Top, string strWhere, string filedOrder)
        {
            DataTable dt = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysPremissionModule> DataTableToList(DataTable dt)
        {
            List<GTMIS.Model.T_SysPremissionModule> modelList = new List<GTMIS.Model.T_SysPremissionModule>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                GTMIS.Model.T_SysPremissionModule model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new GTMIS.Model.T_SysPremissionModule();
                    if (dt.Rows[n]["FPremissionModuleID"].ToString() != "")
                    {
                        model.FPremissionModuleID = int.Parse(dt.Rows[n]["FPremissionModuleID"].ToString());
                    }
                    if (dt.Rows[n]["FPremissionID"].ToString() != "")
                    {
                        model.FPremissionID = int.Parse(dt.Rows[n]["FPremissionID"].ToString());
                    }
                    if (dt.Rows[n]["FModulleID"].ToString() != "")
                    {
                        model.FModulleID = int.Parse(dt.Rows[n]["FModulleID"].ToString());
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