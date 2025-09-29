using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("MonitorCoilDeratingConfigurationId", "MonitorCoilDeratingDetailsId", "Index")]
[Table("MonitorCoilDeratingConfigurations_MonitorCoilDeratingDetails")]
public partial class MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail
{
    [Key]
    public Guid MonitorCoilDeratingConfigurationId { get; set; }

    [Key]
    public Guid MonitorCoilDeratingDetailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [Column("ACUExpansionBoardId")]
    public byte AcuexpansionBoardId { get; set; }

    [ForeignKey("MonitorCoilDeratingConfigurationId")]
    [InverseProperty("MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails")]
    public virtual MonitorCoilDeratingConfiguration MonitorCoilDeratingConfiguration { get; set; } = null!;

    [ForeignKey("MonitorCoilDeratingDetailsId")]
    [InverseProperty("MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails")]
    public virtual MonitorCoilDeratingDetail MonitorCoilDeratingDetails { get; set; } = null!;
}
