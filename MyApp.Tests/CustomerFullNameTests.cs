using AutoFixture.Xunit2;
using MyApp.Models;
using Xunit;

namespace MyApp.Tests
{
    public class CustomerFullNameTests
    {
        [Theory]
        [InlineAutoData("Rahul", "P", "Nath", "Rahul P Nath")]
        [InlineAutoData("Microsoft", "Visual", "Studio 2019", "Microsoft Visual Studio 2019")]
        public void FullNameReturnsExpected(
            string firstName, string middleName,
            string lastName, string expected,
            Customer sut)
        {
            sut.FirstName = firstName;
            sut.MiddleName = middleName;
            sut.LastName = lastName;
                
            var actual = sut.FullName;

            Assert.Equal(expected, actual);
        }
    }
}
