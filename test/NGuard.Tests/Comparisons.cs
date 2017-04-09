using System;
using FluentAssertions;
using Xunit;

namespace NGuard.Tests
{
    public class Comparisons
    {
        public class IsGreaterThan
        {
            [Fact]
            public void FailsWhenValueIsLessThanExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(2));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be greater than 2.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenValueIsEqualToExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(1));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be greater than 1.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenValueIsGreaterThanExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(0));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenNullableValueIsLessThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(2));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be greater than 2.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenNullableValueIsEqualToExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(1));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be greater than 1.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenNullableValueIsGreaterThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(0));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenNullableValueIsNull()
            {
                var value = null as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThan(0));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be greater than 0.\r\nParameter name: value");
            }
        }

        public class IsGreaterThanOrEqualTo
        {
            [Fact]
            public void FailsWhenValueIsLessThanExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(2));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be greater than or equal to 2.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenValueIsEqualToExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(1));

                ex.Should().BeNull();
            }

            [Fact]
            public void PassesWhenValueIsGreaterThanExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(0));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenNullableValueIsLessThanExpected()
            {
                var value = new Nullable<int>(1);
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(2));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be greater than or equal to 2.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenNullableValueIsEqualToExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(1));

                ex.Should().BeNull();
            }

            [Fact]
            public void PassesWhenNullableValueIsGreaterThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(0));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenNullableValueIsNull()
            {
                var value = null as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsGreaterThanOrEqualTo(0));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be greater than or equal to 0.\r\nParameter name: value");
            }
        }

        public class IsLessThan
        {
            [Fact]
            public void PassesWhenValueIsLessThanExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(2));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenValueIsEqualToExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(1));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be less than 1.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenValueIsGreaterThanExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(0));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be less than 0.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenNullableValueIsLessThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(2));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenNullableValueIsEqualToExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(1));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be less than 1.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenNullableValueIsGreaterThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(0));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be less than 0.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenNullableValueIsNull()
            {
                var value = null as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThan(0));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be less than 0.\r\nParameter name: value");
            }
        }

        public class IsLessThanOrEqualTo
        {
            [Fact]
            public void PassesWhenValueIsLessThanExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(2));

                ex.Should().BeNull();
            }

            [Fact]
            public void PassesWhenValueIsEqualToExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(1));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenValueIsGreaterThanExpected()
            {
                var value = 1;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(0));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be less than or equal to 0.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenNullableValueIsLessThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(2));

                ex.Should().BeNull();
            }

            [Fact]
            public void PassesWhenNullableValueIsEqualToExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(1));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenNullableValueIsGreaterThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(0));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be less than or equal to 0.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenNullableValueIsNull()
            {
                var value = null as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsLessThanOrEqualTo(0));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be less than or equal to 0.\r\nParameter name: value");
            }
        }

        public class IsNullOrGreaterThan
        {
            [Fact]
            public void FailsWhenNullableValueIsLessThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrGreaterThan(2));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be either null or greater than 2.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenNullableValueIsEqualToExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrGreaterThan(1));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be either null or greater than 1.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenNullableValueIsGreaterThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrGreaterThan(0));

                ex.Should().BeNull();
            }

            [Fact]
            public void PassesWhenNullableValueIsNull()
            {
                var value = null as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrGreaterThan(0));

                ex.Should().BeNull();
            }
        }

        public class IsNullOrGreaterThanOrEqualTo
        {
            [Fact]
            public void FailsWhenNullableValueIsLessThanExpected()
            {
                var value = new Nullable<int>(1);
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrGreaterThanOrEqualTo(2));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be either null or greater than or equal to 2.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenNullableValueIsEqualToExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrGreaterThanOrEqualTo(1));

                ex.Should().BeNull();
            }

            [Fact]
            public void PassesWhenNullableValueIsGreaterThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrGreaterThanOrEqualTo(0));

                ex.Should().BeNull();
            }

            [Fact]
            public void PassesWhenNullableValueIsNull()
            {
                var value = null as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrGreaterThanOrEqualTo(0));

                ex.Should().BeNull();
            }
        }

        public class IsNullOrLessThan
        {
            [Fact]
            public void PassesWhenNullableValueIsLessThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrLessThan(2));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenNullableValueIsEqualToExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrLessThan(1));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be either null or less than 1.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenNullableValueIsGreaterThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrLessThan(0));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be either null or less than 0.\r\nParameter name: value");
            }

            [Fact]
            public void PassesWhenNullableValueIsNull()
            {
                var value = null as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrLessThan(0));

                ex.Should().BeNull();
            }
        }

        public class IsNullOrLessThanOrEqualTo
        {

            [Fact]
            public void PassesWhenNullableValueIsLessThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrLessThanOrEqualTo(2));

                ex.Should().BeNull();
            }

            [Fact]
            public void PassesWhenNullableValueIsEqualToExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrLessThanOrEqualTo(1));

                ex.Should().BeNull();
            }

            [Fact]
            public void FailsWhenNullableValueIsGreaterThanExpected()
            {
                var value = 1 as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrLessThanOrEqualTo(0));

                ex.Should().NotBeNull();
                ex.Message.Should().Be("value should be either null or less than or equal to 0.\r\nParameter name: value");
            }

            [Fact]
            public void FailsWhenNullableValueIsNull()
            {
                var value = null as int?;
                var ex = Record.Exception(() => Guard.Requires(value, nameof(value)).IsNullOrLessThanOrEqualTo(0));

                ex.Should().BeNull();
            }
        }
    }
}
