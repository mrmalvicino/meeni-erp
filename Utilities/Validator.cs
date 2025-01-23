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

        public static int CountFilledStrings(object obj)
        {
            if (obj == null)
            {
                return 0;
            }

            int count = 0;

            var props = obj.GetType().GetProperties();

            foreach (var prop in props)
            {
                if (prop.PropertyType == typeof(string))
                {
                    var value = (string)prop.GetValue(obj);

                    if (!string.IsNullOrEmpty(value))
                    {
                        count++;
                    }
                }
                else if (!prop.PropertyType.IsPrimitive
                    && !prop.PropertyType.IsEnum
                    && prop.PropertyType != typeof(string))
                {
                    var subObj = prop.GetValue(obj);
                    count += CountFilledStrings(subObj);
                }
            }

            return count;
        }

        public static bool IsEmpty(object obj)
        {
            return CountFilledStrings(obj) == 0;
        }
    }
}
