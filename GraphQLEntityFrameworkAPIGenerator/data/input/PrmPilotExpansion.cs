using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotExpansion")]
public partial class PrmPilotExpansion
{
    [Key]
    public Guid Id { get; set; }

    public byte Position { get; set; }
}
