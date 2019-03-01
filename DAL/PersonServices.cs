using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    /// <summary>
    /// 实现person实体类的功能：查询、删除、增加、删除
    /// </summary>
   public class PersonServices
    {
        /// <summary>
        /// 按照姓名查询
        /// </summary>
        /// <param name="name"></param>
        /// <param name="objListPerson"></param>
        /// <returns></returns>
        public List<Person> GetAllPersonByName(string name,List<Person> objListPerson)
        {
            List<Person> objListQuery = new List<Person>();
            foreach(Person item in objListPerson)
            {
                if (item.PersonName.StartsWith(name))
                {
                    objListQuery.Add(item);
                }
            }
            return objListQuery;
        }
        /// <summary>
        /// 按照手机号码查询
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="objListPerson"></param>
        /// <returns>满足条件的人员信息</returns>
        public List<Person> GetAllPersonByMobile(string mobile, List<Person> objListPerson)
        {
            List<Person> objListQuery = new List<Person>();
            foreach(Person item in objListPerson)
            {
                if (item.PersonMobile.StartsWith(mobile))
                {
                    objListQuery.Add(item);
                }
            }
            return objListQuery;
        }
        /// <summary>
        /// 首先获取最后一个人的ID，加1，就是新增人员的ID
        /// </summary>
        /// <param name="objListPerson"></param>
        /// <returns>新增人员的ID</returns>
        public string GetNewPersonID(List<Person>objListPerson)
        {
            if (objListPerson == null) return "1";
            else
            {
                return (objListPerson[objListPerson.Count - 1].PersonId + 1).ToString();
            }
        }
        /// <summary>
        /// 增加新人员
        /// </summary>
        /// <param name="objPerson"></param>
        /// <param name="objListPerson"></param>
        public void AddPerson(Person objPerson,List<Person> objListPerson)
        {
            objListPerson.Add(objPerson);
        }
        /// <summary>
        /// 修改当前人员信息
        /// </summary>
        /// <param name="objPerson"></param>
        /// <param name="objListPerson"></param>
        public void UpdatePerson(Person objPerson, List<Person> objListPerson)
        {
            for (int i = 0; i < objListPerson.Count; i++)
            {
                if (objListPerson[i].PersonId == objPerson.PersonId)
                {
                    //删除原先的
                    objListPerson.RemoveAt(i);
                    //在原位置添加
                    objListPerson.Insert(i, objPerson);
                    //跳出
                    break;
                }
            }
        }
        /// <summary>
        /// 删除选中的人员信息
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="objListPerson"></param>
        public void DeletePerson(string personID, List<Person> objListPerson)
        {
            foreach(Person item in objListPerson)
            {
                if (item.PersonId == int.Parse(personID))
                {
                    objListPerson.Remove(item);
                    break;
                }
            }
        }
        /// <summary>
        /// 随机获取一名幸运人员
        /// </summary>
        /// <param name="objListPerson"></param>
        /// <returns></returns>
        public string GetOnePerson(List<Person> objListPerson)
        {
            Random objRandom = new Random();
            int number = objRandom.Next(0, objListPerson.Count);
            return objListPerson[number].PersonId+ "     "+objListPerson[number].PersonName + "        " + objListPerson[number].PersonMobile;
        }
        public void DeleteLuckyPersonFromListPerson(string person, List<Person> objListPerson)
        {
            string[] personArray = person.Split(new char[]{ ' '},StringSplitOptions.RemoveEmptyEntries);
            foreach(Person item in objListPerson)
            {
                if (item.PersonId == int.Parse(personArray[0]))
                {
                    objListPerson.Remove(item);
                    break;
                }
            }
        }
    }
}
