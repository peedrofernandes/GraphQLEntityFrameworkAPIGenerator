using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorHoodFan")]
public partial class MonitorHoodFan
{
    [Key]
    public Guid MonitorHoodFanId { get; set; }

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

    public byte Version { get; set; }

    public byte NumberOfSensingLevels { get; set; }

    public bool UseSensing { get; set; }

    [Column("TemperatureGI")]
    public short TemperatureGi { get; set; }

    public byte SpeedLevel0 { get; set; }

    public float SensingTemperatureLevel0 { get; set; }

    public byte SpeedLevel1 { get; set; }

    public float SensingTemperatureLevel1 { get; set; }

    public byte SpeedLevel2 { get; set; }

    public float SensingTemperatureLevel2 { get; set; }

    public byte SpeedLevel3 { get; set; }

    public float SensingTemperatureLevel3 { get; set; }

    public byte SpeedLevel4 { get; set; }

    public float SensingTemperatureLevel4 { get; set; }

    public byte SpeedLevel5 { get; set; }

    public float SensingTemperatureLevel5 { get; set; }

    public byte SpeedLevel6 { get; set; }

    public float SensingTemperatureLevel6 { get; set; }

    [InverseProperty("MonitorHoodFan")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
