using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("Id", "Grouping")]
public partial class CycleOptionsDonenessLevel
{
    [Key]
    public short Id { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    [Key]
    public byte Grouping { get; set; }
}
