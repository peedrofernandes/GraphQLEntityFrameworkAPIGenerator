using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIAnimationFrameConfigurations")]
public partial class UianimationFrameConfiguration
{
    [Key]
    [Column("UIAnimationFrameConfigurationsId")]
    public Guid UianimationFrameConfigurationsId { get; set; }

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

    public byte NumOfFrames { get; set; }

    [InverseProperty("UianimationFrameType")]
    public virtual ICollection<UianimationDetail> UianimationDetails { get; set; } = new List<UianimationDetail>();

    [InverseProperty("UianimationFrameConfigurations")]
    public virtual ICollection<UianimationFrameConfigurationsUianimationFrameDetail> UianimationFrameConfigurationsUianimationFrameDetails { get; set; } = new List<UianimationFrameConfigurationsUianimationFrameDetail>();
}
