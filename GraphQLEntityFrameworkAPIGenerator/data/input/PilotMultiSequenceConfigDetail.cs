using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("ConfigId", "DetailsId", "Index")]
[Table("PilotMultiSequenceConfig_Details")]
public partial class PilotMultiSequenceConfigDetail
{
    [Key]
    public Guid ConfigId { get; set; }

    [Key]
    public Guid DetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("ConfigId")]
    [InverseProperty("PilotMultiSequenceConfigDetails")]
    public virtual PilotMultiSequenceConfig Config { get; set; } = null!;

    [ForeignKey("DetailsId")]
    [InverseProperty("PilotMultiSequenceConfigDetails")]
    public virtual PilotMultiSequenceDetail Details { get; set; } = null!;
}
