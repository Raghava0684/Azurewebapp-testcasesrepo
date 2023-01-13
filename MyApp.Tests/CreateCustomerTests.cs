using AutoFixture.Xunit2;
using Moq;
using Xunit;
using MyApp.Controllers;
using MyApp.Models;

namespace MyApp.Tests
{
    public class CreateCustomerTests
    {
        [Theory, AutoMoqData]
        public void ValidCustomerIsSaved(
            CustomerDto dto,
            [Frozen]Mock<ICustomerRepository> mockRepo,
            CustomerController sut)
        {
            sut.CreateCustomer(dto);

            mockRepo.Verify(
                a => a.Create(It.IsAny<Customer>()),
                Times.Once);
        }


    }
}
