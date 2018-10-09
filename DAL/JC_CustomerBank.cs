using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace DAL
{
    /// <summary>
    /// 数据访问类:JC_CustomerBank
    /// </summary>
    public partial class JC_CustomerBank
    {
        public JC_CustomerBank()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from JC_CustomerBank");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)
            };
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.JC_CustomerBank model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into JC_CustomerBank(");
            strSql.Append("CustId,CardName,BankName,BankCard,OpenBak,BakProvince,BakCity,CardType,BankType,CreateTime,IsDelete,Remark,ReserveMobile,CardNum,BankName2Reapal,BankCode2Reapal,BindId2Reapal)");
            strSql.Append(" values (");
            strSql.Append("@CustId,@CardName,@BankName,@BankCard,@OpenBak,@BakProvince,@BakCity,@CardType,@BankType,@CreateTime,@IsDelete,@Remark,@ReserveMobile,@CardNum,@BankName2Reapal,@BankCode2Reapal,@BindId2Reapal)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@CustId", SqlDbType.Int,4),
                    new SqlParameter("@CardName", SqlDbType.NVarChar,20),
                    new SqlParameter("@BankName", SqlDbType.NVarChar,100),
                    new SqlParameter("@BankCard", SqlDbType.NVarChar,25),
                    new SqlParameter("@OpenBak", SqlDbType.NVarChar,100),
                    new SqlParameter("@BakProvince", SqlDbType.NVarChar,50),
                    new SqlParameter("@BakCity", SqlDbType.NVarChar,50),
                    new SqlParameter("@CardType", SqlDbType.Int,4),
                    new SqlParameter("@BankType", SqlDbType.VarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@IsDelete", SqlDbType.Int,4),
                    new SqlParameter("@Remark", SqlDbType.VarChar,100),
                    new SqlParameter("@ReserveMobile", SqlDbType.VarChar,50),
                    new SqlParameter("@CardNum", SqlDbType.VarChar,50),
                    new SqlParameter("@BankName2Reapal", SqlDbType.VarChar,50),
                    new SqlParameter("@BankCode2Reapal", SqlDbType.VarChar,50),
                    new SqlParameter("@BindId2Reapal", SqlDbType.VarChar,50)};
            parameters[0].Value = model.CustId;
            parameters[1].Value = model.CardName;
            parameters[2].Value = model.BankName;
            parameters[3].Value = model.BankCard;
            parameters[4].Value = model.OpenBak;
            parameters[5].Value = model.BakProvince;
            parameters[6].Value = model.BakCity;
            parameters[7].Value = model.CardType;
            parameters[8].Value = model.BankType;
            parameters[9].Value = model.CreateTime;
            parameters[10].Value = model.IsDelete;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.ReserveMobile;
            parameters[13].Value = model.CardNum;
            parameters[14].Value = model.BankName2Reapal;
            parameters[15].Value = model.BankCode2Reapal;
            parameters[16].Value = model.BindId2Reapal;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(Model.JC_CustomerBank model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update JC_CustomerBank set ");
            strSql.Append("CustId=@CustId,");
            strSql.Append("CardName=@CardName,");
            strSql.Append("BankName=@BankName,");
            strSql.Append("BankCard=@BankCard,");
            strSql.Append("OpenBak=@OpenBak,");
            strSql.Append("BakProvince=@BakProvince,");
            strSql.Append("BakCity=@BakCity,");
            strSql.Append("CardType=@CardType,");
            strSql.Append("BankType=@BankType,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("IsDelete=@IsDelete,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("ReserveMobile=@ReserveMobile,");
            strSql.Append("CardNum=@CardNum,");
            strSql.Append("BankName2Reapal=@BankName2Reapal,");
            strSql.Append("BankCode2Reapal=@BankCode2Reapal,");
            strSql.Append("BindId2Reapal=@BindId2Reapal");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@CustId", SqlDbType.Int,4),
                    new SqlParameter("@CardName", SqlDbType.NVarChar,20),
                    new SqlParameter("@BankName", SqlDbType.NVarChar,100),
                    new SqlParameter("@BankCard", SqlDbType.NVarChar,25),
                    new SqlParameter("@OpenBak", SqlDbType.NVarChar,100),
                    new SqlParameter("@BakProvince", SqlDbType.NVarChar,50),
                    new SqlParameter("@BakCity", SqlDbType.NVarChar,50),
                    new SqlParameter("@CardType", SqlDbType.Int,4),
                    new SqlParameter("@BankType", SqlDbType.VarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@IsDelete", SqlDbType.Int,4),
                    new SqlParameter("@Remark", SqlDbType.VarChar,100),
                    new SqlParameter("@ReserveMobile", SqlDbType.VarChar,50),
                    new SqlParameter("@CardNum", SqlDbType.VarChar,50),
                    new SqlParameter("@BankName2Reapal", SqlDbType.VarChar,50),
                    new SqlParameter("@BankCode2Reapal", SqlDbType.VarChar,50),
                    new SqlParameter("@BindId2Reapal", SqlDbType.VarChar,50),
                    new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.CustId;
            parameters[1].Value = model.CardName;
            parameters[2].Value = model.BankName;
            parameters[3].Value = model.BankCard;
            parameters[4].Value = model.OpenBak;
            parameters[5].Value = model.BakProvince;
            parameters[6].Value = model.BakCity;
            parameters[7].Value = model.CardType;
            parameters[8].Value = model.BankType;
            parameters[9].Value = model.CreateTime;
            parameters[10].Value = model.IsDelete;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.ReserveMobile;
            parameters[13].Value = model.CardNum;
            parameters[14].Value = model.BankName2Reapal;
            parameters[15].Value = model.BankCode2Reapal;
            parameters[16].Value = model.BindId2Reapal;
            parameters[17].Value = model.Id;

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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from JC_CustomerBank ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)
            };
            parameters[0].Value = Id;

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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from JC_CustomerBank ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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
        public Model.JC_CustomerBank GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,CustId,CardName,BankName,BankCard,OpenBak,BakProvince,BakCity,CardType,BankType,CreateTime,IsDelete,Remark,ReserveMobile,CardNum,BankName2Reapal,BankCode2Reapal,BindId2Reapal from JC_CustomerBank ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)
            };
            parameters[0].Value = Id;

            Model.JC_CustomerBank model = new Model.JC_CustomerBank();
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
        public Model.JC_CustomerBank DataRowToModel(DataRow row)
        {
            Model.JC_CustomerBank model = new Model.JC_CustomerBank();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["CustId"] != null && row["CustId"].ToString() != "")
                {
                    model.CustId = int.Parse(row["CustId"].ToString());
                }
                if (row["CardName"] != null)
                {
                    model.CardName = row["CardName"].ToString();
                }
                if (row["BankName"] != null)
                {
                    model.BankName = row["BankName"].ToString();
                }
                if (row["BankCard"] != null)
                {
                    model.BankCard = row["BankCard"].ToString();
                }
                if (row["OpenBak"] != null)
                {
                    model.OpenBak = row["OpenBak"].ToString();
                }
                if (row["BakProvince"] != null)
                {
                    model.BakProvince = row["BakProvince"].ToString();
                }
                if (row["BakCity"] != null)
                {
                    model.BakCity = row["BakCity"].ToString();
                }
                if (row["CardType"] != null && row["CardType"].ToString() != "")
                {
                    model.CardType = int.Parse(row["CardType"].ToString());
                }
                if (row["BankType"] != null)
                {
                    model.BankType = row["BankType"].ToString();
                }
                if (row["CreateTime"] != null && row["CreateTime"].ToString() != "")
                {
                    model.CreateTime = DateTime.Parse(row["CreateTime"].ToString());
                }
                if (row["IsDelete"] != null && row["IsDelete"].ToString() != "")
                {
                    model.IsDelete = int.Parse(row["IsDelete"].ToString());
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["ReserveMobile"] != null)
                {
                    model.ReserveMobile = row["ReserveMobile"].ToString();
                }
                if (row["CardNum"] != null)
                {
                    model.CardNum = row["CardNum"].ToString();
                }
                if (row["BankName2Reapal"] != null)
                {
                    model.BankName2Reapal = row["BankName2Reapal"].ToString();
                }
                if (row["BankCode2Reapal"] != null)
                {
                    model.BankCode2Reapal = row["BankCode2Reapal"].ToString();
                }
                if (row["BindId2Reapal"] != null)
                {
                    model.BindId2Reapal = row["BindId2Reapal"].ToString();
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
            strSql.Append("select Id,CustId,CardName,BankName,BankCard,OpenBak,BakProvince,BakCity,CardType,BankType,CreateTime,IsDelete,Remark,ReserveMobile,CardNum,BankName2Reapal,BankCode2Reapal,BindId2Reapal ");
            strSql.Append(" FROM JC_CustomerBank ");
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
            strSql.Append(" Id,CustId,CardName,BankName,BankCard,OpenBak,BakProvince,BakCity,CardType,BankType,CreateTime,IsDelete,Remark,ReserveMobile,CardNum,BankName2Reapal,BankCode2Reapal,BindId2Reapal ");
            strSql.Append(" FROM JC_CustomerBank ");
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
            strSql.Append("select count(1) FROM JC_CustomerBank ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from JC_CustomerBank T ");
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
			parameters[0].Value = "JC_CustomerBank";
			parameters[1].Value = "Id";
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

