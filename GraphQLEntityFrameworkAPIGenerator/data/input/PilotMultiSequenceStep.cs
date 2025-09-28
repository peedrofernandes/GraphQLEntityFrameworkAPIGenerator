using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PilotMultiSequenceStep")]
public partial class PilotMultiSequenceStep
{
    [Key]
    public Guid Id { get; set; }

    public short StepDuration { get; set; }

    [Column("PilotStatesID0")]
    public byte PilotStatesId0 { get; set; }

    [Column("PilotStatesID1")]
    public byte? PilotStatesId1 { get; set; }

    [Column("PilotStatesID2")]
    public byte? PilotStatesId2 { get; set; }

    [Column("PilotStatesID3")]
    public byte? PilotStatesId3 { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<PilotMultiSequenceDetailsStep> PilotMultiSequenceDetailsSteps { get; set; } = new List<PilotMultiSequenceDetailsStep>();
}
