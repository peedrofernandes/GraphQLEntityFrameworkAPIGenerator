using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorPowerReductionV2PowerRedDetails")]
public partial class MonitorPowerReductionV2powerRedDetail
{
    [Key]
    [Column("MonitorPowerReductionV2PowerRedDetailsId")]
    public Guid MonitorPowerReductionV2powerRedDetailsId { get; set; }

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

    public short TempLimit { get; set; }

    public byte DeltaTemp { get; set; }

    public byte PowerLimitLoad0 { get; set; }

    public byte PowerLimitLoad1 { get; set; }

    public byte PowerLimitLoad2 { get; set; }

    public byte PowerLimitLoad3 { get; set; }

    public byte PowerLimitLoad4 { get; set; }

    public short CavityTempLimit { get; set; }

    public bool PowerLimitLoad0Na { get; set; }

    public bool PowerLimitLoad1Na { get; set; }

    public bool PowerLimitLoad2Na { get; set; }

    public bool PowerLimitLoad3Na { get; set; }

    public bool PowerLimitLoad4Na { get; set; }

    public bool CavityTempLimitNa { get; set; }

    [InverseProperty("MonitorPowerReductionV2powerRedDetails")]
    public virtual ICollection<MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail> MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails { get; set; } = new List<MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail>();
}
