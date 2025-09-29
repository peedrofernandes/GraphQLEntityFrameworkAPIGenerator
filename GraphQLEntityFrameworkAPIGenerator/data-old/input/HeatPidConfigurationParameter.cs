using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class HeatPidConfigurationParameter
{
    [Key]
    public Guid Id { get; set; }

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

    public double Proportional { get; set; }

    public double Integral { get; set; }

    public double Derivative { get; set; }

    public double WindUpFactor { get; set; }

    public bool UseForcedIntegral { get; set; }

    public int ForcedIntegralValue { get; set; }

    public bool ReusePid { get; set; }

    [InverseProperty("PidConfiguration")]
    public virtual ICollection<StmHeatRun> StmHeatRuns { get; set; } = new List<StmHeatRun>();

    [InverseProperty("PidConfiguration")]
    public virtual ICollection<StmHeat> StmHeats { get; set; } = new List<StmHeat>();
}
