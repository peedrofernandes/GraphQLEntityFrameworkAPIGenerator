using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("InductionCoilConfig")]
public partial class InductionCoilConfig
{
    [Key]
    public Guid InductionCoilConfigId { get; set; }

    [Column("CoilLoadID")]
    public byte CoilLoadId { get; set; }

    [Column("HeatsinkNTCGIID")]
    public byte HeatsinkNtcgiid { get; set; }

    [Column("InductionCoilHeatsinkNTCSpecificId")]
    public Guid? InductionCoilHeatsinkNtcspecificId { get; set; }

    public Guid? InductionCoilSpecificId { get; set; }

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

    [Column("CoilNTCGIId")]
    public byte CoilNtcgiid { get; set; }

    [Column("ACNTCGIId")]
    public byte Acntcgiid { get; set; }

    [Column("HeatsinkFanLoadID")]
    public byte HeatsinkFanLoadId { get; set; }

    [Column("CoilNTCSpecificId")]
    public Guid? CoilNtcspecificId { get; set; }

    [Column("ACNTCSpecificId")]
    public Guid? AcntcspecificId { get; set; }

    [Column("CoilSRIPCSafetyId")]
    public Guid? CoilSripcsafetyId { get; set; }

    public Guid? InductionCoilPowerTableConfigId { get; set; }

    [Column("IgbtTemperatureGIId")]
    public byte IgbtTemperatureGiid { get; set; }

    public Guid? InductionInverterSpecificDataId { get; set; }

    public Guid? IgbtSafetyParamsId { get; set; }

    public Guid? EmptyPotDetectionCoilSafetyParamsId { get; set; }

    [ForeignKey("AcntcspecificId")]
    [InverseProperty("InductionCoilConfigAcntcspecifics")]
    public virtual InductionCoilNtcspecific? Acntcspecific { get; set; }

    [ForeignKey("CoilNtcspecificId")]
    [InverseProperty("InductionCoilConfigCoilNtcspecifics")]
    public virtual InductionCoilNtcspecific? CoilNtcspecific { get; set; }

    [ForeignKey("CoilSripcsafetyId")]
    [InverseProperty("InductionCoilConfigs")]
    public virtual InductionCoilSripcsafety? CoilSripcsafety { get; set; }

    [ForeignKey("EmptyPotDetectionCoilSafetyParamsId")]
    [InverseProperty("InductionCoilConfigs")]
    public virtual EmptyPotDetectionCoilSafetyParam? EmptyPotDetectionCoilSafetyParams { get; set; }

    [ForeignKey("IgbtSafetyParamsId")]
    [InverseProperty("InductionCoilConfigIgbtSafetyParams")]
    public virtual InductionCoilNtcspecific? IgbtSafetyParams { get; set; }

    [ForeignKey("InductionCoilHeatsinkNtcspecificId")]
    [InverseProperty("InductionCoilConfigInductionCoilHeatsinkNtcspecifics")]
    public virtual InductionCoilNtcspecific? InductionCoilHeatsinkNtcspecific { get; set; }

    [ForeignKey("InductionCoilPowerTableConfigId")]
    [InverseProperty("InductionCoilConfigs")]
    public virtual InductionCoilPowerTableConfiguration? InductionCoilPowerTableConfig { get; set; }

    [ForeignKey("InductionCoilSpecificId")]
    [InverseProperty("InductionCoilConfigs")]
    public virtual InductionCoilSpecific? InductionCoilSpecific { get; set; }

    [ForeignKey("InductionInverterSpecificDataId")]
    [InverseProperty("InductionCoilConfigs")]
    public virtual InductionInverterSpecificDatum? InductionInverterSpecificData { get; set; }

    [InverseProperty("InductionCoilConfig")]
    public virtual ICollection<InductionIpcdetailsInductionCoilConfig> InductionIpcdetailsInductionCoilConfigs { get; set; } = new List<InductionIpcdetailsInductionCoilConfig>();
}
