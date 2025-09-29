using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class ReadType
{
    [Key]
    public byte ReadTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ReadTypeDsc { get; set; } = null!;

    public byte ReadTypeMax { get; set; }

    public byte NumPins { get; set; }

    public bool NeedParams { get; set; }

    public bool Automatic { get; set; }

    public bool NumReadings { get; set; }

    public bool Multiplexed { get; set; }

    public bool Inverted { get; set; }

    public bool Partialized { get; set; }

    [Column("ACLine")]
    public bool Acline { get; set; }

    [Column("VReference")]
    public bool Vreference { get; set; }

    public bool Compensated { get; set; }

    public bool Delta { get; set; }

    public bool Rotation { get; set; }

    public bool PullUp { get; set; }

    public bool Feedback { get; set; }

    public bool SecondFeedback { get; set; }

    public bool ChannelDischarge { get; set; }

    public bool IsSafetyRelevant { get; set; }

    [InverseProperty("ReadType")]
    public virtual ICollection<GenericInputDetail> GenericInputDetails { get; set; } = new List<GenericInputDetail>();

    [InverseProperty("ReadType")]
    public virtual ICollection<InputTypesReadType> InputTypesReadTypes { get; set; } = new List<InputTypesReadType>();

    [InverseProperty("ReadType")]
    public virtual ICollection<LowLevelInputDetail> LowLevelInputDetails { get; set; } = new List<LowLevelInputDetail>();

    [InverseProperty("ReadType")]
    public virtual MultiInputReadType? MultiInputReadType { get; set; }

    [InverseProperty("ReadTypeId0Navigation")]
    public virtual ICollection<PrmReadMultiInput> PrmReadMultiInputReadTypeId0Navigations { get; set; } = new List<PrmReadMultiInput>();

    [InverseProperty("ReadTypeId1Navigation")]
    public virtual ICollection<PrmReadMultiInput> PrmReadMultiInputReadTypeId1Navigations { get; set; } = new List<PrmReadMultiInput>();

    [InverseProperty("ReadTypeId2Navigation")]
    public virtual ICollection<PrmReadMultiInput> PrmReadMultiInputReadTypeId2Navigations { get; set; } = new List<PrmReadMultiInput>();

    [InverseProperty("ReadTypeId3Navigation")]
    public virtual ICollection<PrmReadMultiInput> PrmReadMultiInputReadTypeId3Navigations { get; set; } = new List<PrmReadMultiInput>();

    [InverseProperty("LlireadType")]
    public virtual ICollection<UigenericInputDetail> UigenericInputDetails { get; set; } = new List<UigenericInputDetail>();

    [InverseProperty("LlireadType")]
    public virtual ICollection<Uiinput> Uiinputs { get; set; } = new List<Uiinput>();

    [ForeignKey("ReadTypeId")]
    [InverseProperty("ReadTypes")]
    public virtual ICollection<Uiinput> UiinputsNavigation { get; set; } = new List<Uiinput>();
}
