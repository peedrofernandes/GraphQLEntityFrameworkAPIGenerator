using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorHeatSinkFan")]
public partial class MonitorHeatSinkFan
{
    [Key]
    public Guid MonitorHeatSinkFanId { get; set; }

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

    public byte StructureVersion { get; set; }

    public byte NumberOfFans { get; set; }

    public byte LoadIndexFan00 { get; set; }

    public Guid? TemperatureDsp00ld { get; set; }

    public byte LoadIndexFan01 { get; set; }

    public Guid? TemperatureDsp01ld { get; set; }

    public byte LoadIndexFan02 { get; set; }

    public Guid? TemperatureDsp02ld { get; set; }

    public byte LoadIndexFan03 { get; set; }

    public Guid? TemperatureDsp03ld { get; set; }

    public byte LoadIndexFan04 { get; set; }

    public Guid? TemperatureDsp04ld { get; set; }

    public byte LoadIndexFan05 { get; set; }

    public Guid? TemperatureDsp05ld { get; set; }

    public byte LoadIndexFan06 { get; set; }

    public Guid? TemperatureDsp06ld { get; set; }

    public byte LoadIndexFan07 { get; set; }

    public Guid? TemperatureDsp07ld { get; set; }

    public byte LoadIndexFan08 { get; set; }

    public Guid? TemperatureDsp08ld { get; set; }

    [InverseProperty("MonitorHeatsinkFan")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();

    [ForeignKey("TemperatureDsp00ld")]
    [InverseProperty("MonitorHeatSinkFanTemperatureDsp00ldNavigations")]
    public virtual MonitorHeatSinkFanTemperature? TemperatureDsp00ldNavigation { get; set; }

    [ForeignKey("TemperatureDsp01ld")]
    [InverseProperty("MonitorHeatSinkFanTemperatureDsp01ldNavigations")]
    public virtual MonitorHeatSinkFanTemperature? TemperatureDsp01ldNavigation { get; set; }

    [ForeignKey("TemperatureDsp02ld")]
    [InverseProperty("MonitorHeatSinkFanTemperatureDsp02ldNavigations")]
    public virtual MonitorHeatSinkFanTemperature? TemperatureDsp02ldNavigation { get; set; }

    [ForeignKey("TemperatureDsp03ld")]
    [InverseProperty("MonitorHeatSinkFanTemperatureDsp03ldNavigations")]
    public virtual MonitorHeatSinkFanTemperature? TemperatureDsp03ldNavigation { get; set; }

    [ForeignKey("TemperatureDsp04ld")]
    [InverseProperty("MonitorHeatSinkFanTemperatureDsp04ldNavigations")]
    public virtual MonitorHeatSinkFanTemperature? TemperatureDsp04ldNavigation { get; set; }

    [ForeignKey("TemperatureDsp05ld")]
    [InverseProperty("MonitorHeatSinkFanTemperatureDsp05ldNavigations")]
    public virtual MonitorHeatSinkFanTemperature? TemperatureDsp05ldNavigation { get; set; }

    [ForeignKey("TemperatureDsp06ld")]
    [InverseProperty("MonitorHeatSinkFanTemperatureDsp06ldNavigations")]
    public virtual MonitorHeatSinkFanTemperature? TemperatureDsp06ldNavigation { get; set; }

    [ForeignKey("TemperatureDsp07ld")]
    [InverseProperty("MonitorHeatSinkFanTemperatureDsp07ldNavigations")]
    public virtual MonitorHeatSinkFanTemperature? TemperatureDsp07ldNavigation { get; set; }

    [ForeignKey("TemperatureDsp08ld")]
    [InverseProperty("MonitorHeatSinkFanTemperatureDsp08ldNavigations")]
    public virtual MonitorHeatSinkFanTemperature? TemperatureDsp08ldNavigation { get; set; }
}
