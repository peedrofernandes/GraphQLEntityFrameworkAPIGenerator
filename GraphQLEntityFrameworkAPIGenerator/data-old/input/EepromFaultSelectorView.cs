using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class EepromFaultSelectorView
{
    public Guid ProjectId { get; set; }

    public byte Target { get; set; }

    public Guid MacroId { get; set; }

    [StringLength(50)]
    public string MacroDescription { get; set; } = null!;

    public byte StatementPosition { get; set; }

    public byte Step { get; set; }

    public bool T { get; set; }

    public bool N { get; set; }

    public Guid StatementId { get; set; }

    public Guid? LowStatementId { get; set; }

    public int? TimeEstimationId { get; set; }

    public int HighStatementId { get; set; }

    public byte FaultId { get; set; }

    [StringLength(50)]
    public string? StepLabel { get; set; }
}
