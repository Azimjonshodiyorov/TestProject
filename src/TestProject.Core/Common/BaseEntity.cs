using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Core.Common;

public class BaseEntity
{
    [Key]
    [Column("id")]
    public long Id { get; set; }
    [Column("create_at")]
    public DateTime CreateAt { get; set; } = DateTime.Now;
    [Column("update_at")]
    public DateTime? UpdateAt { get; set; }
}
