using System;
using Chonla.Duration;

namespace Chonla.DateTimeHelper
{
    public static class DateHelper {
        private static Duration.Duration dur = new Duration.Duration();
        private static readonly TimeSpan oneDay;
        
        static DateHelper() {
            oneDay = dur.Parse("1d");
        }

        public static DateTime Yesterday(this DateTime dt) {
            return dt - oneDay;
        }

        public static DateTime Tomorrow(this DateTime dt) {
            return dt + oneDay;
        }

        public static DateTime At(this DateTime dt, int h, int m = 0, int s = 0, int ms = 0) {
            return new DateTime(
                dt.Year,
                dt.Month,
                dt.Day,
                h,
                m,
                s,
                ms,
                DateTimeKind.Utc
            );
        }
    }
}
