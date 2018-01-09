using System;
using System.Runtime.Serialization;

namespace DRY.Infrastructure.Utils.Exceptions
{

    /// <summary>
    /// 客户端异常类
    /// </summary>
    [Serializable]
    public class CustomerException : Exception
    {

        public CustomerException(string message) : base(message) { }
        public CustomerException(string message, Exception inner) : base(message, inner) { }
        protected CustomerException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
