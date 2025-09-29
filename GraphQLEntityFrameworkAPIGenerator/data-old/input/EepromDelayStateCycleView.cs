using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromDelayStateCycleView
{
    public Guid ProjectId { get; set; }

    public Guid SelectorId { get; set; }

    public int StateCyclePosition { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string StateCycleDescription { get; set; } = null!;

    public byte PhasePosition { get; set; }

    public Guid MacroId { get; set; }

    [StringLength(50)]
    public string MacroDescription { get; set; } = null!;

    public byte StatementPosition { get; set; }

    public byte Step { get; set; }

    public bool T { get; set; }

    public bool N { get; set; }

    public Guid StatementId { get; set; }

    public Guid? LowStatementId { get; set; }

    public int? Target { get; set; }

    public byte Priority { get; set; }

    public byte CycleTypeId { get; set; }

    public Guid? ConditionId { get; set; }

    public int? TimeEstimationId { get; set; }

    public int HighStatementId { get; set; }

    public int CycleNameId { get; set; }

    [StringLength(50)]
    public string? StepLabel { get; set; }
}
