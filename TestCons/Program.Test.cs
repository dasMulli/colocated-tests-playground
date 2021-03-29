using FluentAssertions;
using Xunit;

namespace TestCons
{
    public class ProgramTests : IClassFixture<ProgramFixture>
    {
        private readonly ProgramFixture fixture;

        public ProgramTests(ProgramFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void ItShallReturnCorrectValue()
        {
            fixture.SubjectUnderTest.Greeting.Should().Be("Hello World!");
        }
    }
}