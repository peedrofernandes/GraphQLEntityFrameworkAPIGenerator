using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromUiselectorView
{
    public Guid ProjectId { get; set; }

    public Guid SelectorId { get; set; }

    public byte CyclePosition { get; set; }

    public Guid CycleId { get; set; }

    [StringLength(50)]
    public string CycleDescription { get; set; } = null!;

    public byte PhasePosition { get; set; }

    [StringLength(50)]
    public string PhaseName { get; set; } = null!;

    [Column("UIMacroId")]
    public Guid? UimacroId { get; set; }

    [StringLength(50)]
    public string? MacroDescription { get; set; }

    public byte? StatementPosition { get; set; }

    public byte? Step { get; set; }

    public bool? T { get; set; }

    public bool? N { get; set; }

    [Column("UIStatementId")]
    public Guid? UistatementId { get; set; }

    public byte? OpCode { get; set; }

    public bool? F0 { get; set; }

    public bool? F1 { get; set; }

    public Guid? LowStatementId { get; set; }

    public int? Target { get; set; }

    [StringLength(50)]
    public string? StepLabel { get; set; }
}
