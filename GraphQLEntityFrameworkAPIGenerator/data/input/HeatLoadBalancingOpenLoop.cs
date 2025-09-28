using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("HeatLoadBalancingOpenLoop")]
public partial class HeatLoadBalancingOpenLoop
{
    public byte NumberOfLoads { get; set; }

    public float DutyPeriod { get; set; }

    public byte? LoadId1 { get; set; }

    public float? StartTimeLoad1 { get; set; }

    public float? StopTimeLoad1 { get; set; }

    public byte? MagnetronTargetLoad1 { get; set; }

    public bool? BroilUserTargetLoad1 { get; set; }

    public bool? ReduceFromRightLoad1 { get; set; }

    public byte? TurboOnTimeLoad1 { get; set; }

    public byte? LoadId2 { get; set; }

    public float? StartTimeLoad2 { get; set; }

    public float? StopTimeLoad2 { get; set; }

    public byte? MagnetronTargetLoad2 { get; set; }

    public bool? BroilUserTargetLoad2 { get; set; }

    public bool? ReduceFromRightLoad2 { get; set; }

    public byte? TurboOnTimeLoad2 { get; set; }

    public byte? LoadId3 { get; set; }

    public float? StartTimeLoad3 { get; set; }

    public float? StopTimeLoad3 { get; set; }

    public byte? MagnetronTargetLoad3 { get; set; }

    public bool? BroilUserTargetLoad3 { get; set; }

    public bool? ReduceFromRightLoad3 { get; set; }

    public byte? TurboOnTimeLoad3 { get; set; }

    public byte? LoadId4 { get; set; }

    public float? StartTimeLoad4 { get; set; }

    public float? StopTimeLoad4 { get; set; }

    public byte? MagnetronTargetLoad4 { get; set; }

    public bool? BroilUserTargetLoad4 { get; set; }

    public bool? ReduceFromRightLoad4 { get; set; }

    public byte? TurboOnTimeLoad4 { get; set; }

    public byte? LoadId5 { get; set; }

    public float? StartTimeLoad5 { get; set; }

    public float? StopTimeLoad5 { get; set; }

    public byte? MagnetronTargetLoad5 { get; set; }

    public bool? BroilUserTargetLoad5 { get; set; }

    public bool? ReduceFromRightLoad5 { get; set; }

    public byte? TurboOnTimeLoad5 { get; set; }

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

    [Key]
    [Column("LBOpenLoopId")]
    public Guid LbopenLoopId { get; set; }

    public byte Version { get; set; }

    [InverseProperty("LbopenLoop")]
    public virtual ICollection<StmHeat> StmHeats { get; set; } = new List<StmHeat>();
}
