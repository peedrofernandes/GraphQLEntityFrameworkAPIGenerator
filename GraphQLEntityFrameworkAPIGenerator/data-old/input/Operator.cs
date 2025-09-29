using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Operator
{
    [Key]
    public byte OperatorId { get; set; }

    [Column("Operator")]
    [StringLength(50)]
    [Unicode(false)]
    public string Operator1 { get; set; } = null!;
}
