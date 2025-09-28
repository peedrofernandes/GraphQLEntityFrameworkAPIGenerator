using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class HmiAvailableNode
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    [InverseProperty("NodeAddressNavigation")]
    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();
}
