using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class HeatLoadBalancingParameter
{
    public byte NumberOfLoads { get; set; }

    public byte? LoadId1 { get; set; }

    public bool? IndependentLoad1 { get; set; }

    public byte? PriorityLoad1 { get; set; }

    public byte? BalanceLoad1 { get; set; }

    public byte? LoadId2 { get; set; }

    public bool? IndependentLoad2 { get; set; }

    public byte? PriorityLoad2 { get; set; }

    public byte? BalanceLoad2 { get; set; }

    public byte? LoadId3 { get; set; }

    public bool? IndependentLoad3 { get; set; }

    public byte? PriorityLoad3 { get; set; }

    public byte? BalanceLoad3 { get; set; }

    public byte? LoadId4 { get; set; }

    public bool? IndependentLoad4 { get; set; }

    public byte? PriorityLoad4 { get; set; }

    public byte? BalanceLoad4 { get; set; }

    public byte? LoadId5 { get; set; }

    public bool? IndependentLoad5 { get; set; }

    public byte? PriorityLoad5 { get; set; }

    public byte? BalanceLoad5 { get; set; }

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
    public Guid LoadBalancingId { get; set; }

    public byte Version { get; set; }

    [InverseProperty("LoadBalancing")]
    public virtual ICollection<StmHeatRun> StmHeatRuns { get; set; } = new List<StmHeatRun>();
}
