using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
  public class UsersController : ControllerBase
  {
    [HttpGet]
    [Route("users")]
    public string GetAll()
    {
      return "Get all users";
    }
  }
}
