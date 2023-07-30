using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Api.Dto.User;

namespace SocialNetwork.Api.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController, ApiVersion("1.0")]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDetailResponse>> GetUser([FromRoute] string id)
        {
            return Ok();
        }
    }
}
