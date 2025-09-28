using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class IpcSpecificSafetyParam
{
    [Key]
    public Guid IpcSpecificSafetyParamsId { get; set; }

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

    public float DeltaTempStartRisingTimeEvaluation { get; set; }

    public float DeltaTempEndRisingTimeEvaluation { get; set; }

    public float TimeMinFixedPowerDeration { get; set; }

    public float TemperatureMonitoringAdditionalOffset { get; set; }

    public float TemperatureMonitoringMaxTemperature { get; set; }

    [InverseProperty("IpcSpecificSafetyParams")]
    public virtual ICollection<InductionIpcdetail> InductionIpcdetails { get; set; } = new List<InductionIpcdetail>();
}
