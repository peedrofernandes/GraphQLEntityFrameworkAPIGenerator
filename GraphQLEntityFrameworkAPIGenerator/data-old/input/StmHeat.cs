using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmHeat")]
public partial class StmHeat
{
    [Key]
    public Guid Id { get; set; }

    public byte Version { get; set; }

    public Guid? PidConfigurationId { get; set; }

    [Column("LBOpenLoopId")]
    public Guid? LbopenLoopId { get; set; }

    [Column("LBClosedLoopId")]
    public Guid? LbclosedLoopId { get; set; }

    public byte PyroTargetTime { get; set; }

    public Guid? ConvectionFan1Id { get; set; }

    public Guid? ConvectionFan2Id { get; set; }

    [ForeignKey("ConvectionFan1Id")]
    [InverseProperty("StmHeatConvectionFan1s")]
    public virtual HeatConvectionFanParameter? ConvectionFan1 { get; set; }

    [ForeignKey("ConvectionFan2Id")]
    [InverseProperty("StmHeatConvectionFan2s")]
    public virtual HeatConvectionFanParameter? ConvectionFan2 { get; set; }

    [ForeignKey("LbclosedLoopId")]
    [InverseProperty("StmHeats")]
    public virtual HeatLoadBalancingClosedLoop? LbclosedLoop { get; set; }

    [ForeignKey("LbopenLoopId")]
    [InverseProperty("StmHeats")]
    public virtual HeatLoadBalancingOpenLoop? LbopenLoop { get; set; }

    [ForeignKey("PidConfigurationId")]
    [InverseProperty("StmHeats")]
    public virtual HeatPidConfigurationParameter? PidConfiguration { get; set; }
}
