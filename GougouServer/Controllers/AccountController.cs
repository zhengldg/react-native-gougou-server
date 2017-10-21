using GougouModel;
using GougouModel.Account.Dtos;
using GougouService.Account;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GougouServer.Controllers
{
    /// <summary>
    /// 账户
    /// </summary>
    [Route("api/u")]
    public class AccountController : Controller
    {

        /// <summary>
        /// 上传狗狗头像
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost("uploadAvatar")]
        public APIResult UploadAvatar(UploadAvatarInput files)
        {
            var service = new AccountService();
            var result = service.UploadAvatar(files);
            return result;
        }

        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet("verifycode")]
        public ActionResult SendVerifyCode()
        {
            return Ok();
        }
    }
}
