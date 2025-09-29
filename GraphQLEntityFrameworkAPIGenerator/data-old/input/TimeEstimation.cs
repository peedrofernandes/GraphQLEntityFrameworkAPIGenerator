using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("TimeEstimation")]
public partial class TimeEstimation
{
    [Key]
    public Guid TimeEstimationId { get; set; }

    public short Time { get; set; }

    public bool? HasModifiers { get; set; }

    [Unicode(false)]
    public string? ModifiersLabel { get; set; }

    public bool UseDirectModifier { get; set; }

    public Guid? ModifierId { get; set; }

    [InverseProperty("TimeEstimation")]
    public virtual ICollection<CyclesMacro> CyclesMacros { get; set; } = new List<CyclesMacro>();

    [ForeignKey("ModifierId")]
    [InverseProperty("TimeEstimations")]
    public virtual Modifier? Modifier { get; set; }
}
