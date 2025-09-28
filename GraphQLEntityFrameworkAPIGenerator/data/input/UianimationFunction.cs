using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
[Table("UIAnimationFunctions")]
public partial class UianimationFunction
{
    public short? Id { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }
}
