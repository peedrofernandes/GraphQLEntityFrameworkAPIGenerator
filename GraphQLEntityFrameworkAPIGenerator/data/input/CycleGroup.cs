using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleGroup
{
    [Key]
    public byte Id { get; set; }

    [Column("CycleGroup")]
    [StringLength(20)]
    [Unicode(false)]
    public string CycleGroup1 { get; set; } = null!;

    [InverseProperty("CycleGroupNavigation")]
    public virtual ICollection<CycleName> CycleNames { get; set; } = new List<CycleName>();
}
