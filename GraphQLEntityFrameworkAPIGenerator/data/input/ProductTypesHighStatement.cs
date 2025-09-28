using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("ProductTypeId", "HighStatementId")]
[Table("ProductTypes_HighStatements")]
public partial class ProductTypesHighStatement
{
    [Key]
    public byte ProductTypeId { get; set; }

    [Key]
    public int HighStatementId { get; set; }

    public byte OpCode { get; set; }

    public bool F0 { get; set; }

    public bool F1 { get; set; }

    [ForeignKey("HighStatementId")]
    [InverseProperty("ProductTypesHighStatements")]
    public virtual HighStatement HighStatement { get; set; } = null!;

    [ForeignKey("OpCode")]
    [InverseProperty("ProductTypesHighStatements")]
    public virtual OpCode OpCodeNavigation { get; set; } = null!;

    [ForeignKey("ProductTypeId")]
    [InverseProperty("ProductTypesHighStatements")]
    public virtual ProductType ProductType { get; set; } = null!;
}
