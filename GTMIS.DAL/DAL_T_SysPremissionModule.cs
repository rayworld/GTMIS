using Ray.Framework.DBUtility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GTMIS.DAL
{
    //T_SysPremissionModule
    public partial class DAL_T_SysPremissionModule
    {
        //Get connection string 
        private static readonly string conn = SqlHelper.GetConnectionString("GTMIS");

        public bool Exists(int FPremissionModuleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_SysPremissionModule");
            strSql.Append(" where ");
            strSql.Append(" FPremissionModuleID = @FPremissionModuleID  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@FPremissionModuleID", SqlDbType.Int,4)           };
            parameters[0].Value = FPremissionModuleID;

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
        public void Add(GTMIS.Model.T_SysPremissionModule model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_SysPremissionModule(");
            strSql.Append("FPremissionModuleID,FPremissionID,FModulleID,FCreateBy,FCreateDate");
            strSql.Append(") values (");
            strSql.Append("@FPremissionModuleID,@FPremissionID,@FModulleID,@FCreateBy,@FCreateDate");
            strSql.Append(") ");

            SqlParameter[] parameters = {
                        new SqlParameter("@FPremissionModuleID", SqlDbType.Int,4) ,
                        new SqlParameter("@FPremissionID", SqlDbType.Int,4) ,
                        new SqlParameter("@FModulleID", SqlDbType.Int,4) ,
                        new SqlParameter("@FCreateBy", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FCreateDate", SqlDbType.DateTime)

            };

            parameters[0].Value = model.FPremissionModuleID;
            parameters[1].Value = model.FPremissionID;
            parameters[2].Value = model.FModulleID;
            parameters[3].Value = model.FCreateBy;
            parameters[4].Value = model.FCreateDate;
            //DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
            SqlHelper.ExecuteScalar(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysPremissionModule model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_SysPremissionModule set ");

            strSql.Append(" FPremissionModuleID = @FPremissionModuleID , ");
            strSql.Append(" FPremissionID = @FPremissionID , ");
            strSql.Append(" FModulleID = @FModulleID , ");
            strSql.Append(" FCreateBy = @FCreateBy , ");
            strSql.Append(" FCreateDate = @FCreateDate  ");
            strSql.Append(" where FPremissionModuleID=@FPremissionModuleID  ");

            SqlParameter[] parameters = {
                        new SqlParameter("@FPremissionModuleID", SqlDbType.Int,4) ,
                        new SqlParameter("@FPremissionID", SqlDbType.Int,4) ,
                        new SqlParameter("@FModulleID", SqlDbType.Int,4) ,
                        new SqlParameter("@FCreateBy", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FCreateDate", SqlDbType.DateTime)

            };

            parameters[0].Value = model.FPremissionModuleID;
            parameters[1].Value = model.FPremissionID;
            parameters[2].Value = model.FModulleID;
            parameters[3].Value = model.FCreateBy;
            parameters[4].Value = model.FCreateDate;
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
        public bool Delete(int FPremissionModuleID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_SysPremissionModule ");
            strSql.Append(" where FPremissionModuleID=@FPremissionModuleID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@FPremissionModuleID", SqlDbType.Int,4)           };
            parameters[0].Value = FPremissionModuleID;


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
        public GTMIS.Model.T_SysPremissionModule GetModel(int FPremissionModuleID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FPremissionModuleID, FPremissionID, FModulleID, FCreateBy, FCreateDate  ");
            strSql.Append("  from T_SysPremissionModule ");
            strSql.Append(" where FPremissionModuleID=@FPremissionModuleID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@FPremissionModuleID", SqlDbType.Int,4)           };
            parameters[0].Value = FPremissionModuleID;


            GTMIS.Model.T_SysPremissionModule model = new GTMIS.Model.T_SysPremissionModule();
            //DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
            DataTable dt = SqlHelper.ExecuteDataTable(conn, strSql.ToString(), parameters);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["FPremissionModuleID"].ToString() != "")
                {
                    model.FPremissionModuleID = int.Parse(dt.Rows[0]["FPremissionModuleID"].ToString());
                }
                if (dt.Rows[0]["FPremissionID"].ToString() != "")
                {
                    model.FPremissionID = int.Parse(dt.Rows[0]["FPremissionID"].ToString());
                }
                if (dt.Rows[0]["FModulleID"].ToString() != "")
                {
                    model.FModulleID = int.Parse(dt.Rows[0]["FModulleID"].ToString());
                }
                model.FCreateBy = dt.Rows[0]["FCreateBy"].ToString();
                if (dt.Rows[0]["FCreateDate"].ToString() != "")
                {
                    model.FCreateDate = DateTime.Parse(dt.Rows[0]["FCreateDate"].ToString());
                }

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
            strSql.Append(" FROM T_SysPremissionModule ");
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
            strSql.Append(" FROM T_SysPremissionModule ");
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