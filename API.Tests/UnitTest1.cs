using System;
using Xunit;
using API.Controllers;

namespace API.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, UserController.Add());
        }
    }
}
