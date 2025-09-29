using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class InductionIpcSpecificDatum
{
    [Key]
    public Guid InductionIpcSpecificDataId { get; set; }

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

    public float PanInactiveCounterTimeout { get; set; }

    public float FrequencyLimitSlackGain { get; set; }

    public float FrequencyIncreaseGainCritical { get; set; }

    public float FrequencyIncreaseGainOverload { get; set; }

    public float FrequencyDecreaseGainRelax { get; set; }

    public float IirSmoothingFactor { get; set; }

    public float IirValidationMinDebounceSteps { get; set; }

    public float MainsLineUnderVoltageFailureThreshold { get; set; }

    public float MainsLineOverVoltageFailureThreshold { get; set; }

    [InverseProperty("InductionIpcSpecificData")]
    public virtual ICollection<InductionIpcdetail> InductionIpcdetails { get; set; } = new List<InductionIpcdetail>();
}
