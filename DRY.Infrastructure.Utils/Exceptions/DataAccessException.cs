using System;
using System.Runtime.Serialization;

namespace DRY.Infrastructure.Utils.Exceptions
{
    /// <summary>
    /// 数据访问层异常类，用于封装数据访问层引发的异常，以供【业务逻辑层】抓取
    /// </summary>
    [Serializable]
    public class DataAccessException : Exception
    {

        public DataAccessException(string message): base(message){}
        public DataAccessException(string message, Exception inner): base(message, inner){}
        protected DataAccessException(SerializationInfo info, StreamingContext context): base(info, context){}
    }
}