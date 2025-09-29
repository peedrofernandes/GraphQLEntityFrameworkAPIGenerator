using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadSRPeakToPeakAnalog")]
public partial class PrmReadSrpeakToPeakAnalog
{
    [Key]
    public Guid Id { get; set; }

    public short MinimumAdValue { get; set; }

    public short MaximumAdValue { get; set; }

    public short NominalAdValue { get; set; }

    public byte Hysteresis { get; set; }

    public short PreOffset { get; set; }

    public short PostOffset { get; set; }

    public short ZeroLevelReference { get; set; }
}
