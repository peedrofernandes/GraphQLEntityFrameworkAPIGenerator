using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("InductionZeroCrossConfiguration")]
public partial class InductionZeroCrossConfiguration
{
    [Key]
    public Guid ZeroCrossConfigId { get; set; }

    [Column("HeatSink0GIID")]
    public byte? HeatSink0Giid { get; set; }

    [Column("HeatSink1GIID")]
    public byte? HeatSink1Giid { get; set; }

    public Guid? InverterChannel0Id { get; set; }

    public Guid? InverterChannel1Id { get; set; }

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

    [InverseProperty("ZeroCrossChannel0")]
    public virtual ICollection<InductionIpcdetail> InductionIpcdetailZeroCrossChannel0s { get; set; } = new List<InductionIpcdetail>();

    [InverseProperty("ZeroCrossChannel1")]
    public virtual ICollection<InductionIpcdetail> InductionIpcdetailZeroCrossChannel1s { get; set; } = new List<InductionIpcdetail>();

    [InverseProperty("ZeroCrossChannel2")]
    public virtual ICollection<InductionIpcdetail> InductionIpcdetailZeroCrossChannel2s { get; set; } = new List<InductionIpcdetail>();

    [ForeignKey("InverterChannel0Id")]
    [InverseProperty("InductionZeroCrossConfigurationInverterChannel0s")]
    public virtual InductionInverterChannelConfiguration? InverterChannel0 { get; set; }

    [ForeignKey("InverterChannel1Id")]
    [InverseProperty("InductionZeroCrossConfigurationInverterChannel1s")]
    public virtual InductionInverterChannelConfiguration? InverterChannel1 { get; set; }
}
