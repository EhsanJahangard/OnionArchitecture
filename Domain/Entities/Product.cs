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

[Table("Products")]
[Index("Title", IsUnique = true, Name = "TitleProduct_IndexUnique")]
public class Product : BaseEntity<long>
{
    [StringLength(200)]
    [Required]
    public string Title { get; set; }

    public int ProductCategoryId { get; set; }
    public ProductCategory ProductCategory { get; set; }
    public int ProductUnitId { get; set; }
    public ProductUnit ProductUnit { get; set; }

    [MaxLength(350)]
    public string QrBarCode { get; set; }

    [StringLength(300)]
    public string? Description { get; set; }
    [Required]
    public DateTime DateCreateProduct { get; set; }
    public virtual ICollection<Remittance> Remittances { get; set; }
}

