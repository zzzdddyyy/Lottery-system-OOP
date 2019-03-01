using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    /// <summary>
    /// 针对奖品信息的访问和操作
    /// </summary>
    public class PrizeServices
    {
        /// <summary>
        /// 获取新增产品ID
        /// </summary>
        /// <param name="objListPrize"></param>
        /// <returns>新增奖品ID</returns>
        public string GetNewPrizeID(List<Prize> objListPrize)
        {
            if (objListPrize == null|objListPrize.Count==0) return "1";
            else
            {
                return ((objListPrize[objListPrize.Count - 1].PrizeID + 1).ToString());
            }
        }
        /// <summary>
        /// 判当前奖品等级是否存在
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="objListPrize"></param>
        /// <returns>bool</returns>
        public bool IsExistPrizeRank(string rank, List<Prize> objListPrize)
        {
            if (objListPrize == null) return false;
            foreach (Prize item in objListPrize)
            {
                if (item.PrizeRank.Contains(rank))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 新增奖品
        /// </summary>
        /// <param name="objPrize"></param>
        /// <param name="objListPrize"></param>
        public void AddPrize(Prize objPrize,List<Prize> objListPrize)
        {
            objListPrize.Add(objPrize);
        }
        /// <summary>
        /// 修改奖品信息
        /// </summary>
        /// <param name="objPrize"></param>
        /// <param name="objListPrize"></param>
        public void UpdatePrize(Prize objPrize, List<Prize> objListPrize)
        {
            for (int i = 0; i < objListPrize.Count; i++)
            {
                if (objListPrize[i].PrizeID == objPrize.PrizeID)
                {
                    //先删除
                    objListPrize.RemoveAt(i);
                    //再添加
                    objListPrize.Insert(i, objPrize);
                    //退出
                    break;
                }
            }
        }
        /// <summary>
        /// 删除奖品信息
        /// </summary>
        /// <param name="objPrize"></param>
        /// <param name="objListPrize"></param>
        public void DeletePrize(string prizeID , List<Prize> objListPrize)
        {
            for(int i = 0; i < objListPrize.Count; i++)
            {
                if (objListPrize[i].PrizeID == int.Parse(prizeID))
                {
                    objListPrize.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
