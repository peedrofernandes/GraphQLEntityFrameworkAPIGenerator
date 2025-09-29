using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class EmptyPotDetectionCoilSafetyParam
{
    [Key]
    public Guid EmptyPotDetectionCoilSafetyParamsId { get; set; }

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

    public bool IsEmptyPotDetectionEnabled { get; set; }

    public bool UseGapTempSensorForEmptyPotDetection { get; set; }

    public float RisingTimeThreshold { get; set; }

    public int MinLoadPowerAvgDeliveredDuringRisingTime { get; set; }

    public int MaxLoadPowerAvgDeliveredDuringRisingTime { get; set; }

    public int MaxLoadPowerAvgWhenFixedDerating { get; set; }

    public float TemperatureControlSetpointSlope { get; set; }

    [InverseProperty("EmptyPotDetectionCoilSafetyParams")]
    public virtual ICollection<InductionCoilConfig> InductionCoilConfigs { get; set; } = new List<InductionCoilConfig>();
}
