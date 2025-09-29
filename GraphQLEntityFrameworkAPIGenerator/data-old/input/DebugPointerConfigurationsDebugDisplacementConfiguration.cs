using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("DebugPointerConfigurationsId", "DebugDisplacementConfigurationsId", "Index")]
[Table("DebugPointerConfigurations_DebugDisplacementConfigurations")]
public partial class DebugPointerConfigurationsDebugDisplacementConfiguration
{
    [Key]
    public Guid DebugPointerConfigurationsId { get; set; }

    [Key]
    public Guid DebugDisplacementConfigurationsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("DebugDisplacementConfigurationsId")]
    [InverseProperty("DebugPointerConfigurationsDebugDisplacementConfigurations")]
    public virtual DebugDisplacementConfiguration DebugDisplacementConfigurations { get; set; } = null!;

    [ForeignKey("DebugPointerConfigurationsId")]
    [InverseProperty("DebugPointerConfigurationsDebugDisplacementConfigurations")]
    public virtual DebugPointerConfiguration DebugPointerConfigurations { get; set; } = null!;
}
