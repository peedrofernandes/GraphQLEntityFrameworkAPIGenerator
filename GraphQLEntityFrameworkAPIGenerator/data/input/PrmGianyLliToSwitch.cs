using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmGIAnyLliToSwitch")]
public partial class PrmGianyLliToSwitch
{
    [Key]
    public Guid Id { get; set; }

    [Column("N_Values")]
    public byte NValues { get; set; }

    [MaxLength(12)]
    public byte[] SwitchInputValues { get; set; } = null!;

    [MaxLength(6)]
    public byte[] SwitchOutputValues { get; set; } = null!;

    public byte SearchMethod { get; set; }
}
