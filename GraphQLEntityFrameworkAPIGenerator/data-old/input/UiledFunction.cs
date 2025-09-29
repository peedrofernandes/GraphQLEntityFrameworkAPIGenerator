using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UILedFunctions")]
public partial class UiledFunction
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Description { get; set; } = null!;

    public bool IsGroupFunction { get; set; }
}
