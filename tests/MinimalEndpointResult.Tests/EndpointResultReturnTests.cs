using FluentAssertions;
using Xunit;

namespace MinimalEndpointResult.Tests
{
    public class EndpointResultReturnTests
    {
        private const int ArbitraryStatusCode = 200;

        [Fact]
        public void ReturnsIEndpointResult()
        {
            EndpointResult.Return(ArbitraryStatusCode, 0).Should().BeAssignableTo<IEndpointResult<int>>();
        }

        [Theory]
        [InlineData(201)]
        [InlineData(400)]
        [InlineData(404)]
        public void ReturnsResultWithStatus(int statusCode)
        {
            EndpointResult.Return<Dummy>(statusCode, default).StatusCode.Should().Be(statusCode);
        }

        [Fact]
        public void ReturnsResultWithReferenceTypeValue()
        {
            var dummy = new Dummy();

            EndpointResult.Return(ArbitraryStatusCode, dummy).Value.Should().Be(dummy);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void ReturnsResultWithValueTypeValue(int value)
        {
            EndpointResult.Return(ArbitraryStatusCode, value).Value.Should().Be(value);
        }
    }
}
