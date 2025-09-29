using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIAnimationDetails")]
public partial class UianimationDetail
{
    [Key]
    [Column("UIAnimationDetailsId")]
    public Guid UianimationDetailsId { get; set; }

    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public byte AnimationType { get; set; }

    public byte PatternExecutions { get; set; }

    [Column("CSF")]
    public bool Csf { get; set; }

    [Column("IAF")]
    public bool Iaf { get; set; }

    [Column("TSF")]
    public bool Tsf { get; set; }

    [Column("CEF")]
    public bool Cef { get; set; }

    [Column("DF")]
    public bool Df { get; set; }

    [Column("RF")]
    public bool Rf { get; set; }

    public short Period { get; set; }

    public short TimeBetweenRepeats { get; set; }

    [Column("UIAnimationFadingTypeId")]
    public Guid? UianimationFadingTypeId { get; set; }

    [Column("UIAnimationBlinkTypeId")]
    public Guid? UianimationBlinkTypeId { get; set; }

    [Column("UIAnimationSequenceTypeId")]
    public Guid? UianimationSequenceTypeId { get; set; }

    [Column("UIAnimationFrameTypeId")]
    public Guid? UianimationFrameTypeId { get; set; }

    public short AnimationFunction { get; set; }

    public byte Compartment { get; set; }

    public byte AnimationIndex { get; set; }

    [ForeignKey("UianimationBlinkTypeId")]
    [InverseProperty("UianimationDetails")]
    public virtual UianimationBlinkType? UianimationBlinkType { get; set; }

    [InverseProperty("UianimationDetails")]
    public virtual ICollection<UianimationConfigurationsUianimationDetail> UianimationConfigurationsUianimationDetails { get; set; } = new List<UianimationConfigurationsUianimationDetail>();

    [ForeignKey("UianimationFadingTypeId")]
    [InverseProperty("UianimationDetails")]
    public virtual UianimationFadingType? UianimationFadingType { get; set; }

    [ForeignKey("UianimationFrameTypeId")]
    [InverseProperty("UianimationDetails")]
    public virtual UianimationFrameConfiguration? UianimationFrameType { get; set; }

    [ForeignKey("UianimationSequenceTypeId")]
    [InverseProperty("UianimationDetails")]
    public virtual UianimationSequenceType? UianimationSequenceType { get; set; }
}
