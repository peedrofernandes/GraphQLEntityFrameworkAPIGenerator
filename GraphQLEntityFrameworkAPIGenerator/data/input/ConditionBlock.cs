using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class ConditionBlock
{
    [Key]
    public Guid ConditionBlockId { get; set; }

    public byte BoolOperator { get; set; }

    public int FirstVariableId { get; set; }

    public byte OperatorId { get; set; }

    public int? SecondVariableId { get; set; }

    public double? Operand { get; set; }

    public short Mask { get; set; }

    public byte FirstOffset { get; set; }

    public byte? SecondOffset { get; set; }

    public bool IsNot { get; set; }

    public byte FirstVariableGroupId { get; set; }

    public byte? SecondVariableGroupId { get; set; }

    public byte ProductTypeId { get; set; }

    [InverseProperty("ConditionBlock1")]
    public virtual ICollection<Condition> ConditionConditionBlock1s { get; set; } = new List<Condition>();

    [InverseProperty("ConditionBlock2")]
    public virtual ICollection<Condition> ConditionConditionBlock2s { get; set; } = new List<Condition>();

    [InverseProperty("ConditionBlock3")]
    public virtual ICollection<Condition> ConditionConditionBlock3s { get; set; } = new List<Condition>();

    [InverseProperty("ConditionBlock4")]
    public virtual ICollection<Condition> ConditionConditionBlock4s { get; set; } = new List<Condition>();

    [InverseProperty("ConditionBlock5")]
    public virtual ICollection<Condition> ConditionConditionBlock5s { get; set; } = new List<Condition>();

    [InverseProperty("ConditionBlock6")]
    public virtual ICollection<Condition> ConditionConditionBlock6s { get; set; } = new List<Condition>();

    [InverseProperty("ConditionBlock7")]
    public virtual ICollection<Condition> ConditionConditionBlock7s { get; set; } = new List<Condition>();

    [InverseProperty("ConditionBlock8")]
    public virtual ICollection<Condition> ConditionConditionBlock8s { get; set; } = new List<Condition>();
}
