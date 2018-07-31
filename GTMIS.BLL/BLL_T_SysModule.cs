using System;
using System.Collections.Generic;
using System.Data;

namespace GTMIS.BLL
{
    //T_SysModule
    public partial class BLL_T_SysModule
    {

        private readonly GTMIS.DAL.DAL_T_SysModule dal = new GTMIS.DAL.DAL_T_SysModule();
        public BLL_T_SysModule()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FModuleID)
        {
            return dal.Exists(FModuleID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(GTMIS.Model.T_SysModule model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysModule model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FModuleID)
        {

            return dal.Delete(FModuleID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysModule GetModel(int FModuleID)
        {

            return dal.GetModel(FModuleID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        ///public GTMIS.Model.T_SysModule GetModelByCache(int FModuleID)
        ///{
        ///	
        ///	string CacheKey = "T_SysModuleModel-" + FModuleID;
        ///	object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        ///	if (objModel == null)
        ///	{
        ///		try
        ///		{
        ///			objModel = dal.GetModel(FModuleID);
        ///			if (objModel != null)
        ///			{
        ///				int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        ///				Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        ///			}
        ///		}
        ///		catch{}
        ///	}
        ///	return (GTMIS.Model.T_SysModule)objModel;
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
        public List<GTMIS.Model.T_SysModule> GetModelList(int Top, string strWhere, string filedOrder)
        {
            DataTable dt = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysModule> DataTableToList(DataTable dt)
        {
            List<GTMIS.Model.T_SysModule> modelList = new List<GTMIS.Model.T_SysModule>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                GTMIS.Model.T_SysModule model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new GTMIS.Model.T_SysModule();
                    if (dt.Rows[n]["FModuleID"].ToString() != "")
                    {
                        model.FModuleID = int.Parse(dt.Rows[n]["FModuleID"].ToString());
                    }
                    model.FModuleName = dt.Rows[n]["FModuleName"].ToString();
                    if (dt.Rows[n]["FParent"].ToString() != "")
                    {
                        model.FParent = int.Parse(dt.Rows[n]["FParent"].ToString());
                    }
                    model.FIcon = dt.Rows[n]["FIcon"].ToString();
                    model.FURL = dt.Rows[n]["FURL"].ToString();
                    if (dt.Rows[n]["FCreateDate"].ToString() != "")
                    {
                        model.FCreateDate = DateTime.Parse(dt.Rows[n]["FCreateDate"].ToString());
                    }
                    model.FCreateBy = dt.Rows[n]["FCreateBy"].ToString();


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