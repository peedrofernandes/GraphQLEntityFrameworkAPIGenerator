using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotPWM")]
public partial class PrmPilotPwm
{
    [Key]
    public Guid Id { get; set; }

    public bool F { get; set; }

    public bool A { get; set; }

    public int BaseFrequency { get; set; }

    public short SpeedMin { get; set; }

    public short DeltaMax { get; set; }

    public short DeltaMin { get; set; }
}
