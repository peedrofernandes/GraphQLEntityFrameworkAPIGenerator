using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotImpulsive")]
public partial class PrmPilotImpulsive
{
    [Key]
    public Guid Id { get; set; }

    public byte MaxPulseNumber { get; set; }

    public byte PulseTiming { get; set; }

    public short UnlockWaitTime { get; set; }

    public bool IsDoorSensing { get; set; }

    public byte PulseWidth { get; set; }
}
