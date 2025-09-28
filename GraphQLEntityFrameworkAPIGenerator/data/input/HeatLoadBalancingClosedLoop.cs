using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("HeatLoadBalancingClosedLoop")]
public partial class HeatLoadBalancingClosedLoop
{
    [Key]
    [Column("LBClosedLoopId")]
    public Guid LbclosedLoopId { get; set; }

    public byte NumberOfLoads { get; set; }

    public float DutyPeriod { get; set; }

    public byte? LoadId1 { get; set; }

    public float? StartTimeLoad1 { get; set; }

    public float? StopTimeLoad1 { get; set; }

    public byte? LoadId2 { get; set; }

    public float? StartTimeLoad2 { get; set; }

    public float? StopTimeLoad2 { get; set; }

    public byte? LoadId3 { get; set; }

    public float? StartTimeLoad3 { get; set; }

    public float? StopTimeLoad3 { get; set; }

    public byte? LoadId4 { get; set; }

    public float? StartTimeLoad4 { get; set; }

    public float? StopTimeLoad4 { get; set; }

    public byte? LoadId5 { get; set; }

    public float? StartTimeLoad5 { get; set; }

    public float? StopTimeLoad5 { get; set; }

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

    public Guid? ConvectionFan1Id { get; set; }

    public Guid? ConvectionFan2Id { get; set; }

    [ForeignKey("ConvectionFan1Id")]
    [InverseProperty("HeatLoadBalancingClosedLoopConvectionFan1s")]
    public virtual HeatConvectionFanParameter? ConvectionFan1 { get; set; }

    [ForeignKey("ConvectionFan2Id")]
    [InverseProperty("HeatLoadBalancingClosedLoopConvectionFan2s")]
    public virtual HeatConvectionFanParameter? ConvectionFan2 { get; set; }

    [InverseProperty("LbclosedLoop")]
    public virtual ICollection<StmHeat> StmHeats { get; set; } = new List<StmHeat>();
}
