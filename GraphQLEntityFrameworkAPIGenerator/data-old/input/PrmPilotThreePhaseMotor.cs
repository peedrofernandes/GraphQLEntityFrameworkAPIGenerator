using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotThreePhaseMotor")]
public partial class PrmPilotThreePhaseMotor
{
    [Key]
    public Guid Id { get; set; }

    public byte MotorIndex { get; set; }

    public byte DefaultAcceleration { get; set; }

    public byte RefreshSeconds { get; set; }
}
