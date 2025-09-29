using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class CycleOptionsPrmMwoPowerLevel
{
    [Key]
    public Guid MwoPowerLevelsOptionsId { get; set; }

    public byte PowerLevelTypeSelection { get; set; }

    public int PowerLevelDefault { get; set; }

    public int Min { get; set; }

    public int Max { get; set; }

    public int Step { get; set; }

    [MaxLength(50)]
    public byte[] List { get; set; } = null!;

    public short NumberOfLevels { get; set; }
}
