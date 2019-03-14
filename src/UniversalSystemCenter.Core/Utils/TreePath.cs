using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Utils
{
    public static class TreePath
    {
        /// <summary>
        /// 获取下一个树节点路径
        /// </summary>
        /// <param name="level">级别</param>
        /// <param name="currCode">最新节点路径</param>
        /// <returns></returns>
        public static string GetTreePath(int level, string currCode)
        {
            if (string.IsNullOrEmpty(currCode))
            {
                return GetFirst(level);
            }
            if (currCode.Length < 2)
            {
                throw new Exception("错误的编码路径" + currCode);
            }
            else
            {
                string code = currCode.Substring(currCode.Length - 2, 2);
                string newCode = GetNumber(code);
                if (string.IsNullOrEmpty(newCode))
                {
                    newCode = GetNumberAndtLetter(code);
                    if (string.IsNullOrEmpty(newCode))
                    {
                        newCode = GetLetter(code);
                    }
                }
                return currCode.Substring(0, currCode.Length - 2) + newCode;
            }
        }

        static private string GetFirst(int level)
        {
            switch (level)
            {
                case 1:
                    return "01";
                case 2:
                    return "0101";
                case 3:
                    return "010101";
                case 4:
                    return "01010101";
                case 5:
                    return "0101010101";
                case 6:
                    return "010101010101";
                case 7:
                    return "01010101010101";
                case 8:
                    return "0101010101010101";
                case 9:
                    return "010101010101010101";
                default:
                    throw new Exception("超出范围，暂未实现");
            }
        }

        /// <summary>
        /// 0-99
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        static private string GetNumber(string code)
        {
            int result = 0;
            if (int.TryParse(code, out result))
            {
                if (result < 99)
                {
                    return (result + 1).ToString().PadLeft(2, '0');
                }
                else
                {
                    return "0A";
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// 0A-9Z
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        static private string GetNumberAndtLetter(string code)
        {
            var first = code.Substring(0, 1);
            var second = code.Substring(1, 1);
            int secondint = Convert.ToInt32(Convert.ToChar(second));
            if (secondint < 90)
            {
                return first + Convert.ToChar(secondint + 1).ToString();
            }
            int result = 0;
            if (int.TryParse(first, out result))
            {
                if (result < 9)
                {
                    return (result + 1).ToString() + "A";
                }
                else
                {
                    return "AA";
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// AA-ZZ
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        static private string GetLetter(string code)
        {
            var first = code.Substring(0, 1);
            var second = code.Substring(1, 1);
            int secondint = Convert.ToInt32(Convert.ToChar(second));
            if (secondint < 90)
            {
                return first + Convert.ToChar(secondint + 1).ToString();
            }
            int result = Convert.ToInt32(Convert.ToChar(first));

            if (result < 90)
            {
                return Convert.ToChar(result + 1).ToString() + "A";
            }
            else
            {
                throw new Exception("超出范围，暂未实现");
            }
            throw new Exception("超出范围，暂未实现");
        }
    }
}
