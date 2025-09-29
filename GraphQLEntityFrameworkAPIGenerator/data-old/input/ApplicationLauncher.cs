using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("ApplicationName", "Environment")]
[Table("ApplicationLauncher")]
public partial class ApplicationLauncher
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ApplicationName { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Environment { get; set; } = null!;

    public bool Enabled { get; set; }
}
