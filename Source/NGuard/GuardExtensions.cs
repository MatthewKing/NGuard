namespace NGuard
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// Extension methods for NGuard.Guard.
    /// </summary>
    public static class GuardExtensions
    {
        /// <summary>
        /// Checks that the argument value is equal to the specified value. An exception is
        /// thrown otherwise.
        /// </summary>
        /// <typeparam name="T">The type of the argument.</typeparam>
        /// <param name="guard">The guard instance that holds the argument to be checked.</param>
        /// <param name="value">The value to compare the argument value with.</param>
        /// <returns>The specified guard instance.</returns>
        [DebuggerStepThrough]
        public static Guard<T> IsEqualTo<T>(this Guard<T> guard, T value)
        {
            return IsEqualTo(guard, value, EqualityComparer<T>.Default);
        }

        /// <summary>
        /// Checks that the argument value is equal to the specified value. An exception is
        /// thrown otherwise.
        /// </summary>
        /// <typeparam name="T">The type of the argument.</typeparam>
        /// <param name="guard">The guard instance that holds the argument to be checked.</param>
        /// <param name="value">The value to compare the argument value with.</param>
        /// <param name="comparer">An equality comparer to compare values.</param>
        /// <returns>The specified guard instance.</returns>
        [DebuggerStepThrough]
        public static Guard<T> IsEqualTo<T>(this Guard<T> guard,
            T value, IEqualityComparer<T> comparer)
        {
            if (comparer == null)
            {
                comparer = EqualityComparer<T>.Default;
            }

            if (!comparer.Equals(guard.Value, value))
            {
                string paramName = guard.ParameterName;
                string message = paramName + " should be equal to " + value.ToString();
                throw new ArgumentException(message, paramName);
            }

            return guard;
        }

        /// <summary>
        /// Checks whether the argument value is not equal to the specified value. An exception
        /// is thrown otherwise.
        /// </summary>
        /// <typeparam name="T">The type of the argument.</typeparam>
        /// <param name="guard">The guard instance that holds the argument to be checked.</param>
        /// <param name="value">The value to compare the argument value with.</param>
        /// <returns>The specified guard instance.</returns>
        [DebuggerStepThrough]
        public static Guard<T> IsNotEqualTo<T>(this Guard<T> guard, T value)
        {
            return IsNotEqualTo(guard, value, EqualityComparer<T>.Default);
        }

        /// <summary>
        /// Checks whether the argument value is not equal to the specified value. An exception
        /// is thrown otherwise.
        /// </summary>
        /// <typeparam name="T">The type of the argument.</typeparam>
        /// <param name="guard">The guard instance that holds the argument to be checked.</param>
        /// <param name="value">The value to compare the argument value with.</param>
        /// <param name="comparer">An equality comparer to compare values.</param>
        /// <returns>The specified guard instance.</returns>
        [DebuggerStepThrough]
        public static Guard<T> IsNotEqualTo<T>(this Guard<T> guard,
            T value, IEqualityComparer<T> comparer)
        {
            if (comparer == null)
            {
                comparer = EqualityComparer<T>.Default;
            }

            if (comparer.Equals(guard.Value, value))
            {
                string paramName = guard.ParameterName;
                string message = paramName + " should not be equal to " + value.ToString();
                throw new ArgumentException(message, paramName);
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
        public static Guard<T> IsNotNull<T>(this Guard<T> guard) where T : class
        {
            if (guard.Value == null)
            {
                string paramName = guard.ParameterName;
                string message = String.Format(
                    "{0} should not be null.",
                    paramName);

                throw new ArgumentNullException(paramName, message);
            }

            return guard;
        }

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
                string paramName = guard.ParameterName;
                string message = String.Format(
                    "{0} should not be an empty string.",
                    paramName);

                throw new ArgumentException(message, paramName);
            }

            return guard;
        }

        /// <summary>
        /// Checks that the argument value is not comprised entirely of whitespace characters.
        /// An exception is thrown otherwise.
        /// </summary>
        /// <param name="guard">The guard instance that holds the argument to be checked.</param>
        /// <returns>The specified guard instance.</returns>
        [DebuggerStepThrough]
        public static Guard<string> IsNotWhiteSpace(this Guard<string> guard)
        {
            if (guard.Value != null && guard.Value.Length > 0)
            {
                bool whitespace = true;
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
                    string paramName = guard.ParameterName;
                    string message = String.Format(
                        "{0} should contain some non-white-space characters.",
                        paramName);

                    throw new ArgumentNullException(paramName, message);
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
    }
}
