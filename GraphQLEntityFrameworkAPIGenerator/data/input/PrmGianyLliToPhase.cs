using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmGIAnyLliToPhase")]
public partial class PrmGianyLliToPhase
{
    [Key]
    public Guid Id { get; set; }

    public byte Version { get; set; }

    public byte Trigger { get; set; }

    [Column("IIRWeight")]
    public short Iirweight { get; set; }
}
