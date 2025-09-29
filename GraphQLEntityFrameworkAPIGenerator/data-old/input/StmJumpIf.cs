using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmJumpIf")]
public partial class StmJumpIf
{
    [Key]
    public Guid Id { get; set; }

    public byte? DestinationCycle { get; set; }

    [StringLength(50)]
    public string? DestinationCycleLabel { get; set; }

    public byte? DestinationPhase { get; set; }

    [StringLength(50)]
    public string? DestinationPhaseLabel { get; set; }

    public byte DestinationStep { get; set; }

    public Guid? ConditionId { get; set; }

    public bool WithReturn { get; set; }

    public byte JumpIfPredictionBehaviorId { get; set; }

    [StringLength(50)]
    public string? DestinationStepLabel { get; set; }

    [ForeignKey("ConditionId")]
    [InverseProperty("StmJumpIfs")]
    public virtual Condition? Condition { get; set; }

    [ForeignKey("JumpIfPredictionBehaviorId")]
    [InverseProperty("StmJumpIfs")]
    public virtual JumpIfPredictionBehavior JumpIfPredictionBehavior { get; set; } = null!;
}
