using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorSteamWaterLevelSensor")]
public partial class MonitorSteamWaterLevelSensor
{
    [Key]
    public Guid MonitorSteamWaterLevelSensorId { get; set; }

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

    public byte ColdTankLevels { get; set; }

    public byte WarmTankLevels { get; set; }

    public int ColdTankMaxVolume { get; set; }

    public int WarmTankMaxVolume { get; set; }

    public int ColdTankWlsVolume1 { get; set; }

    public int ColdTankWlsVolume2 { get; set; }

    public int ColdTankWlsVolume3 { get; set; }

    public int ColdTankWlsVolume4 { get; set; }

    public int ColdTankWlsVolume5 { get; set; }

    public int WarmTankWlsVolume1 { get; set; }

    public int WarmTankWlsVolume2 { get; set; }

    public int WarmTankWlsVolume3 { get; set; }

    public int WarmTankWlsVolume4 { get; set; }

    public int WarmTankWlsVolume5 { get; set; }

    public short VolumeSubtracted { get; set; }

    public int MinimumWaterLevelThreshold { get; set; }

    public int MedianWaterLevelThreshold { get; set; }

    public int MaximumWaterLevelThreshold { get; set; }

    [InverseProperty("MonitorSteamWaterLevelSensor")]
    public virtual ICollection<MonitorSteam> MonitorSteams { get; set; } = new List<MonitorSteam>();
}
