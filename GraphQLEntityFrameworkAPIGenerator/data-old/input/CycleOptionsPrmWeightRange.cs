using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleOptionsPrmWeightRange
{
    [Key]
    public Guid WeightRangesOptionId { get; set; }

    public byte Version { get; set; }

    public float Step { get; set; }

    public float WeightDefault { get; set; }

    public byte NumberOfLevels { get; set; }

    public float Weight1 { get; set; }

    public float Weight2 { get; set; }

    public float Weight3 { get; set; }

    public float Weight4 { get; set; }

    public float Weight5 { get; set; }

    public float Weight6 { get; set; }
}
