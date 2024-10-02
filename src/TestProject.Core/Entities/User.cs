using System.ComponentModel.DataAnnotations.Schema;
using TestProject.Core.Common;
using TestProject.Core.Enums;

namespace TestProject.Core.Entities;

[Table("user" , Schema ="test")]
public class User : BaseEntity
{
    [Column("first_name")]
    public string FirstName { get; set; }
    [Column("last_name")]
    public string  LastName { get; set; }
    [Column("gender")]
    public Gender Gender { get; set; }
    [Column("birth_date")]
    public DateOnly BirthDate { get; set; }
    [Column("phone_number")]
    public string PhoneNumber { get; set; }
    [Column("password")]
    public string Password { get; set; }
    [Column("email")]
    public string Email { get; set; }
    [NotMapped] 
    public ICollection<Post> Posts { get; set; }

}
