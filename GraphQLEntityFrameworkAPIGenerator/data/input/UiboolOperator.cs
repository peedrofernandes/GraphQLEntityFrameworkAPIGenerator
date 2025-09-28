using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIBoolOperators")]
public partial class UiboolOperator
{
    [Key]
    [Column("UIOperatorId")]
    public byte UioperatorId { get; set; }

    [Column("UIOperator")]
    [StringLength(50)]
    [Unicode(false)]
    public string Uioperator { get; set; } = null!;
}
