using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("SRStuckProbeCheckParameters")]
public partial class SrstuckProbeCheckParameter
{
    [Key]
    public Guid SrStuckProbeCheckParamsId { get; set; }

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

    public byte VarianceThreshold { get; set; }

    public byte DebounceThreshold { get; set; }

    public byte BakeAmperes { get; set; }

    public byte Broil1Amperes { get; set; }

    public byte Broil2Amperes { get; set; }

    public byte ConvectRing1Amperes { get; set; }

    public byte ConvectRing2Amperes { get; set; }

    public int TotalAmpereThreshold { get; set; }

    [InverseProperty("SrStuckProbeCheckParams")]
    public virtual ICollection<SrsafetyRelevantParameter> SrsafetyRelevantParameters { get; set; } = new List<SrsafetyRelevantParameter>();
}
