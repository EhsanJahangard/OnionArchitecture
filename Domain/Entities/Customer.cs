using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
[Table("Customers")]
[Index("Email", IsUnique = true, Name = "EmailCustomers_IndexUnique")]
public class Customer : BaseEntity<long>
{
    [StringLength(100)]
    [Required]
    public string FirstName { get; set; }
    [StringLength(200)]
    [Required]
    public string LastName { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }
    [DataType(DataType.Date)]
    public DateTime? BirthDay { get; set; }
    [EmailAddress]
    [Required]
    public string Email { get; set; }
    [Phone]
    [Required]
    public string? Phone { get; set; }
    public virtual ICollection<Remittance> Remittances { get; set; }
}

