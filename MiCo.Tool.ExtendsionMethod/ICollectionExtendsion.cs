using System;
using System.Collections.Generic;
using System.Text;

namespace MiCo.Tool.ExtendsionMethod
{
    public static class ICollectionExtendsion
    {
        /// <summary>
        /// 添加addItem到集合，当addItem!=null。
        /// </summary>
        /// <typeparam name="T">泛型类型</typeparam>
        /// <param name="_this">集合</param>
        /// <param name="addItem">待插入项</param>
        /// <returns>成功插入，返回true；否则返回false</returns>
        public static bool AddNotNull<T>(this ICollection<T> _this, T addItem)
        {
            if (_this == null || addItem == null) return false;
            _this.Add(addItem);
            return true;
        }










    }
}
