using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("InductionCoilNTCSpecific")]
public partial class InductionCoilNtcspecific
{
    [Key]
    [Column("InductionCoilNTCSpecificId")]
    public Guid InductionCoilNtcspecificId { get; set; }

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

    public byte StuckExecutionTime { get; set; }

    public byte StuckValidationTime { get; set; }

    public float SafetyDebounceTime { get; set; }

    public float ShortDebounceTime { get; set; }

    public float OpenDebounceTime { get; set; }

    public short ShortThresholdMax { get; set; }

    public short OpenThresholdMin { get; set; }

    public short StuckWindowMin { get; set; }

    public short StuckWindowMax { get; set; }

    public short StuckExitDelta { get; set; }

    public short SafetyThreshold { get; set; }

    public short SafetyHysteresis { get; set; }

    public float StuckExitDeltaCelsius { get; set; }

    public float SafetyHysteresisCelsius { get; set; }

    [InverseProperty("Acntcspecific")]
    public virtual ICollection<InductionCoilConfig> InductionCoilConfigAcntcspecifics { get; set; } = new List<InductionCoilConfig>();

    [InverseProperty("CoilNtcspecific")]
    public virtual ICollection<InductionCoilConfig> InductionCoilConfigCoilNtcspecifics { get; set; } = new List<InductionCoilConfig>();

    [InverseProperty("IgbtSafetyParams")]
    public virtual ICollection<InductionCoilConfig> InductionCoilConfigIgbtSafetyParams { get; set; } = new List<InductionCoilConfig>();

    [InverseProperty("InductionCoilHeatsinkNtcspecific")]
    public virtual ICollection<InductionCoilConfig> InductionCoilConfigInductionCoilHeatsinkNtcspecifics { get; set; } = new List<InductionCoilConfig>();
}
