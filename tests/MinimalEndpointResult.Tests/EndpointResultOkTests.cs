using FluentAssertions;
using Xunit;

namespace MinimalEndpointResult.Tests
{
    public class EndpointResultOkTests
    {
        [Fact]
        public void ReturnsIEndpointResult()
        {
            MinimalEndpointResult.EndpointResult.Ok().Should().BeAssignableTo<IEndpointResult<None>>();
        }

        [Fact]
        public void ReturnsResultWith200StatusCode()
        {
            MinimalEndpointResult.EndpointResult.Ok().StatusCode.Should().Be(200);
        }

        [Fact]
        public void ReturnsResultWithValueOfNone()
        {
            MinimalEndpointResult.EndpointResult.Ok().Value.Should().Be(None.Value);
        }
    }
}
