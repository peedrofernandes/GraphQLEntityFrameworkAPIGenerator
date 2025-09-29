using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("CycleMappingId", "CycleOptionsConfigurationsId", "Index")]
[Table("CycleMapping_CycleOptionsConfigurations")]
public partial class CycleMappingCycleOptionsConfiguration
{
    [Key]
    public Guid CycleMappingId { get; set; }

    [Key]
    public Guid CycleOptionsConfigurationsId { get; set; }

    [Key]
    public byte Index { get; set; }

    public int? CycleName { get; set; }

    [StringLength(100)]
    public string? HmiCycleName { get; set; }

    public int? ConnectivityCycleEnumeration0 { get; set; }

    public byte Compartment0 { get; set; }

    public long? ConnectivityCycleKey0 { get; set; }

    public byte? SetCycleTreeLevels { get; set; }

    public Guid? UriTreeId { get; set; }

    [ForeignKey("CycleMappingId")]
    [InverseProperty("CycleMappingCycleOptionsConfigurations")]
    public virtual CycleMapping CycleMapping { get; set; } = null!;

    [ForeignKey("CycleOptionsConfigurationsId")]
    [InverseProperty("CycleMappingCycleOptionsConfigurations")]
    public virtual CycleOptionsConfiguration CycleOptionsConfigurations { get; set; } = null!;

    [ForeignKey("UriTreeId")]
    [InverseProperty("CycleMappingCycleOptionsConfigurations")]
    public virtual CycleMappingUri? UriTree { get; set; }
}
