using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("CycleOptionsPrmStepsConfigId", "CycleOptionsStepDetailsId", "Index")]
[Table("CycleOptionsPrmStepsConfigurations_CycleOptionsStepDetails")]
public partial class CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetail
{
    [Key]
    public Guid CycleOptionsPrmStepsConfigId { get; set; }

    [Key]
    public Guid CycleOptionsStepDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("CycleOptionsPrmStepsConfigId")]
    [InverseProperty("CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails")]
    public virtual CycleOptionsPrmStepsConfiguration CycleOptionsPrmStepsConfig { get; set; } = null!;

    [ForeignKey("CycleOptionsStepDetailsId")]
    [InverseProperty("CycleOptionsPrmStepsConfigurationsCycleOptionsStepDetails")]
    public virtual CycleOptionsStepDetail CycleOptionsStepDetails { get; set; } = null!;
}
