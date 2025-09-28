using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIOpCodes")]
public partial class UiopCode
{
    [Key]
    public byte OpCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Statement { get; set; } = null!;

    [InverseProperty("OpCodeNavigation")]
    public virtual ICollection<UihighStatement> UihighStatements { get; set; } = new List<UihighStatement>();
}
