using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmSetupTempSelector")]
public partial class StmSetupTempSelector
{
    [Key]
    public Guid Id { get; set; }

    public Guid HeatInitializeId { get; set; }

    [ForeignKey("HeatInitializeId")]
    [InverseProperty("StmSetupTempSelectors")]
    public virtual HeatInitialize HeatInitialize { get; set; } = null!;
}
