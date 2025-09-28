using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UistepId", "UiconditionId", "Index")]
[Table("UISteps_UIConditions")]
public partial class UistepsUicondition
{
    [Key]
    [Column("UIStepId")]
    public Guid UistepId { get; set; }

    [Key]
    [Column("UIConditionId")]
    public Guid UiconditionId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UiconditionId")]
    [InverseProperty("UistepsUiconditions")]
    public virtual Uicondition Uicondition { get; set; } = null!;

    [ForeignKey("UistepId")]
    [InverseProperty("UistepsUiconditions")]
    public virtual Uistep Uistep { get; set; } = null!;
}
