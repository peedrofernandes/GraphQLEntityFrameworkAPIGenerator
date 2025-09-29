using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleOptionsStepTableType
{
    [Key]
    public byte Id { get; set; }

    [StringLength(100)]
    public string Description { get; set; } = null!;
}
