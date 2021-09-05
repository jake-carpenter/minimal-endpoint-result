using FluentAssertions;
using Xunit;

namespace MinimalEndpointResult.Tests
{
    public class ResultWithoutValueTests
    {
        private const int ArbitraryStatusCode = 200;

        [Fact]
        public void ImplementsIEndpointResult()
        {
            new ResultWithoutValue(ArbitraryStatusCode).Should().BeAssignableTo<IEndpointResult>();
        }

        [Theory]
        [InlineData(200)]
        [InlineData(400)]
        [InlineData(401)]
        public void AcceptsStatusCode(int statusCode)
        {
            new ResultWithoutValue(statusCode).StatusCode.Should().Be(statusCode);
        }
    }
}
