using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DebugDisplacementConfiguration
{
    [Key]
    public Guid DebugDisplacementConfigurationsId { get; set; }

    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    public bool FlagOneDataType { get; set; }

    public byte DataType { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [InverseProperty("DebugDisplacementConfigurations")]
    public virtual ICollection<DebugDisplacementConfigurationsDebugDataDetail> DebugDisplacementConfigurationsDebugDataDetails { get; set; } = new List<DebugDisplacementConfigurationsDebugDataDetail>();

    [InverseProperty("DebugDisplacementConfigurations")]
    public virtual ICollection<DebugPointerConfigurationsDebugDisplacementConfiguration> DebugPointerConfigurationsDebugDisplacementConfigurations { get; set; } = new List<DebugPointerConfigurationsDebugDisplacementConfiguration>();
}
