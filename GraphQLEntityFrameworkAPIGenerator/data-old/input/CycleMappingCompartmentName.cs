using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleMappingCompartmentName
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    public string CompartmentKeyName { get; set; } = null!;

    [StringLength(50)]
    public string CompartmentDisplayName { get; set; } = null!;

    public byte Compartment { get; set; }
}
