using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DebounceMethodPrescalar
{
    [Key]
    public byte DebounceMethodPrescalarId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DebounceMethodPrescalarDescription { get; set; } = null!;

    [InverseProperty("FaultPrescalar")]
    public virtual ICollection<DebounceMethodParameter> DebounceMethodParameterFaultPrescalars { get; set; } = new List<DebounceMethodParameter>();

    [InverseProperty("PrefaultPrescalar")]
    public virtual ICollection<DebounceMethodParameter> DebounceMethodParameterPrefaultPrescalars { get; set; } = new List<DebounceMethodParameter>();

    [InverseProperty("RemovedFaultPrescalar")]
    public virtual ICollection<DebounceMethodParameter> DebounceMethodParameterRemovedFaultPrescalars { get; set; } = new List<DebounceMethodParameter>();

    [InverseProperty("RemovedPrefaultPrescalar")]
    public virtual ICollection<DebounceMethodParameter> DebounceMethodParameterRemovedPrefaultPrescalars { get; set; } = new List<DebounceMethodParameter>();
}
