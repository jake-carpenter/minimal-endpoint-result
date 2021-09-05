using FluentAssertions;
using Xunit;

namespace MinimalEndpointResult.Tests
{
    public class ResultWithValueTests
    {
        [Fact]
        public void ImplementsIEndpointResultWithType()
        {
            new ResultWithValue<Dummy>(default, default).Should().BeAssignableTo<IEndpointResult<Dummy>>();
        }

        [Fact]
        public void ImplementsIEndpointResult()
        {
            new ResultWithValue<Dummy>(default, default).Should().BeAssignableTo<IEndpointResult>();
        }

        [Theory]
        [InlineData(200)]
        [InlineData(400)]
        [InlineData(401)]
        public void AcceptsStatusCode(int statusCode)
        {
            new ResultWithValue<Dummy>(statusCode).StatusCode.Should().Be(statusCode);
        }

        [Fact]
        public void AcceptsStatusCode_AndValueOfReferenceType()
        {
            const int statusCode = 200;
            var dummy = new Dummy();

            var sut = new ResultWithValue<Dummy>(statusCode, dummy);

            sut.StatusCode.Should().Be(statusCode);
            sut.Value.Should().Be(dummy);
        }

        [Fact]
        public void AcceptsStatusCode_AndValueOfValueType()
        {
            const int statusCode = 200;
            const int value = 99;

            var sut = new ResultWithValue<int>(statusCode, value);

            sut.StatusCode.Should().Be(statusCode);
            sut.Value.Should().Be(value);
        }
    }
}
