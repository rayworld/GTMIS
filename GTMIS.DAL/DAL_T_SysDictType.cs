using Ray.Framework.DBUtility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GTMIS.DAL
{
    //T_SysDictType
    public partial class DAL_T_SysDictType
    {
        //Get connection string 
        private static readonly string conn = SqlHelper.GetConnectionString("GTMIS");

        public bool Exists(int FDictTypeId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_SysDictType");
            strSql.Append(" where ");
            strSql.Append(" FDictTypeId = @FDictTypeId  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@FDictTypeId", SqlDbType.Int,4)
            };
            parameters[0].Value = FDictTypeId;

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
        public int Add(GTMIS.Model.T_SysDictType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_SysDictType(");
            strSql.Append("FTypeName,FParentId,FCreateBy,FCreateDate");
            strSql.Append(") values (");
            strSql.Append("@FTypeName,@FParentId,@FCreateBy,@FCreateDate");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@FTypeName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FParentId", SqlDbType.Int,4) ,
                        new SqlParameter("@FCreateBy", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FCreateDate", SqlDbType.DateTime)

            };

            parameters[0].Value = model.FTypeName;
            parameters[1].Value = model.FParentId;
            parameters[2].Value = model.FCreateBy;
            parameters[3].Value = model.FCreateDate;

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
        public bool Update(GTMIS.Model.T_SysDictType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_SysDictType set ");

            strSql.Append(" FTypeName = @FTypeName , ");
            strSql.Append(" FParentId = @FParentId , ");
            strSql.Append(" FCreateBy = @FCreateBy , ");
            strSql.Append(" FCreateDate = @FCreateDate  ");
            strSql.Append(" where FDictTypeId=@FDictTypeId ");

            SqlParameter[] parameters = {
                        new SqlParameter("@FDictTypeId", SqlDbType.Int,4) ,
                        new SqlParameter("@FTypeName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FParentId", SqlDbType.Int,4) ,
                        new SqlParameter("@FCreateBy", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@FCreateDate", SqlDbType.DateTime)

            };

            parameters[0].Value = model.FDictTypeId;
            parameters[1].Value = model.FTypeName;
            parameters[2].Value = model.FParentId;
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
        public bool Delete(int FDictTypeId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_SysDictType ");
            strSql.Append(" where FDictTypeId=@FDictTypeId");
            SqlParameter[] parameters = {
                    new SqlParameter("@FDictTypeId", SqlDbType.Int,4)
            };
            parameters[0].Value = FDictTypeId;


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
        public bool DeleteList(string FDictTypeIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_SysDictType ");
            strSql.Append(" where ID in (" + FDictTypeIdlist + ")  ");
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
        public GTMIS.Model.T_SysDictType GetModel(int FDictTypeId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select FDictTypeId, FTypeName, FParentId, FCreateBy, FCreateDate  ");
            strSql.Append("  from T_SysDictType ");
            strSql.Append(" where FDictTypeId=@FDictTypeId");
            SqlParameter[] parameters = {
                    new SqlParameter("@FDictTypeId", SqlDbType.Int,4)
            };
            parameters[0].Value = FDictTypeId;


            GTMIS.Model.T_SysDictType model = new GTMIS.Model.T_SysDictType();
            //DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
            DataTable dt = SqlHelper.ExecuteDataTable(conn, strSql.ToString(), parameters);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["FDictTypeId"].ToString() != "")
                {
                    model.FDictTypeId = int.Parse(dt.Rows[0]["FDictTypeId"].ToString());
                }
                model.FTypeName = dt.Rows[0]["FTypeName"].ToString();
                if (dt.Rows[0]["FParentId"].ToString() != "")
                {
                    model.FParentId = int.Parse(dt.Rows[0]["FParentId"].ToString());
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
            strSql.Append(" FROM T_SysDictType ");
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
            strSql.Append(" FROM T_SysDictType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            //return DbHelperSQL.Query(strSql.ToString());
            return SqlHelper.ExecuteDataTable(conn, strSql.ToString());
        }

        /// <summary>
        /// 调用分页过程，通用分页
        /// </summary>
        /// <param name="Conn"></param>
        /// <param name="tableName"></param>
        /// <param name="primaryKey"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="queryOrder"></param>
        /// <param name="queryFieldName"></param>
        /// <param name="queryCondition"></param>
        /// <param name="queryGroup"></param>
        /// <returns></returns>
        public DataTable GetListByPage(string tableName,
            string primaryKey,
            int pageIndex,
            int pageSize,
            string queryOrder,
            string queryFieldName,
            string queryCondition,
            string queryGroup)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@Tables", SqlDbType.VarChar, 255),
                    new SqlParameter("@PrimaryKey" , SqlDbType.VarChar , 255),
                    new SqlParameter("@Sort", SqlDbType.VarChar , 255 ),
                    new SqlParameter("@CurrentPage", SqlDbType.Int),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@Fields", SqlDbType.VarChar, 255),
                    new SqlParameter("@Filter", SqlDbType.VarChar,1000),
                    new SqlParameter("@Group" ,SqlDbType.VarChar , 1000 )
                    };
            parameters[0].Value = tableName;
            parameters[1].Value = primaryKey;
            parameters[2].Value = queryOrder;
            parameters[3].Value = pageIndex;
            parameters[4].Value = pageSize;
            parameters[5].Value = queryFieldName;
            parameters[6].Value = queryCondition;
            parameters[7].Value = queryGroup;
            DataTable dt = SqlHelper.ExecuteDataSet(conn, CommandType.StoredProcedure, "SP_Pagination", parameters).Tables[0];

            return dt;
        }

        /// <summary>
        /// 得到指定条件下的记录数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="queryCondition"></param>
        /// <returns></returns>
        public int GetRecCount(string tableName, string queryCondition)
        {
            string strSql = " SELECT COUNT(1) FROM " + tableName;
            if (queryCondition != string.Empty)
            {
                strSql += " WHERE " + queryCondition;
            }
            return int.Parse(SqlHelper.ExecuteScalar(conn, strSql).ToString());
        }

        /// <summary>
        /// 通过名称查询编号
        /// </summary>
        /// <param name="deptName">实体名称列</param>
        /// <returns></returns>
        public int GetDeptIdByName(string nameField)
        {
            string strSql = String.Format(" Select FDeptId From T_SysDept Where [FDeptName] = '{0}' ", nameField);

            object obj = SqlHelper.ExecuteScalar(conn, strSql).ToString();

            if (obj != null && !string.IsNullOrEmpty(obj.ToString()))
            {
                return int.Parse(obj.ToString());
            }
            else
            {
                return 0;
            }
        }
    }
}

