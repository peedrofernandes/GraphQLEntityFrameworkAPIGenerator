using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class HeatConvectionFanParameter
{
    [Key]
    public Guid ConvectionFanId { get; set; }

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

    public byte StartTime { get; set; }

    public byte StopTime { get; set; }

    public byte Speed { get; set; }

    public byte NumberOfLinkedRings { get; set; }

    public byte ConvectionRingLoad1 { get; set; }

    public byte ConvectionRingLoad2 { get; set; }

    public byte ConvectionRingLoad3 { get; set; }

    public byte ConvectionRingLoad4 { get; set; }

    public byte Version { get; set; }

    public bool UseOpenLoopPeriod { get; set; }

    [InverseProperty("ConvectionFan1")]
    public virtual ICollection<HeatLoadBalancingClosedLoop> HeatLoadBalancingClosedLoopConvectionFan1s { get; set; } = new List<HeatLoadBalancingClosedLoop>();

    [InverseProperty("ConvectionFan2")]
    public virtual ICollection<HeatLoadBalancingClosedLoop> HeatLoadBalancingClosedLoopConvectionFan2s { get; set; } = new List<HeatLoadBalancingClosedLoop>();

    [InverseProperty("ConvectionFan1")]
    public virtual ICollection<StmHeat> StmHeatConvectionFan1s { get; set; } = new List<StmHeat>();

    [InverseProperty("ConvectionFan2")]
    public virtual ICollection<StmHeat> StmHeatConvectionFan2s { get; set; } = new List<StmHeat>();

    [InverseProperty("ConvectionFan1")]
    public virtual ICollection<StmHeatRun> StmHeatRunConvectionFan1s { get; set; } = new List<StmHeatRun>();

    [InverseProperty("ConvectionFan2")]
    public virtual ICollection<StmHeatRun> StmHeatRunConvectionFan2s { get; set; } = new List<StmHeatRun>();
}
