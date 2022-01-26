using FluentAssertions;
using Xunit;

namespace NGuard.Tests;

public class Strings
{
    public class IsNotEmpty
    {
        [Fact]
        public void PassesWhenValueIsNotEmpty()
        {
            var value = "not empty";
            var action = () => Guard.Requires(value, nameof(value)).IsNotEmpty();

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueIsEmpty()
        {
            var value = "";
            var action = () => Guard.Requires(value, nameof(value)).IsNotEmpty();

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should not be an empty string.*");
        }
    }

    public class IsNotWhiteSpace
    {
        [Fact]
        public void PassesWhenValueIsNotWhiteSpace()
        {
            var value = "not empty";
            var action = () => Guard.Requires(value, nameof(value)).IsNotWhiteSpace();

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueIsWhiteSpace()
        {
            var value = " \t\r\n";
            var action = () => Guard.Requires(value, nameof(value)).IsNotWhiteSpace();

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should not consist only of white-space characters.*");
        }
    }

    public class IsNotNullOrEmpty
    {
        [Fact]
        public void PassesWhenValueIsNotNullOrEmpty()
        {
            var value = "not null or empty";
            var action = () => Guard.Requires(value, nameof(value)).IsNotNullOrEmpty();

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueIsNull()
        {
            var value = null as string;
            var action = () => Guard.Requires(value, nameof(value)).IsNotNullOrEmpty();

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should not be null.*");
        }

        [Fact]
        public void FailsWhenValueIsEmpty()
        {
            var value = "";
            var action = () => Guard.Requires(value, nameof(value)).IsNotNullOrEmpty();

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should not be an empty string.*");
        }
    }

    public class IsNotNullOrEmptyOrWhiteSpace
    {
        [Fact]
        public void PassesWhenValueIsNotNullOrEmptyOrWhiteSpace()
        {
            var value = "not null or empty or whitespace";
            var action = () => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace();

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueIsNull()
        {
            var value = null as string;
            var action = () => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace();

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should not be null.*");
        }

        [Fact]
        public void FailsWhenValueIsEmpty()
        {
            var value = "";
            var action = () => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace();

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should not be an empty string.*");
        }

        [Fact]
        public void FailsWhenValueIsWhiteSpace()
        {
            var value = "\r\n \t";
            var action = () => Guard.Requires(value, nameof(value)).IsNotNullOrEmptyOrWhiteSpace();

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should not consist only of white-space characters.*");
        }
    }

    public class StartsWith
    {
        [Fact]
        public void PassesWhenValueStartsWithSpecifiedString()
        {
            var value = "example string";
            var action = () => Guard.Requires(value, nameof(value)).StartsWith("example", StringComparison.Ordinal);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueDoesNotStartWithSpecifiedString()
        {
            var value = "example string";
            var action = () => Guard.Requires(value, nameof(value)).StartsWith("xxx", StringComparison.Ordinal);

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should start with 'xxx'.*");
        }

        [Fact]
        public void PassesWhenValueStartsWithSpecifiedStringUsingCustomStringComparison()
        {
            var value = "example string";
            var action = () => Guard.Requires(value, nameof(value)).StartsWith("EXAMPLE", StringComparison.OrdinalIgnoreCase);

            action.Should().NotThrow();
        }
    }

    public class EndsWith
    {
        [Fact]
        public void PassesWhenValueEndsWithSpecifiedString()
        {
            var value = "example string";
            var action = () => Guard.Requires(value, nameof(value)).EndsWith("string");

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueDoesNotEndWithSpecifiedString()
        {
            var value = "example string";
            var action = () => Guard.Requires(value, nameof(value)).EndsWith("xxx");

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should end with 'xxx'.*");
        }

        [Fact]
        public void PassesWhenValueEndsWithSpecifiedStringUsingCustomStringComparison()
        {
            var value = "example string";
            var action = () => Guard.Requires(value, nameof(value)).EndsWith("STRING", StringComparison.OrdinalIgnoreCase);

            action.Should().NotThrow();
        }
    }

    public class Contains
    {
        [Fact]
        public void PassesWhenValueContainsTheSpecifiedString()
        {
            var value = "example string";
            var action = () => Guard.Requires(value, nameof(value)).Contains("str");

            action.Should().NotThrow();
        }

        [Fact]
        public void PassesWhenValueContainsTheSpecifiedStringUsingCustomStringComparison()
        {
            var value = "example string";
            var action = () => Guard.Requires(value, nameof(value)).Contains("STR", StringComparison.OrdinalIgnoreCase);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueDoesNotContainTheSpecifiedString()
        {
            var value = "example string";
            var action = () => Guard.Requires(value, nameof(value)).Contains("xxx");

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should contain 'xxx'.*");
        }

        [Fact]
        public void FailsWhenValueDoesNotContainTheSpecifiedStringUsingCustomStringComparison()
        {
            var value = "example string";
            var action = () => Guard.Requires(value, nameof(value)).Contains("xxx", StringComparison.OrdinalIgnoreCase);

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should contain 'xxx'.*");
        }
    }
}
