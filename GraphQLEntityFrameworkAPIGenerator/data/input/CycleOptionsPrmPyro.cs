using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmPyro")]
public partial class CycleOptionsPrmPyro
{
    [Key]
    public Guid PyroOptionsId { get; set; }

    public byte PyroCompletePercent { get; set; }

    public int CleanBackToBackTime { get; set; }
}
