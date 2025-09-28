using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("ProductTypeId", "TaskId")]
[Table("ProductTypes_Tasks")]
public partial class ProductTypesTask
{
    [Key]
    public byte ProductTypeId { get; set; }

    [Key]
    public int TaskId { get; set; }

    public byte ProductTypeTaskId { get; set; }

    [ForeignKey("ProductTypeId")]
    [InverseProperty("ProductTypesTasks")]
    public virtual ProductType ProductType { get; set; } = null!;

    [ForeignKey("TaskId")]
    [InverseProperty("ProductTypesTasks")]
    public virtual Task Task { get; set; } = null!;
}
