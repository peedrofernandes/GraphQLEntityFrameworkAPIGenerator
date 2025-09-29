using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmAmount")]
public partial class CycleOptionsPrmAmount
{
    [Key]
    public Guid AmountOptionsId { get; set; }

    public float AmountMin { get; set; }

    public float AmountDefault { get; set; }

    public float AmountMax { get; set; }

    public byte AmountUnits { get; set; }

    public float Step { get; set; }
}
