using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;
[Table("ProductCategories")]
[Index("Title", IsUnique = true, Name = "TitleProductCategory_IndexUnique")]
public class ProductCategory : BaseEntity<int>
{
    [StringLength(200)]
    [Required]
    public string Title { get; set; }
    [StringLength(300)]
    public string? Description { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}

