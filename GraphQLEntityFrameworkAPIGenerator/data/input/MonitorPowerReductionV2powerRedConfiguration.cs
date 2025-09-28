using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorPowerReductionV2PowerRedConfiguration")]
public partial class MonitorPowerReductionV2powerRedConfiguration
{
    [Key]
    [Column("MonitorPowerReductionV2PowerRedConfigurationId")]
    public Guid MonitorPowerReductionV2powerRedConfigurationId { get; set; }

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

    [InverseProperty("MonitorPowerReductionV2powerRedConfiguration")]
    public virtual ICollection<MonitorPowerReductionV2detail> MonitorPowerReductionV2details { get; set; } = new List<MonitorPowerReductionV2detail>();

    [InverseProperty("MonitorPowerReductionV2powerRedConfiguration")]
    public virtual ICollection<MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail> MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails { get; set; } = new List<MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail>();
}
