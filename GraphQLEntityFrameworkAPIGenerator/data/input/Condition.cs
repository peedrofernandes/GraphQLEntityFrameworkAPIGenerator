using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class Condition
{
    [Key]
    public Guid ConditionId { get; set; }

    public byte NumConditions { get; set; }

    public Guid? ConditionBlock1Id { get; set; }

    public Guid? ConditionBlock2Id { get; set; }

    public Guid? ConditionBlock3Id { get; set; }

    public Guid? ConditionBlock4Id { get; set; }

    public Guid? ConditionBlock5Id { get; set; }

    public Guid? ConditionBlock6Id { get; set; }

    public Guid? ConditionBlock7Id { get; set; }

    public Guid? ConditionBlock8Id { get; set; }

    [ForeignKey("ConditionBlock1Id")]
    [InverseProperty("ConditionConditionBlock1s")]
    public virtual ConditionBlock? ConditionBlock1 { get; set; }

    [ForeignKey("ConditionBlock2Id")]
    [InverseProperty("ConditionConditionBlock2s")]
    public virtual ConditionBlock? ConditionBlock2 { get; set; }

    [ForeignKey("ConditionBlock3Id")]
    [InverseProperty("ConditionConditionBlock3s")]
    public virtual ConditionBlock? ConditionBlock3 { get; set; }

    [ForeignKey("ConditionBlock4Id")]
    [InverseProperty("ConditionConditionBlock4s")]
    public virtual ConditionBlock? ConditionBlock4 { get; set; }

    [ForeignKey("ConditionBlock5Id")]
    [InverseProperty("ConditionConditionBlock5s")]
    public virtual ConditionBlock? ConditionBlock5 { get; set; }

    [ForeignKey("ConditionBlock6Id")]
    [InverseProperty("ConditionConditionBlock6s")]
    public virtual ConditionBlock? ConditionBlock6 { get; set; }

    [ForeignKey("ConditionBlock7Id")]
    [InverseProperty("ConditionConditionBlock7s")]
    public virtual ConditionBlock? ConditionBlock7 { get; set; }

    [ForeignKey("ConditionBlock8Id")]
    [InverseProperty("ConditionConditionBlock8s")]
    public virtual ConditionBlock? ConditionBlock8 { get; set; }

    [InverseProperty("Condition")]
    public virtual ICollection<SelectorsCycle> SelectorsCycles { get; set; } = new List<SelectorsCycle>();

    [InverseProperty("Condition")]
    public virtual ICollection<StmJumpIf> StmJumpIfs { get; set; } = new List<StmJumpIf>();

    [InverseProperty("Condition")]
    public virtual ICollection<StmLoadsControl> StmLoadsControlConditions { get; set; } = new List<StmLoadsControl>();

    [InverseProperty("DeactivationCondition")]
    public virtual ICollection<StmLoadsControl> StmLoadsControlDeactivationConditions { get; set; } = new List<StmLoadsControl>();

    [InverseProperty("Condition")]
    public virtual ICollection<StmMaintain> StmMaintains { get; set; } = new List<StmMaintain>();
}
