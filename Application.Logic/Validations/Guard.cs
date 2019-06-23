namespace Application.Logic.Validations
{
    using System;

    public static class Guard
    {
        public static void ArgumentIsNull(object param, string name)
        {
            if (param == null)
            {
                throw new ArgumentNullException(name, string.Format("{0} is null", param.GetType().Name));
            }
        }

        public static void ArgumentIsEmpty(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(value, string.Format("{0} is null or empty", paramName));
            }
        }

        public static void ArgumentIsEmpty(int value, string paramName)
        {
            if (value == 0)
            {
                throw new ArgumentException(string.Format("{0} is null or empty", paramName));
            }
        }
    }
}
