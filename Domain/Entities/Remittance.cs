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

[Table("Remittances")]

public class Remittance : BaseEntity<long>
{

    public long ProductId { get; set; }
    public Product Product { get; set; }
    public long CustomerId { get; set; }
    public Customer Customer { get; set; }
    public double Qty { get; set; }
    [Required]
    public DateTime DateRemittance { get; set; }
    [StringLength(300)]
    public string? Description { get; set; }

    [StringLength(6)]//Input Or Output Value
    [Required]
    public string TypeRemittance { get; set; }


}

