using GougouModel.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GougouServer.Controllers
{
    /// <summary>
    /// 测试
    /// </summary>
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private QiniuConfig qiniuOption;
        private ILogger<ValuesController> logger;

        public ValuesController(IOptions<QiniuConfig> qiniuOption
            , ILogger<ValuesController> logger
            )
        {
            this.qiniuOption = qiniuOption.Value;
            this.logger = logger;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            logger.LogInformation("get:" + id);
            return this.qiniuOption.APP_KEY;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
