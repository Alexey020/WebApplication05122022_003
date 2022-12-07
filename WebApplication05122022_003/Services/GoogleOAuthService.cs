using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;

namespace WebApplication05122022_003.Services
{
    public class GoogleOAuthService
    {
        public static string ClientId { get; } = "243887951104-rm4hhimqradh9jlrohp7gt0fcvra2otj.apps.googleusercontent.com";
        public static string ClientSecret { get; } = "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";

        const string  oAuthServerEndPoint = "https://accounts.google.com/o/oauth2/v2/auth";
        string  TokenServerEndPoint = "https://oauth2.googleapis.com/token";


        public static string GenerateRequestUrl(string redirectUri, string scope, string codeChallenge)
        {

            var queryParams = new Dictionary<string,string>()
            {
                {"client_id", ClientId},
                {"redirect_uri",redirectUri },
                {"response_type", "code" },
                {"scope", scope },
                {"code_challenge", codeChallenge },
                {"code_challenge_method", "S256" }//,
               // {"access_type", "ofline" }
            };
           
            string url = QueryHelpers.AddQueryString(oAuthServerEndPoint, queryParams);
            
            return url;
        }

        public static object ExchangeCodeOnAccessToken(string code, string codeVerifier,string redirectUrl)
        {
            var authParams = new Dictionary<string, string>()
            {
                { "client_id", ClientId},
                { "client_secret", ClientSecret},
                { "code", code},
                { "code_verifier", codeVerifier  },
                { "grant_type", "authorization_code" },
                { "redirect_uri", redirectUrl },
            };

            var tokenResult = new object();//TODO: create helper for SendPostRequest<token result tyoe>(tokenServerEndPoint, authParams)
            return tokenResult;
        }
        public static object RefreshToken(string refreshToken)
        {
            var queryParams = new Dictionary<string, string>()
            {
                {"client_id", ClientId},
                {"client_secret", ClientSecret},
                {"grant_type", "refresh_token"},
                {"refresh_token", refreshToken},

            };
            var tokenResult = new object();//TODO: create helper for SendPostRequest<token result tyoe>(tokenServerEndPoint, authParams)
            return tokenResult;
        }

    }
}
