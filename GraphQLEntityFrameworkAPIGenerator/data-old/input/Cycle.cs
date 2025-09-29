using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Cycle
{
    [Key]
    public Guid CycleId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid? ProgrammingMacroId { get; set; }

    public Guid? DelayMacroId { get; set; }

    public Guid? PauseMacroId { get; set; }

    public Guid? EndMacroId { get; set; }

    [Column("ProgrammingUIMacroId")]
    public Guid? ProgrammingUimacroId { get; set; }

    [Column("DelayUIMacroId")]
    public Guid? DelayUimacroId { get; set; }

    [Column("PauseUIMacroId")]
    public Guid? PauseUimacroId { get; set; }

    [Column("EndUIMacroId")]
    public Guid? EndUimacroId { get; set; }

    [Column("RunUIMacroId")]
    public Guid? RunUimacroId { get; set; }

    public byte AfterFaultRestore { get; set; }

    public byte BackupRestore { get; set; }

    public bool Pause { get; set; }

    public int CycleName { get; set; }

    public byte CycleHeading { get; set; }

    public byte CycleSubHeading { get; set; }

    public byte CycleGroup { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public byte Target { get; set; }

    [ForeignKey("CycleName")]
    [InverseProperty("Cycles")]
    public virtual CycleName CycleNameNavigation { get; set; } = null!;

    [InverseProperty("Cycle")]
    public virtual ICollection<CyclesMacro> CyclesMacros { get; set; } = new List<CyclesMacro>();

    [ForeignKey("DelayMacroId")]
    [InverseProperty("CycleDelayMacros")]
    public virtual Macro? DelayMacro { get; set; }

    [ForeignKey("DelayUimacroId")]
    [InverseProperty("CycleDelayUimacros")]
    public virtual Uimacro? DelayUimacro { get; set; }

    [ForeignKey("EndMacroId")]
    [InverseProperty("CycleEndMacros")]
    public virtual Macro? EndMacro { get; set; }

    [ForeignKey("EndUimacroId")]
    [InverseProperty("CycleEndUimacros")]
    public virtual Uimacro? EndUimacro { get; set; }

    [ForeignKey("PauseMacroId")]
    [InverseProperty("CyclePauseMacros")]
    public virtual Macro? PauseMacro { get; set; }

    [ForeignKey("PauseUimacroId")]
    [InverseProperty("CyclePauseUimacros")]
    public virtual Uimacro? PauseUimacro { get; set; }

    [ForeignKey("ProgrammingMacroId")]
    [InverseProperty("CycleProgrammingMacros")]
    public virtual Macro? ProgrammingMacro { get; set; }

    [ForeignKey("ProgrammingUimacroId")]
    [InverseProperty("CycleProgrammingUimacros")]
    public virtual Uimacro? ProgrammingUimacro { get; set; }

    [ForeignKey("RunUimacroId")]
    [InverseProperty("CycleRunUimacros")]
    public virtual Uimacro? RunUimacro { get; set; }

    [InverseProperty("Cycle")]
    public virtual ICollection<SelectorsCycle> SelectorsCycles { get; set; } = new List<SelectorsCycle>();

    [ForeignKey("TableTarget")]
    [InverseProperty("Cycles")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;
}
