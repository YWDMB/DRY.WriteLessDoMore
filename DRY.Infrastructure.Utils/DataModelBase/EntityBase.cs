using System;
using System.ComponentModel.DataAnnotations;

namespace DRY.Infrastructure.Utils.DataModelBase
{
    /// <summary>
    /// 可持久到数据库的领域模型的基类。
    /// </summary>
    [Serializable]
    public abstract class EntityBase<TKey>
    {
        [Key]
        public TKey Id { get; set; }

    }
}
