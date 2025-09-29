using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadSRDigitalMatrix")]
public partial class PrmReadSrdigitalMatrix
{
    [Key]
    public Guid Id { get; set; }

    public bool Inverted { get; set; }

    public bool PullUp { get; set; }

    public byte StrobePin { get; set; }
}
