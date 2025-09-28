using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("FaultPrmFanOverSpeedFailure")]
public partial class FaultPrmFanOverSpeedFailure
{
    [Key]
    public Guid Id { get; set; }

    public byte Version { get; set; }

    [Column("FanSpeedGI")]
    public byte FanSpeedGi { get; set; }

    public short MaximumFanSpeed { get; set; }
}
