namespace Application.Logic.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Serializable]
    public class ProductDisplayNameDoesNotExistsException : Exception
    {
        public ProductDisplayNameDoesNotExistsException() { }
        public ProductDisplayNameDoesNotExistsException(string message) : base(message) { }
        public ProductDisplayNameDoesNotExistsException(string message, Exception inner) : base(message, inner) { }
        protected ProductDisplayNameDoesNotExistsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
