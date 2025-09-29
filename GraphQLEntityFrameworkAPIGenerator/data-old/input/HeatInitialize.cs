using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("HeatInitialize")]
public partial class HeatInitialize
{
    [Key]
    public Guid Id { get; set; }

    public bool IsPyro { get; set; }

    public byte PyroDutyPeriod { get; set; }

    public byte ProbeBalance { get; set; }

    public double RtdSlope1 { get; set; }

    public double RtdSlope2 { get; set; }

    public short RtdOffset1 { get; set; }

    public short RtdOffset2 { get; set; }

    public short TargetTemperatureOffset { get; set; }

    public byte? PyroTargetTime { get; set; }

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

    public bool UseForcedIntegral { get; set; }

    public int ForcedIntegralValue { get; set; }

    public bool ReusePid { get; set; }

    [InverseProperty("HeatInitialize")]
    public virtual ICollection<StmHeatInitializeSelector> StmHeatInitializeSelectors { get; set; } = new List<StmHeatInitializeSelector>();

    [InverseProperty("HeatInitialize")]
    public virtual ICollection<StmSetupTempSelector> StmSetupTempSelectors { get; set; } = new List<StmSetupTempSelector>();
}
