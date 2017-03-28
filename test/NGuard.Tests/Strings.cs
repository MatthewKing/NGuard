using System;
using FluentAssertions;
using Xunit;

namespace NGuard.Tests
{
    public class Strings
    {
        [Fact]
        public void IsNotEmptyPassesWhenValueIsNotEmpty()
        {
            var value = "not empty";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotEmpty());

            ex.Should().BeNull();
        }

        [Fact]
        public void IsNotEmptyFailsWhenValueIsEmpty()
        {
            var value = "";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotEmpty());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be an empty string.\r\nParameter name: value");
        }

        [Fact]
        public void IsNotWhiteSpacePassesWhenValueIsNotWhiteSpace()
        {
            var value = "not empty";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotWhiteSpace());

            ex.Should().BeNull();
        }

        [Fact]
        public void IsNotWhiteSpaceFailsWhenValueIsWhiteSpace()
        {
            var value = " \t\r\n";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotWhiteSpace());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not consist only of white-space characters.\r\nParameter name: value");
        }

        [Fact]
        public void IsNotNullOrEmptyPassesWhenValueIsNotNullOrEmpty()
        {
            var value = "not null or empty";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmpty());

            ex.Should().BeNull();
        }

        [Fact]
        public void IsNotNullOrEmptyFailsWhenValueIsNull()
        {
            var value = null as string;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmpty());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be null.\r\nParameter name: value");
        }

        [Fact]
        public void IsNotNullOrEmptyFailsWhenValueIsEmpty()
        {
            var value = "";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmpty());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be an empty string.\r\nParameter name: value");
        }

        [Fact]
        public void IsNotNullOrEmptyOrWhiteSpacePassesWhenValueIsNotNullOrEmptyOrWhiteSpace()
        {
            var value = "not null or empty or whitespace";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace());

            ex.Should().BeNull();
        }

        [Fact]
        public void IsNotNullOrEmptyOrWhiteSpaceFailsWhenValueIsNull()
        {
            var value = null as string;
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be null.\r\nParameter name: value");
        }

        [Fact]
        public void IsNotNullOrEmptyOrWhiteSpaceFailsWhenValueIsEmpty()
        {
            var value = "";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not be an empty string.\r\nParameter name: value");
        }

        [Fact]
        public void IsNotNullOrEmptyOrWhiteSpaceFailsWhenValueIsWhiteSpace()
        {
            var value = "\r\n \t";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace());

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should not consist only of white-space characters.\r\nParameter name: value");
        }

        [Fact]
        public void StartsWithPassesWhenValueStartsWithSpecifiedString()
        {
            var value = "example string";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).StartsWith("example", StringComparison.Ordinal));

            ex.Should().BeNull();
        }

        [Fact]
        public void StartsWithFailsWhenValueDoesNotStartWithSpecifiedString()
        {
            var value = "example string";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).StartsWith("xxx", StringComparison.Ordinal));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should start with 'xxx'.\r\nParameter name: value");
        }

        [Fact]
        public void StartsWithPassesWhenValueStartsWithSpecifiedStringUsingCustomStringComparison()
        {
            var value = "example string";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).StartsWith("EXAMPLE", StringComparison.OrdinalIgnoreCase));

            ex.Should().BeNull();
        }

        [Fact]
        public void EndsWithPassesWhenValueEndsWithSpecifiedString()
        {
            var value = "example string";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).EndsWith("string", StringComparison.Ordinal));

            ex.Should().BeNull();
        }

        [Fact]
        public void EndsWithFailsWhenValueDoesNotEndWithSpecifiedString()
        {
            var value = "example string";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).EndsWith("xxx", StringComparison.Ordinal));

            ex.Should().NotBeNull();
            ex.Message.Should().Be("value should end with 'xxx'.\r\nParameter name: value");
        }

        [Fact]
        public void EndsWithPassesWhenValueEndsWithSpecifiedStringUsingCustomStringComparison()
        {
            var value = "example string";
            var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).EndsWith("STRING", StringComparison.OrdinalIgnoreCase));

            ex.Should().BeNull();
        }
    }
}
