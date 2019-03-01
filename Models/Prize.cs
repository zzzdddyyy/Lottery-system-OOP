using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 用来表示奖品信息的实体类
    /// </summary>
    public class Prize
    {
        public int PrizeID { get; set; }//ID
        public string PrizeRank { get; set; }//Rank
        public string PrizeCounts { get; set; }//Counts
        public string PrizeName { get; set; }//奖品名称
    }
}
