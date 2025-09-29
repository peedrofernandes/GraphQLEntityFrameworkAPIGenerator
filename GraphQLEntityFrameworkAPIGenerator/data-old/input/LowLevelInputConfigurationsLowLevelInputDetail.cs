using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("LowLevelInputConfigurationId", "LowLevelInputDetailId", "Index")]
[Table("LowLevelInputConfigurations_LowLevelInputDetails")]
public partial class LowLevelInputConfigurationsLowLevelInputDetail
{
    [Key]
    public Guid LowLevelInputConfigurationId { get; set; }

    [Key]
    public Guid LowLevelInputDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("LowLevelInputConfigurationId")]
    [InverseProperty("LowLevelInputConfigurationsLowLevelInputDetails")]
    public virtual LowLevelInputConfiguration LowLevelInputConfiguration { get; set; } = null!;

    [ForeignKey("LowLevelInputDetailId")]
    [InverseProperty("LowLevelInputConfigurationsLowLevelInputDetails")]
    public virtual LowLevelInputDetail LowLevelInputDetail { get; set; } = null!;
}
