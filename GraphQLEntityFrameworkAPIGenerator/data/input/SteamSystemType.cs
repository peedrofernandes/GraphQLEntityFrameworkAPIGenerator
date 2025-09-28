using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("SteamSystemType")]
public partial class SteamSystemType
{
    [Key]
    public bool SteamSystemTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SteamSystemTypeDesc { get; set; } = null!;
}
