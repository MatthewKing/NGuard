namespace NGuard
{
    using System;

    public static class GuardExtensions
    {
        public static Guard<T> IsNotNull<T>(this Guard<T> guard) where T : class
        {
            if (guard.Value == null)
            {
                string paramName = guard.ArgumentName;
                string message = String.Format(
                    "{0} should not be null.",
                    paramName);

                throw new ArgumentNullException(paramName, message);
            }

            return guard;
        }

        public static Guard<string> IsNotEmpty(this Guard<string> guard)
        {
            if (guard.Value != null && guard.Value.Length == 0)
            {
                string paramName = guard.ArgumentName;
                string message = String.Format(
                    "{0} should not be an empty string.",
                    paramName);

                throw new ArgumentNullException(paramName, message);
            }

            return guard;
        }

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
                    string paramName = guard.ArgumentName;
                    string message = String.Format(
                        "{0} should contain some non-white-space characters.",
                        paramName);

                    throw new ArgumentNullException(paramName, message);
                }
            }

            return guard;
        }
    }
}
