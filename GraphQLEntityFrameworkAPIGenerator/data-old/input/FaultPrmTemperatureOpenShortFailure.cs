using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("FaultPrmTemperatureOpenShortFailure")]
public partial class FaultPrmTemperatureOpenShortFailure
{
    [Key]
    public Guid Id { get; set; }

    public float DetectFaultThreshold { get; set; }

    public float RemoveFaultThreshold { get; set; }
}
