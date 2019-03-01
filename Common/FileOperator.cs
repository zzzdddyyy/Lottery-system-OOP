using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.IO;

namespace Common
{
    /// <summary>
    /// 文件操作的静态类
    /// </summary>
    public static class FileOperator
    {
        /// <summary>
        /// 逐行读取文件并返回objList ，返回成员为Person的List
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static List<Person> ReadFile(string filePath)
        {
            List<Person> objList = new List<Person>();
            //逐行读取
            try
            {
                StreamReader sr = new StreamReader(filePath, Encoding.Default);
                string Line = sr.ReadLine();
                while (Line != null)
                {
                    string[] personArray = Line.Split(',');
                    objList.Add(new Person
                    {
                        PersonId= Convert.ToInt32(personArray[0]),
                        PersonName = personArray[1],
                        PersonMobile =personArray[2]
                    });
                    Line = sr.ReadLine();
                }
                sr.Close();
            }
            catch(Exception  ex)
            {
                throw ex;
            }
            return objList;
        }
        /// <summary>
        /// 保存数据到CSV文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="objListPerson"></param>
        /// <returns></returns>
        public static bool WriteFile(string filePath,List<Person> objListPerson)
        {
            //清空原先数据
            try
            {
                //清空文件内容
                File.WriteAllText(filePath, string.Empty);
                //逐行写入
                StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default);//true代表是否是逐行写入
                foreach(Person item in objListPerson)
                {
                    string strPerson = item.PersonId.ToString() + ',' + item.PersonName.ToString() + ',' + item.PersonMobile.ToString();
                    sw.WriteLine(strPerson);
                }
                sw.Close();
            }
            catch (Exception ex)
            {

                throw(ex);
            }
            return true;
        }
        public static void SaveLuckyPerson(string filePath,List<LuckyPerson> objLuckPerson)
        {
            try
            {
                //清空文件
                File.WriteAllText(filePath, string.Empty);
                //逐行写入
                StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default);
                foreach(LuckyPerson item in objLuckPerson)
                {
                    string line = item.personID + ',' + item.personName + ',' + item.personMobile + ',' + item.PrizeRank + ',' + item.PrizeName + ',' + item.PrizeCount;
                    sw.WriteLine(line);
                }
                sw.Close();
            }
            catch (Exception ex)
            {

                throw(ex);
            }
        }
    }
}
