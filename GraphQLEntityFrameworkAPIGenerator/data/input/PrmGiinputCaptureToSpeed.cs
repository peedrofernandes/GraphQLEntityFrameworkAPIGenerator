using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmGIInputCaptureToSpeed")]
public partial class PrmGiinputCaptureToSpeed
{
    [Key]
    public Guid Id { get; set; }

    public byte Version { get; set; }

    public byte InvertedAlphaExponent { get; set; }

    public byte NumberOfPoles { get; set; }
}
