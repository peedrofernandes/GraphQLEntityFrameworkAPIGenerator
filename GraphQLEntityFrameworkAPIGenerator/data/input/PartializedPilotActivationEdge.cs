using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PartializedPilotActivationEdge")]
public partial class PartializedPilotActivationEdge
{
    [Key]
    public byte Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Label { get; set; } = null!;
}
