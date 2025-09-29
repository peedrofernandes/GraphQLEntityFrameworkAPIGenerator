using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromCyclesView
{
    public Guid ProjectId { get; set; }

    public Guid SelectorId { get; set; }

    public int? Target { get; set; }

    [StringLength(50)]
    public string SelectorDescription { get; set; } = null!;

    public byte CyclePosition { get; set; }

    public Guid CycleId { get; set; }

    [StringLength(50)]
    public string CycleDescription { get; set; } = null!;

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

    public byte CyclesTarget { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CycleName { get; set; } = null!;

    public byte CycleTypeId { get; set; }

    public byte Priority { get; set; }

    public Guid? ConditionId { get; set; }

    public int CycleNameId { get; set; }
}
