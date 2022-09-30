using MiniServer.HTTP.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniServer.HTTP.Headers
{
    public  class HttpHeader
    {
        public HttpHeader(string key, string value)
        {
            CoreValidator.ThrowIfNullOrEmpty(text: key, name: nameof(key));
            CoreValidator.ThrowIfNullOrEmpty(text: value, name: nameof(value));

            this.Key = key;
            this.Value = value;
        }

        public string Key { get; set; }
        public string  Value { get; set; }

        public override string ToString()
        {
            return $"{this.Key}: {this.Value}";
        }
                
    }
}
