using AutoFixture.Xunit2;
using MyApp.Models;
using Xunit;

namespace MyApp.Tests
{
    public class ShippingConditionTests
    {
        [Theory]
        [InlineAutoData(22, true)]
        [InlineAutoData(40, true)]
        [InlineAutoData(21, false)]
        [InlineAutoData(11, false)]
        public void ForCustomerWithAddressShippingCOnditionReturnsExpected(
            int age,
            bool expected,
            Customer customer,
            CustomerShippingCondition sut)
        {
            customer.Age = age;
            var actual = sut.Check(customer);

            Assert.Equal(expected, actual);
        }

        [Theory, AutoData]
        public void ForCustomerWithoutAddressShippingCOnditionReturnsFalse(
            Customer customer,
            CustomerShippingCondition sut)
        {
            customer.Addresses.Clear();
            var actual = sut.Check(customer);

            Assert.False(actual);
        }
    }
}
