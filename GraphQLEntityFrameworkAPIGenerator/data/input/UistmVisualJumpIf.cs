using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIStmVisualJumpIf")]
public partial class UistmVisualJumpIf
{
    [Key]
    public Guid Id { get; set; }

    public byte Step { get; set; }

    public Guid? ConditionId { get; set; }

    [ForeignKey("ConditionId")]
    [InverseProperty("UistmVisualJumpIfs")]
    public virtual UifunctionCondition? Condition { get; set; }
}
