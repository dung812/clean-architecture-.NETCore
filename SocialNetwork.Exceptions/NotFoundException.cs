using Microsoft.AspNetCore.Http;

namespace SocialNetwork.Exceptions
{
    public class NotFoundException : CustomException
    {
        public NotFoundException(string message) : base(StatusCodes.Status404NotFound, message) { }
    }
}
