using DotCoreBasic.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotCoreBasic.Controllers
{
    [Route("[controller]")]
    //ApiController 属性使模型验证错误自动触发 HTTP 400 响应。 因此，操作方法中不需要以下代码：
    /*if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
     * */
    //[ApiController]
    public class ModelValidationController: ControllerBase
    {
        private string CheckModelIsVaild()
        {
            if (!ModelState.IsValid)
            {
                var validString = string.Empty;

                foreach (var item in ModelState.Values)
                {
                    foreach (var jitem in item.Errors)
                    {
                        validString += jitem?.ErrorMessage + " | ";
                    }
                }
                return $"模型错误：{validString}";
            }
            return string.Empty;
        }
        
        [Route("[action]")]
        public IActionResult Validation(Person param)
        {
            return new ContentResult() {Content= CheckModelIsVaild() };
        }
        
        [Route("[action]")]
        public async Task<IActionResult> ValidationAgainTry(Person param)
        {
            var nowStartTime = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1));
            var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));

            param.Height = (decimal)1.0;
            //在调用TryValidateModel前，调用Clear(),否则ModelState不会被重置
            ModelState.Clear();
            var result=TryValidateModel(param);
           
            return new ContentResult() { Content = CheckModelIsVaild() };
        }


    }
}
