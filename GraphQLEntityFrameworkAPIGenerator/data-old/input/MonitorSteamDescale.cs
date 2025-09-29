using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorSteamDescale")]
public partial class MonitorSteamDescale
{
    [Key]
    public Guid MonitorSteamDescaleId { get; set; }

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

    public byte NumberOfWaterHardnessCoeff { get; set; }

    public short RecommendDescaleHours { get; set; }

    public short RequireDescaleHours { get; set; }

    public byte RecommendDescaleEfficiency { get; set; }

    public byte ReqiureDescaleEfficiency { get; set; }

    public float WaterHardnessCoeff1 { get; set; }

    public float WaterHardnessCoeff2 { get; set; }

    public float WaterHardnessCoeff3 { get; set; }

    public float WaterHardnessCoeff4 { get; set; }

    public float WaterHardnessCoeff5 { get; set; }

    public float WaterHardnessCoeff6 { get; set; }

    public float WaterHardnessCoeff7 { get; set; }

    public float WaterHardnessCoeff8 { get; set; }

    public float WaterHardnessCoeff9 { get; set; }

    public float WaterHardnessCoeff10 { get; set; }

    public byte DescaleDetectionMethod { get; set; }

    public bool TimeBasedDescale { get; set; }

    public bool BoilerEfficiencyBasedDescale { get; set; }

    public bool WaterLevelSensorBasedDescale { get; set; }

    [InverseProperty("MonitorSteamDescale")]
    public virtual ICollection<MonitorSteam> MonitorSteams { get; set; } = new List<MonitorSteam>();
}
