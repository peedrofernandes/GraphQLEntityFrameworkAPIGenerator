using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmGIAnyLliToConvert")]
public partial class PrmGianyLliToConvert
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    [Column("N_Points")]
    public byte NPoints { get; set; }

    public byte InputDataType { get; set; }

    public byte OutputDataType { get; set; }

    [MaxLength(2040)]
    public byte[] InputValues { get; set; } = null!;

    [MaxLength(2040)]
    public byte[] OutputValues { get; set; } = null!;

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    [MaxLength(384)]
    public byte[] InputExtendValues { get; set; } = null!;

    [MaxLength(384)]
    public byte[] OutputExtendValues { get; set; } = null!;

    public byte SearchMethod { get; set; }
}
