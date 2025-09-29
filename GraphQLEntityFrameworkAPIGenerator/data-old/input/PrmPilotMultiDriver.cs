using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmPilotMultiDriver")]
public partial class PrmPilotMultiDriver
{
    [Key]
    public Guid Id { get; set; }

    public byte PilotTypeId0 { get; set; }

    public Guid? PilotParametersId0 { get; set; }

    public byte PilotTypeId1 { get; set; }

    public Guid? PilotParametersId1 { get; set; }

    public byte? PilotTypeId2 { get; set; }

    public Guid? PilotParametersId2 { get; set; }

    public byte? PilotTypeId3 { get; set; }

    public Guid? PilotParametersId3 { get; set; }

    public byte NumOfPins { get; set; }

    [ForeignKey("PilotTypeId0")]
    [InverseProperty("PrmPilotMultiDriverPilotTypeId0Navigations")]
    public virtual PilotType PilotTypeId0Navigation { get; set; } = null!;

    [ForeignKey("PilotTypeId1")]
    [InverseProperty("PrmPilotMultiDriverPilotTypeId1Navigations")]
    public virtual PilotType PilotTypeId1Navigation { get; set; } = null!;

    [ForeignKey("PilotTypeId2")]
    [InverseProperty("PrmPilotMultiDriverPilotTypeId2Navigations")]
    public virtual PilotType? PilotTypeId2Navigation { get; set; }

    [ForeignKey("PilotTypeId3")]
    [InverseProperty("PrmPilotMultiDriverPilotTypeId3Navigations")]
    public virtual PilotType? PilotTypeId3Navigation { get; set; }
}
