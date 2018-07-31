using System;
using System.Collections.Generic;
using System.Data;

namespace GTMIS.BLL
{
    //T_SysRole
    public partial class BLL_T_SysRole
    {

        private readonly GTMIS.DAL.DAL_T_SysRole dal = new GTMIS.DAL.DAL_T_SysRole();
        public BLL_T_SysRole()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FRoleID)
        {
            return dal.Exists(FRoleID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(GTMIS.Model.T_SysRole model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysRole model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FRoleID)
        {

            return dal.Delete(FRoleID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string FRoleIDlist)
        {
            return dal.DeleteList(FRoleIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysRole GetModel(int FRoleID)
        {

            return dal.GetModel(FRoleID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        ///public GTMIS.Model.T_SysRole GetModelByCache(int FRoleID)
        ///{
        ///	
        ///	string CacheKey = "T_SysRoleModel-" + FRoleID;
        ///	object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        ///	if (objModel == null)
        ///	{
        ///		try
        ///		{
        ///			objModel = dal.GetModel(FRoleID);
        ///			if (objModel != null)
        ///			{
        ///				int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        ///				Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        ///			}
        ///		}
        ///		catch{}
        ///	}
        ///	return (GTMIS.Model.T_SysRole)objModel;
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
        public List<GTMIS.Model.T_SysRole> GetModelList(int Top, string strWhere, string filedOrder)
        {
            DataTable dt = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysRole> DataTableToList(DataTable dt)
        {
            List<GTMIS.Model.T_SysRole> modelList = new List<GTMIS.Model.T_SysRole>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                GTMIS.Model.T_SysRole model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new GTMIS.Model.T_SysRole();
                    if (dt.Rows[n]["FRoleID"].ToString() != "")
                    {
                        model.FRoleID = int.Parse(dt.Rows[n]["FRoleID"].ToString());
                    }
                    model.FRoleName = dt.Rows[n]["FRoleName"].ToString();
                    model.FRoleDesc = dt.Rows[n]["FRoleDesc"].ToString();
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