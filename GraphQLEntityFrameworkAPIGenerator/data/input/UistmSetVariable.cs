using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIStmSetVariable")]
public partial class UistmSetVariable
{
    [Key]
    public Guid Id { get; set; }

    public int VariableIndex { get; set; }

    public double Value { get; set; }

    public Guid? ConditionId { get; set; }

    public byte VariableOffset { get; set; }

    public byte VariableGroup { get; set; }

    public byte ProductType { get; set; }

    [ForeignKey("ConditionId")]
    [InverseProperty("UistmSetVariables")]
    public virtual UifunctionCondition? Condition { get; set; }
}
