using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmHeatRun")]
public partial class StmHeatRun
{
    [Key]
    public Guid Id { get; set; }

    public bool IsPyro { get; set; }

    public byte Version { get; set; }

    public byte? CavityIndex { get; set; }

    public byte DutyPeriod { get; set; }

    public byte? ProbeBalance { get; set; }

    public double? RtdSlope1 { get; set; }

    public double? RtdSlope2 { get; set; }

    public byte? RtdOffset1 { get; set; }

    public byte? RtdOffset2 { get; set; }

    public byte? SetPointOffset { get; set; }

    public Guid? PidConfigurationId { get; set; }

    public Guid? LoadBalancingId { get; set; }

    public Guid? ConvectionFan1Id { get; set; }

    public Guid? ConvectionFan2Id { get; set; }

    public byte? PyroTargetTime { get; set; }

    [ForeignKey("ConvectionFan1Id")]
    [InverseProperty("StmHeatRunConvectionFan1s")]
    public virtual HeatConvectionFanParameter? ConvectionFan1 { get; set; }

    [ForeignKey("ConvectionFan2Id")]
    [InverseProperty("StmHeatRunConvectionFan2s")]
    public virtual HeatConvectionFanParameter? ConvectionFan2 { get; set; }

    [ForeignKey("LoadBalancingId")]
    [InverseProperty("StmHeatRuns")]
    public virtual HeatLoadBalancingParameter? LoadBalancing { get; set; }

    [ForeignKey("PidConfigurationId")]
    [InverseProperty("StmHeatRuns")]
    public virtual HeatPidConfigurationParameter? PidConfiguration { get; set; }
}
