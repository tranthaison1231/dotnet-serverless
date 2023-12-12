using Microsoft.AspNetCore.Mvc;

namespace DotnetServerless.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {
    [HttpGet]
    public string GetAll()
    {
      return "Get all users";
    }

    [HttpGet]
    [Route("{id}")]
    public string GetBy(int id)
    {
      return $"Get user {id}";
    }
  }
}
