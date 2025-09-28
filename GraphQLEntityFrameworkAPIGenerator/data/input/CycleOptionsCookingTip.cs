using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("TipKeyId", "TipValueId")]
public partial class CycleOptionsCookingTip
{
    [Key]
    public int TipKeyId { get; set; }

    [Key]
    public int TipValueId { get; set; }

    [StringLength(50)]
    public string TipKeyDescription { get; set; } = null!;

    [StringLength(200)]
    public string TipValueDescription { get; set; } = null!;
}
