using System;
using System.Net;

namespace Utilities
{
    public static class Validator
    {
        public static bool URLExists(string URL)
        {
            if (Uri.TryCreate(URL, UriKind.Absolute, out Uri uriResult) &&
                (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uriResult);
                    request.Method = "HEAD";
                    request.Timeout = 5000;

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        return response.StatusCode == HttpStatusCode.OK;
                    }
                }
                catch (WebException)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
