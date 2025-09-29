using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class StmHeatRunView
{
    public Guid Id { get; set; }

    public byte? OpenLoopNumberOfLoads { get; set; }

    public byte? ClosedLoopNumberOfLoads { get; set; }

    public float? OpenLoopDutyPeriod { get; set; }

    public float? ClosedLoopDutyPeriod { get; set; }

    public float? OpenLoopStartTimeLoad1 { get; set; }

    public float? OpenLoopStopTimeLoad1 { get; set; }

    public byte? OpenLoopMagnetronTargetLoad1 { get; set; }

    public bool? OpenLoopBroilUserControl1 { get; set; }

    public byte? OpenLoopLoadId1 { get; set; }

    public float? OpenLoopStartTimeLoad2 { get; set; }

    public float? OpenLoopStopTimeLoad2 { get; set; }

    public byte? OpenLoopMagnetronTargetLoad2 { get; set; }

    public bool? OpenLoopBroilUserControl2 { get; set; }

    public byte? OpenLoopLoadId2 { get; set; }

    public float? OpenLoopStartTimeLoad3 { get; set; }

    public float? OpenLoopStopTimeLoad3 { get; set; }

    public byte? OpenLoopMagnetronTargetLoad3 { get; set; }

    public bool? OpenLoopBroilUserControl3 { get; set; }

    public byte? OpenLoopLoadId3 { get; set; }

    public float? OpenLoopStartTimeLoad4 { get; set; }

    public float? OpenLoopStopTimeLoad4 { get; set; }

    public byte? OpenLoopMagnetronTargetLoad4 { get; set; }

    public bool? OpenLoopBroilUserControl4 { get; set; }

    public byte? OpenLoopLoadId4 { get; set; }

    public float? OpenLoopStartTimeLoad5 { get; set; }

    public float? OpenLoopStopTimeLoad5 { get; set; }

    public byte? OpenLoopMagnetronTargetLoad5 { get; set; }

    public bool? OpenLoopBroilUserControl5 { get; set; }

    public byte? OpenLoopLoadId5 { get; set; }

    public float? ClosedLoopStartTimeLoad1 { get; set; }

    public float? ClosedLoopStopTimeLoad1 { get; set; }

    public byte? ClosedLoopLoadId1 { get; set; }

    public float? ClosedLoopStartTimeLoad2 { get; set; }

    public float? ClosedLoopStopTimeLoad2 { get; set; }

    public byte? ClosedLoopLoadId2 { get; set; }

    public float? ClosedLoopStartTimeLoad3 { get; set; }

    public float? ClosedLoopStopTimeLoad3 { get; set; }

    public byte? ClosedLoopLoadId3 { get; set; }

    public float? ClosedLoopStartTimeLoad4 { get; set; }

    public float? ClosedLoopStopTimeLoad4 { get; set; }

    public byte? ClosedLoopLoadId4 { get; set; }

    public float? ClosedLoopStartTimeLoad5 { get; set; }

    public float? ClosedLoopStopTimeLoad5 { get; set; }

    public byte? ClosedLoopLoadId5 { get; set; }

    public Guid? ConvectionFanId { get; set; }

    public byte? ConvectionStartTime { get; set; }

    public byte? ConvectionStopTime { get; set; }

    public Guid? PidConfigurationId { get; set; }

    [Column("LBOpenLoopId")]
    public Guid? LbopenLoopId { get; set; }

    public Guid? ConvectionFan1Id { get; set; }

    public Guid? ConvectionFan2Id { get; set; }

    [Column("LBClosedLoopId")]
    public Guid? LbclosedLoopId { get; set; }

    public byte? NumberOfLinkedRings { get; set; }

    public byte? ConvectionRingLoad1 { get; set; }

    public byte? ConvectionRingLoad2 { get; set; }

    public bool? UseOpenLoopPeriod { get; set; }
}
