namespace Application.Logic.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class ProductLocaleNameAlreadyExistsException : Exception
    {
        public ProductLocaleNameAlreadyExistsException(string message, Exception inner) : base(message, inner) { }

        protected ProductLocaleNameAlreadyExistsException(
            SerializationInfo info,
          StreamingContext context)
            : base(info, context) { }

        public ProductLocaleNameAlreadyExistsException(string message) : base(message) { }

        public ProductLocaleNameAlreadyExistsException() { }
    }
}
