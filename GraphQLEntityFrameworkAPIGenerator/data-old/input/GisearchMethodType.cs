using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("GISearchMethodTypes")]
public partial class GisearchMethodType
{
    [Key]
    [Column("GISearchMethodId")]
    public byte GisearchMethodId { get; set; }

    [Column("GISearchMethodDescription")]
    [StringLength(50)]
    public string GisearchMethodDescription { get; set; } = null!;
}
