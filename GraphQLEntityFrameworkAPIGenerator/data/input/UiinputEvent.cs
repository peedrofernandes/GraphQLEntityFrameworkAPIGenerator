using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIInputEvents")]
public partial class UiinputEvent
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Description { get; set; } = null!;
}
