using FinanceMan.Shared.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FinanceMan.Web.Controllers;

[Route("api/user-controller")]
[ApiController]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetHello()
    {
        return Ok();
    }
}
