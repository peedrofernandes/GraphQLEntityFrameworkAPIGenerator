using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UimacroId", "UistatementId", "Index")]
[Table("UIMacros_UIStatements")]
public partial class UimacrosUistatement
{
    [Key]
    [Column("UIMacroId")]
    public Guid UimacroId { get; set; }

    [Key]
    [Column("UIStatementId")]
    public Guid UistatementId { get; set; }

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

    [ForeignKey("UimacroId")]
    [InverseProperty("UimacrosUistatements")]
    public virtual Uimacro Uimacro { get; set; } = null!;

    [ForeignKey("UistatementId")]
    [InverseProperty("UimacrosUistatements")]
    public virtual Uistatement Uistatement { get; set; } = null!;
}
