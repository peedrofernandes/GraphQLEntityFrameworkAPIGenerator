using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("SRSafetyRelevantParameters")]
public partial class SrsafetyRelevantParameter
{
    [Key]
    [Column("SRSafetyParametersId")]
    public Guid SrsafetyParametersId { get; set; }

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

    [Column("SROverTempCheckId")]
    public Guid? SroverTempCheckId { get; set; }

    public Guid? SrFanSpeedCheckParamsId { get; set; }

    public Guid? SrStuckProbeCheckParamsId { get; set; }

    [Column("SRHMIEventCheckParametersId")]
    public Guid? SrhmieventCheckParametersId { get; set; }

    public Guid? SrPlausibilityCheckParamsId { get; set; }

    [Column("SRPCBCheckParamsId")]
    public Guid? SrpcbcheckParamsId { get; set; }

    [Column("SRBoilerOverTempCheckParamsId")]
    public Guid? SrboilerOverTempCheckParamsId { get; set; }

    public Guid? SrPinShortCheckParamsId { get; set; }

    [Column("SRExpansionConfigurationsId")]
    public Guid? SrexpansionConfigurationsId { get; set; }

    [InverseProperty("SrsafetyParameters")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();

    [ForeignKey("SrFanSpeedCheckParamsId")]
    [InverseProperty("SrsafetyRelevantParameters")]
    public virtual SrfanSpeedCheckParameter? SrFanSpeedCheckParams { get; set; }

    [ForeignKey("SrPinShortCheckParamsId")]
    [InverseProperty("SrsafetyRelevantParameters")]
    public virtual SrpinShortCheckParameter? SrPinShortCheckParams { get; set; }

    [ForeignKey("SrPlausibilityCheckParamsId")]
    [InverseProperty("SrsafetyRelevantParameters")]
    public virtual SrplausibilityCheckParameter? SrPlausibilityCheckParams { get; set; }

    [ForeignKey("SrStuckProbeCheckParamsId")]
    [InverseProperty("SrsafetyRelevantParameters")]
    public virtual SrstuckProbeCheckParameter? SrStuckProbeCheckParams { get; set; }

    [ForeignKey("SrboilerOverTempCheckParamsId")]
    [InverseProperty("SrsafetyRelevantParameters")]
    public virtual SrboilerOverTempCheckParameter? SrboilerOverTempCheckParams { get; set; }

    [ForeignKey("SrexpansionConfigurationsId")]
    [InverseProperty("SrsafetyRelevantParameters")]
    public virtual SrexpansionConfiguration? SrexpansionConfigurations { get; set; }

    [ForeignKey("SrhmieventCheckParametersId")]
    [InverseProperty("SrsafetyRelevantParameters")]
    public virtual SrhmieventCheckParameter? SrhmieventCheckParameters { get; set; }

    [ForeignKey("SroverTempCheckId")]
    [InverseProperty("SrsafetyRelevantParameters")]
    public virtual SroverTempCheckParameter? SroverTempCheck { get; set; }

    [ForeignKey("SrpcbcheckParamsId")]
    [InverseProperty("SrsafetyRelevantParameters")]
    public virtual SrpcbcheckParameter? SrpcbcheckParams { get; set; }
}
