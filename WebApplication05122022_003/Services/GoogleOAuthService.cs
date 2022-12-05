using System;
namespace WebApplication05122022_003.Services
{
    public class GoogleOAuthService
    {
        public static string ClientId { get; } = "243887951104-rm4hhimqradh9jlrohp7gt0fcvra2otj.apps.googleusercontent.com";
        public static string ClientSecret { get; } = "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";


        public static string GenerateRequestUrl()
        {
            throw new NotImplementedException();
        }

        public static object ExchangeCodeOnAccessToken(string code)
        {
            throw new NotImplementedException();
        }
        public static object RefreshToken(string resreshTokent)
        {
            throw new NotImplementedException();
        }

    }
}
