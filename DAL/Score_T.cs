using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace DAL
{
    /// <summary>
    /// 数据访问类:Score_T
    /// </summary>
    public partial class Score_T
    {
        public Score_T()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ScoreID", "Score_T");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ScoreID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Score_T");
            strSql.Append(" where ScoreID=@ScoreID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ScoreID", SqlDbType.Int,4)           };
            parameters[0].Value = ScoreID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.Score_T model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Score_T(");
            strSql.Append("StudentID,ScoreNum)");
            strSql.Append(" values (");
            strSql.Append("@StudentID,@ScoreNum)");
            SqlParameter[] parameters = {
                   // new SqlParameter("@ScoreID", SqlDbType.Int,4),
                    new SqlParameter("@StudentID", SqlDbType.Int,4),
                    new SqlParameter("@ScoreNum", SqlDbType.Decimal,9)};
           // parameters[0].Value = model.ScoreID;
            parameters[0].Value = model.StudentID;
            parameters[1].Value = model.ScoreNum;

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
        public bool Update(Model.Score_T model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Score_T set ");
            strSql.Append("StudentID=@StudentID,");
            strSql.Append("ScoreNum=@ScoreNum");
            strSql.Append(" where ScoreID=@ScoreID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@StudentID", SqlDbType.Int,4),
                    new SqlParameter("@ScoreNum", SqlDbType.Decimal,9),
                    new SqlParameter("@ScoreID", SqlDbType.Int,4)};
            parameters[0].Value = model.StudentID;
            parameters[1].Value = model.ScoreNum;
            parameters[2].Value = model.ScoreID;

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
        public bool Delete(int ScoreID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Score_T ");
            strSql.Append(" where ScoreID=@ScoreID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ScoreID", SqlDbType.Int,4)           };
            parameters[0].Value = ScoreID;

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
        public bool DeleteList(string ScoreIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Score_T ");
            strSql.Append(" where ScoreID in (" + ScoreIDlist + ")  ");
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
        public Model.Score_T GetModel(int ScoreID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ScoreID,StudentID,ScoreNum from Score_T ");
            strSql.Append(" where ScoreID=@ScoreID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ScoreID", SqlDbType.Int,4)           };
            parameters[0].Value = ScoreID;

            Model.Score_T model = new Model.Score_T();
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
        public Model.Score_T DataRowToModel(DataRow row)
        {
            Model.Score_T model = new Model.Score_T();
            if (row != null)
            {
                if (row["ScoreID"] != null && row["ScoreID"].ToString() != "")
                {
                    model.ScoreID = int.Parse(row["ScoreID"].ToString());
                }
                if (row["StudentID"] != null && row["StudentID"].ToString() != "")
                {
                    model.StudentID = int.Parse(row["StudentID"].ToString());
                }
                if (row["ScoreNum"] != null && row["ScoreNum"].ToString() != "")
                {
                    model.ScoreNum = decimal.Parse(row["ScoreNum"].ToString());
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
            strSql.Append("select ScoreID,StudentID,ScoreNum ");
            strSql.Append(" FROM Score_T ");
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
            strSql.Append(" ScoreID,StudentID,ScoreNum ");
            strSql.Append(" FROM Score_T ");
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
            strSql.Append("select count(1) FROM Score_T ");
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
                strSql.Append("order by T.ScoreID desc");
            }
            strSql.Append(")AS Row, T.*  from Score_T T ");
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
			parameters[0].Value = "Score_T";
			parameters[1].Value = "ScoreID";
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

