#if NET5_0_OR_GREATER

using FluentAssertions;
using Xunit;

namespace NGuard.Tests;

public class CallerArgumentExpression
{
    [Fact]
    public void Parameter()
    {
        var parameter = 110;
        var action = () => Guard.Requires(parameter).IsLessThan(100);

        action.Should()
            .Throw<ArgumentOutOfRangeException>()
            .WithMessage("parameter (110) should be less than 100.*");
    }

    [Fact]
    public void Expression()
    {
        var action = () => Guard.Requires(50 + 60).IsLessThan(100);

        action.Should()
            .Throw<ArgumentOutOfRangeException>()
            .WithMessage("50 + 60 (110) should be less than 100.*");
    }

    [Fact]
    public void ManuallySpecified()
    {
        var action = () => Guard.Requires(110, "ManuallySpecifiedName").IsLessThan(100);

        action.Should()
            .Throw<ArgumentOutOfRangeException>()
            .WithMessage("ManuallySpecifiedName (110) should be less than 100.*");
    }
}

#endif
