using FluentAssertions;
using Xunit;

namespace MinimalEndpointResult.Tests
{
    public class EndpointResultTests
    {
        [Fact]
        public void ImplementsIEndpointResult()
        {
            new Result<Dummy>(default, default).Should().BeAssignableTo<IEndpointResult<Dummy>>();
        }

        [Theory]
        [InlineData(200)]
        [InlineData(400)]
        [InlineData(401)]
        public void AcceptsStatusCode(int statusCode)
        {
            new Result<Dummy>(statusCode).StatusCode.Should().Be(statusCode);
        }

        [Fact]
        public void AcceptsStatusCode_AndValueOfReferenceType()
        {
            const int statusCode = 200;
            var dummy = new Dummy();

            var sut = new Result<Dummy>(statusCode, dummy);

            sut.StatusCode.Should().Be(statusCode);
            sut.Value.Should().Be(dummy);
        }

        [Fact]
        public void AcceptsStatusCode_AndValueOfValueType()
        {
            const int statusCode = 200;
            const int value = 99;

            var sut = new Result<int>(statusCode, value);

            sut.StatusCode.Should().Be(statusCode);
            sut.Value.Should().Be(value);
        }
    }
}
