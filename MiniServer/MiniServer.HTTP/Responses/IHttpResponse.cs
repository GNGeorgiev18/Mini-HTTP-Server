using MiniServer.HTTP.Common;
using MiniServer.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;
using static MiniServer.HTTP.Enums.Enumerators;

namespace MiniServer.HTTP.Responses
{
    public interface IHttpResponse {
        HttpResponseStatusCode StatusCode { get; set; }
        IHttpHeaderCollection Headers { get; }
        byte[] Content { get; set; }

        void AddHeader(HttpHeader header);

        byte[] GetBytes();

    }

    class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        {
            this.Headers = new HttpHeaderCollection();
            this.Content = new byte[0];
        }

        public HttpResponse(HttpResponseStatusCode statusCode) : this() {
            CoreValidator.ThrowIfNull(StatusCode, name: nameof(StatusCode));
            this.StatusCode = statusCode;
        }
        
        public HttpResponseStatusCode StatusCode { get; set; }

        public IHttpHeaderCollection Headers { get; }
        public byte[] Content { get; set; }

        public void AddHeader(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, name: nameof(header));
            this.Headers.AddHeader(header);
        }

        public byte[] GetBytes()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result
                .Append($"{GlobalConstants.HttpOneProtocolFragment} {(int)this.StatusCode} {this.StatusCode.ToString()}")
                .Append(GlobalConstants.HttpNewLine)
                .Append(this.Headers)
                .Append(GlobalConstants.HttpNewLine);

            result.Append(GlobalConstants.HttpNewLine);

            return result.ToString();
        }
    }
}
