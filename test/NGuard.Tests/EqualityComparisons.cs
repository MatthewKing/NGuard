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
            var action = () => Guard.Requires(value, nameof(value)).IsEqualTo("x");

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueIsNotEqualToExpected()
        {
            var value = "x";
            var action = () => Guard.Requires(value, nameof(value)).IsEqualTo("y");

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should be equal to 'y'.*");
        }

        [Fact]
        public void FailsWhenValueIsNull()
        {
            var value = default(string);
            var action = () => Guard.Requires(value, nameof(value)).IsEqualTo("z");

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should be equal to 'z'.*");
        }
    }

    public class IsNotEqualTo
    {
        [Fact]
        public void FailsWhenValueIsEqualToExpected()
        {
            var value = "x";
            var action = () => Guard.Requires(value, nameof(value)).IsNotEqualTo("x");

            action.Should()
                .Throw<ArgumentException>()
                .WithMessage("value should not be equal to 'x'.*");
        }

        [Fact]
        public void PassesWhenValueIsNotEqualToExpected()
        {
            var value = "x";
            var action = () => Guard.Requires(value, nameof(value)).IsNotEqualTo("y");

            action.Should().NotThrow();
        }

        [Fact]
        public void PassesWhenValueIsNull()
        {
            var value = default(string);
            var action = () => Guard.Requires(value, nameof(value)).IsNotEqualTo("z");

            action.Should().NotThrow();
        }
    }
}
