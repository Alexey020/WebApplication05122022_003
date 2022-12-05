﻿using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication05122022_003.Services;

namespace WebApplication05122022_003.Controllers
{
    public class GoogleOAuthController : Controller
    {
        public IActionResult RedirectToOAuthServer()
        {
            var url = GoogleOAuthService.GenerateRequestUrl();
            return Redirect(url);
        }
        public IActionResult Code(string code)
        {
            var tokenResult = GoogleOAuthService.ExchangeCodeOnAccessToken(code);
            return Ok();
        }

    }
}
