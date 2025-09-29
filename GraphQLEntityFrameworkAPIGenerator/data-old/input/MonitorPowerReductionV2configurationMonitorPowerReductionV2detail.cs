using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[PrimaryKey("MonitorPowerReductionV2configurationId", "MonitorPowerReductionV2detailsId", "Index")]
[Table("MonitorPowerReductionV2Configuration_MonitorPowerReductionV2Details")]
public partial class MonitorPowerReductionV2configurationMonitorPowerReductionV2detail
{
    [Key]
    [Column("MonitorPowerReductionV2ConfigurationId")]
    public Guid MonitorPowerReductionV2configurationId { get; set; }

    [Key]
    [Column("MonitorPowerReductionV2DetailsId")]
    public Guid MonitorPowerReductionV2detailsId { get; set; }

    [Key]
    public byte Index { get; set; }

    [ForeignKey("MonitorPowerReductionV2configurationId")]
    [InverseProperty("MonitorPowerReductionV2configurationMonitorPowerReductionV2details")]
    public virtual MonitorPowerReductionV2configuration MonitorPowerReductionV2configuration { get; set; } = null!;

    [ForeignKey("MonitorPowerReductionV2detailsId")]
    [InverseProperty("MonitorPowerReductionV2configurationMonitorPowerReductionV2details")]
    public virtual MonitorPowerReductionV2detail MonitorPowerReductionV2details { get; set; } = null!;
}
