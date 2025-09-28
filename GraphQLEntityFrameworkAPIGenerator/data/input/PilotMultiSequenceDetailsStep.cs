using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("DetailsId", "Id", "Index")]
[Table("PilotMultiSequenceDetails_Step")]
public partial class PilotMultiSequenceDetailsStep
{
    [Key]
    public Guid DetailsId { get; set; }

    [Key]
    public Guid Id { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("DetailsId")]
    [InverseProperty("PilotMultiSequenceDetailsSteps")]
    public virtual PilotMultiSequenceDetail Details { get; set; } = null!;

    [ForeignKey("Id")]
    [InverseProperty("PilotMultiSequenceDetailsSteps")]
    public virtual PilotMultiSequenceStep IdNavigation { get; set; } = null!;
}
