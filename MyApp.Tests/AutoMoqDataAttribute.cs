using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace MyApp.Tests
{
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute()
            :base(() => new Fixture()
                .Customize(new AutoMoqCustomization()))
        {

        }
    }
}
