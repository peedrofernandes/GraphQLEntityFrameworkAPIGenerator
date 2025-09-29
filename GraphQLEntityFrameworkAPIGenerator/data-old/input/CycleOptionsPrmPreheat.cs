using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmPreheat")]
public partial class CycleOptionsPrmPreheat
{
    [Key]
    public Guid PreheatOptionsId { get; set; }

    public bool UserEditable { get; set; }

    public byte PreheatDefault { get; set; }

    public bool NoPreheatOptionPresent { get; set; }

    public bool PreheatOptionPresent { get; set; }

    public bool RapidPreheatOptionPresent { get; set; }

    public byte DisplayRampStepF { get; set; }

    public byte DisplayRampStepC { get; set; }
}
