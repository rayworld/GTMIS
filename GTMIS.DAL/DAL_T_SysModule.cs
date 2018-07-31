using Ray.Framework.DBUtility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GTMIS.DAL
{
    //T_SysModule
    public partial class DAL_T_SysModule
    {
        
        private static readonly string conn = SqlHelper.GetConnectionString("GTMIS");

        public bool Exists(int FModuleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_SysModule");
            strSql.Append(" where ");
            strSql.Append(" FModuleID = @FModuleID  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@FModuleID", SqlDbType.Int,4)         };
            parameters[0].Value = FModuleID;

            //return DbHelperSQL.Exists(strSql.ToString(),parameters);
            object obj = SqlHelper.ExecuteScalar(conn, strSql.ToString(), parameters);
            if (obj != null && int.Parse(obj.ToString()) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(GTMIS.Model.T_SysModule model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_SysModule(");
            strSql.Append("FModuleID,FModuleName,FParent,FIcon,FURL,FCreateDate,FCreateBy");
            strSql.Append(") values (");
            strSql.Append("@FModuleID,@FModuleName,@FParent,@FIcon,@FURL,@FCreateDate,@FCreateBy");
            strSql.Append(") ");

            SqlParameter[] parameters = {
                        new SqlParameter("@FModuleID", SqlDbType.Int,4) ,
                        new SqlParameter("@FModuleName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FParent", SqlDbType.Int,4) ,
                        new SqlParameter("@FIcon", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FURL", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FCreateDate", SqlDbType.DateTime) ,
                        new SqlParameter("@FCreateBy", SqlDbType.NVarChar,50)

            };

            parameters[0].Value = model.FModuleID;
            parameters[1].Value = model.FModuleName;
            parameters[2].Value = model.FParent;
            parameters[3].Value = model.FIcon;
            parameters[4].Value = model.FURL;
            parameters[5].Value = model.FCreateDate;
            parameters[6].Value = model.FCreateBy;
            //DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            SqlHelper.ExecuteScalar(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysModule model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_SysModule set ");

            strSql.Append(" FModuleID = @FModuleID , ");
            strSql.Append(" FModuleName = @FModuleName , ");
            strSql.Append(" FParent = @FParent , ");
            strSql.Append(" FIcon = @FIcon , ");
            strSql.Append(" FURL = @FURL , ");
            strSql.Append(" FCreateDate = @FCreateDate , ");
            strSql.Append(" FCreateBy = @FCreateBy  ");
            strSql.Append(" where FModuleID=@FModuleID  ");

            SqlParameter[] parameters = {
                        new SqlParameter("@FModuleID", SqlDbType.Int,4) ,
                        new SqlParameter("@FModuleName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FParent", SqlDbType.Int,4) ,
                        new SqlParameter("@FIcon", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FURL", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FCreateDate", SqlDbType.DateTime) ,
                        new SqlParameter("@FCreateBy", SqlDbType.NVarChar,50)

            };

            parameters[0].Value = model.FModuleID;
            parameters[1].Value = model.FModuleName;
            parameters[2].Value = model.FParent;
            parameters[3].Value = model.FIcon;
            parameters[4].Value = model.FURL;
            parameters[5].Value = model.FCreateDate;
            parameters[6].Value = model.FCreateBy;
            //int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            int rows = SqlHelper.ExecuteNonQuery(conn, strSql.ToString(), parameters);

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FModuleID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_SysModule ");
            strSql.Append(" where FModuleID=@FModuleID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@FModuleID", SqlDbType.Int,4)         };
            parameters[0].Value = FModuleID;


            //int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            int rows = SqlHelper.ExecuteNonQuery(conn, strSql.ToString(), parameters);

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GTMIS.Model.T_SysModule GetModel(int FModuleID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FModuleID, FModuleName, FParent, FIcon, FURL, FCreateDate, FCreateBy  ");
            strSql.Append("  from T_SysModule ");
            strSql.Append(" where FModuleID=@FModuleID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@FModuleID", SqlDbType.Int,4)         };
            parameters[0].Value = FModuleID;


            GTMIS.Model.T_SysModule model = new GTMIS.Model.T_SysModule();
            //DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
            DataTable dt = SqlHelper.ExecuteDataTable(conn, strSql.ToString(), parameters);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["FModuleID"].ToString() != "")
                {
                    model.FModuleID = int.Parse(dt.Rows[0]["FModuleID"].ToString());
                }
                model.FModuleName = dt.Rows[0]["FModuleName"].ToString();
                if (dt.Rows[0]["FParent"].ToString() != "")
                {
                    model.FParent = int.Parse(dt.Rows[0]["FParent"].ToString());
                }
                model.FIcon = dt.Rows[0]["FIcon"].ToString();
                model.FURL = dt.Rows[0]["FURL"].ToString();
                if (dt.Rows[0]["FCreateDate"].ToString() != "")
                {
                    model.FCreateDate = DateTime.Parse(dt.Rows[0]["FCreateDate"].ToString());
                }
                model.FCreateBy = dt.Rows[0]["FCreateBy"].ToString();

                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM T_SysModule ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            //return DbHelperSQL.Query(strSql.ToString());
            return SqlHelper.ExecuteDataTable(conn, strSql.ToString());

        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataTable GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM T_SysModule ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            //return DbHelperSQL.Query(strSql.ToString());
            return SqlHelper.ExecuteDataTable(conn, strSql.ToString());
        }


    }
}

