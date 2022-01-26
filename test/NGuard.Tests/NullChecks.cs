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
            var action = () => Guard.Requires(value, nameof(value)).IsNotNull();

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueIsNull()
        {
            var value = default(object);
            var action = () => Guard.Requires(value, nameof(value)).IsNotNull();

            action.Should()
                .Throw<ArgumentNullException>()
                .WithMessage("value should not be null.*");
        }

        [Fact]
        public void PassesWhenNullableValueIsNotNull()
        {
            var value = 123 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNotNull();

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenNullableValueIsNull()
        {
            var value = null as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNotNull();

            action.Should()
                .Throw<ArgumentNullException>()
                .WithMessage("value should not be null.*");
        }
    }
}
