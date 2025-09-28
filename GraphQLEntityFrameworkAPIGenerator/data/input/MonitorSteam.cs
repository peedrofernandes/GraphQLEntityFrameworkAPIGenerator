using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorSteam")]
public partial class MonitorSteam
{
    [Key]
    public Guid MonitorSteamId { get; set; }

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

    public Guid? MonitorSteamParamsId { get; set; }

    public Guid? MonitorSteamDrainId { get; set; }

    public Guid? MonitorSteamWaterLevelSensorId { get; set; }

    public byte Version { get; set; }

    public Guid? MonitorSteamDescaleId { get; set; }

    public Guid? MonitorSteamHumidityMapId { get; set; }

    public Guid? MonitorSteamerParamsId { get; set; }

    [InverseProperty("MonitorSteam")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();

    [ForeignKey("MonitorSteamDescaleId")]
    [InverseProperty("MonitorSteams")]
    public virtual MonitorSteamDescale? MonitorSteamDescale { get; set; }

    [ForeignKey("MonitorSteamDrainId")]
    [InverseProperty("MonitorSteams")]
    public virtual MonitorSteamDrain? MonitorSteamDrain { get; set; }

    [ForeignKey("MonitorSteamHumidityMapId")]
    [InverseProperty("MonitorSteams")]
    public virtual MonitorSteamHumidityTargetMapping? MonitorSteamHumidityMap { get; set; }

    [ForeignKey("MonitorSteamParamsId")]
    [InverseProperty("MonitorSteams")]
    public virtual MonitorSteamParam? MonitorSteamParams { get; set; }

    [ForeignKey("MonitorSteamWaterLevelSensorId")]
    [InverseProperty("MonitorSteams")]
    public virtual MonitorSteamWaterLevelSensor? MonitorSteamWaterLevelSensor { get; set; }

    [ForeignKey("MonitorSteamerParamsId")]
    [InverseProperty("MonitorSteams")]
    public virtual MonitorSteamerParam? MonitorSteamerParams { get; set; }
}
