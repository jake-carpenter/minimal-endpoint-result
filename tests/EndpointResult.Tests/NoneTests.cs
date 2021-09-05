using FluentAssertions;
using Xunit;

namespace EndpointResult.Tests
{
    public class NoneTests
    {
        [Fact]
        public void ValueIsNone()
        {
            None.Value.Should().Be(None.Value);
        }

        [Fact]
        public void NoneIsNotEqualToAnotherObjectIfItIsNotNone()
        {
            var equals = None.Value.Equals(new Dummy());

            equals.Should().BeFalse();
        }

        [Fact]
        public void NoneIsEqualToAnotherNoneWithEquals()
        {
            var equals = None.Value.Equals(None.Value);

            equals.Should().BeTrue();
        }

        [Fact]
        public void NoneIsEqualToAnotherNoneWithEqualsOperator()
        {
            // ReSharper disable once EqualExpressionComparison
            var equals = None.Value == None.Value;

            equals.Should().BeTrue();
        }

        [Fact]
        public void NoneIsEqualToAnotherNoneWithNotEqualsOperator()
        {
            // ReSharper disable once EqualExpressionComparison
            var equals = None.Value != None.Value;

            equals.Should().BeFalse();
        }

        [Fact]
        public void CompareToReturns0()
        {
            None.Value.CompareTo(None.Value).Should().Be(0);
        }

        [Fact]
        public void CompareToAnotherObjectReturns1()
        {
            None.Value.CompareTo(1).Should().Be(1);
        }

        [Fact]
        public void GetHashCodeReturns0()
        {
            None.Value.GetHashCode().Should().Be(0);
        }
    }
}
