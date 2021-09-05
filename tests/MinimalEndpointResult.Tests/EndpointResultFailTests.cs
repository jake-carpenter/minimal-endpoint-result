﻿using FluentAssertions;
using Xunit;

namespace MinimalEndpointResult.Tests
{
    public class EndpointResultFailTests
    {
        private const int ArbitraryStatusCode = 404;

        [Fact]
        public void WithoutValue_ReturnsIEndpointResult()
        {
            MinimalEndpointResult.EndpointResult.Fail(ArbitraryStatusCode).Should().BeAssignableTo<IEndpointResult<None>>();
        }

        [Fact]
        public void WithValue_ReturnsIEndpointResult()
        {
            MinimalEndpointResult.EndpointResult.Fail(ArbitraryStatusCode, new Dummy()).Should().BeAssignableTo<IEndpointResult<Dummy>>();
        }

        [Theory]
        [InlineData(400)]
        [InlineData(401)]
        [InlineData(404)]
        public void WithoutValue_ReturnsResultWithStatusCode(int statusCode)
        {
            MinimalEndpointResult.EndpointResult.Fail(statusCode).StatusCode.Should().Be(statusCode);
        }

        [Theory]
        [InlineData(400)]
        [InlineData(401)]
        [InlineData(404)]
        public void WithValue_ReturnsResultWithStatusCode(int statusCode)
        {
            MinimalEndpointResult.EndpointResult.Fail(statusCode, new Dummy()).StatusCode.Should().Be(statusCode);
        }

        [Fact]
        public void WithoutValue_ReturnsResultWithValueOfNone()
        {
            MinimalEndpointResult.EndpointResult.Fail(ArbitraryStatusCode).Value.Should().Be(None.Value);
        }

        [Fact]
        public void WithValue_ReturnsResultWithValueOfProvidedType()
        {
            var dummy = new Dummy();
            MinimalEndpointResult.EndpointResult.Fail(ArbitraryStatusCode, dummy).Value.Should().Be(dummy);
        }
    }
}