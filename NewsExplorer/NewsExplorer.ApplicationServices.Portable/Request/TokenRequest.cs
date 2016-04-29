using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Davang.Enterprise.Portable;
using NewsExplorer.ApplicationServices.Portable.Parser;

namespace NewsExplorere.ApplicationServices.Portable.Request
{
    public abstract class TokenRequest
    {
        public string AccessToken { get; set; }

        public TokenRequest()
        {
        }

        public TokenRequest(string accessToken)
        {
            AccessToken = accessToken;
        }

        protected async Task<string> GetRawResult(string url)
        {
            if (string.IsNullOrEmpty(url)) throw new AppException("Url is required...");
            if (string.IsNullOrEmpty(AccessToken)) throw new AppException("AccessToken is required...");

            AppendToken(ref url, AccessToken);

            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(url);
            httpClient.Dispose();

            return result;
        }

        protected async Task<T> GetResult<T>(string url, IParser parser)
        {
            if (string.IsNullOrEmpty(url)) throw new AppException("Url is required...");
            if (string.IsNullOrEmpty(AccessToken)) throw new AppException("Access token is required...");
            if (parser == null) throw new AppException("Parser is required...");

            AppendToken(ref url, AccessToken);

            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(url).ContinueWith(rawTask => parser.Parse<T>(rawTask.Result));
            httpClient.Dispose();

            return result;
        }

        private void AppendToken(ref string url, string token)
        {
            if (url.Contains("?"))
                url = url + "&access_token=" + token;
            else
                url = url + "?access_token=" + token;
        }
    }
}
