using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotReleZC")]
public partial class PrmPilotReleZc
{
    [Key]
    public Guid Id { get; set; }

    public byte Start { get; set; }

    public byte Stop { get; set; }
}
