using System;
using System.Collections.Generic;

namespace WebApplication05122022_003.Services
{
    public class GoogleOAuthService
    {
        public static string ClientId { get; } = "243887951104-rm4hhimqradh9jlrohp7gt0fcvra2otj.apps.googleusercontent.com";
        public static string ClientSecret { get; } = "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";

        string  oAuthServerEndPoint = "https://accounts.google.com/o/oauth2/v2/auth";
        string  TokenServerEndPoint = "https://oauth2.googleapis.com/token";


        public static string GenerateRequestUrl(string redirectUri,string scope, string codeChallenge)
        {

            var queryParams = new Dictionary<string,string>()
            {
                {"client_id", ClientId},
                {"redirect_uri",redirectUri },
                {"response_type", "code" },
                {"scope", scope },
                {"code_challenge", codeChallenge },
                {"code_challenge_method", "S256" },
                {"access_type", "ofline" }
            };
            //TODO: helper for creating url ------https://accounts.google.com/o/oauth2/v2/auth?
            //                                    scope = email % 20profile &
            //                                    response_type = code &
            //                                    state = security_token % 3D138r5719ru3e1 % 26url % 3Dhttps % 3A % 2F % 2Foauth2.example.com % 2Ftoken &
            //                                    redirect_uri = com.example.app % 3A / oauth2redirect &
            //                                    client_id = client_id
            //return someHelper.createUrl(endPoint, queryParams);
            throw new NotImplementedException();
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
