using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("FaultPrmMeatProbeFailure")]
public partial class FaultPrmMeatProbeFailure
{
    [Key]
    public Guid Id { get; set; }

    public float MaximumTemperature { get; set; }
}
