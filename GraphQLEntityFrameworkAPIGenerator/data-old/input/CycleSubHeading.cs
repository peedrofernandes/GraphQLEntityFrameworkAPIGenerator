using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleSubHeading
{
    [Key]
    public byte Id { get; set; }

    [Column("CycleSubHeading")]
    [StringLength(255)]
    [Unicode(false)]
    public string CycleSubHeading1 { get; set; } = null!;
}
