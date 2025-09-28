using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class RefreshRate
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    [InverseProperty("RefreshRateNavigation")]
    public virtual ICollection<PrmReadI2cinfrared> PrmReadI2cinfrareds { get; set; } = new List<PrmReadI2cinfrared>();
}
