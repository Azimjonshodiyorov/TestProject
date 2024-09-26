using System.ComponentModel.DataAnnotations.Schema;
using TestProject.Core.Enums;

namespace TestProject.Application.DataTransferObject.User;

public class UserDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public DateOnly BirthDate { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}
