//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

//namespace DotCoreBasic.ModelValidation
//{
//    /// <summary>
//    /// 验证定义的枚举
//    /// </summary>
//    public class DefineEnumAttribute: ValidationAttribute
//    {
//        /// <summary>
//        /// 验证类型
//        /// </summary>
//        private Type _type;

//        /// <summary>
//        /// 验证值
//        /// </summary>
//        private IList<object> _typeDefineValues;

//        /// <summary>
//        /// 枚举类型，为验证对象类型。
//        /// </summary>
//        public DefineEnumAttribute()
//        {

//        }

//        /// <summary>
//        /// 传入指定的验证类型
//        /// </summary>
//        /// <param name="type">指定的验证类型，该类型可以不是对象的定义类型</param>
//        public DefineEnumAttribute(Type type)
//        {
//            _type = type;
//            _typeDefineValues = null;
//        }

//        /// <summary>
//        /// 传入指定的验证类型，和验证值。（验证值，必须为验证类型定义的值，不然会报异常。）
//        /// </summary>
//        /// <param name="type">指定的验证类型，该类型可以不是对象的定义类型</param>
//        /// <param name="typeDefineValues">指定类型中定义的部分或全部值</param>
//        public DefineEnumAttribute(Type type, List<object> typeDefineValues)
//        {
//            _type = type;
//            _typeDefineValues = typeDefineValues;
//        }
        
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="value"></param>
//        /// <param name="validationContext"></param>
//        /// <returns></returns>
//        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//        {
//            if (_type == null)
//                _type = value.GetType();
//            if(value.GetType().IsImport)



//            if (value == null)
//                return new ValidationResult($"{validationContext.DisplayName}传入值不能为null。");

//            if (!System.Enum.IsDefined(_type, value))
//                return new ValidationResult($"{validationContext.DisplayName}的传入值{value}不是预定义的枚举值。");

//            var hasValue = false;
//            if (!(_valueType?.Count > 0)) hasValue = true;
//            var vaildValus = "[";

//            foreach (var item in _valueType ?? new List<object>())
//            {
//                if (!System.Enum.IsDefined(_type, value))
//                {
//                    return new ValidationResult($"{validationContext.DisplayName}的验证值{item}不是预定义的枚举值。");
//                }
//                if (item == value) hasValue = true;
//                vaildValus += item + ",";
//            }
//            if (vaildValus.Length > 1)
//                vaildValus = vaildValus.Substring(0, vaildValus.Length - 1);

//            vaildValus += "]";

//            if (!hasValue)
//                return new ValidationResult($"{validationContext.DisplayName}的传入值{value}不是{vaildValus}中的值。");


//            return ValidationResult.Success;
//        }

//    }
//}
