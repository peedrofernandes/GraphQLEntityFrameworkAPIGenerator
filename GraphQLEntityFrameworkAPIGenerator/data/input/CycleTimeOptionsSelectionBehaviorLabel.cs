using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleTimeOptionsSelectionBehaviorLabel
{
    [Key]
    public byte Id { get; set; }

    [StringLength(100)]
    public string Behavior { get; set; } = null!;

    [InverseProperty("UserCookTimeSelectionBehaviorNavigation")]
    public virtual ICollection<CycleOptionsPrmTime> CycleOptionsPrmTimes { get; set; } = new List<CycleOptionsPrmTime>();
}
