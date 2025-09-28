using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Index("Id", Name = "IX_Tasks", IsUnique = true)]
public partial class Task
{
    [Key]
    public int Id { get; set; }

    [Column("Task")]
    [StringLength(50)]
    [Unicode(false)]
    public string Task1 { get; set; } = null!;

    public bool TaskParametersNeeded { get; set; }

    [InverseProperty("Task")]
    public virtual ICollection<ProductTypesTask> ProductTypesTasks { get; set; } = new List<ProductTypesTask>();
}
