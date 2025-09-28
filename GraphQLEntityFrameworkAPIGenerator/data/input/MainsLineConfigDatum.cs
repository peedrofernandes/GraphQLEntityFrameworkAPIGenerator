using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class MainsLineConfigDatum
{
    [Key]
    public Guid MainsLineConfigId { get; set; }

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

    public float NominalPower { get; set; }

    public float NominalCurrent { get; set; }

    public float IntegralGainCurrentAndPower { get; set; }

    public float CurrentFaultTreshold { get; set; }

    public float PowerFaultThreshold { get; set; }

    public float RestartLineVoltageThresholdAfterSurgeFault { get; set; }

    public float RestartWaitingTimeAfterSurgeFault { get; set; }

    [Column("ReclosingWaitingTimeAfter400VDetectionFaultIsCleared")]
    public float ReclosingWaitingTimeAfter400VdetectionFaultIsCleared { get; set; }

    [Column("OpeningWaitingTimeAfter400VDetectionFault")]
    public float OpeningWaitingTimeAfter400VdetectionFault { get; set; }

    [InverseProperty("MainsLineConfig")]
    public virtual ICollection<IpcControllerIpcConfiguration> IpcControllerIpcConfigurations { get; set; } = new List<IpcControllerIpcConfiguration>();
}
