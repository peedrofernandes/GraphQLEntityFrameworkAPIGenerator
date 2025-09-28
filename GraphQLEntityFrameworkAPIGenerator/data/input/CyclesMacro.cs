using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("CycleId", "MacroId", "Index")]
[Table("Cycles_Macros")]
public partial class CyclesMacro
{
    [Key]
    public Guid CycleId { get; set; }

    [Key]
    public Guid MacroId { get; set; }

    [Key]
    public byte Index { get; set; }

    [StringLength(50)]
    public string PhaseName { get; set; } = null!;

    [Column("UIMacroId")]
    public Guid? UimacroId { get; set; }

    public Guid? TimeEstimationId { get; set; }

    public int? UserPhaseName { get; set; }

    [ForeignKey("CycleId")]
    [InverseProperty("CyclesMacros")]
    public virtual Cycle Cycle { get; set; } = null!;

    [ForeignKey("MacroId")]
    [InverseProperty("CyclesMacros")]
    public virtual Macro Macro { get; set; } = null!;

    [ForeignKey("TimeEstimationId")]
    [InverseProperty("CyclesMacros")]
    public virtual TimeEstimation? TimeEstimation { get; set; }

    [ForeignKey("UimacroId")]
    [InverseProperty("CyclesMacros")]
    public virtual Uimacro? Uimacro { get; set; }

    [ForeignKey("UserPhaseName")]
    [InverseProperty("CyclesMacros")]
    public virtual UserPhaseName? UserPhaseNameNavigation { get; set; }
}
