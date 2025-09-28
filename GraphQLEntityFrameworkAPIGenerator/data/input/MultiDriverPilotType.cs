using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class MultiDriverPilotType
{
    [Key]
    public byte PilotTypeId { get; set; }

    [ForeignKey("PilotTypeId")]
    [InverseProperty("MultiDriverPilotType")]
    public virtual PilotType PilotType { get; set; } = null!;
}
