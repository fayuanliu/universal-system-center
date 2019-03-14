using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util;

namespace UniversalSystemCenter.Core.Utils
{
    public class ArrayUtil
    {
        public static Guid GetArrlast(string strIds)
        {
            if (string.IsNullOrEmpty(strIds))
            {
                return Guid.Empty;
            }
            else
            {
                var arr = strIds.Split(',');
                return arr[arr.Length - 1].ToGuid();
            }

        }

        public static string GetArrlastByString(string strIds)
        {
            if (string.IsNullOrEmpty(strIds))
            {
                return null;
            }
            else
            {
                var arr = strIds.Split(',');
                return arr[arr.Length - 1];
            }

        }
    }
      
}
