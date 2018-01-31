using System;
using Xunit;
using Chonla.DateTimeHelper;

namespace Chonla.DateTimeHelper.Tests
{
    public class DateHelperTest
    {
        [Fact]
        public void TestYesterday() {
            var dt = DateTime.Parse("2018-02-05T01:02:03Z");
            var result = dt.Yesterday();
            Assert.Equal("2018-02-04 01:02:03Z", result.ToUniversalTime().ToString("u"));
        }

        [Fact]
        public void TestTomorrow() {
            var dt = DateTime.Parse("2018-02-05T01:02:03Z");
            var result = dt.Tomorrow();
            Assert.Equal("2018-02-06 01:02:03Z", result.ToUniversalTime().ToString("u"));
        }

        [Fact]
        public void TestAtTime() {
            var dt = DateTime.Parse("2018-02-05T01:02:03Z");
            var result = dt.At(10, 12, 3, 42);
            Assert.Equal("2018-02-05 10:12:03Z", result.ToUniversalTime().ToString("u"));
        }
    }
}
