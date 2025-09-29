using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class MicrowavePowerTableView
{
    public Guid MicrowavePowerTableConfigId { get; set; }

    public byte Index { get; set; }

    public byte PowerLabel { get; set; }

    [Column("MWDutyPeriod")]
    public float MwdutyPeriod { get; set; }

    public float OnTime { get; set; }
}
