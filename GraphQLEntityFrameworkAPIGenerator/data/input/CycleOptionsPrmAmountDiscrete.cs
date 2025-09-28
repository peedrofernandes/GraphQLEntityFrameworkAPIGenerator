using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmAmountDiscrete")]
public partial class CycleOptionsPrmAmountDiscrete
{
    [Key]
    public Guid AmountDiscreteOptionId { get; set; }

    public byte Version { get; set; }

    public byte NumberOfDecimals { get; set; }

    public byte Units { get; set; }

    public byte NumberOfLevels { get; set; }

    public float DefaultAmount { get; set; }

    public float Amount1 { get; set; }

    public float Amount2 { get; set; }

    public float Amount3 { get; set; }

    public float Amount4 { get; set; }

    public float Amount5 { get; set; }

    public float Amount6 { get; set; }

    public float Amount7 { get; set; }

    public float Amount8 { get; set; }
}
