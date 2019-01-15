using System.Net;

namespace Tabload.Net
{
    class NetLoader
    {
        protected string _webScraperStr(string url)
        {
            using (WebClient client = new WebClient())
            {
                string doc = client.DownloadString($@"{url}");
                return doc;
            }
        }

        protected void _webScraperFile(string url, string path)
        {
            //TODO implement use of this
            using (WebClient client = new WebClient())
            {
                client.DownloadFile($@"{url}", $@"{path}");
            }
        }
    }
}
