using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Person类实体---记录抽奖人员的信息
    /// </summary>
    public class Person
    {
        public int PersonId { get; set; }//人员编号
        public string PersonName { get; set; }//人员姓名
        public string PersonMobile { get; set; }//人员手机号码
    }
}
