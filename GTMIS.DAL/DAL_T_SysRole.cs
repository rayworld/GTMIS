using Ray.Framework.DBUtility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GTMIS.DAL
{
    //T_SysRole
    public partial class DAL_T_SysRole
    {
        //Get connection string 
        private static readonly string conn = SqlHelper.GetConnectionString("GTMIS");

        public bool Exists(int FRoleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_SysRole");
            strSql.Append(" where ");
            strSql.Append(" FRoleID = @FRoleID  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@FRoleID", SqlDbType.Int,4)
            };
            parameters[0].Value = FRoleID;

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
        public int Add(GTMIS.Model.T_SysRole model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_SysRole(");
            strSql.Append("FRoleName,FRoleDesc,FCreateDate,FCreateBy");
            strSql.Append(") values (");
            strSql.Append("@FRoleName,@FRoleDesc,@FCreateDate,@FCreateBy");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@FRoleName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FRoleDesc", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FCreateDate", SqlDbType.DateTime) ,
                        new SqlParameter("@FCreateBy", SqlDbType.NVarChar,50)

            };

            parameters[0].Value = model.FRoleName;
            parameters[1].Value = model.FRoleDesc;
            parameters[2].Value = model.FCreateDate;
            parameters[3].Value = model.FCreateBy;

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
        public bool Update(GTMIS.Model.T_SysRole model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_SysRole set ");

            strSql.Append(" FRoleName = @FRoleName , ");
            strSql.Append(" FRoleDesc = @FRoleDesc , ");
            strSql.Append(" FCreateDate = @FCreateDate , ");
            strSql.Append(" FCreateBy = @FCreateBy  ");
            strSql.Append(" where FRoleID=@FRoleID ");

            SqlParameter[] parameters = {
                        new SqlParameter("@FRoleID", SqlDbType.Int,4) ,
                        new SqlParameter("@FRoleName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FRoleDesc", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FCreateDate", SqlDbType.DateTime) ,
                        new SqlParameter("@FCreateBy", SqlDbType.NVarChar,50)

            };

            parameters[0].Value = model.FRoleID;
            parameters[1].Value = model.FRoleName;
            parameters[2].Value = model.FRoleDesc;
            parameters[3].Value = model.FCreateDate;
            parameters[4].Value = model.FCreateBy;
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
        public bool Delete(int FRoleID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_SysRole ");
            strSql.Append(" where FRoleID=@FRoleID");
            SqlParameter[] parameters = {
                    new SqlParameter("@FRoleID", SqlDbType.Int,4)
            };
            parameters[0].Value = FRoleID;


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
        public bool DeleteList(string FRoleIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_SysRole ");
            strSql.Append(" where ID in (" + FRoleIDlist + ")  ");
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
        public GTMIS.Model.T_SysRole GetModel(int FRoleID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FRoleID, FRoleName, FRoleDesc, FCreateDate, FCreateBy  ");
            strSql.Append("  from T_SysRole ");
            strSql.Append(" where FRoleID=@FRoleID");
            SqlParameter[] parameters = {
                    new SqlParameter("@FRoleID", SqlDbType.Int,4)
            };
            parameters[0].Value = FRoleID;


            GTMIS.Model.T_SysRole model = new GTMIS.Model.T_SysRole();
            //DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
            DataTable dt = SqlHelper.ExecuteDataTable(conn, strSql.ToString(), parameters);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["FRoleID"].ToString() != "")
                {
                    model.FRoleID = int.Parse(dt.Rows[0]["FRoleID"].ToString());
                }
                model.FRoleName = dt.Rows[0]["FRoleName"].ToString();
                model.FRoleDesc = dt.Rows[0]["FRoleDesc"].ToString();
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
            strSql.Append(" FROM T_SysRole ");
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
            strSql.Append(" FROM T_SysRole ");
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