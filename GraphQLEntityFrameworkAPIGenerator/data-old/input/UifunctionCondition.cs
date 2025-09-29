using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIFunctionConditions")]
public partial class UifunctionCondition
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
    [InverseProperty("UifunctionConditionConditionBlock1s")]
    public virtual UiconditionBlock? ConditionBlock1 { get; set; }

    [ForeignKey("ConditionBlock2Id")]
    [InverseProperty("UifunctionConditionConditionBlock2s")]
    public virtual UiconditionBlock? ConditionBlock2 { get; set; }

    [ForeignKey("ConditionBlock3Id")]
    [InverseProperty("UifunctionConditionConditionBlock3s")]
    public virtual UiconditionBlock? ConditionBlock3 { get; set; }

    [ForeignKey("ConditionBlock4Id")]
    [InverseProperty("UifunctionConditionConditionBlock4s")]
    public virtual UiconditionBlock? ConditionBlock4 { get; set; }

    [ForeignKey("ConditionBlock5Id")]
    [InverseProperty("UifunctionConditionConditionBlock5s")]
    public virtual UiconditionBlock? ConditionBlock5 { get; set; }

    [ForeignKey("ConditionBlock6Id")]
    [InverseProperty("UifunctionConditionConditionBlock6s")]
    public virtual UiconditionBlock? ConditionBlock6 { get; set; }

    [ForeignKey("ConditionBlock7Id")]
    [InverseProperty("UifunctionConditionConditionBlock7s")]
    public virtual UiconditionBlock? ConditionBlock7 { get; set; }

    [ForeignKey("ConditionBlock8Id")]
    [InverseProperty("UifunctionConditionConditionBlock8s")]
    public virtual UiconditionBlock? ConditionBlock8 { get; set; }

    [InverseProperty("SelectorCondition")]
    public virtual ICollection<SelectorsCycle> SelectorsCycles { get; set; } = new List<SelectorsCycle>();

    [InverseProperty("Condition")]
    public virtual ICollection<UistmSetIncompatibility> UistmSetIncompatibilities { get; set; } = new List<UistmSetIncompatibility>();

    [InverseProperty("Condition")]
    public virtual ICollection<UistmSetVariable> UistmSetVariables { get; set; } = new List<UistmSetVariable>();

    [InverseProperty("Condition")]
    public virtual ICollection<UistmVisualJumpIf> UistmVisualJumpIfs { get; set; } = new List<UistmVisualJumpIf>();
}
