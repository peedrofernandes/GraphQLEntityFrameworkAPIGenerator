using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorPowerReductionV2EstimatedTempConfiguration")]
public partial class MonitorPowerReductionV2estimatedTempConfiguration
{
    [Key]
    [Column("MonitorPowerReductionV2EstimatedTempConfigurationId")]
    public Guid MonitorPowerReductionV2estimatedTempConfigurationId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public bool DeltaTempTerm { get; set; }

    public bool OverTempEstimation { get; set; }

    [Required]
    public bool? CavityTempTermApplies { get; set; }

    [InverseProperty("MonitorPowerReductionV2estimatedTempConfiguration")]
    public virtual ICollection<MonitorPowerReductionV2detail> MonitorPowerReductionV2details { get; set; } = new List<MonitorPowerReductionV2detail>();

    [InverseProperty("MonitorPowerReductionV2estimatedTempConfiguration")]
    public virtual ICollection<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail> MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails { get; set; } = new List<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail>();
}
