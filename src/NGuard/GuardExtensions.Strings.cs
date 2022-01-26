using System.Diagnostics;

namespace NGuard;

public static partial class GuardExtensions
{
    /// <summary>
    /// Checks that the argument value is not an empty string. An exception is thrown
    /// otherwise.
    /// </summary>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<string> IsNotEmpty(this Guard<string> guard)
    {
        if (guard.Value != null && guard.Value.Length == 0)
        {
            throw new ArgumentException(
                message: $"{guard.Name} should not be an empty string.",
                paramName: guard.Name);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is not comprised entirely of white-space characters.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<string> IsNotWhiteSpace(this Guard<string> guard)
    {
        if (guard.Value != null && guard.Value.Length > 0)
        {
            var whitespace = true;
            for (int i = 0; i < guard.Value.Length; i++)
            {
                if (!Char.IsWhiteSpace(guard.Value[i]))
                {
                    whitespace = false;
                    break;
                }
            }

            if (whitespace)
            {
                throw new ArgumentException(
                    message: $"{guard.Name} should not consist only of white-space characters.",
                    paramName: guard.Name);
            }
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is not null or an empty string. An exception is thrown
    /// otherwise.
    /// </summary>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<string> IsNotNullOrEmpty(this Guard<string> guard)
    {
        return guard.IsNotNull().IsNotEmpty();
    }

    /// <summary>
    /// Checks that the argument value is not null, an empty string, or comprised entirely
    /// of whitespace characters. An exception is thrown otherwise.
    /// </summary>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<string> IsNotNullOrEmptyOrWhiteSpace(this Guard<string> guard)
    {
        return guard.IsNotNull().IsNotEmpty().IsNotWhiteSpace();
    }

    /// <summary>
    /// Checks that the beginning of the argument value matches the specified string when
    /// compared using the specified comparison option. An exception is thrown otherwise.
    /// </summary>
    /// <param name="guard">
    /// The guard instance that holds the argument to be checked.
    /// </param>
    /// <param name="value">
    /// The string to compare.
    /// </param>
    /// <param name="comparisonType">
    /// A <see cref="StringComparison"/> value that determines how the strings are compared.
    /// </param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<string> StartsWith(this Guard<string> guard, string value, StringComparison comparisonType = StringComparison.CurrentCulture)
    {
        if (guard.Value == null || !guard.Value.StartsWith(value, comparisonType))
        {
            throw new ArgumentException(
                message: $"{guard.Name} should start with '{value}'.",
                paramName: guard.Name);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the end of the argument value matches the specified string when
    /// compared using the specified comparison option. An exception is thrown otherwise.
    /// </summary>
    /// <param name="guard">
    /// The guard instance that holds the argument to be checked.
    /// </param>
    /// <param name="value">
    /// The string to compare.
    /// </param>
    /// <param name="comparisonType">
    /// A <see cref="StringComparison"/> value that determines how the strings are compared.
    /// </param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<string> EndsWith(this Guard<string> guard, string value, StringComparison comparisonType = StringComparison.CurrentCulture)
    {
        if (guard.Value == null || !guard.Value.EndsWith(value, comparisonType))
        {
            throw new ArgumentException(
                message: $"{guard.Name} should end with '{value}'.",
                paramName: guard.Name);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value contains the specified string when
    /// compared using the specified comparison option.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <param name="guard">
    /// The guard instance that holds the argument to be checked.
    /// </param>
    /// <param name="value">
    /// The string to compare.
    /// </param>
    /// <param name="comparisonType">
    /// A <see cref="StringComparison"/> value that determines how the strings are compared.
    /// </param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<string> Contains(this Guard<string> guard, string value, StringComparison comparisonType = StringComparison.CurrentCulture)
    {
        if (guard.Value == null || guard.Value.IndexOf(value, comparisonType) < 0)
        {
            throw new ArgumentException(
                message: $"{guard.Name} should contain '{value}'.",
                paramName: guard.Name);
        }

        return guard;
    }
}
