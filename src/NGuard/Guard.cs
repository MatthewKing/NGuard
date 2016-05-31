namespace NGuard
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Facilitates the instantiation of Guard&lt;T&gt; instances.
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// Returns a new Guard&lt;T&gt; that facilitates the validation of the specified argument.
        /// </summary>
        /// <typeparam name="T">The type of the argument.</typeparam>
        /// <param name="value">The value of the argument.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <returns>
        /// A new Guard&lt;T&gt; that facilitates the validation of the specified argument.
        /// </returns>
        public static Guard<T> Requires<T>(T value, string parameterName)
        {
            return new Guard<T>(value, parameterName);
        }
    }

    /// <summary>
    /// Facilitates the validation of the specified argument.
    /// </summary>
    /// <typeparam name="T">The type of the argument</typeparam>
    public sealed class Guard<T>
    {
        /// <summary>
        /// Gets the name of the parameter.
        /// </summary>
        public string ParameterName { get; private set; }

        /// <summary>
        /// Gets the value of the argument.
        /// </summary>
        public T Value { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Guard class.
        /// </summary>
        /// <param name="value">The value of the argument.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        public Guard(T value, string parameterName)
        {
            this.Value = value;
            this.ParameterName = parameterName;
        }

        #region System.Object methods

        // We're giving each of the System.Object methods an EditorBrowsableAttribute with
        // EditorBrowsableState.Never in order to hide them in the public API.

        /// <summary>
        /// Gets the System.Type of the current instance.
        /// </summary>
        /// <returns>
        /// The exact runtime type of the current instance.
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return base.GetType();
        }

        /// <summary>
        /// Determines whether the specified System.Object is equal to the current System.Object.
        /// </summary>
        /// <param name="obj">
        /// The object to compare with the current object.
        /// </param>
        /// <returns>
        /// true if the specified object is equal to the current object; otherwise, false.
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>
        /// A hash code for the current System.Object.
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion
    }
}
