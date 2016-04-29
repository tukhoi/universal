using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsExplorer.ApplicationServices.Portable.Parser;
using NUnit.Framework;
using System.Reflection;
using System.IO;
using NewsExplorer.Models.Portable;

namespace NewsExplorer.Tests.Portable.ApplicationServices
{
    [TestFixture]
    public class PageParserTests
    {
        [Test]
        public void CanParseAPage()
        {
            var parser = new PageParser();
            var raw = ReadSample();
            var page = parser.Parse<Page>(raw);
            Assert.IsNotNull(page);
        }

        private string ReadSample()
        {
            var assembly = typeof(PageParserTests).GetTypeInfo().Assembly;
            string[] resources = assembly.GetManifestResourceNames();
            using (var stream = assembly.GetManifestResourceStream("NewsExplorer.Tests.Portable.Data.page.json"))
            {
                var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                reader.Dispose();
                return content;
            }
        }
    }
}
