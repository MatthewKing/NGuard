using System.Diagnostics;

namespace NGuard;

public static partial class GuardExtensions
{
    /// <summary>
    /// Checks that the argument value is equal to the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">An equality comparer to compare values.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T> IsEqualTo<T>(this Guard<T> guard, T value, IEqualityComparer<T> comparer = null)
    {
        comparer = comparer ?? EqualityComparer<T>.Default;

        if (!comparer.Equals(guard.Value, value))
        {
            throw new ArgumentException(
                message: $"{guard.Name} should be equal to '{value}'.",
                paramName: guard.Name);
        }

        return guard;
    }

    /// <summary>
    /// Checks whether the argument value is not equal to the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">An equality comparer to compare values.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T> IsNotEqualTo<T>(this Guard<T> guard, T value, IEqualityComparer<T> comparer = null)
    {
        comparer = comparer ?? EqualityComparer<T>.Default;

        if (comparer.Equals(guard.Value, value))
        {
            throw new ArgumentException(
                message: $"{guard.Name} should not be equal to '{value}'.",
                paramName: guard.Name);
        }

        return guard;
    }
}
