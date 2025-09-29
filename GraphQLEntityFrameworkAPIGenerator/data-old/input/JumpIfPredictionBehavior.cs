using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class JumpIfPredictionBehavior
{
    [Key]
    public byte JumpIfPredictionBehaviorId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string JumpIfPredictionBehaviorDescription { get; set; } = null!;

    [InverseProperty("JumpIfPredictionBehavior")]
    public virtual ICollection<StmJumpIf> StmJumpIfs { get; set; } = new List<StmJumpIf>();
}
