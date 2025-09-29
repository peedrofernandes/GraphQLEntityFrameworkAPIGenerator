using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIMacros")]
public partial class Uimacro
{
    [Key]
    [Column("UIMacroId")]
    public Guid UimacroId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TimeStamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [InverseProperty("DelayUimacro")]
    public virtual ICollection<Cycle> CycleDelayUimacros { get; set; } = new List<Cycle>();

    [InverseProperty("EndUimacro")]
    public virtual ICollection<Cycle> CycleEndUimacros { get; set; } = new List<Cycle>();

    [InverseProperty("PauseUimacro")]
    public virtual ICollection<Cycle> CyclePauseUimacros { get; set; } = new List<Cycle>();

    [InverseProperty("ProgrammingUimacro")]
    public virtual ICollection<Cycle> CycleProgrammingUimacros { get; set; } = new List<Cycle>();

    [InverseProperty("RunUimacro")]
    public virtual ICollection<Cycle> CycleRunUimacros { get; set; } = new List<Cycle>();

    [InverseProperty("Uimacro")]
    public virtual ICollection<CyclesMacro> CyclesMacros { get; set; } = new List<CyclesMacro>();

    [InverseProperty("GlobalUimacro")]
    public virtual ICollection<SelectorConfiguration> SelectorConfigurations { get; set; } = new List<SelectorConfiguration>();

    [InverseProperty("DelayUimacro")]
    public virtual ICollection<Selector> SelectorDelayUimacros { get; set; } = new List<Selector>();

    [InverseProperty("EndUimacro")]
    public virtual ICollection<Selector> SelectorEndUimacros { get; set; } = new List<Selector>();

    [InverseProperty("GlobalUimacro")]
    public virtual ICollection<Selector> SelectorGlobalUimacros { get; set; } = new List<Selector>();

    [InverseProperty("OffUimacro")]
    public virtual ICollection<Selector> SelectorOffUimacros { get; set; } = new List<Selector>();

    [InverseProperty("PauseUimacro")]
    public virtual ICollection<Selector> SelectorPauseUimacros { get; set; } = new List<Selector>();

    [InverseProperty("ProgrammingUimacro")]
    public virtual ICollection<Selector> SelectorProgrammingUimacros { get; set; } = new List<Selector>();

    [ForeignKey("TableTarget")]
    [InverseProperty("Uimacros")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [InverseProperty("Uimacro")]
    public virtual ICollection<UimacrosUistatement> UimacrosUistatements { get; set; } = new List<UimacrosUistatement>();

    [InverseProperty("DoMacro")]
    public virtual ICollection<UiviewEngineControlStateDetail> UiviewEngineControlStateDetailDoMacros { get; set; } = new List<UiviewEngineControlStateDetail>();

    [InverseProperty("OnEntryMacro")]
    public virtual ICollection<UiviewEngineControlStateDetail> UiviewEngineControlStateDetailOnEntryMacros { get; set; } = new List<UiviewEngineControlStateDetail>();

    [InverseProperty("OnExitMacro")]
    public virtual ICollection<UiviewEngineControlStateDetail> UiviewEngineControlStateDetailOnExitMacros { get; set; } = new List<UiviewEngineControlStateDetail>();

    [InverseProperty("DoMacro")]
    public virtual ICollection<UiviewEngineViewsDetail> UiviewEngineViewsDetailDoMacros { get; set; } = new List<UiviewEngineViewsDetail>();

    [InverseProperty("OnEntryMacro")]
    public virtual ICollection<UiviewEngineViewsDetail> UiviewEngineViewsDetailOnEntryMacros { get; set; } = new List<UiviewEngineViewsDetail>();

    [InverseProperty("OnExitMacro")]
    public virtual ICollection<UiviewEngineViewsDetail> UiviewEngineViewsDetailOnExitMacros { get; set; } = new List<UiviewEngineViewsDetail>();
}
