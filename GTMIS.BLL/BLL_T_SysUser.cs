using System;
using System.Collections.Generic;
using System.Data;

namespace GTMIS.BLL
{
    //T_SysUser
    public partial class BLL_T_SysUser
    {

        private readonly GTMIS.DAL.DAL_T_SysUser dal = new GTMIS.DAL.DAL_T_SysUser();
        public BLL_T_SysUser()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FUserID)
        {
            return dal.Exists(FUserID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(GTMIS.Model.T_SysUser model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysUser model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FUserID)
        {

            return dal.Delete(FUserID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string FUserIDlist)
        {
            return dal.DeleteList(FUserIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysUser GetModel(int FUserID)
        {

            return dal.GetModel(FUserID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        ///public GTMIS.Model.T_SysUser GetModelByCache(int FUserID)
        ///{
        ///	
        ///	string CacheKey = "T_SysUserModel-" + FUserID;
        ///	object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        ///	if (objModel == null)
        ///	{
        ///		try
        ///		{
        ///			objModel = dal.GetModel(FUserID);
        ///			if (objModel != null)
        ///			{
        ///				int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        ///				Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        ///			}
        ///		}
        ///		catch{}
        ///	}
        ///	return (GTMIS.Model.T_SysUser)objModel;
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
        public List<GTMIS.Model.T_SysUser> GetModelList(int Top, string strWhere, string filedOrder)
        {
            DataTable dt = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(dt);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<GTMIS.Model.T_SysUser> DataTableToList(DataTable dt)
        {
            List<GTMIS.Model.T_SysUser> modelList = new List<GTMIS.Model.T_SysUser>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                GTMIS.Model.T_SysUser model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new GTMIS.Model.T_SysUser();
                    if (dt.Rows[n]["FUserID"].ToString() != "")
                    {
                        model.FUserID = int.Parse(dt.Rows[n]["FUserID"].ToString());
                    }
                    model.FUserName = dt.Rows[n]["FUserName"].ToString();
                    model.FPassword = dt.Rows[n]["FPassword"].ToString();
                    if (dt.Rows[n]["FRowID"].ToString() != "")
                    {
                        model.FRowID = int.Parse(dt.Rows[n]["FRowID"].ToString());
                    }
                    if (dt.Rows[n]["FDeptID"].ToString() != "")
                    {
                        model.FDeptID = int.Parse(dt.Rows[n]["FDeptID"].ToString());
                    }
                    if (dt.Rows[n]["FTitleID"].ToString() != "")
                    {
                        model.FTitleID = int.Parse(dt.Rows[n]["FTitleID"].ToString());
                    }
                    model.CreateBy = dt.Rows[n]["CreateBy"].ToString();
                    if (dt.Rows[n]["CreateDate"].ToString() != "")
                    {
                        model.CreateDate = DateTime.Parse(dt.Rows[n]["CreateDate"].ToString());
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