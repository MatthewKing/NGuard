using System;
using FluentAssertions;
using Xunit;

namespace NGuard.Tests
{
    public class Comparisons
    {
        [Fact]
        public void IsGreaterThanFailsWhenValueIsLessThanExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(2));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be greater than 2.\r\nParameter name: value");
        }

        [Fact]
        public void IsGreaterThanFailsWhenValueIsEqualToExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(1));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be greater than 1.\r\nParameter name: value");
        }

        [Fact]
        public void IsGreaterThanPassesWhenValueIsGreaterThanExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(0));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsGreaterThanFailsWhenNullableValueIsLessThanExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(2));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be greater than 2.\r\nParameter name: value");
        }

        [Fact]
        public void IsGreaterThanFailsWhenNullableValueIsEqualToExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(1));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be greater than 1.\r\nParameter name: value");
        }

        [Fact]
        public void IsGreaterThanPassesWhenNullableValueIsGreaterThanExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(0));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsGreaterThanFailsWhenNullableValueIsNull()
        {
            var value = new Nullable<int>();
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(0));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be greater than 0.\r\nParameter name: value");
        }

        [Fact]
        public void IsGreaterThanOrEqualToFailsWhenValueIsLessThanExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(2));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be greater than or equal to 2.\r\nParameter name: value");
        }

        [Fact]
        public void IsGreaterThanOrEqualToPassesWhenValueIsEqualToExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(1));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsGreaterThanOrEqualToPassesWhenValueIsGreaterThanExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(0));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsGreaterThanOrEqualToFailsWhenNullableValueIsLessThanExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(2));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be greater than or equal to 2.\r\nParameter name: value");
        }

        [Fact]
        public void IsGreaterThanOrEqualToPassesWhenNullableValueIsEqualToExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(1));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsGreaterThanOrEqualToPassesWhenNullableValueIsGreaterThanExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(0));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsGreaterThanOrEqualToFailsWhenNullableValueIsNull()
        {
            var value = new Nullable<int>();
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(0));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be greater than or equal to 0.\r\nParameter name: value");
        }

        [Fact]
        public void IsLessThanPassesWhenValueIsLessThanExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(2));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsLessThanFailsWhenValueIsEqualToExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(1));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be less than 1.\r\nParameter name: value");
        }

        [Fact]
        public void IsLessThanFailsWhenValueIsGreaterThanExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(0));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be less than 0.\r\nParameter name: value");
        }

        [Fact]
        public void IsLessThanPassesWhenNullableValueIsLessThanExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(2));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsLessThanFailsWhenNullableValueIsEqualToExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(1));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be less than 1.\r\nParameter name: value");
        }

        [Fact]
        public void IsLessThanFailsWhenNullableValueIsGreaterThanExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(0));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be less than 0.\r\nParameter name: value");
        }

        [Fact]
        public void IsLessThanFailsWhenNullableValueIsNull()
        {
            var value = new Nullable<int>();
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(0));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be less than 0.\r\nParameter name: value");
        }

        [Fact]
        public void IsLessThanOrEqualToPassesWhenValueIsLessThanExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(2));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsLessThanOrEqualToPassesWhenValueIsEqualToExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(1));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsLessThanOrEqualToFailsWhenValueIsGreaterThanExpected()
        {
            var value = 1;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(0));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be less than or equal to 0.\r\nParameter name: value");
        }

        [Fact]
        public void IsLessThanOrEqualToPassesWhenNullableValueIsLessThanExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(2));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsLessThanOrEqualToPassesWhenNullableValueIsEqualToExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(1));

            ex.Should().BeNull();
        }

        [Fact]
        public void IsLessThanOrEqualToFailsWhenNullableValueIsGreaterThanExpected()
        {
            var value = new Nullable<int>(1);
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(0));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be less than or equal to 0.\r\nParameter name: value");
        }

        [Fact]
        public void IsLessThanOrEqualToFailsWhenNullableValueIsNull()
        {
            var value = new Nullable<int>();
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(0));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should be less than or equal to 0.\r\nParameter name: value");
        }
    }
}
