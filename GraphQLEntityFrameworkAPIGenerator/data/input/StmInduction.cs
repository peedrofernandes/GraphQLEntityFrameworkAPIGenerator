using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmInduction")]
public partial class StmInduction
{
    [Key]
    public Guid Id { get; set; }

    public byte Version { get; set; }

    [Column("Level_")]
    public byte? Level { get; set; }

    public byte? Mode { get; set; }

    public short? Wattage { get; set; }
}
