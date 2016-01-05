using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duplica
{
    public static class Constants
    {

        public static readonly string[] Units = new string[] {
                "",
                "Bytes",
                "KB",
                "MB",
                "GB",
                "TB",
                "PB"
        };

        public static readonly long[] Multiplier = new long[]
        {
            0,
            1,
            1024,
            1024 * 1024,
            1024 * 1024 * 1024,
            1024L * 1024L * 1024L * 1024L,
            1024L * 1024L * 1024L * 1024L * 1024L
        };
    }
}
