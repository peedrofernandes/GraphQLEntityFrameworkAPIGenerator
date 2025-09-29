using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class InductionInverterSpecificDatum
{
    [Key]
    public Guid InductionInverterSpecificDataId { get; set; }

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

    public float SnubberCapacitance { get; set; }

    public float ResonantCapacitance { get; set; }

    public int GateDelayOffHighSideIgbt { get; set; }

    public int GateDelayOffLowSideIgbt { get; set; }

    public float MaxNominalInverterPowerFactor { get; set; }

    public float MaxNominalInverterPowerFactorBooster { get; set; }

    [InverseProperty("InductionInverterSpecificData")]
    public virtual ICollection<InductionCoilConfig> InductionCoilConfigs { get; set; } = new List<InductionCoilConfig>();
}
