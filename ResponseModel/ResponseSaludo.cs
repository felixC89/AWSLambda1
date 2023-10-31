using System;
using System.Collections.Generic;
using System.Text;

namespace AWSLambda1.ResponseModel
{
    public class ResponseSaludo
    {
        public int ErrorCode { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
