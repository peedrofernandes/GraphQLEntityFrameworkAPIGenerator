using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleTemperatureOptionsBehaviorLabel
{
    [Key]
    public byte Id { get; set; }

    [StringLength(100)]
    public string Behavior { get; set; } = null!;

    [InverseProperty("TemperatureSelectionBehaviorNavigation")]
    public virtual ICollection<CycleOptionsPrmTemperature> CycleOptionsPrmTemperatures { get; set; } = new List<CycleOptionsPrmTemperature>();
}
