using FluentAssertions;
using Xunit;

namespace MinimalEndpointResult.Tests
{
    public class EndpointResultOkTests
    {
        [Fact]
        public void ReturnsIEndpointResult()
        {
            EndpointResult.Ok().Should().BeAssignableTo<IEndpointResult>();
        }

        [Fact]
        public void ReturnsResultWith200StatusCode()
        {
            EndpointResult.Ok().StatusCode.Should().Be(200);
        }
    }
}
