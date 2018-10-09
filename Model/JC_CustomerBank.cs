using System;
namespace Model
{
    /// <summary>
    /// JC_CustomerBank:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class JC_CustomerBank
    {
        public JC_CustomerBank()
        { }
        #region Model
        private int _id;
        private int? _custid;
        private string _cardname;
        private string _bankname;
        private string _bankcard;
        private string _openbak;
        private string _bakprovince;
        private string _bakcity;
        private int _cardtype = 1;
        private string _banktype = "";
        private DateTime _createtime = DateTime.Now;
        private int _isdelete = 0;
        private string _remark;
        private string _reservemobile = "";
        private string _cardnum = "";
        private string _bankname2reapal = "";
        private string _bankcode2reapal = "";
        private string _bindid2reapal = "";
        /// <summary>
        /// 编号
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int? CustId
        {
            set { _custid = value; }
            get { return _custid; }
        }
        /// <summary>
        /// 持卡人
        /// </summary>
        public string CardName
        {
            set { _cardname = value; }
            get { return _cardname; }
        }
        /// <summary>
        /// 银行名称
        /// </summary>
        public string BankName
        {
            set { _bankname = value; }
            get { return _bankname; }
        }
        /// <summary>
        /// 银行卡号码
        /// </summary>
        public string BankCard
        {
            set { _bankcard = value; }
            get { return _bankcard; }
        }
        /// <summary>
        /// 支行名称
        /// </summary>
        public string OpenBak
        {
            set { _openbak = value; }
            get { return _openbak; }
        }
        /// <summary>
        /// 银行省份
        /// </summary>
        public string BakProvince
        {
            set { _bakprovince = value; }
            get { return _bakprovince; }
        }
        /// <summary>
        /// 银行城市
        /// </summary>
        public string BakCity
        {
            set { _bakcity = value; }
            get { return _bakcity; }
        }
        /// <summary>
        /// 卡种 1 储蓄卡/借记卡 2 信用卡/贷记卡 
        /// </summary>
        public int CardType
        {
            set { _cardtype = value; }
            get { return _cardtype; }
        }
        /// <summary>
        /// 银行类型，小写全称首字母 如中国人民银行 zgrmyh
        /// </summary>
        public string BankType
        {
            set { _banktype = value; }
            get { return _banktype; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDelete
        {
            set { _isdelete = value; }
            get { return _isdelete; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 银行卡预留手机号
        /// </summary>
        public string ReserveMobile
        {
            set { _reservemobile = value; }
            get { return _reservemobile; }
        }
        /// <summary>
        /// 身份证
        /// </summary>
        public string CardNum
        {
            set { _cardnum = value; }
            get { return _cardnum; }
        }
        /// <summary>
        /// 来自融宝返回的银行名称
        /// </summary>
        public string BankName2Reapal
        {
            set { _bankname2reapal = value; }
            get { return _bankname2reapal; }
        }
        /// <summary>
        /// 来自融宝返回的银行代码
        /// </summary>
        public string BankCode2Reapal
        {
            set { _bankcode2reapal = value; }
            get { return _bankcode2reapal; }
        }
        /// <summary>
        /// 来自融宝返回的绑卡编号
        /// </summary>
        public string BindId2Reapal
        {
            set { _bindid2reapal = value; }
            get { return _bindid2reapal; }
        }
        #endregion Model

    }
}

