using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace MiCo.Tool.ExtendsionMethod
{
    public static class EnumExtendsion
    {
        /// <summary>
        /// 判断当前值是否TEnum定义的枚举值（可空类型）
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="_this"></param>
        /// <returns></returns>
        public static bool IsDefineEnumValue<TEnum>(this TEnum? _this) where TEnum : struct
        {
            try
            {
                if (!_this.HasValue) return false;
                if (System.Enum.IsDefined(typeof(TEnum), _this))
                {
                    return true;
                }
            }
            catch { }
            return false;

        }

        /// <summary>
        /// 判断当前值是否TEnum定义的枚举值（可空类型）
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="_this"></param>
        /// <returns></returns>
        public static bool IsDefineEnumValue<TEnum>(this TEnum _this) where TEnum : struct
        {
            try
            {
                if (System.Enum.IsDefined(typeof(TEnum), _this))
                {
                    return true;
                }
            }
            catch { }
            return false;

        }


        /// <summary>
        /// 获取枚举的描述字符串(通过Description)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescripetion<T>(this T value) where T : struct
        {
            string result = "";
            try
            {
                if (value is System.Enum)
                {
                    string str = value.ToString();
                    FieldInfo field = value.GetType().GetField(str);
                    object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (objs != null && objs.Length != 0)
                    {
                        DescriptionAttribute da = objs[0] as DescriptionAttribute;
                        if (!string.IsNullOrWhiteSpace(da.Description))
                        {
                            result = da.Description;
                        }
                    }
                }
            }
            catch { }
            return result;
        }
    }
}
