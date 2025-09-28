using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("Id", "HighStatementId")]
public partial class SetStateEndCompletionType
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    [Key]
    public byte HighStatementId { get; set; }
}
