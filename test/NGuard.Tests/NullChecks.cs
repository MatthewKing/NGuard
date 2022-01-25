using FluentAssertions;
using Xunit;

namespace NGuard.Tests;

public class NullChecks
{
    public class IsNotNull
    {
        [Fact]
        public void PassesWhenValueIsNotNull()
        {
            var value = new object();
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNull());

            ex.Should().BeNull();
        }

        [Fact]
        public void FailsWhenValueIsNull()
        {
            var value = null as object;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNull());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be null.\r\nParameter name: value");
        }

        [Fact]
        public void PassesWhenNullableValueIsNotNull()
        {
            var value = 123 as int?;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNull());

            ex.Should().BeNull();
        }

        [Fact]
        public void FailsWhenNullableValueIsNull()
        {
            var value = null as int?;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNull());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be null.\r\nParameter name: value");
        }
    }
}
