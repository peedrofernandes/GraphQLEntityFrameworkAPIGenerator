using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class ModifierSearchMethod
{
    [Key]
    public byte ModifierSearchMethodId { get; set; }

    [StringLength(50)]
    public string ModifierSearchMethodDescription { get; set; } = null!;

    [InverseProperty("ModifierSearchMethod")]
    public virtual ICollection<ModifiersDetail> ModifiersDetails { get; set; } = new List<ModifiersDetail>();
}
