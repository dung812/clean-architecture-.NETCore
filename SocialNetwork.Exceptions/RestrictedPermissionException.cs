using Microsoft.AspNetCore.Http;

namespace SocialNetwork.Exceptions
{
    public class RestrictedPermissionException : CustomException
    {
        public RestrictedPermissionException(string message) : base(StatusCodes.Status403Forbidden, message)
        {
        }
    }
}
