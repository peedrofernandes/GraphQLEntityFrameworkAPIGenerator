using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("SelectorId", "CycleId", "Index")]
[Table("Selectors_Cycles")]
public partial class SelectorsCycle
{
    [Key]
    public Guid SelectorId { get; set; }

    [Key]
    public Guid CycleId { get; set; }

    [Key]
    public byte Index { get; set; }

    public Guid? SelectorConditionId { get; set; }

    public byte? EnteringCycle { get; set; }

    public Guid? ConditionId { get; set; }

    public byte Priority { get; set; }

    public byte CycleTypeId { get; set; }

    [ForeignKey("ConditionId")]
    [InverseProperty("SelectorsCycles")]
    public virtual Condition? Condition { get; set; }

    [ForeignKey("CycleId")]
    [InverseProperty("SelectorsCycles")]
    public virtual Cycle Cycle { get; set; } = null!;

    [ForeignKey("SelectorId")]
    [InverseProperty("SelectorsCycles")]
    public virtual Selector Selector { get; set; } = null!;

    [ForeignKey("SelectorConditionId")]
    [InverseProperty("SelectorsCycles")]
    public virtual UifunctionCondition? SelectorCondition { get; set; }
}
