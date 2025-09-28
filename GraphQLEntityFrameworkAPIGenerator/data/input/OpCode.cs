using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class OpCode
{
    [Key]
    [Column("OpCode")]
    public byte OpCode1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Statement { get; set; } = null!;

    [InverseProperty("OpCodeNavigation")]
    public virtual ICollection<ProductTypesHighStatement> ProductTypesHighStatements { get; set; } = new List<ProductTypesHighStatement>();
}
