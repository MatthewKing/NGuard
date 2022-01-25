using FluentAssertions;
using Xunit;

namespace NGuard.Tests;

public class EqualityComparisons
{
    public class IsEqualTo
    {
        [Fact]
        public void PassesWhenValueIsEqualToExpected()
        {
            var value = "x";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsEqualTo("x"));

            ex.Should().BeNull();
        }

        [Fact]
        public void FailsWhenValueIsNotEqualToExpected()
        {
            var value = "x";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsEqualTo("y"));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be equal to y.\r\nParameter name: value");
        }

        [Fact]
        public void FailsWhenValueIsNull()
        {
            var value = default(string);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsEqualTo("z"));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be equal to z.\r\nParameter name: value");
        }
    }

    public class IsNotEqualTo
    {
        [Fact]
        public void FailsWhenValueIsEqualToExpected()
        {
            var value = "x";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotEqualTo("x"));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be equal to x.\r\nParameter name: value");
        }

        [Fact]
        public void PassesWhenValueIsNotEqualToExpected()
        {
            var value = "x";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotEqualTo("y"));

            ex.Should().BeNull();
        }

        [Fact]
        public void PassesWhenValueIsNull()
        {
            var value = default(string);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotEqualTo("z"));

            ex.Should().BeNull();
        }
    }
}
