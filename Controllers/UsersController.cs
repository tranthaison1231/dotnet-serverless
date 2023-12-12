using DotnetServerless.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetServerless.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {
    private List<User> users = new List<User>() {
      new User { Id = 1, Name = "John", Email = "a@b.com" },
    };

    [HttpGet]
    public IActionResult GetAll()
    {
      return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetBy(int id)
    {
      var user = users.FirstOrDefault(u => u.Id == id);
      if (user == null) return NotFound("User not found");
      return Ok(user);
    }

    [HttpPost]
    public string Create([FromBody] User user)
    {
      return $"Creating a user {user.Name}";
    }

    [HttpPut("{id}")]
    public string Update(int id)
    {
      return $"Update a user with {id}";
    }
  }
}
