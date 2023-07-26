using Microsoft.AspNetCore.Http;

namespace SocialNetwork.Exceptions
{
    public class PrimaryKeyConstraintException : CustomException
    {
        public PrimaryKeyConstraintException(string message) : base(StatusCodes.Status409Conflict, message) { }
    }
}
