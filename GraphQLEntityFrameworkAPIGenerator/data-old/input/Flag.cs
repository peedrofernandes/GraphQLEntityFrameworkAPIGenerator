using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("Position", "VariableId")]
public partial class Flag
{
    [Key]
    public byte Position { get; set; }

    [Key]
    public int VariableId { get; set; }

    [Column("Flag")]
    [StringLength(50)]
    [Unicode(false)]
    public string Flag1 { get; set; } = null!;

    public byte Offset { get; set; }

    public bool IsEnum { get; set; }

    public byte BitSize { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TableBinding { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DisplayMember { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ValueMember { get; set; }

    [ForeignKey("VariableId")]
    [InverseProperty("Flags")]
    public virtual Variable Variable { get; set; } = null!;
}
