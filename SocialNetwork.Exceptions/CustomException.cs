using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Exceptions
{
    public abstract class CustomException : Exception
    {
        public int StatusCode { get; set; } = 500;

        protected CustomException(int statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
