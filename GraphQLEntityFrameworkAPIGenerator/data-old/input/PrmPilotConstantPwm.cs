using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotConstantPWM")]
public partial class PrmPilotConstantPwm
{
    [Key]
    public Guid Id { get; set; }

    public int BaseFrequency { get; set; }

    public byte ProfileNumber { get; set; }

    [Column("DProfiles")]
    [MaxLength(16)]
    public byte[] Dprofiles { get; set; } = null!;

    public byte? MaxDutyStep { get; set; }

    public byte? MinDutyStep { get; set; }

    public byte? ValidMinDuty { get; set; }

    public short? StepIntervalTime { get; set; }

    public bool? EnableDutyStep { get; set; }
}
