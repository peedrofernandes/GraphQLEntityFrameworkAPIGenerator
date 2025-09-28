using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class PilotType
{
    [Key]
    public byte PilotTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PilotTypeDsc { get; set; } = null!;

    public byte NumPins { get; set; }

    public bool NeedParams { get; set; }

    public bool NeedFeedbacks { get; set; }

    public bool IsSafetyRelevant { get; set; }

    [InverseProperty("PilotType")]
    public virtual ICollection<LoadDetail> LoadDetails { get; set; } = new List<LoadDetail>();

    [InverseProperty("PilotType")]
    public virtual MultiDriverPilotType? MultiDriverPilotType { get; set; }

    [InverseProperty("PilotType")]
    public virtual MultiSequencePilotType? MultiSequencePilotType { get; set; }

    [InverseProperty("PilotTypeId0Navigation")]
    public virtual ICollection<PrmPilotMultiDriver> PrmPilotMultiDriverPilotTypeId0Navigations { get; set; } = new List<PrmPilotMultiDriver>();

    [InverseProperty("PilotTypeId1Navigation")]
    public virtual ICollection<PrmPilotMultiDriver> PrmPilotMultiDriverPilotTypeId1Navigations { get; set; } = new List<PrmPilotMultiDriver>();

    [InverseProperty("PilotTypeId2Navigation")]
    public virtual ICollection<PrmPilotMultiDriver> PrmPilotMultiDriverPilotTypeId2Navigations { get; set; } = new List<PrmPilotMultiDriver>();

    [InverseProperty("PilotTypeId3Navigation")]
    public virtual ICollection<PrmPilotMultiDriver> PrmPilotMultiDriverPilotTypeId3Navigations { get; set; } = new List<PrmPilotMultiDriver>();

    [ForeignKey("PilotTypeId")]
    [InverseProperty("PilotTypes")]
    public virtual ICollection<LoadType> LoadTypes { get; set; } = new List<LoadType>();
}
