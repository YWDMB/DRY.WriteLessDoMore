using System.ComponentModel;

namespace DRY.Infrastructure.Utils.Result
{
    /// <summary>
    /// 表示业务操作结果的枚举
    /// </summary>
    [Description("业务操作结果的枚举")]
    public enum OperationResultType
    {
        [Description("操作成功。")]
        Success,

        [Description("操作没有引发任何变化，提交取消。")]
        NoChanged,

        [Description("参数错误。")]
        ParamError,

        [Description("指定参数的数据不存在。")]
        QueryNull,

        [Description("当前用户权限不足，不能继续操作。")]
        PurviewLack,

        [Description("非法操作。")]
        IllegalOperation,

        /// <summary>
        /// 警告
        /// </summary>
        [Description("警告")]
        Warning,

        [Description("操作引发错误。")]
        Error,
    }

}
