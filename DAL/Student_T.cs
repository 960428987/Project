using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace DAL
{
    /// <summary>
    /// 数据访问类:Student_T
    /// </summary>
    public partial class Student_T
    {
        public Student_T()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("StudentID", "Student_T");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int StudentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Student_T");
            strSql.Append(" where StudentID=@StudentID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@StudentID", SqlDbType.Int,4)         };
            parameters[0].Value = StudentID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.Student_T model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Student_T(");
            strSql.Append("Name,Age)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Age)");
            SqlParameter[] parameters = {
                    //new SqlParameter("@StudentID", SqlDbType.Int,4),
                    new SqlParameter("@Name", SqlDbType.NVarChar,50),
                    new SqlParameter("@Age", SqlDbType.Int,4)};
           // parameters[0].Value = model.StudentID;
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Age;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Student_T model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Student_T set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Age=@Age");
            strSql.Append(" where StudentID=@StudentID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Name", SqlDbType.NVarChar,50),
                    new SqlParameter("@Age", SqlDbType.Int,4),
                    new SqlParameter("@StudentID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Age;
            parameters[2].Value = model.StudentID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int StudentID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Student_T ");
            strSql.Append(" where StudentID=@StudentID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@StudentID", SqlDbType.Int,4)         };
            parameters[0].Value = StudentID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string StudentIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Student_T ");
            strSql.Append(" where StudentID in (" + StudentIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Model.Student_T GetModel(int StudentID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 StudentID,Name,Age from Student_T ");
            strSql.Append(" where StudentID=@StudentID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@StudentID", SqlDbType.Int,4)         };
            parameters[0].Value = StudentID;

            Model.Student_T model = new Model.Student_T();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Student_T DataRowToModel(DataRow row)
        {
            Model.Student_T model = new Model.Student_T();
            if (row != null)
            {
                if (row["StudentID"] != null && row["StudentID"].ToString() != "")
                {
                    model.StudentID = int.Parse(row["StudentID"].ToString());
                }
                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["Age"] != null && row["Age"].ToString() != "")
                {
                    model.Age = int.Parse(row["Age"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select StudentID,Name,Age ");
            strSql.Append(" FROM Student_T ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" StudentID,Name,Age ");
            strSql.Append(" FROM Student_T ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Student_T ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.StudentID desc");
            }
            strSql.Append(")AS Row, T.*  from Student_T T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Student_T";
			parameters[1].Value = "StudentID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

