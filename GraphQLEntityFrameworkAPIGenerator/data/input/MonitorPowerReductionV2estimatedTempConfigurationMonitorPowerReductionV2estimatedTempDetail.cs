using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("MonitorPowerReductionV2estimatedTempConfigurationId", "MonitorPowerReductionV2estimatedTempDetailsId", "Index")]
[Table("MonitorPowerReductionV2EstimatedTempConfiguration_MonitorPowerReductionV2EstimatedTempDetails")]
public partial class MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetail
{
    [Key]
    [Column("MonitorPowerReductionV2EstimatedTempConfigurationId")]
    public Guid MonitorPowerReductionV2estimatedTempConfigurationId { get; set; }

    [Key]
    [Column("MonitorPowerReductionV2EstimatedTempDetailsId")]
    public Guid MonitorPowerReductionV2estimatedTempDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("MonitorPowerReductionV2estimatedTempConfigurationId")]
    [InverseProperty("MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails")]
    public virtual MonitorPowerReductionV2estimatedTempConfiguration MonitorPowerReductionV2estimatedTempConfiguration { get; set; } = null!;

    [ForeignKey("MonitorPowerReductionV2estimatedTempDetailsId")]
    [InverseProperty("MonitorPowerReductionV2estimatedTempConfigurationMonitorPowerReductionV2estimatedTempDetails")]
    public virtual MonitorPowerReductionV2estimatedTempDetail MonitorPowerReductionV2estimatedTempDetails { get; set; } = null!;
}
