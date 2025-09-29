using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotStepByStep")]
public partial class PrmPilotStepByStep
{
    [Key]
    public Guid Id { get; set; }

    public short NumSteps { get; set; }

    public short NumSpeeds { get; set; }

    public byte AdjSteps { get; set; }

    public bool P { get; set; }

    public bool I { get; set; }

    public byte NumSeq { get; set; }

    [MaxLength(32)]
    public byte[] Steps { get; set; } = null!;

    public int Seqs { get; set; }

    public short NumPositions { get; set; }
}
