using System;
using System.Collections.Generic;
using System.Text;

namespace MiniServer.HTTP.Exceptions
{
    public class BadRequestException : Exception
    {
        string message = "The Request was malformed or contains unsupported elem";



    }
}
