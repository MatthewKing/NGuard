namespace NGuard
{
    using System;
    using System.ComponentModel;

    public static class Guard
    {
        public static Guard<T> Requires<T>(T value, string argumentName)
        {
            return new Guard<T>(value, argumentName);
        }
    }

    public sealed class Guard<T>
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ArgumentName { get; private set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public T Value { get; private set; }

        public Guard(T value, string argumentName)
        {
            this.Value = value;
            this.ArgumentName = argumentName;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType()
        {
            return base.GetType();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
