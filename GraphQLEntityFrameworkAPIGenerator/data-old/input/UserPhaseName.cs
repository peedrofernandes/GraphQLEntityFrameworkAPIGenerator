using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class UserPhaseName
{
    [Key]
    public int Id { get; set; }

    [Column("UserPhaseName")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserPhaseName1 { get; set; } = null!;

    [InverseProperty("UserPhaseNameNavigation")]
    public virtual ICollection<CyclesMacro> CyclesMacros { get; set; } = new List<CyclesMacro>();
}
