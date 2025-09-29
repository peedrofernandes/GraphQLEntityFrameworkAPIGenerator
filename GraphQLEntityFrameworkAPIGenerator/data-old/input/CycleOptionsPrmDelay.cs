using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmDelay")]
public partial class CycleOptionsPrmDelay
{
    [Key]
    public Guid DelayOptionsId { get; set; }

    public int DelayMin { get; set; }

    public int DelayDefault { get; set; }

    public int DelayMax { get; set; }

    public int Step { get; set; }
}
