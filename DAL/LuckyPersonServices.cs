using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Common;

namespace DAL
{
    /// <summary>
    /// 中奖人员信息处理
    /// </summary>
    public class LuckyPersonServices
    {
        /// <summary>
        /// 准备好奖品，等待获奖人员填充
        /// </summary>
        /// <param name="objListPrize">奖品列表</param>
        /// <param name="drawOrder">抽奖顺序</param>
        /// <returns>初始化的List<LuckyPerson> </returns>
        public List<LuckyPerson> Initialize(List<Prize> objListPrize,bool drawOrder)
        {
            List<LuckyPerson> objListLuckPerson = new List<LuckyPerson>();
            //遍历奖品,选出获奖的个数：比如特等奖：1；一等奖：2；
            foreach(Prize item in objListPrize)
            {
                for (int i = 0; i <int.Parse( item.PrizeCounts); i++)
                {
                    objListLuckPerson.Add(new LuckyPerson
                    {
                        //初始化中奖奖品信息
                        //中了几等奖
                        PrizeRank = item.PrizeRank,
                        //奖品是什么
                        PrizeName=item.PrizeName,
                       //奖品数量
                        PrizeCount=item.PrizeCounts,
                    });
                }
            }
            //如果从小奖向大奖抽，奖品排序反转
            if (!drawOrder) objListLuckPerson.Reverse();
            return objListLuckPerson;
        }
        public void WritePersonInfo(string person,LuckyPerson objLuckyPerson)
        {
            string[] personArray = person.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            objLuckyPerson.personID = personArray[0];
            objLuckyPerson.personName = personArray[1];
            objLuckyPerson.personMobile = personArray[2];
        }
        /// <summary>
        /// 按照姓名查询
        /// </summary>
        /// <param name="name"></param>
        /// <param name="objListLuckyPerson"></param>
        /// <returns>被查询的中奖者信息</returns>
        public List<LuckyPerson> GetLuckyPersonByName(string name,List<LuckyPerson> objListLuckyPerson)
        {
            List<LuckyPerson> objQueryList = new List<LuckyPerson>();
            foreach(LuckyPerson item in objListLuckyPerson)
            {
                if (item.personName.Contains(name))
                {
                    objQueryList.Add(item);
                }
            }
            return objQueryList;
        }
        /// <summary>
        /// 按照电话号码查询
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="objListLuckyPerson"></param>
        /// <returns>被查询的中奖者信息</returns>
        public List<LuckyPerson> GetLuckyPersonByMobile(string mobile ,List<LuckyPerson> objListLuckyPerson)
        {
            List<LuckyPerson> objQueryList = new List<LuckyPerson>();
            foreach (LuckyPerson item in objListLuckyPerson)
            {
                if (item.personMobile.Contains(mobile))
                {
                    objQueryList.Add(item);
                }
            }
            return objQueryList;
        }
    }
}
