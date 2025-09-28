using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsBrowning")]
public partial class CycleOptionsBrowning
{
    [Key]
    public Guid BrowningOptionsId { get; set; }

    public byte DefaultSelection { get; set; }

    public bool High { get; set; }

    public bool Medium { get; set; }

    public bool Low { get; set; }
}
