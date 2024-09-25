using System.ComponentModel.DataAnnotations.Schema;
using TestProject.Core.Common;
using TestProject.Core.Enums;

namespace TestProject.Core.Entities;

[Table("user" , Schema ="test")]
public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string  LastName { get; set; }
    public Gender Gender { get; set; }
    public DateOnly BirthDate { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

}
