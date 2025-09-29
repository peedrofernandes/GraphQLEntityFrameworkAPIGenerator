using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("FaultPrmRelayLoadFailure")]
public partial class FaultPrmRelayLoadFailure
{
    [Key]
    public Guid FaultPrmRelayLoadFailureId { get; set; }

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

    public byte NumberOfLoads { get; set; }

    [Column("NumberofGIs")]
    public byte NumberofGis { get; set; }

    public short Gi1 { get; set; }

    public short Gi2 { get; set; }

    public short Load1 { get; set; }

    public short Load2 { get; set; }

    public short Load3 { get; set; }

    public short Load4 { get; set; }

    public short Load5 { get; set; }

    public short Load6 { get; set; }

    public short Load7 { get; set; }

    public short Load8 { get; set; }

    public short Load9 { get; set; }

    public short Load10 { get; set; }

    [InverseProperty("FaultPrmRelayLoadFailure")]
    public virtual ICollection<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition> FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions { get; set; } = new List<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition>();
}
