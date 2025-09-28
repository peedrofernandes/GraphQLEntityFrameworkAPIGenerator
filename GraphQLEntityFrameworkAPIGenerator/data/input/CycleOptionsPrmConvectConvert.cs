using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmConvectConvert")]
public partial class CycleOptionsPrmConvectConvert
{
    [Key]
    public Guid ConvectConversionOptionsId { get; set; }

    public byte TimeAdjustValue { get; set; }

    public float TemperatureAdjustValue { get; set; }
}
