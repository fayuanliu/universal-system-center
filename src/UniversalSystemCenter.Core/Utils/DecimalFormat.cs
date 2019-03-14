using System;

namespace UniversalSystemCenter.Core.Utils
{
    public static class DecimalFormat
    {
        /// <summary>
        /// 截取两位小数点（不进行任何四舍五入）
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Floor_2Point(decimal value)
        {
            if (value < 0)
            {
                return Math.Floor(Math.Abs(value) * 100) * 0.01M * -1;
            }
            else if (value == 0)
            {
                return value;
            }
            else
            {
                return Math.Floor(value * 100) * 0.01M;
            }
        }
    }
}
