using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("TimeEstimationConfigurationId", "TimeEstimationDetailId", "Index")]
[Table("TimeEstimationConfigurations_TimeEstimationDetails")]
public partial class TimeEstimationConfigurationsTimeEstimationDetail
{
    [Key]
    public Guid TimeEstimationConfigurationId { get; set; }

    [Key]
    public Guid TimeEstimationDetailId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("TimeEstimationConfigurationId")]
    [InverseProperty("TimeEstimationConfigurationsTimeEstimationDetails")]
    public virtual TimeEstimationConfiguration TimeEstimationConfiguration { get; set; } = null!;

    [ForeignKey("TimeEstimationDetailId")]
    [InverseProperty("TimeEstimationConfigurationsTimeEstimationDetails")]
    public virtual TimeEstimationDetail TimeEstimationDetail { get; set; } = null!;
}
