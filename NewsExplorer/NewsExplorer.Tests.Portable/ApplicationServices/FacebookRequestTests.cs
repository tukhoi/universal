using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsExplorere.ApplicationServices.Portable.Request;
using NUnit.Framework;

namespace NewsExplorer.Tests.Portable.ApplicationServices
{
    [TestFixture]
    public class FacebookRequestTests
    {
        private string _testAccessToken = "1530697210570021|DrN7efqg1rL5HfaLueibO3N4VWo";

        [Test]
        public void CanRequestPageRawResult()
        {
            var request = new FacebookRequest(_testAccessToken);
            var result = request.GetPageRawResult("tran.thanh.ne");
            Assert.IsNotNull(result);
            System.Diagnostics.Debug.WriteLine(result);
        }

        [Test]
        public void CanRequestAPage()
        {
            var request = new FacebookRequest(_testAccessToken);
            var page = request.GetPage("tran.thanh.ne").Result;
            Assert.IsNotNull(page);
            System.Diagnostics.Debug.WriteLine(page.about);
        }
    }
}
