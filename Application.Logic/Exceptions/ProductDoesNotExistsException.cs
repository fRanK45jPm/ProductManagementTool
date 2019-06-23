namespace Application.Logic.Exceptions
{
    using System;

    [Serializable]
    public class ProductDoesNotExistsException : Exception
    {
        public ProductDoesNotExistsException() { }
        public ProductDoesNotExistsException(string message) : base(message) { }
        public ProductDoesNotExistsException(string message, Exception inner) : base(message, inner) { }
        protected ProductDoesNotExistsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
