using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("FaultRelayLoadFailureFaultCondition")]
public partial class FaultRelayLoadFailureFaultCondition
{
    [Key]
    public Guid FaultConditionId { get; set; }

    public short Gi1MonitoredState { get; set; }

    public short Gi2MonitoredState { get; set; }

    public short Load1MonitoredState { get; set; }

    public short Load2MonitoredState { get; set; }

    public short Load3MonitoredState { get; set; }

    public short Load4MonitoredState { get; set; }

    public short Load5MonitoredState { get; set; }

    public short Load6MonitoredState { get; set; }

    public short Load7MonitoredState { get; set; }

    public short Load8MonitoredState { get; set; }

    public short Load9MonitoredState { get; set; }

    public short Load10MonitoredState { get; set; }

    public bool Gi1Ignore { get; set; }

    public bool Gi2Ignore { get; set; }

    public bool Load1Ignore { get; set; }

    public bool Load2Ignore { get; set; }

    public bool Load3Ignore { get; set; }

    public bool Load4Ignore { get; set; }

    public bool Load5Ignore { get; set; }

    public bool Load6Ignore { get; set; }

    public bool Load7Ignore { get; set; }

    public bool Load8Ignore { get; set; }

    public bool Load9Ignore { get; set; }

    public bool Load10Ignore { get; set; }

    [InverseProperty("FaultCondition")]
    public virtual ICollection<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition> FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultConditions { get; set; } = new List<FaultPrmRelayLoadFailureFaultRelayLoadFailureFaultCondition>();
}
