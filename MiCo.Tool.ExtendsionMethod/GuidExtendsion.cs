using System;
using System.Collections.Generic;
using System.Text;

namespace MiCo.Tool.ExtendsionMethod
{
    public static class GuidExtendsion
    {
        /// <summary>
        /// 值是否为非empty的Guid
        /// </summary>
        /// <param name="_this"></param>
        /// <returns></returns>
        public static bool IsGuidNoEmpty(this Guid? _this)
            => _this.HasValue ? (Guid.Empty != _this.Value) : false;

        /// <summary>
        /// 值是否为非empty的Guid
        /// </summary>
        /// <param name="_this"></param>
        /// <returns></returns>
        public static bool IsGuidNoEmpty(this Guid _this)
            => Guid.Empty == _this;
    }
}
