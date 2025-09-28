using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Macro
{
    [Key]
    public Guid MacroId { get; set; }

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

    public byte Target { get; set; }

    [Unicode(false)]
    public string? Comment { get; set; }

    [InverseProperty("DelayMacro")]
    public virtual ICollection<Cycle> CycleDelayMacros { get; set; } = new List<Cycle>();

    [InverseProperty("EndMacro")]
    public virtual ICollection<Cycle> CycleEndMacros { get; set; } = new List<Cycle>();

    [InverseProperty("PauseMacro")]
    public virtual ICollection<Cycle> CyclePauseMacros { get; set; } = new List<Cycle>();

    [InverseProperty("ProgrammingMacro")]
    public virtual ICollection<Cycle> CycleProgrammingMacros { get; set; } = new List<Cycle>();

    [InverseProperty("Macro")]
    public virtual ICollection<CyclesMacro> CyclesMacros { get; set; } = new List<CyclesMacro>();

    [InverseProperty("Macro")]
    public virtual ICollection<FaultDetail> FaultDetails { get; set; } = new List<FaultDetail>();

    [InverseProperty("Macro")]
    public virtual ICollection<MacrosStatement> MacrosStatements { get; set; } = new List<MacrosStatement>();

    [InverseProperty("OffMacro")]
    public virtual ICollection<Selector> Selectors { get; set; } = new List<Selector>();

    [ForeignKey("TableTarget")]
    [InverseProperty("Macros")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
