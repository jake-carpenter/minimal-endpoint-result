using FluentAssertions;
using Xunit;

namespace EndpointResult.Tests
{
    public class EndpointResultOkTests
    {
        [Fact]
        public void ReturnsIEndpointResult()
        {
            EndpointResult.Ok().Should().BeAssignableTo<IEndpointResult<None>>();
        }

        [Fact]
        public void ReturnsResultWith200StatusCode()
        {
            EndpointResult.Ok().StatusCode.Should().Be(200);
        }

        [Fact]
        public void ReturnsResultWithValueOfNone()
        {
            EndpointResult.Ok().Value.Should().Be(None.Value);
        }
    }
}
