using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class CyclesToStatement
{
    public Guid CycleId { get; set; }

    public short? Time { get; set; }

    [StringLength(50)]
    public string? TimeEstModDescription { get; set; }

    public bool? UseDirectModifier { get; set; }

    [Column("UIMacro")]
    [StringLength(50)]
    public string? Uimacro { get; set; }

    public Guid StatementId { get; set; }

    public Guid? LowStatementId { get; set; }

    public int? HighStatementId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int? MacrosIndex { get; set; }

    public byte StatementsIndex { get; set; }

    public bool T { get; set; }

    [StringLength(50)]
    public string CycleDescription { get; set; } = null!;

    [StringLength(50)]
    public string MacroDescription { get; set; } = null!;

    [StringLength(50)]
    public string PhaseName { get; set; } = null!;

    public bool N { get; set; }

    public int CycleRev { get; set; }

    public int PhaseRev { get; set; }

    public bool Pause { get; set; }

    public byte BackupRestore { get; set; }

    public bool? HasTimeEstModifiers { get; set; }

    [Unicode(false)]
    public string? ModifiersLabel { get; set; }

    public byte? OpCode { get; set; }

    public bool? F0 { get; set; }

    public bool? F1 { get; set; }
}
