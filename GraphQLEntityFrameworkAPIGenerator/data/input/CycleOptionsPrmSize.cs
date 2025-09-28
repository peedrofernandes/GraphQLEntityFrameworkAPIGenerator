using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmSize")]
public partial class CycleOptionsPrmSize
{
    [Key]
    public Guid SizeOptionsId { get; set; }

    public float SizeSelectionMin { get; set; }

    public float SizeSelectionDefault { get; set; }

    public float SizeSelectionMax { get; set; }

    public bool? UnitsAreMetric { get; set; }

    public float Step { get; set; }
}
