using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("FaultPrmFanStalledFailure")]
public partial class FaultPrmFanStalledFailure
{
    [Key]
    public Guid Id { get; set; }

    public byte Version { get; set; }

    [Column("FanSpeedGI")]
    public byte FanSpeedGi { get; set; }

    public short MinimumFanSpeed { get; set; }
}
