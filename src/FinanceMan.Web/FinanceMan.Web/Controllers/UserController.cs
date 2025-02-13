using FinanceMan.Shared.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FinanceMan.Web.Controllers;

[ApiController]
[Route("/api/user-controller")]
public class UserController(IUserService userService) : ControllerBase
{
    // GET
    [HttpGet]
    public async Task<IActionResult> JustGet()
    {
        await Task.Delay(200);
        return Ok();
    }
}