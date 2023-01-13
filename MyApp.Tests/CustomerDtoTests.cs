using MyApp;
using MyApp.Controllers;
using Xunit;

namespace MyApp.Tests
{
    public class CustomerDtoTests
    {
        [Theory, AutoMoqData]
        public void Test(CustomerDto sut)
        {
            Assert.NotNull(sut);
        }
    }
}
