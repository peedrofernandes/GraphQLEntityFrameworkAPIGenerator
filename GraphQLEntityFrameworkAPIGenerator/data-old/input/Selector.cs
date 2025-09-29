using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Selector
{
    [Key]
    public Guid SelectorId { get; set; }

    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid? OffMacroId { get; set; }

    [Column("UIUserFunctionConfigurationId")]
    public Guid? UiuserFunctionConfigurationId { get; set; }

    [Column("GlobalUIMacroId")]
    public Guid? GlobalUimacroId { get; set; }

    [Column("ProgrammingUIMacroId")]
    public Guid? ProgrammingUimacroId { get; set; }

    [Column("DelayUIMacroId")]
    public Guid? DelayUimacroId { get; set; }

    [Column("PauseUIMacroId")]
    public Guid? PauseUimacroId { get; set; }

    [Column("EndUIMacroId")]
    public Guid? EndUimacroId { get; set; }

    [Column("OffUIMacroId")]
    public Guid? OffUimacroId { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public byte Target { get; set; }

    [Unicode(false)]
    public string? Comment { get; set; }

    [ForeignKey("DelayUimacroId")]
    [InverseProperty("SelectorDelayUimacros")]
    public virtual Uimacro? DelayUimacro { get; set; }

    [ForeignKey("EndUimacroId")]
    [InverseProperty("SelectorEndUimacros")]
    public virtual Uimacro? EndUimacro { get; set; }

    [ForeignKey("GlobalUimacroId")]
    [InverseProperty("SelectorGlobalUimacros")]
    public virtual Uimacro? GlobalUimacro { get; set; }

    [ForeignKey("OffMacroId")]
    [InverseProperty("Selectors")]
    public virtual Macro? OffMacro { get; set; }

    [ForeignKey("OffUimacroId")]
    [InverseProperty("SelectorOffUimacros")]
    public virtual Uimacro? OffUimacro { get; set; }

    [ForeignKey("PauseUimacroId")]
    [InverseProperty("SelectorPauseUimacros")]
    public virtual Uimacro? PauseUimacro { get; set; }

    [ForeignKey("ProgrammingUimacroId")]
    [InverseProperty("SelectorProgrammingUimacros")]
    public virtual Uimacro? ProgrammingUimacro { get; set; }

    [InverseProperty("Selector")]
    public virtual ICollection<SelectorConfigurationsSelector> SelectorConfigurationsSelectors { get; set; } = new List<SelectorConfigurationsSelector>();

    [InverseProperty("Selector")]
    public virtual ICollection<SelectorsCycle> SelectorsCycles { get; set; } = new List<SelectorsCycle>();

    [ForeignKey("TableTarget")]
    [InverseProperty("Selectors")]
    public virtual TableTarget TableTargetNavigation { get; set; } = null!;

    [ForeignKey("UiuserFunctionConfigurationId")]
    [InverseProperty("Selectors")]
    public virtual UifunctionConfiguration? UiuserFunctionConfiguration { get; set; }
}
