using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DebounceMethodParameter
{
    [Key]
    public Guid DebounceMethodParametersId { get; set; }

    public byte PrefaultDebounceMethodId { get; set; }

    public byte PrefaultPrescalarId { get; set; }

    public byte PrefaultDelay { get; set; }

    public byte FaultDebounceMethodId { get; set; }

    public byte FaultPrescalarId { get; set; }

    public byte FaultDelay { get; set; }

    public byte RemovedPrefaultPrescalarId { get; set; }

    public byte RemovedPrefaultDelay { get; set; }

    public byte RemovedFaultPrescalarId { get; set; }

    public byte RemovedFaultDelay { get; set; }

    [ForeignKey("FaultDebounceMethodId")]
    [InverseProperty("DebounceMethodParameterFaultDebounceMethods")]
    public virtual DebounceMethod FaultDebounceMethod { get; set; } = null!;

    [InverseProperty("DebounceParameters")]
    public virtual ICollection<FaultDetail> FaultDetails { get; set; } = new List<FaultDetail>();

    [ForeignKey("FaultPrescalarId")]
    [InverseProperty("DebounceMethodParameterFaultPrescalars")]
    public virtual DebounceMethodPrescalar FaultPrescalar { get; set; } = null!;

    [ForeignKey("PrefaultDebounceMethodId")]
    [InverseProperty("DebounceMethodParameterPrefaultDebounceMethods")]
    public virtual DebounceMethod PrefaultDebounceMethod { get; set; } = null!;

    [ForeignKey("PrefaultPrescalarId")]
    [InverseProperty("DebounceMethodParameterPrefaultPrescalars")]
    public virtual DebounceMethodPrescalar PrefaultPrescalar { get; set; } = null!;

    [ForeignKey("RemovedFaultPrescalarId")]
    [InverseProperty("DebounceMethodParameterRemovedFaultPrescalars")]
    public virtual DebounceMethodPrescalar RemovedFaultPrescalar { get; set; } = null!;

    [ForeignKey("RemovedPrefaultPrescalarId")]
    [InverseProperty("DebounceMethodParameterRemovedPrefaultPrescalars")]
    public virtual DebounceMethodPrescalar RemovedPrefaultPrescalar { get; set; } = null!;
}
