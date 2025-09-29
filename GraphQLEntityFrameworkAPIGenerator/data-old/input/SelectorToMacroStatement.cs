using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class SelectorToMacroStatement
{
    public Guid SelectorId { get; set; }

    public Guid StatementId { get; set; }

    public Guid? LowStatementId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(41)]
    [Unicode(false)]
    public string MacroPrefix { get; set; } = null!;

    public int MacroIndex { get; set; }

    public byte StatementsIndex { get; set; }

    public bool T { get; set; }

    [StringLength(50)]
    public string MacroDescription { get; set; } = null!;

    public bool N { get; set; }

    public int PhaseRev { get; set; }

    public byte? OpCode { get; set; }

    public bool? F0 { get; set; }

    public bool? F1 { get; set; }

    public int? HighStatementId { get; set; }
}
