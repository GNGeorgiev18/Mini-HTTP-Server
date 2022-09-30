using System;
using System.Collections.Generic;
using System.Text;

namespace MiniServer.HTTP.Exceptions
{
    class InternalServerErrorException : Exception
    {
        string message = "The Server has encountered an error.";
    }
}
