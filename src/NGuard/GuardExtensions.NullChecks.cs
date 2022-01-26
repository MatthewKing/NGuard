using System.Diagnostics;

namespace NGuard;

public static partial class GuardExtensions
{
    /// <summary>
    /// Checks that the argument value is not null. An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T> IsNotNull<T>(this Guard<T> guard)
        where T : class
    {
        if (guard.Value == null)
        {
            throw new ArgumentNullException(
                paramName: guard.Name,
                message: $"{guard.Name} should not be null.");
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is not null. An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T?> IsNotNull<T>(this Guard<T?> guard)
        where T : struct
    {
        if (!guard.Value.HasValue)
        {
            throw new ArgumentNullException(
                paramName: guard.Name,
                message: $"{guard.Name} should not be null.");
        }

        return guard;
    }
}
