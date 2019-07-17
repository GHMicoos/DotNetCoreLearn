using System;
using System.Collections.Generic;
using System.Text;

namespace MiCo.Tool.ExtendsionMethod
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringExtendsion
    {

        /// <summary>
        /// 字符串判断 null 和 空字符串
        /// </summary>
        /// <param name="_this"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string _this)
        {
            return string.IsNullOrEmpty(_this);
        }

        /// <summary>
        /// 字符串判断 null 空字符串 空白字符串
        /// </summary>
        /// <param name="_this"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string _this)
        {
            return string.IsNullOrWhiteSpace(_this);
        }
    }
}
