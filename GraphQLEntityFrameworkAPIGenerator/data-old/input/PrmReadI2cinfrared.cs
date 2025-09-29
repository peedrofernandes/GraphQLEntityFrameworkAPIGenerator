using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadI2CInfrared")]
public partial class PrmReadI2cinfrared
{
    [Key]
    public Guid Id { get; set; }

    public int StepPeriodMilliseconds { get; set; }

    [Column("I2CChannel")]
    public byte I2cchannel { get; set; }

    public byte BitResolution { get; set; }

    public byte RefreshRate { get; set; }

    [ForeignKey("RefreshRate")]
    [InverseProperty("PrmReadI2cinfrareds")]
    public virtual RefreshRate RefreshRateNavigation { get; set; } = null!;
}
