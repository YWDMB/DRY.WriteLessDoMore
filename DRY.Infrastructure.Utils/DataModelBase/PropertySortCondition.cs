﻿using System.ComponentModel;

namespace DRY.Infrastructure.Utils.DataModelBase
{
    /// <summary>
    /// 属性排序条件信息类
    /// </summary>
    public class PropertySortCondition
    {
        #region 属性
        /// <summary>
        /// 获取或设置 排序属性名称
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// 获取或设置 排序方向
        /// </summary>
        public ListSortDirection ListSortDirection { get; set; }
        #endregion

        #region 构造函数
        /// <summary>
        ///  构造一个排序属性名称和排序方式的排序条件
        /// </summary>
        /// <param name="propertyName">排序属性名称</param>
        /// <param name="listSortDirection">排序方式</param>
        public PropertySortCondition(string propertyName, ListSortDirection listSortDirection)
        {
            PropertyName = propertyName;
            ListSortDirection = listSortDirection;
        }

        /// <summary>
        ///  构造一个指定属性名称的升序排序的排序条件
        /// </summary>
        /// <param name="propertyName">排序属性名称</param>
        public PropertySortCondition(string propertyName): this(propertyName, ListSortDirection.Ascending) { }
        #endregion

    }
}
