using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("MicrowavePowerTableConfigId", "MicrowavePowerTableDetailsId", "Index")]
[Table("MicrowavePowerTableConfigurations_MicrowavePowerTableDetails")]
public partial class MicrowavePowerTableConfigurationsMicrowavePowerTableDetail
{
    [Key]
    public Guid MicrowavePowerTableConfigId { get; set; }

    [Key]
    public Guid MicrowavePowerTableDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("MicrowavePowerTableConfigId")]
    [InverseProperty("MicrowavePowerTableConfigurationsMicrowavePowerTableDetails")]
    public virtual MicrowavePowerTableConfiguration MicrowavePowerTableConfig { get; set; } = null!;

    [ForeignKey("MicrowavePowerTableDetailsId")]
    [InverseProperty("MicrowavePowerTableConfigurationsMicrowavePowerTableDetails")]
    public virtual MicrowavePowerTableDetail MicrowavePowerTableDetails { get; set; } = null!;
}
