using FluentAssertions;
using Xunit;

namespace NGuard.Tests;

public class Comparisons
{
    public class IsGreaterThan
    {
        [Fact]
        public void FailsWhenValueIsLessThanExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThan(2);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be greater than 2.*");
        }

        [Fact]
        public void FailsWhenValueIsEqualToExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThan(1);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be greater than 1.*");
        }

        [Fact]
        public void PassesWhenValueIsGreaterThanExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThan(0);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenNullableValueIsLessThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThan(2);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be greater than 2.*");
        }

        [Fact]
        public void FailsWhenNullableValueIsEqualToExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThan(1);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be greater than 1.*");
        }

        [Fact]
        public void PassesWhenNullableValueIsGreaterThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThan(0);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenNullableValueIsNull()
        {
            var value = null as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThan(0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (null) should be greater than 0.*");
        }
    }

    public class IsGreaterThanOrEqualTo
    {
        [Fact]
        public void FailsWhenValueIsLessThanExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(2);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be greater than or equal to 2.*");
        }

        [Fact]
        public void PassesWhenValueIsEqualToExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(1);

            action.Should().NotThrow();
        }

        [Fact]
        public void PassesWhenValueIsGreaterThanExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(0);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenNullableValueIsLessThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(2);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be greater than or equal to 2.*");
        }

        [Fact]
        public void PassesWhenNullableValueIsEqualToExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(1);

            action.Should().NotThrow();
        }

        [Fact]
        public void PassesWhenNullableValueIsGreaterThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(0);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenNullableValueIsNull()
        {
            var value = null as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (null) should be greater than or equal to 0.*");
        }
    }

    public class IsLessThan
    {
        [Fact]
        public void PassesWhenValueIsLessThanExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThan(2);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueIsEqualToExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThan(1);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be less than 1.*");
        }

        [Fact]
        public void FailsWhenValueIsGreaterThanExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThan(0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be less than 0.*");
        }

        [Fact]
        public void PassesWhenNullableValueIsLessThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThan(2);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenNullableValueIsEqualToExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThan(1);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be less than 1.*");
        }

        [Fact]
        public void FailsWhenNullableValueIsGreaterThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThan(0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be less than 0.*");
        }

        [Fact]
        public void FailsWhenNullableValueIsNull()
        {
            var value = null as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThan(0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (null) should be less than 0.*");
        }
    }

    public class IsLessThanOrEqualTo
    {
        [Fact]
        public void PassesWhenValueIsLessThanExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(2);

            action.Should().NotThrow();
        }

        [Fact]
        public void PassesWhenValueIsEqualToExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(1);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenValueIsGreaterThanExpected()
        {
            var value = 1;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be less than or equal to 0.*");
        }

        [Fact]
        public void PassesWhenNullableValueIsLessThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(2);

            action.Should().NotThrow();
        }

        [Fact]
        public void PassesWhenNullableValueIsEqualToExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(1);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenNullableValueIsGreaterThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should be less than or equal to 0.*");
        }

        [Fact]
        public void FailsWhenNullableValueIsNull()
        {
            var value = null as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (null) should be less than or equal to 0.*");
        }
    }

    public class IsNullOrGreaterThan
    {
        [Fact]
        public void FailsWhenNullableValueIsLessThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrGreaterThan(2);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should either be null, or be greater than 2.*");
        }

        [Fact]
        public void FailsWhenNullableValueIsEqualToExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrGreaterThan(1);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should either be null, or be greater than 1.*");
        }

        [Fact]
        public void PassesWhenNullableValueIsGreaterThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrGreaterThan(0);

            action.Should().NotThrow();
        }

        [Fact]
        public void PassesWhenNullableValueIsNull()
        {
            var value = null as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrGreaterThan(0);

            action.Should().NotThrow();
        }
    }

    public class IsNullOrGreaterThanOrEqualTo
    {
        [Fact]
        public void FailsWhenNullableValueIsLessThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrGreaterThanOrEqualTo(2);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should either be null, or be greater than or equal to 2.*");
        }

        [Fact]
        public void PassesWhenNullableValueIsEqualToExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrGreaterThanOrEqualTo(1);

            action.Should().NotThrow();
        }

        [Fact]
        public void PassesWhenNullableValueIsGreaterThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrGreaterThanOrEqualTo(0);

            action.Should().NotThrow();
        }

        [Fact]
        public void PassesWhenNullableValueIsNull()
        {
            var value = null as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrGreaterThanOrEqualTo(0);

            action.Should().NotThrow();
        }
    }

    public class IsNullOrLessThan
    {
        [Fact]
        public void PassesWhenNullableValueIsLessThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrLessThan(2);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenNullableValueIsEqualToExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrLessThan(1);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should either be null, or be less than 1.*");
        }

        [Fact]
        public void FailsWhenNullableValueIsGreaterThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrLessThan(0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should either be null, or be less than 0.*");
        }

        [Fact]
        public void PassesWhenNullableValueIsNull()
        {
            var value = null as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrLessThan(0);

            action.Should().NotThrow();
        }
    }

    public class IsNullOrLessThanOrEqualTo
    {
        [Fact]
        public void PassesWhenNullableValueIsLessThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrLessThanOrEqualTo(2);

            action.Should().NotThrow();
        }

        [Fact]
        public void PassesWhenNullableValueIsEqualToExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrLessThanOrEqualTo(1);

            action.Should().NotThrow();
        }

        [Fact]
        public void FailsWhenNullableValueIsGreaterThanExpected()
        {
            var value = 1 as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrLessThanOrEqualTo(0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("value (1) should either be null, or be less than or equal to 0.*");
        }

        [Fact]
        public void FailsWhenNullableValueIsNull()
        {
            var value = null as int?;
            var action = () => Guard.Requires(value, nameof(value)).IsNullOrLessThanOrEqualTo(0);

            action.Should().NotThrow();
        }
    }
}
