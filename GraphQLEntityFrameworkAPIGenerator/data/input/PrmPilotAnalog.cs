using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotAnalog")]
public partial class PrmPilotAnalog
{
    [Key]
    public Guid Id { get; set; }

    public float MinPercent { get; set; }

    public float MaxPercent { get; set; }
}
