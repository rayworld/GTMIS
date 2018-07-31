using System;
using System.Collections.Generic;
using System.Data;

namespace GTMIS.BLL
{
    //T_SysRolePremission
    public partial class BLL_T_SysRolePremission
    {

        private readonly GTMIS.DAL.DAL_T_SysRolePremission dal = new GTMIS.DAL.DAL_T_SysRolePremission();
        public BLL_T_SysRolePremission()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FRolePremissionID)
        {
            return dal.Exists(FRolePremissionID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(GTMIS.Model.T_SysRolePremission model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysRolePremission model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FRolePremissionID)
        {

            return dal.Delete(FRolePremissionID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysRolePremission GetModel(int FRolePremissionID)
        {

            return dal.GetModel(FRolePremissionID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        ///public GTMIS.Model.T_SysRolePremission GetModelByCache(int FRolePremissionID)
        ///{
        ///	
        ///	string CacheKey = "T_SysRolePremissionModel-" + FRolePremissionID;
        ///	object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        ///	if (objModel == null)
        ///	{
        ///		try
        ///		{
        ///			objModel = dal.GetModel(FRolePremissionID);
        ///			if (objModel != null)
        ///			{
        ///				int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        ///				Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        ///			}
        ///		}
        ///		catch{}
        ///	}
        ///	return (GTMIS.Model.T_SysRolePremission)objModel;
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
        public List<GTMIS.Model.T_SysRolePremission> GetModelList(int Top, string strWhere, string filedOrder)
        {
            DataTable dt = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysRolePremission> DataTableToList(DataTable dt)
        {
            List<GTMIS.Model.T_SysRolePremission> modelList = new List<GTMIS.Model.T_SysRolePremission>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                GTMIS.Model.T_SysRolePremission model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new GTMIS.Model.T_SysRolePremission();
                    if (dt.Rows[n]["FRolePremissionID"].ToString() != "")
                    {
                        model.FRolePremissionID = int.Parse(dt.Rows[n]["FRolePremissionID"].ToString());
                    }
                    if (dt.Rows[n]["FRoleID"].ToString() != "")
                    {
                        model.FRoleID = int.Parse(dt.Rows[n]["FRoleID"].ToString());
                    }
                    if (dt.Rows[n]["FPremissionID"].ToString() != "")
                    {
                        model.FPremissionID = int.Parse(dt.Rows[n]["FPremissionID"].ToString());
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