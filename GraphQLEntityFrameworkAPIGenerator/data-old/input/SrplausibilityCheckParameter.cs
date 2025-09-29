using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("SRPlausibilityCheckParameters")]
public partial class SrplausibilityCheckParameter
{
    [Key]
    public Guid SrPlausibilityCheckParamsId { get; set; }

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

    public byte Version { get; set; }

    public byte NumberOfPlausibilityChecks { get; set; }

    [Column("ADCMinThresholdForPlausibilityCheck1")]
    public short AdcminThresholdForPlausibilityCheck1 { get; set; }

    [Column("ADCMaxThresholdForPlausibilityCheck1")]
    public short AdcmaxThresholdForPlausibilityCheck1 { get; set; }

    [Column("PlausibilityCheckGIIndex1")]
    public byte PlausibilityCheckGiindex1 { get; set; }

    [Column("PlausibilityCheckTemperatureGIIndex1")]
    public byte PlausibilityCheckTemperatureGiindex1 { get; set; }

    [Column("ADCMinThresholdForPlausibilityCheck2")]
    public short AdcminThresholdForPlausibilityCheck2 { get; set; }

    [Column("ADCMaxThresholdForPlausibilityCheck2")]
    public short AdcmaxThresholdForPlausibilityCheck2 { get; set; }

    [Column("PlausibilityCheckGIIndex2")]
    public byte PlausibilityCheckGiindex2 { get; set; }

    [Column("PlausibilityCheckTemperatureGIIndex2")]
    public byte PlausibilityCheckTemperatureGiindex2 { get; set; }

    [InverseProperty("SrPlausibilityCheckParams")]
    public virtual ICollection<SrsafetyRelevantParameter> SrsafetyRelevantParameters { get; set; } = new List<SrsafetyRelevantParameter>();
}
