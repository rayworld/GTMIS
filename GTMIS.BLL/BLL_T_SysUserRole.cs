using System;
using System.Collections.Generic;
using System.Data;

namespace GTMIS.BLL
{
    //T_SysUserRole
    public partial class BLL_T_SysUserRole
    {

        private readonly GTMIS.DAL.DAL_T_SysUserRole dal = new GTMIS.DAL.DAL_T_SysUserRole();
        public BLL_T_SysUserRole()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FUserRoleID)
        {
            return dal.Exists(FUserRoleID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(GTMIS.Model.T_SysUserRole model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysUserRole model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FUserRoleID)
        {

            return dal.Delete(FUserRoleID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysUserRole GetModel(int FUserRoleID)
        {

            return dal.GetModel(FUserRoleID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        ///public GTMIS.Model.T_SysUserRole GetModelByCache(int FUserRoleID)
        ///{
        ///	
        ///	string CacheKey = "T_SysUserRoleModel-" + FUserRoleID;
        ///	object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        ///	if (objModel == null)
        ///	{
        ///		try
        ///		{
        ///			objModel = dal.GetModel(FUserRoleID);
        ///			if (objModel != null)
        ///			{
        ///				int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        ///				Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        ///			}
        ///		}
        ///		catch{}
        ///	}
        ///	return (GTMIS.Model.T_SysUserRole)objModel;
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
        public List<GTMIS.Model.T_SysUserRole> GetModelList(int Top, string strWhere, string filedOrder)
        {
            DataTable dt = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysUserRole> DataTableToList(DataTable dt)
        {
            List<GTMIS.Model.T_SysUserRole> modelList = new List<GTMIS.Model.T_SysUserRole>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                GTMIS.Model.T_SysUserRole model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new GTMIS.Model.T_SysUserRole();
                    if (dt.Rows[n]["FUserRoleID"].ToString() != "")
                    {
                        model.FUserRoleID = int.Parse(dt.Rows[n]["FUserRoleID"].ToString());
                    }
                    if (dt.Rows[n]["FUserID"].ToString() != "")
                    {
                        model.FUserID = int.Parse(dt.Rows[n]["FUserID"].ToString());
                    }
                    if (dt.Rows[n]["FRoleID"].ToString() != "")
                    {
                        model.FRoleID = int.Parse(dt.Rows[n]["FRoleID"].ToString());
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