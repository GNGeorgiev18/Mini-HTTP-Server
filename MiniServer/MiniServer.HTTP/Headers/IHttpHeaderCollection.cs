using System;
using System.Collections.Generic;
using System.Text;

namespace MiniServer.HTTP.Headers
{

    public interface IHttpHeaderCollection {
        void AddHeader(HttpHeader header);

        bool ContainsHeader(string key);

        HttpHeader GetHeader(string key);
    }

    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }
        public void AddHeader(HttpHeader header)
        {
            this.headers.Add(header.Key, header);
        }

        public bool ContainsHeader(string key)
        {
            return headers.ContainsKey(key);
        }
              

        public HttpHeader GetHeader(string key)
        {
            foreach (var k in headers) {
                if (k.Key == key) {
                    return k.Value;
                }
            }return null;
        }

        public override string ToString()
        {
            string returnable = "";
            foreach (var k in headers) {
                returnable += k.Value.Value + "\n";
            }
            return returnable;
        }
    }

}
