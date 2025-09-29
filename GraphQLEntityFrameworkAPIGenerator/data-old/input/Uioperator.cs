using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIOperators")]
public partial class Uioperator
{
    [Key]
    [Column("UIOperatorId")]
    public byte UioperatorId { get; set; }

    [Column("UIOperator")]
    [StringLength(50)]
    [Unicode(false)]
    public string Uioperator1 { get; set; } = null!;

    [InverseProperty("Uioperator")]
    public virtual ICollection<UiconditionBlock> UiconditionBlocks { get; set; } = new List<UiconditionBlock>();
}
