using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("FaultPrmOverTemperatureFailure")]
public partial class FaultPrmOverTemperatureFailure
{
    [Key]
    public Guid Id { get; set; }

    public float DetectOverTemperature { get; set; }

    public float RemoveOverTemperature { get; set; }
}
