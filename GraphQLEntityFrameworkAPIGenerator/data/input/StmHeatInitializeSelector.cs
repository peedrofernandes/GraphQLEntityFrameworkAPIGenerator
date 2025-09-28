using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmHeatInitializeSelector")]
public partial class StmHeatInitializeSelector
{
    [Key]
    public Guid Id { get; set; }

    public Guid HeatInitializeId { get; set; }

    [ForeignKey("HeatInitializeId")]
    [InverseProperty("StmHeatInitializeSelectors")]
    public virtual HeatInitialize HeatInitialize { get; set; } = null!;
}
