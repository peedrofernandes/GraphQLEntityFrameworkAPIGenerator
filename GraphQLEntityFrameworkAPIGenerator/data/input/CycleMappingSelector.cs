using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class CycleMappingSelector
{
    public Guid ProjectId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public int? Index { get; set; }
}
