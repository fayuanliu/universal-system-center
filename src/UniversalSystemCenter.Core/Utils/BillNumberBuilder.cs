using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Utils
{
    public class BillNumberBuilder
    {
        private static object locker = new object();

        private static int sn = 0;

        public static string NextBillNumber()
        {
            lock (locker)
            {
                if (sn == 9999999)
                    sn = 0;
                else
                    sn++;
                return DateTime.Now.ToString("yyyyMMddHHmmss") + sn.ToString().PadLeft(7, '0');
            }
        }
        // 单例
        private BillNumberBuilder() { }
    }
}
