using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorSteamHumidityTargetMapping")]
public partial class MonitorSteamHumidityTargetMapping
{
    [Key]
    public Guid MonitorSteamHumidityMapId { get; set; }

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

    public byte NumberOfLevels { get; set; }

    public short TargetTemperature1 { get; set; }

    public short TargetTemperature2 { get; set; }

    public short TargetTemperature3 { get; set; }

    public int TargetHumidity1 { get; set; }

    public int TargetHumidity2 { get; set; }

    public int TargetHumidity3 { get; set; }

    public int TargetHumidity4 { get; set; }

    [InverseProperty("MonitorSteamHumidityMap")]
    public virtual ICollection<MonitorSteam> MonitorSteams { get; set; } = new List<MonitorSteam>();
}
