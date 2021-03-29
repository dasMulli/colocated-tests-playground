using FluentAssertions;
using Xunit;

namespace TestLib
{
    public class ExampleClassTests : IClassFixture<ExampleClassFixture>
    {
        private readonly ExampleClassFixture fixture;

        public ExampleClassTests(ExampleClassFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void ItShallReturnCorrectValue()
        {
            fixture.SubjectUnderTest.ExampleProperty.Should().Be("ExampleValue");
        }
    }
}