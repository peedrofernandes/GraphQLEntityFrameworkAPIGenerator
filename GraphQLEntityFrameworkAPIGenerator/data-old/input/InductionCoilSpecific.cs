using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("InductionCoilSpecific")]
public partial class InductionCoilSpecific
{
    [Key]
    public Guid InductionCoilSpecificId { get; set; }

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

    public short ResonanceCapacitance { get; set; }

    public short MaxCurrentNormal { get; set; }

    public short MaxCurrentBooster { get; set; }

    public short BoosterPowerThreshold { get; set; }

    public short PanettoneElectricThreshold { get; set; }

    public float PanDetectedThreshold { get; set; }

    public float PanNotDetectedThreshold { get; set; }

    public int MaxNominalLoadAveragePower { get; set; }

    public float MaxNominalIgbtPeakTurnOffCurrent { get; set; }

    public int MaxNominalLoadAveragePowerBooster { get; set; }

    public float MaxNominalIgbtPeakTurnOffCurrentBooster { get; set; }

    public float MaxNominalLoadRmsCurrent { get; set; }

    public float MaxNominalLoadRmsCurrentBooster { get; set; }

    [InverseProperty("InductionCoilSpecific")]
    public virtual ICollection<InductionCoilConfig> InductionCoilConfigs { get; set; } = new List<InductionCoilConfig>();
}
