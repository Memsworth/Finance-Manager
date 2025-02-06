using System.ComponentModel.DataAnnotations;

namespace FinanceMan.Shared.Dtos;

public class CreateUserDto
{
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required, MinLength(5, ErrorMessage = "Just write down a decent username")]
    public string UserName { get; set; }
}
