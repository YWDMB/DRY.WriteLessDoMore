using System;
using System.Runtime.Serialization;

namespace DRY.Infrastructure.Utils.Exceptions
{
    /// <summary>
    /// 业务逻辑层异常类，用于封装业务逻辑层引发的异常，以供【展现层】抓取
    /// </summary>
    [Serializable]
    public class BusinessException : Exception
    {

        public BusinessException(string message): base(message) { }
        public BusinessException(string message, Exception inner): base(message, inner) { }
        protected BusinessException(SerializationInfo info, StreamingContext context): base(info, context) { }
    }
}