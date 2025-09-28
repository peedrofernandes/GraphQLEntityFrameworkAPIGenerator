using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("OpCode", "F0", "F1")]
[Table("UIHighStatements")]
public partial class UihighStatement
{
    [Key]
    public byte OpCode { get; set; }

    [Key]
    public bool F0 { get; set; }

    [Key]
    public bool F1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public byte Priority { get; set; }

    [ForeignKey("OpCode")]
    [InverseProperty("UihighStatements")]
    public virtual UiopCode OpCodeNavigation { get; set; } = null!;
}
