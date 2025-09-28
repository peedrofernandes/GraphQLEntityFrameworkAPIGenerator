using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class RestoreMode
{
    [Key]
    public byte Id { get; set; }

    [Column("RestoreMode")]
    [StringLength(64)]
    [Unicode(false)]
    public string RestoreMode1 { get; set; } = null!;
}
