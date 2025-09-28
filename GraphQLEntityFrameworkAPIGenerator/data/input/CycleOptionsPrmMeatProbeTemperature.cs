using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmMeatProbeTemperature")]
public partial class CycleOptionsPrmMeatProbeTemperature
{
    [Key]
    public Guid MeatProbeOptionsId { get; set; }

    public float TempSelectionCelsiusMin { get; set; }

    public float TempSelectionCelsiusDefault { get; set; }

    public float TempSelectionCelsiusMax { get; set; }

    public byte StepCelsius { get; set; }

    public byte StepFahrenheit { get; set; }
}
