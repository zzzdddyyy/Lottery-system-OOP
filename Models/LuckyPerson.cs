using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 中奖人员信息的实体类
    /// </summary>
     public  class LuckyPerson
    {
        public string personID { get; set; }//工号
        public string personName { get; set; }//姓名
        public string personMobile { get; set; }//手机号
        public string PrizeRank { get; set; }//奖品级别
        public string PrizeName { get; set; }//奖品名称
        public string PrizeCount { get; set; }//奖品数量
    }
}
