using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.ConsoleApp
{
    public class EndpointBuilder
    {
        private readonly StringBuilder stringBuilderUrl = new();
        private readonly StringBuilder stringBuilderParams = new();

        private const char defaultDelimiter = '/';
        private string BaseUrl { get; set; }

        public EndpointBuilder(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        public EndpointBuilder Append(string @value)
        {
            // localhost/api/v1/user
            stringBuilderUrl.Append(@value);
            //stringBuilderUrl.Append(defaultDelimiter);
            return this;
        }


        /// <summary>
        /// BaseUrl for Append parameter and value.
        /// </summary>
        /// <param name="key">parameter key</param>
        /// <param name="value">parameter value</param>
        /// <returns></returns>
        public EndpointBuilder AppendParam(string key, string value)
        {
            // localhost/api/v1/user?id=5
            stringBuilderUrl.AppendFormat("{0}={1}&", key, value);
            return this;
        }

        public string Build()
        {
            if (BaseUrl.EndsWith(defaultDelimiter))
                stringBuilderUrl.Insert(0, BaseUrl);
            else
                stringBuilderUrl.Insert(0, BaseUrl + defaultDelimiter);
           
            var url = stringBuilderUrl.ToString().TrimEnd('&');
            
            if(stringBuilderParams.Length > 0)
            {
                string queryParams = stringBuilderParams.ToString().TrimEnd('&');
                url = stringBuilderUrl.ToString().TrimEnd(defaultDelimiter).TrimEnd('?');
                url = $"{url}?{queryParams}";
            }
            
            // localhost/api/v1/user?id=5
  
            return url.TrimEnd(defaultDelimiter);
        }
    }
}
