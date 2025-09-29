using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("StmMaintain")]
public partial class StmMaintain
{
    [Key]
    public Guid Id { get; set; }

    public int Time { get; set; }

    public Guid? ModifiersId { get; set; }

    public bool IsAdd { get; set; }

    public Guid? ConditionId { get; set; }

    [ForeignKey("ConditionId")]
    [InverseProperty("StmMaintains")]
    public virtual Condition? Condition { get; set; }

    [ForeignKey("ModifiersId")]
    [InverseProperty("StmMaintains")]
    public virtual Modifier? Modifiers { get; set; }
}
