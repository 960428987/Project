using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;
using Maticsoft.DBUtility;
using System.Collections;
using System.Data.SqlClient;

namespace ProjectDemoWebAPI.获取数据列表
{
    public partial class getDataList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLL.JC_CustomerBank jC_CustomerBank_BLL = new BLL.JC_CustomerBank();
            DataTable dt = jC_CustomerBank_BLL.GetList("").Tables[0];
            Model.JC_CustomerBank jC_CustomerBank_Model = new Model.JC_CustomerBank();
            jC_CustomerBank_Model.BankCard = "1";
            DataList1.DataSource = dt;
            DataList1.DataBind();
            B b = new B();
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            Model.Score_T score_T_M = new Model.Score_T();
            Model.Student_T student_T_M = new Model.Student_T();
            BLL.Score_T score_T_B = new BLL.Score_T();
            BLL.Student_T student_T_B = new BLL.Student_T();
            score_T_M.ScoreNum = Convert.ToDecimal(ScoreNum.Text);
            score_T_M.StudentID = Convert.ToInt16(student_T_B.GetMaxId());
            student_T_M.Age = Convert.ToInt16(Age.Text);
            student_T_M.Name = Name.Text;
            Hashtable ht = new Hashtable();
            SqlParameter[] ScoreParameters = {
                    new SqlParameter("@StudentID", SqlDbType.Int,4),
                    new SqlParameter("@ScoreNum", SqlDbType.Decimal,9)};
            ScoreParameters[0].Value = score_T_M.StudentID;
            ScoreParameters[1].Value = score_T_M.ScoreNum;
            SqlParameter[] StudentParameters = {
                 new SqlParameter( "@Name", SqlDbType.NVarChar,50),
                    new SqlParameter("@Age", SqlDbType.Int,4)
                   };
            StudentParameters[0].Value = student_T_M.Name;
            StudentParameters[1].Value = student_T_M.Age;
            ht.Add("insert into Student_T(Name,Age) values (@Name,@Age)", StudentParameters);
            ht.Add("insert into Score_T(StudentID,ScoreNum) values (@StudentID,@ScoreNum)", ScoreParameters);
            DbHelperSQL.ExecuteSqlTran(ht);//执行sql,实现事务
        }
    }

    public class A
    {
        public A()
        {

        }
        public virtual void eat() { }
    }
    class B :A
    {
        int x = 1;
        int y;
        string s;
        public B()
        {
            y = -1;
            eat();
        }
        public override void eat()
        {
            Console.WriteLine("x = {0},y = {1}",x,y);
            base.eat();
        }
    }
}