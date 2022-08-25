using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
[Table("Jobs")]
[Index("Title", IsUnique = true, Name = "TitleJobs_IndexUnique")]
public class Job : BaseEntity<int>
{
    [StringLength(150)]
    [Required]
    public string Title { get; set; }
    public virtual ICollection<Customer> Customers { get; set; }
}
    
