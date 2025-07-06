﻿using B2W.Models.Authentication;

namespace B2W.Service
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> LoginAsync(LoginModel model);
        Task<string> AddrolesAsync(AddRoleModel model);
        Task SendEmailAsync(mailrequest mailrequest ,string? token = null);
        Task<string> SendTokenToEmailAsync(string email);
        Task<string> ResetPasswordAsync(resetpassword model);

    }
}
