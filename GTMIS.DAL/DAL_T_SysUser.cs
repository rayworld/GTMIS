using Ray.Framework.DBUtility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GTMIS.DAL
{
    //T_SysUser
    public partial class DAL_T_SysUser
    {
        //Get connection string 
        private static readonly string conn = SqlHelper.GetConnectionString("GTMIS");

        public bool Exists(int FUserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_SysUser");
            strSql.Append(" where ");
            strSql.Append(" FUserID = @FUserID  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@FUserID", SqlDbType.Int,4)
            };
            parameters[0].Value = FUserID;

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
        public int Add(GTMIS.Model.T_SysUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_SysUser(");
            strSql.Append("FUserName,FPassword,FRowID,FDeptID,FTitleID,CreateBy,CreateDate");
            strSql.Append(") values (");
            strSql.Append("@FUserName,@FPassword,@FRowID,@FDeptID,@FTitleID,@CreateBy,@CreateDate");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@FUserName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FPassword", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FRowID", SqlDbType.Int,4) ,
                        new SqlParameter("@FDeptID", SqlDbType.Int,4) ,
                        new SqlParameter("@FTitleID", SqlDbType.Int,4) ,
                        new SqlParameter("@CreateBy", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@CreateDate", SqlDbType.DateTime)

            };

            parameters[0].Value = model.FUserName;
            parameters[1].Value = model.FPassword;
            parameters[2].Value = model.FRowID;
            parameters[3].Value = model.FDeptID;
            parameters[4].Value = model.FTitleID;
            parameters[5].Value = model.CreateBy;
            parameters[6].Value = model.CreateDate;

            //object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
            object obj = SqlHelper.ExecuteScalar(conn, strSql.ToString(), parameters);

            if (obj == null)
            {
                return 0;
            }
            else
            {

                return Convert.ToInt32(obj);

            }

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(GTMIS.Model.T_SysUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_SysUser set ");

            strSql.Append(" FUserName = @FUserName , ");
            strSql.Append(" FPassword = @FPassword , ");
            strSql.Append(" FRowID = @FRowID , ");
            strSql.Append(" FDeptID = @FDeptID , ");
            strSql.Append(" FTitleID = @FTitleID , ");
            strSql.Append(" CreateBy = @CreateBy , ");
            strSql.Append(" CreateDate = @CreateDate  ");
            strSql.Append(" where FUserID=@FUserID ");

            SqlParameter[] parameters = {
                        new SqlParameter("@FUserID", SqlDbType.Int,4) ,
                        new SqlParameter("@FUserName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FPassword", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FRowID", SqlDbType.Int,4) ,
                        new SqlParameter("@FDeptID", SqlDbType.Int,4) ,
                        new SqlParameter("@FTitleID", SqlDbType.Int,4) ,
                        new SqlParameter("@CreateBy", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@CreateDate", SqlDbType.DateTime)

            };

            parameters[0].Value = model.FUserID;
            parameters[1].Value = model.FUserName;
            parameters[2].Value = model.FPassword;
            parameters[3].Value = model.FRowID;
            parameters[4].Value = model.FDeptID;
            parameters[5].Value = model.FTitleID;
            parameters[6].Value = model.CreateBy;
            parameters[7].Value = model.CreateDate;
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
        public bool Delete(int FUserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_SysUser ");
            strSql.Append(" where FUserID=@FUserID");
            SqlParameter[] parameters = {
                    new SqlParameter("@FUserID", SqlDbType.Int,4)
            };
            parameters[0].Value = FUserID;


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
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string FUserIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_SysUser ");
            strSql.Append(" where ID in (" + FUserIDlist + ")  ");
            //int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
            int rows = SqlHelper.ExecuteNonQuery(conn, strSql.ToString());

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
        public GTMIS.Model.T_SysUser GetModel(int FUserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FUserID, FUserName, FPassword, FRowID, FDeptID, FTitleID, CreateBy, CreateDate  ");
            strSql.Append("  from T_SysUser ");
            strSql.Append(" where FUserID=@FUserID");
            SqlParameter[] parameters = {
                    new SqlParameter("@FUserID", SqlDbType.Int,4)
            };
            parameters[0].Value = FUserID;


            GTMIS.Model.T_SysUser model = new GTMIS.Model.T_SysUser();
            //DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
            DataTable dt = SqlHelper.ExecuteDataTable(conn, strSql.ToString(), parameters);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["FUserID"].ToString() != "")
                {
                    model.FUserID = int.Parse(dt.Rows[0]["FUserID"].ToString());
                }
                model.FUserName = dt.Rows[0]["FUserName"].ToString();
                model.FPassword = dt.Rows[0]["FPassword"].ToString();
                if (dt.Rows[0]["FRowID"].ToString() != "")
                {
                    model.FRowID = int.Parse(dt.Rows[0]["FRowID"].ToString());
                }
                if (dt.Rows[0]["FDeptID"].ToString() != "")
                {
                    model.FDeptID = int.Parse(dt.Rows[0]["FDeptID"].ToString());
                }
                if (dt.Rows[0]["FTitleID"].ToString() != "")
                {
                    model.FTitleID = int.Parse(dt.Rows[0]["FTitleID"].ToString());
                }
                model.CreateBy = dt.Rows[0]["CreateBy"].ToString();
                if (dt.Rows[0]["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(dt.Rows[0]["CreateDate"].ToString());
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
            strSql.Append(" FROM T_SysUser ");
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
            strSql.Append(" FROM T_SysUser ");
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