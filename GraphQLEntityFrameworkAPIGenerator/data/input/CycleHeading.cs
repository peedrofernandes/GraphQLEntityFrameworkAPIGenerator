using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleHeading
{
    [Key]
    public byte Id { get; set; }

    [Column("CycleHeading")]
    [StringLength(20)]
    [Unicode(false)]
    public string CycleHeading1 { get; set; } = null!;

    [InverseProperty("CycleHeadingNavigation")]
    public virtual ICollection<CycleName> CycleNames { get; set; } = new List<CycleName>();
}
