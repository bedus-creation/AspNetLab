using System;
using Xunit;
using Sms.Controllers;
namespace Sms.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new PageController();
            var result = controller.Index();
            Assert.Equal("Index", result.ViewName);
        }
    }
}
