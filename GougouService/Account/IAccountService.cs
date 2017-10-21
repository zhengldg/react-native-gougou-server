using GougouModel;
using GougouModel.Account.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GougouService.Account
{
    public interface IAccountService
    {
        APIResult UploadAvatar(UploadAvatarInput input);
    }
}
