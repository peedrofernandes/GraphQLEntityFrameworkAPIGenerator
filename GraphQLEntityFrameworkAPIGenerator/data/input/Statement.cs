using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Statement
{
    [Key]
    public Guid StatementId { get; set; }

    public Guid? LowStatementId { get; set; }

    public int HighStatementId { get; set; }

    [InverseProperty("Statement")]
    public virtual ICollection<MacrosStatement> MacrosStatements { get; set; } = new List<MacrosStatement>();
}
