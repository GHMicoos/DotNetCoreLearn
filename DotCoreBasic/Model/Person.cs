using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotCoreBasic.Model
{
    public class Person
    {
        /// <summary>
        /// 名
        /// </summary>
        [Required(ErrorMessage ="FirstName 不能为空。")]
        public string FirstName { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        [StringLength(10,MinimumLength =1)]
        public string LastName { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        [Required]
        public decimal? Height { get; set; }

    }
}
