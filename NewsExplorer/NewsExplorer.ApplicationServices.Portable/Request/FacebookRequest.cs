using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsExplorer.ApplicationServices.Portable.Parser;
using NewsExplorer.Models.Portable;

namespace NewsExplorere.ApplicationServices.Portable.Request
{
    public class FacebookRequest : TokenRequest
    {
        public string RootUrl { get { return "https://graph.facebook.com"; } }
        public string Version { get { return "v2.6"; } }

        public string NodeId { get; set; }
        public string EdgeName { get; set; }
        public string Fields { get; set; }

        private string _pageUrl;

        private IParser _pageParser;

        public FacebookRequest(string accessToken)
            : base(accessToken)
        {
            InitializeUrls();
            _pageParser = new PageParser();
        }

        public string GetPageRawResult(string pageId)
        {
            var url = string.Format(_pageUrl, pageId);
            var rawResult = GetRawResult(url).Result;
            return rawResult;
        }

        public Task<Page> GetPage(string pageId)
        {
            var url = string.Format(_pageUrl, pageId);
            return GetResult<Page>(url, _pageParser);
        }

        #region Private

        private void InitializeUrls()
        {
            _pageUrl = RootUrl + "/" + Version + "/{0}?fields=" + string.Join(",", Page.REMOTE_FIELDS);
        }

        #endregion
    }
}
