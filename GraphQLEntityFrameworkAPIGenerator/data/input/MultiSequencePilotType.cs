using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class MultiSequencePilotType
{
    [Key]
    public byte PilotTypeId { get; set; }

    [ForeignKey("PilotTypeId")]
    [InverseProperty("MultiSequencePilotType")]
    public virtual PilotType PilotType { get; set; } = null!;

    [InverseProperty("PilotTypeId0Navigation")]
    public virtual ICollection<PrmPilotMultiSequence> PrmPilotMultiSequencePilotTypeId0Navigations { get; set; } = new List<PrmPilotMultiSequence>();

    [InverseProperty("PilotTypeId1Navigation")]
    public virtual ICollection<PrmPilotMultiSequence> PrmPilotMultiSequencePilotTypeId1Navigations { get; set; } = new List<PrmPilotMultiSequence>();

    [InverseProperty("PilotTypeId2Navigation")]
    public virtual ICollection<PrmPilotMultiSequence> PrmPilotMultiSequencePilotTypeId2Navigations { get; set; } = new List<PrmPilotMultiSequence>();

    [InverseProperty("PilotTypeId3Navigation")]
    public virtual ICollection<PrmPilotMultiSequence> PrmPilotMultiSequencePilotTypeId3Navigations { get; set; } = new List<PrmPilotMultiSequence>();
}
