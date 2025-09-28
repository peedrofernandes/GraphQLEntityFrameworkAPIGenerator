using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("UisequenceId", "UistepId", "Index")]
[Table("UISequences_UISteps")]
public partial class UisequencesUistep
{
    [Key]
    [Column("UISequenceId")]
    public Guid UisequenceId { get; set; }

    [Key]
    [Column("UIStepId")]
    public Guid UistepId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("UisequenceId")]
    [InverseProperty("UisequencesUisteps")]
    public virtual Uisequence Uisequence { get; set; } = null!;

    [ForeignKey("UistepId")]
    [InverseProperty("UisequencesUisteps")]
    public virtual Uistep Uistep { get; set; } = null!;
}
