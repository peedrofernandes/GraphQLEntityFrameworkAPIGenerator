using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmMaxStartTemperature")]
public partial class CycleOptionsPrmMaxStartTemperature
{
    [Key]
    public Guid MaxTempOptionsId { get; set; }

    public double MaximumStartTemperature { get; set; }
}
