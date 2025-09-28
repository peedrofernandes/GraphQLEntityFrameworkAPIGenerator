using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorPowerReductionV2EstimatedTempDetails")]
public partial class MonitorPowerReductionV2estimatedTempDetail
{
    [Key]
    [Column("MonitorPowerReductionV2EstimatedTempDetailsId")]
    public Guid MonitorPowerReductionV2estimatedTempDetailsId { get; set; }

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

    [Column("TempLimitKLoad0")]
    public float TempLimitKload0 { get; set; }

    [Column("TempLimitKLoad1")]
    public float TempLimitKload1 { get; set; }

    [Column("TempLimitKLoad2")]
    public float TempLimitKload2 { get; set; }

    [Column("TempLimitKLoad3")]
    public float TempLimitKload3 { get; set; }

    [Column("TempLimitKLoad4")]
    public float TempLimitKload4 { get; set; }

    [Column("TempLimitKLoad5")]
    public float TempLimitKload5 { get; set; }

    public float CoolDownTempFan0 { get; set; }

    public float CoolDownTempFan1 { get; set; }

    public float CoolDownTempFan2 { get; set; }

    [Column("CAvityTempTerm")]
    public float CavityTempTerm { get; set; }

    public byte PowerLimitLoad0 { get; set; }

    public byte PowerLimitLoad1 { get; set; }

    public byte PowerLimitLoad2 { get; set; }

    public byte PowerLimitLoad3 { get; set; }

    public byte PowerLimitLoad4 { get; set; }

    public byte PowerLimitLoad5 { get; set; }

    public float CoolDownTempFan3 { get; set; }

    [InverseProperty("MonitorPowerReductionV2estimatedTempDetails")]
    public virtual ICollection<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail> MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails { get; set; } = new List<MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail>();
}
