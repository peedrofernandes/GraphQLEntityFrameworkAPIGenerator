using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorPowerReductionV2Details")]
public partial class MonitorPowerReductionV2detail
{
    [Key]
    [Column("MonitorPowerReductionV2DetailsId")]
    public Guid MonitorPowerReductionV2detailsId { get; set; }

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

    public byte TemperatureNodeNameId { get; set; }

    [Column("MonitorPowerReductionV2EstimatedTempConfigurationId")]
    public Guid? MonitorPowerReductionV2estimatedTempConfigurationId { get; set; }

    [Column("MonitorPowerReductionV2PowerRedConfigurationId")]
    public Guid? MonitorPowerReductionV2powerRedConfigurationId { get; set; }

    public byte TemperatureCalculationParametersType { get; set; }

    public float Slope { get; set; }

    public float Offset { get; set; }

    public float TempSensorId { get; set; }

    [InverseProperty("MonitorPowerReductionV2details")]
    public virtual ICollection<MonitorPowerReductionV2configurationMonitorPowerReductionV2detail> MonitorPowerReductionV2configurationMonitorPowerReductionV2details { get; set; } = new List<MonitorPowerReductionV2configurationMonitorPowerReductionV2detail>();

    [ForeignKey("MonitorPowerReductionV2estimatedTempConfigurationId")]
    [InverseProperty("MonitorPowerReductionV2details")]
    public virtual MonitorPowerReductionV2estimatedTempConfiguration? MonitorPowerReductionV2estimatedTempConfiguration { get; set; }

    [ForeignKey("MonitorPowerReductionV2powerRedConfigurationId")]
    [InverseProperty("MonitorPowerReductionV2details")]
    public virtual MonitorPowerReductionV2powerRedConfiguration? MonitorPowerReductionV2powerRedConfiguration { get; set; }
}
