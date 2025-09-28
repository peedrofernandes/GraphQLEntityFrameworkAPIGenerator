using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Keyless]
public partial class FkView
{
    [StringLength(128)]
    public string? PrimaryKeyTable { get; set; }

    [StringLength(128)]
    public string? PrimaryKeyField { get; set; }

    [StringLength(128)]
    public string? SecondaryKeyTable { get; set; }

    [StringLength(128)]
    public string? SecondaryKeyField { get; set; }
}
