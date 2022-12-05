using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication05122022_003.Services;

namespace WebApplication05122022_003.Controllers
{
    public class GoogleOAuthController : Controller
    {
        public static IActionResult RedirectToOAuthServer()
        {
            var url = GoogleOAuthService.GenerateRequestUrl();
            return RedirectToOAuthServer()
            throw new NotImplementedException();
        }

    }
}
