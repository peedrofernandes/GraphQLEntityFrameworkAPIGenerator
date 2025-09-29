using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Fault
{
    [Key]
    public byte FaultId { get; set; }

    [Unicode(false)]
    public string FaultName { get; set; } = null!;

    public bool NeedSpecificParams { get; set; }
}
