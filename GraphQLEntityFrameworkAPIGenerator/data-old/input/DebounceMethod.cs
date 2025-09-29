using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class DebounceMethod
{
    [Key]
    public byte DebounceMethodId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DebounceMethodDescription { get; set; } = null!;

    [InverseProperty("FaultDebounceMethod")]
    public virtual ICollection<DebounceMethodParameter> DebounceMethodParameterFaultDebounceMethods { get; set; } = new List<DebounceMethodParameter>();

    [InverseProperty("PrefaultDebounceMethod")]
    public virtual ICollection<DebounceMethodParameter> DebounceMethodParameterPrefaultDebounceMethods { get; set; } = new List<DebounceMethodParameter>();
}
