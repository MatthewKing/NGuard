using FluentAssertions;
using Xunit;

namespace NGuard.Tests
{
    public class EqualityComparisons
    {
        [Fact]
        public void IsEqualToPassesWhenValueIsEqualToExpected()
        {
            var value = "x";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsEqualTo("x"));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsEqualToFailsWhenValueIsNotEqualToExpected()
        {
            var value = "x";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsEqualTo("y"));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be equal to y.\r\nParameter name: value");
        }

        [Fact]
        public void IsEqualToFailsWhenValueIsNull()
        {
            var value = default(string);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsEqualTo("z"));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be equal to z.\r\nParameter name: value");
        }

        [Fact]
        public void IsNotEqualToFailsWhenValueIsEqualToExpected()
        {
            var value = "x";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotEqualTo("x"));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be equal to x.\r\nParameter name: value");
        }

        [Fact]
        public void IsNotEqualToPassesWhenValueIsNotEqualToExpected()
        {
            var value = "x";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotEqualTo("y"));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsNotEqualToPassesWhenValueIsNull()
        {
            var value = default(string);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotEqualTo("z"));

            ex.Should().BeNull();
        }
    }
}
