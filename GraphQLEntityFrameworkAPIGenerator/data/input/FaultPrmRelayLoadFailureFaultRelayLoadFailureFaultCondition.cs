using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("FaultPrmRelayLoadFailureId", "FaultConditionId", "Index")]
[Table("FaultPrmRelayLoadFailure_FaultRelayLoadFailureFaultCondition")]
public partial class FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition
{
    [Key]
    public Guid FaultPrmRelayLoadFailureId { get; set; }

    [Key]
    public Guid FaultConditionId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("FaultConditionId")]
    [InverseProperty("FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions")]
    public virtual FaultRelayLoadFailureFaultCondition FaultCondition { get; set; } = null!;

    [ForeignKey("FaultPrmRelayLoadFailureId")]
    [InverseProperty("FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions")]
    public virtual FaultPrmRelayLoadFailure FaultPrmRelayLoadFailure { get; set; } = null!;
}
