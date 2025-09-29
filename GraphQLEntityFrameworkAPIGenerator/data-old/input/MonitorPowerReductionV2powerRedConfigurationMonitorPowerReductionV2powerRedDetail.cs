using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("MonitorPowerReductionV2powerRedConfigurationId", "MonitorPowerReductionV2powerRedDetailsId", "Index")]
[Table("MonitorPowerReductionV2PowerRedConfiguration_MonitorPowerReductionV2PowerRedDetails")]
public partial class MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetail
{
    [Key]
    [Column("MonitorPowerReductionV2PowerRedConfigurationId")]
    public Guid MonitorPowerReductionV2powerRedConfigurationId { get; set; }

    [Key]
    [Column("MonitorPowerReductionV2PowerRedDetailsId")]
    public Guid MonitorPowerReductionV2powerRedDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("MonitorPowerReductionV2powerRedConfigurationId")]
    [InverseProperty("MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails")]
    public virtual MonitorPowerReductionV2powerRedConfiguration MonitorPowerReductionV2powerRedConfiguration { get; set; } = null!;

    [ForeignKey("MonitorPowerReductionV2powerRedDetailsId")]
    [InverseProperty("MonitorPowerReductionV2powerRedConfigurationMonitorPowerReductionV2powerRedDetails")]
    public virtual MonitorPowerReductionV2powerRedDetail MonitorPowerReductionV2powerRedDetails { get; set; } = null!;
}
