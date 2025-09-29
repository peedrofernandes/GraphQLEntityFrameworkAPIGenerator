using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class ModifierOverallOperation
{
    [Key]
    public byte ModifierOverallOperationId { get; set; }

    [StringLength(50)]
    public string ModifierOverallOperationDescription { get; set; } = null!;
}
