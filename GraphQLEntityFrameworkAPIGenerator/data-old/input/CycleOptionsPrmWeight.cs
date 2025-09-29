using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmWeight")]
public partial class CycleOptionsPrmWeight
{
    [Key]
    public Guid WeightOptionsId { get; set; }

    public float WeightSelectionMin { get; set; }

    public float WeightSelectionDefault { get; set; }

    public float WeightSelectionMax { get; set; }

    public bool? UnitsAreMetric { get; set; }

    public float Step { get; set; }
}
