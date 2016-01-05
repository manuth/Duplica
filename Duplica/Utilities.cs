using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duplica
{
    public static class Utilities
    {
        public static string BytesToString(long byteCount)
        {
            if (byteCount == 0)
                return "0 " + Constants.Units[1];
            long bytes = Math.Abs(byteCount);
            int unit = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, unit), 1);
            return (Math.Sign(byteCount) * num).ToString("#,0.00 ") + Constants.Units[unit + 1];
        }
    }
}
