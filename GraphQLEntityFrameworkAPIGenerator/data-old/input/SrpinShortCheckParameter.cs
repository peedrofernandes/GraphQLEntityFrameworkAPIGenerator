using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("SRPinShortCheckParameters")]
public partial class SrpinShortCheckParameter
{
    [Key]
    public Guid SrPinShortCheckParamsId { get; set; }

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

    public byte NumberOfPinShortPairs { get; set; }

    public int TimeDelay { get; set; }

    public int ErrorTime { get; set; }

    public short PairOutputPin1 { get; set; }

    public short PairInputPin1 { get; set; }

    public short PairOutputPin2 { get; set; }

    public short PairInputPin2 { get; set; }

    public short PairOutputPin3 { get; set; }

    public short PairInputPin3 { get; set; }

    public short PairOutputPin4 { get; set; }

    public short PairInputPin4 { get; set; }

    public short PairOutputPin5 { get; set; }

    public short PairInputPin5 { get; set; }

    public short PairOutputPin6 { get; set; }

    public short PairInputPin6 { get; set; }

    public short PairOutputPin7 { get; set; }

    public short PairInputPin7 { get; set; }

    public short PairOutputPin8 { get; set; }

    public short PairInputPin8 { get; set; }

    [InverseProperty("SrPinShortCheckParams")]
    public virtual ICollection<SrsafetyRelevantParameter> SrsafetyRelevantParameters { get; set; } = new List<SrsafetyRelevantParameter>();
}
