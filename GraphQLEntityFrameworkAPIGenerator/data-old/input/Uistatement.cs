using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIStatements")]
public partial class Uistatement
{
    [Key]
    [Column("UIStatementId")]
    public Guid UistatementId { get; set; }

    public byte OpCode { get; set; }

    public bool F0 { get; set; }

    public bool F1 { get; set; }

    public Guid? LowStatementId { get; set; }

    [InverseProperty("Uistatement")]
    public virtual ICollection<UimacrosUistatement> UimacrosUistatements { get; set; } = new List<UimacrosUistatement>();
}
