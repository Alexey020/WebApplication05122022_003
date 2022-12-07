using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication05122022_003.Helpers;
using WebApplication05122022_003.Services;

namespace WebApplication05122022_003.Controllers
{
    public class GoogleOAuthController : Controller
    {
        private const string RedirectUrl = "https://localhost:44374";
        //private const string RedirectUrl = "https://localhost:44374/GoogleOAuth/Code";
        private const string YouTubeScope = "https://www.googleapis.com/auth/youtube";
        private const string PkceSessionKey = "codeVerifier";
        public IActionResult RedirectToOAuthServer()
        {
            var codeVerifier = Guid.NewGuid().ToString();
            var codeChellange = Sha256Helper.ComputeHash(codeVerifier);

            var url = GoogleOAuthService.GenerateRequestUrl(RedirectUrl, YouTubeScope, codeChellange);
            return Redirect(url);
        }
        public IActionResult Code(string code)//client is reciving code here
        {
            var tokenResult = GoogleOAuthService.ExchangeCodeOnAccessToken(code, "some", "some");
            return Ok();
        }

    }
}
