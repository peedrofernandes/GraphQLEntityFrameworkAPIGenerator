using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("SrexpansionConfigurationsId", "SrexpansionDetailsId", "Index")]
[Table("SRExpansionConfigurations_SRExpansionDetails")]
public partial class SrexpansionConfigurationsSrexpansionDetail
{
    [Key]
    [Column("SRExpansionConfigurationsId")]
    public Guid SrexpansionConfigurationsId { get; set; }

    [Key]
    [Column("SRExpansionDetailsId")]
    public Guid SrexpansionDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [Column("ACUExpansionBoardId")]
    public byte AcuexpansionBoardId { get; set; }

    [ForeignKey("SrexpansionConfigurationsId")]
    [InverseProperty("SrexpansionConfigurationsSrexpansionDetails")]
    public virtual SrexpansionConfiguration SrexpansionConfigurations { get; set; } = null!;

    [ForeignKey("SrexpansionDetailsId")]
    [InverseProperty("SrexpansionConfigurationsSrexpansionDetails")]
    public virtual SrexpansionDetail SrexpansionDetails { get; set; } = null!;
}
