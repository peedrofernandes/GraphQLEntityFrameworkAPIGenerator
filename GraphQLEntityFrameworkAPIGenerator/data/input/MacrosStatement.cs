using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("MacroId", "StatementId", "Index")]
[Table("Macros_Statements")]
public partial class MacrosStatement
{
    [Key]
    public Guid MacroId { get; set; }

    [Key]
    public Guid StatementId { get; set; }

    [Key]
    public byte Index { get; set; }

    public byte Step { get; set; }

    public bool T { get; set; }

    public bool N { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Comment { get; set; }

    [StringLength(50)]
    public string? StepLabel { get; set; }

    [ForeignKey("MacroId")]
    [InverseProperty("MacrosStatements")]
    public virtual Macro Macro { get; set; } = null!;

    [ForeignKey("StatementId")]
    [InverseProperty("MacrosStatements")]
    public virtual Statement Statement { get; set; } = null!;
}
