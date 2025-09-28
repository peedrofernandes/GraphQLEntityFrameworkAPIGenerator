using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotUniversalMotor")]
public partial class PrmPilotUniversalMotor
{
    [Key]
    public Guid Id { get; set; }

    public byte TachoIndex { get; set; }

    public short FbkDebounceTime { get; set; }

    public short TapfieldSuspendTime { get; set; }

    public short TachoTimeout { get; set; }

    public short AngleFbkThreshold { get; set; }
}
