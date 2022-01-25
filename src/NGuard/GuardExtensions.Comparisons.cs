using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace NGuard;

public static partial class GuardExtensions
{
    /// <summary>
    /// Checks that the argument value is greater than the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T> IsGreaterThan<T>(this Guard<T> guard, T value, IComparer<T> comparer = null)
        where T : IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (guard.Value == null || comparer.Compare(guard.Value, value) <= 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be greater than {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is greater than the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T?> IsGreaterThan<T>(this Guard<T?> guard, T value, IComparer<T> comparer = null)
        where T : struct, IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (!guard.Value.HasValue || comparer.Compare(guard.Value.Value, value) <= 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be greater than {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is either null or greater than the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T?> IsNullOrGreaterThan<T>(this Guard<T?> guard, T value, IComparer<T> comparer = null)
        where T : struct, IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (guard.Value.HasValue && comparer.Compare(guard.Value.Value, value) <= 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be either null or greater than {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is greater than or equal to the specified comparison
    /// value. An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T> IsGreaterThanOrEqualTo<T>(this Guard<T> guard, T value, IComparer<T> comparer = null)
        where T : IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (guard.Value == null || comparer.Compare(guard.Value, value) < 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be greater than or equal to {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is greater than or equal to the specified comparison
    /// value. An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T?> IsGreaterThanOrEqualTo<T>(this Guard<T?> guard, T value, IComparer<T> comparer = null)
        where T : struct, IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (!guard.Value.HasValue || comparer.Compare(guard.Value.Value, value) < 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be greater than or equal to {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is either null or greater than or equal to the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T?> IsNullOrGreaterThanOrEqualTo<T>(this Guard<T?> guard, T value, IComparer<T> comparer = null)
        where T : struct, IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (guard.Value.HasValue && comparer.Compare(guard.Value.Value, value) < 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be either null or greater than or equal to {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is less than the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T> IsLessThan<T>(this Guard<T> guard, T value, IComparer<T> comparer = null)
        where T : IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (guard.Value == null || comparer.Compare(guard.Value, value) >= 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be less than {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is less than the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T?> IsLessThan<T>(this Guard<T?> guard, T value, IComparer<T> comparer = null)
        where T : struct, IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (!guard.Value.HasValue || comparer.Compare(guard.Value.Value, value) >= 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be less than {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is either null or less than the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T?> IsNullOrLessThan<T>(this Guard<T?> guard, T value, IComparer<T> comparer = null)
        where T : struct, IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (guard.Value.HasValue && comparer.Compare(guard.Value.Value, value) >= 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be either null or less than {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is less than or equal to the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T> IsLessThanOrEqualTo<T>(this Guard<T> guard, T value, IComparer<T> comparer = null)
        where T : IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (guard.Value == null || comparer.Compare(guard.Value, value) > 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be less than or equal to {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is less than or equal to the specified comparison
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T?> IsLessThanOrEqualTo<T>(this Guard<T?> guard, T value, IComparer<T> comparer = null)
        where T : struct, IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (!guard.Value.HasValue || comparer.Compare(guard.Value.Value, value) > 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be less than or equal to {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }

    /// <summary>
    /// Checks that the argument value is either null or less than or equal to the specified comparison value.
    /// An exception is thrown otherwise.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    /// <param name="guard">The guard instance that holds the argument to be checked.</param>
    /// <param name="value">The value to compare the argument value with.</param>
    /// <param name="comparer">A comparer to compare values. If null, the default comparer will be used.</param>
    /// <returns>The specified guard instance.</returns>
    [DebuggerStepThrough]
    public static Guard<T?> IsNullOrLessThanOrEqualTo<T>(this Guard<T?> guard, T value, IComparer<T> comparer = null)
        where T : struct, IComparable<T>
    {
        comparer = comparer ?? Comparer<T>.Default;

        if (guard.Value.HasValue && comparer.Compare(guard.Value.Value, value) > 0)
        {
            var paramName = guard.ParameterName;
            var message = $"{paramName} should be either null or less than or equal to {value}.";
            throw new ArgumentOutOfRangeException(paramName, message);
        }

        return guard;
    }
}
