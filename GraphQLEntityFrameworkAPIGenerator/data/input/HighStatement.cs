using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class HighStatement
{
    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public byte Priority { get; set; }

    [Key]
    public int HighStatementId { get; set; }

    [InverseProperty("HighStatement")]
    public virtual ICollection<ProductTypesHighStatement> ProductTypesHighStatements { get; set; } = new List<ProductTypesHighStatement>();
}
