using System;
using FluentAssertions;
using Xunit;

namespace NGuard.Tests
{
    public class NullChecks
    {
        [Fact]
        public void IsNotNullPassesWhenValueIsNotNull()
        {
            var value = new object();
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNull());

            ex.Should().BeNull();
        }

        [Fact]
        public void IsNotNullFailsWhenValueIsNull()
        {
            var value = null as object;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNull());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be null.\r\nParameter name: value");
        }

        [Fact]
        public void IsNotNullPassesWhenNullableStructValueIsNotNull()
        {
            var value = new Nullable<int>(123);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNull());

            ex.Should().BeNull();
        }

        [Fact]
        public void IsNotNullFailsWhenNullableStructValueIsNull()
        {
            var value = new Nullable<int>();
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNull());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be null.\r\nParameter name: value");
        }
    }
}
