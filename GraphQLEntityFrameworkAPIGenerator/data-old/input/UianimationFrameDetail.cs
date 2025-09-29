using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("UIAnimationFrameDetails")]
public partial class UianimationFrameDetail
{
    [Key]
    [Column("UIAnimationFrameDetailsId")]
    public Guid UianimationFrameDetailsId { get; set; }

    public long Pattern { get; set; }

    public short TimeOn { get; set; }

    public byte FrameIntensity { get; set; }

    [InverseProperty("UianimationFrameDetails")]
    public virtual ICollection<UianimationFrameConfigurationsUianimationFrameDetail> UianimationFrameConfigurationsUianimationFrameDetails { get; set; } = new List<UianimationFrameConfigurationsUianimationFrameDetail>();
}
