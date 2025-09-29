using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotMultiSequence")]
public partial class PrmPilotMultiSequence
{
    [Key]
    public Guid Id { get; set; }

    public byte PilotTypeId0 { get; set; }

    public Guid? PilotParametersId0 { get; set; }

    public byte? PilotTypeId1 { get; set; }

    public Guid? PilotParametersId1 { get; set; }

    public byte? PilotTypeId2 { get; set; }

    public Guid? PilotParametersId2 { get; set; }

    public byte? PilotTypeId3 { get; set; }

    public Guid? PilotParametersId3 { get; set; }

    public Guid? SequencesConfiguration { get; set; }

    public byte NumOfPins { get; set; }

    [ForeignKey("PilotTypeId0")]
    [InverseProperty("PrmPilotMultiSequencePilotTypeId0Navigations")]
    public virtual MultiSequencePilotType PilotTypeId0Navigation { get; set; } = null!;

    [ForeignKey("PilotTypeId1")]
    [InverseProperty("PrmPilotMultiSequencePilotTypeId1Navigations")]
    public virtual MultiSequencePilotType? PilotTypeId1Navigation { get; set; }

    [ForeignKey("PilotTypeId2")]
    [InverseProperty("PrmPilotMultiSequencePilotTypeId2Navigations")]
    public virtual MultiSequencePilotType? PilotTypeId2Navigation { get; set; }

    [ForeignKey("PilotTypeId3")]
    [InverseProperty("PrmPilotMultiSequencePilotTypeId3Navigations")]
    public virtual MultiSequencePilotType? PilotTypeId3Navigation { get; set; }

    [ForeignKey("SequencesConfiguration")]
    [InverseProperty("PrmPilotMultiSequences")]
    public virtual PilotMultiSequenceConfig? SequencesConfigurationNavigation { get; set; }
}
