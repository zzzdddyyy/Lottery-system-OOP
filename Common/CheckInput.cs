using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public static class CheckInput
    {
        //判断输入是否是中文
        public static bool IsChinese(string str)
        {
            Regex objRegex = new Regex(@"^[\u4e00-\u9fa5]{0,}$");
            return objRegex.IsMatch(str);
        }
        public static bool IsMobileNumber(string str)
        {
            //判断手机号码
            Regex objRegex = new Regex(@"^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$");
            return objRegex.IsMatch(str);
        }
        public static bool IsNumber(string str)
        {
            Regex objRegex = new Regex(@"^[0-9]*$");
            return objRegex.IsMatch(str);
        }
    }
}
