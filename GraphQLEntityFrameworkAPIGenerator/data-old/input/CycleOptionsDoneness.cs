using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsDoneness")]
public partial class CycleOptionsDoneness
{
    [Key]
    public Guid DonenessOptionsId { get; set; }

    public short DefaultSelection { get; set; }

    public bool Well { get; set; }

    public bool MediumWell { get; set; }

    public bool Medium { get; set; }

    public bool MediumRare { get; set; }

    public bool Rare { get; set; }
}
