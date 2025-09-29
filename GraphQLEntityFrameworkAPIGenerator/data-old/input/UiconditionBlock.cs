using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIConditionBlocks")]
public partial class UiconditionBlock
{
    [Key]
    [Column("UIConditionBlockId")]
    public Guid UiconditionBlockId { get; set; }

    public byte ProductTypeId { get; set; }

    [Column("UIBoolOperatorId")]
    public byte UiboolOperatorId { get; set; }

    public int FirstVariableId { get; set; }

    [Column("UIOperatorId")]
    public byte UioperatorId { get; set; }

    public double? Operand { get; set; }

    public byte FirstOffset { get; set; }

    public byte VariableGroups { get; set; }

    public bool UseVisualValue { get; set; }

    [InverseProperty("ConditionBlock1")]
    public virtual ICollection<UifunctionCondition> UifunctionConditionConditionBlock1s { get; set; } = new List<UifunctionCondition>();

    [InverseProperty("ConditionBlock2")]
    public virtual ICollection<UifunctionCondition> UifunctionConditionConditionBlock2s { get; set; } = new List<UifunctionCondition>();

    [InverseProperty("ConditionBlock3")]
    public virtual ICollection<UifunctionCondition> UifunctionConditionConditionBlock3s { get; set; } = new List<UifunctionCondition>();

    [InverseProperty("ConditionBlock4")]
    public virtual ICollection<UifunctionCondition> UifunctionConditionConditionBlock4s { get; set; } = new List<UifunctionCondition>();

    [InverseProperty("ConditionBlock5")]
    public virtual ICollection<UifunctionCondition> UifunctionConditionConditionBlock5s { get; set; } = new List<UifunctionCondition>();

    [InverseProperty("ConditionBlock6")]
    public virtual ICollection<UifunctionCondition> UifunctionConditionConditionBlock6s { get; set; } = new List<UifunctionCondition>();

    [InverseProperty("ConditionBlock7")]
    public virtual ICollection<UifunctionCondition> UifunctionConditionConditionBlock7s { get; set; } = new List<UifunctionCondition>();

    [InverseProperty("ConditionBlock8")]
    public virtual ICollection<UifunctionCondition> UifunctionConditionConditionBlock8s { get; set; } = new List<UifunctionCondition>();

    [ForeignKey("UioperatorId")]
    [InverseProperty("UiconditionBlocks")]
    public virtual Uioperator Uioperator { get; set; } = null!;
}
