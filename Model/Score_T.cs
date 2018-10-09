using System;
namespace Model
{
    /// <summary>
    /// Score_T:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Score_T
    {
        public Score_T()
        { }
        #region Model
        private int _scoreid;
        private int? _studentid;
        private decimal? _scorenum;
        /// <summary>
        /// 
        /// </summary>
        public int ScoreID
        {
            set { _scoreid = value; }
            get { return _scoreid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StudentID
        {
            set { _studentid = value; }
            get { return _studentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ScoreNum
        {
            set { _scorenum = value; }
            get { return _scorenum; }
        }
        #endregion Model

    }
}

