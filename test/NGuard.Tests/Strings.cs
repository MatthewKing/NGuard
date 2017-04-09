using System;
using FluentAssertions;
using Xunit;

namespace NGuard.Tests
{
    public class Strings
    {
        public class IsNotEmpty
        {
            [Fact]
            public void PassesWhenValueIsNotEmpty()
            {
                var value = "not empty";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotEmpty());

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenValueIsEmpty()
            {
                var value = "";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotEmpty());

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should not be an empty string.\r\nParameter name: value");
            }
        }

        public class IsNotWhiteSpace
        {
            [Fact]
            public void PassesWhenValueIsNotWhiteSpace()
            {
                var value = "not empty";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotWhiteSpace());

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenValueIsWhiteSpace()
            {
                var value = " \t\r\n";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotWhiteSpace());

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should not consist only of white-space characters.\r\nParameter name: value");
            }
        }

        public class IsNotNullOrEmpty
        {
            [Fact]
            public void PassesWhenValueIsNotNullOrEmpty()
            {
                var value = "not null or empty";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmpty());

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenValueIsNull()
            {
                var value = null as string;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmpty());

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should not be null.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenValueIsEmpty()
            {
                var value = "";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmpty());

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should not be an empty string.\r\nParameter name: value");
            }
        }

        public class IsNotNullOrEmptyOrWhiteSpace
        {
            [Fact]
            public void PassesWhenValueIsNotNullOrEmptyOrWhiteSpace()
            {
                var value = "not null or empty or whitespace";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace());

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenValueIsNull()
            {
                var value = null as string;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace());

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should not be null.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenValueIsEmpty()
            {
                var value = "";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace());

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should not be an empty string.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenValueIsWhiteSpace()
            {
                var value = "\r\n \t";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace());

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should not consist only of white-space characters.\r\nParameter name: value");
            }
        }

        public class StartsWith
        {
            [Fact]
            public void PassesWhenValueStartsWithSpecifiedString()
            {
                var value = "example string";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).StartsWith("example", StringComparison.Ordinal));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenValueDoesNotStartWithSpecifiedString()
            {
                var value = "example string";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).StartsWith("xxx", StringComparison.Ordinal));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should start with 'xxx'.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenValueStartsWithSpecifiedStringUsingCustomStringComparison()
            {
                var value = "example string";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).StartsWith("EXAMPLE", StringComparison.OrdinalIgnoreCase));

                ex.Should().BeNull();
            }
        }

        public class EndsWith
        {
            [Fact]
            public void PassesWhenValueEndsWithSpecifiedString()
            {
                var value = "example string";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).EndsWith("string"));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenValueDoesNotEndWithSpecifiedString()
            {
                var value = "example string";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).EndsWith("xxx"));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should end with 'xxx'.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenValueEndsWithSpecifiedStringUsingCustomStringComparison()
            {
                var value = "example string";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).EndsWith("STRING", StringComparison.OrdinalIgnoreCase));

                ex.Should().BeNull();
            }
        }

        public class Contains
        {
            [Fact]
            public void PassesWhenValueContainsTheSpecifiedString()
            {
                var value = "example string";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).Contains("str"));

                ex.Should().BeNull();
            }

            [Fact]
            public void PassesWhenValueContainsTheSpecifiedStringUsingCustomStringComparison()
            {
                var value = "example string";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).Contains("STR", StringComparison.OrdinalIgnoreCase));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenValueDoesNotContainTheSpecifiedString()
            {
                var value = "example string";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).Contains("xxx"));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should contain 'xxx'.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenValueDoesNotContainTheSpecifiedStringUsingCustomStringComparison()
            {
                var value = "example string";
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).Contains("XXX", StringComparison.OrdinalIgnoreCase));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should contain 'XXX'.\r\nParameter name: value");
            }
        }
    }
}
