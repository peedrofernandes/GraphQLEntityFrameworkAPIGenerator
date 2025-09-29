using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmReadSRTouchKey")]
public partial class PrmReadSrtouchKey
{
    [Key]
    public Guid Id { get; set; }

    [Column("SRTouchControllerIndex")]
    public byte SrtouchControllerIndex { get; set; }

    [Column("SRTouchKeyIndex")]
    public byte SrtouchKeyIndex { get; set; }
}
