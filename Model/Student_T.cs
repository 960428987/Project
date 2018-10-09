using System;
namespace Model
{
    /// <summary>
    /// Student_T:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Student_T
    {
        public Student_T()
        { }
        #region Model
        private int _studentid;
        private string _name;
        private int? _age;
        /// <summary>
        /// 
        /// </summary>
        public int StudentID
        {
            set { _studentid = value; }
            get { return _studentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Age
        {
            set { _age = value; }
            get { return _age; }
        }
        #endregion Model

    }
}

