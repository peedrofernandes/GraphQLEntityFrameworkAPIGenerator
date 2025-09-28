using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("DebugDisplacementConfigurationsId", "DebugDataDetailsId", "Index")]
[Table("DebugDisplacementConfigurations_DebugDataDetails")]
public partial class DebugDisplacementConfigurationsDebugDataDetail
{
    [Key]
    public Guid DebugDisplacementConfigurationsId { get; set; }

    [Key]
    public Guid DebugDataDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("DebugDataDetailsId")]
    [InverseProperty("DebugDisplacementConfigurationsDebugDataDetails")]
    public virtual DebugDataDetail DebugDataDetails { get; set; } = null!;

    [ForeignKey("DebugDisplacementConfigurationsId")]
    [InverseProperty("DebugDisplacementConfigurationsDebugDataDetails")]
    public virtual DebugDisplacementConfiguration DebugDisplacementConfigurations { get; set; } = null!;
}
