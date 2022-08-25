using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;


[Table("ProductUnits")]
[Index("Title", IsUnique = true, Name = "TitleProductUnits_IndexUnique")]
public class ProductUnit : BaseEntity<int>
{
    [StringLength(150)]
    [Required]
    public string Title { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}

