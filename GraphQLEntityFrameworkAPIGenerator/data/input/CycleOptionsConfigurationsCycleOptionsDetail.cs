using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("CycleOptionsConfigurationsId", "CycleOptionsDetailsId", "Index")]
[Table("CycleOptionsConfigurations_CycleOptionsDetails")]
public partial class CycleOptionsConfigurationsCycleOptionsDetail
{
    [Key]
    public Guid CycleOptionsConfigurationsId { get; set; }

    [Key]
    public Guid CycleOptionsDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("CycleOptionsConfigurationsId")]
    [InverseProperty("CycleOptionsConfigurationsCycleOptionsDetails")]
    public virtual CycleOptionsConfiguration CycleOptionsConfigurations { get; set; } = null!;

    [ForeignKey("CycleOptionsDetailsId")]
    [InverseProperty("CycleOptionsConfigurationsCycleOptionsDetails")]
    public virtual CycleOptionsDetail CycleOptionsDetails { get; set; } = null!;
}
