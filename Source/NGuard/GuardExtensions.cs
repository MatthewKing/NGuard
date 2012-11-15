namespace NGuard
{
    using System;

    /// <summary>
    /// Extension methods for NGuard.Guard.
    /// </summary>
    public static class GuardExtensions
    {
        /// <summary>
        /// Checks that the specified value is not null. An exception is thrown otherwise.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="guard">The guard instance that holds the value to be checked.</param>
        /// <returns>The specified guard instance.</returns>
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
        /// Checks that the specified value is not an empty string. An exception is thrown
        /// otherwise.
        /// </summary>
        /// <param name="guard">The guard instance that holds the value to be checked.</param>
        /// <returns>The specified guard instance.</returns>
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
        /// Checks that the specified value is not comprised entirely of whitespace characters.
        /// An exception is thrown otherwise.
        /// </summary>
        /// <param name="guard">The guard instance that holds the value to be checked.</param>
        /// <returns>The specified guard instance.</returns>
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
        /// Checks that the specified value is not null or an empty string. An exception is thrown
        /// otherwise.
        /// </summary>
        /// <param name="guard">The guard instance that holds the value to be checked.</param>
        /// <returns>The specified guard instance.</returns>
        public static Guard<string> IsNotNullOrEmpty(this Guard<string> guard)
        {
            return guard.IsNotNull().IsNotEmpty();
        }

        /// <summary>
        /// Checks that the specified value is not null, an empty string, or comprised entirely
        /// of whitespace characters. An exception is thrown otherwise.
        /// </summary>
        /// <param name="guard">The guard instance that holds the value to be checked.</param>
        /// <returns>The specified guard instance.</returns>
        public static Guard<string> IsNotNullOrEmptyOrWhiteSpace(this Guard<string> guard)
        {
            return guard.IsNotNull().IsNotEmpty().IsNotWhiteSpace();
        }
    }
}
