using System.ComponentModel.DataAnnotations.Schema;
using TestProject.Core.Common;

namespace TestProject.Core.Entities;
[Table("post" , Schema ="test")]
public class Post : BaseEntity
{
    [Column("title")]
    public string Title { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("user_id")]
    public long UserId { get; set; }
    [NotMapped]
    public User User { get; set; }
}
