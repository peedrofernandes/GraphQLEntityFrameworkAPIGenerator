using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class ExpansionBoard
{
    [Key]
    public byte ExpansionBoardId { get; set; }

    [Column("ExpansionBoard")]
    [StringLength(100)]
    [Unicode(false)]
    public string ExpansionBoard1 { get; set; } = null!;

    public bool IsHmi { get; set; }
}
