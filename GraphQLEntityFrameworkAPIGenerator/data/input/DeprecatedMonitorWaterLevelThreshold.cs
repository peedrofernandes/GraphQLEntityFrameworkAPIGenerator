using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("DeprecatedMonitorWaterLevelThreshold")]
public partial class DeprecatedMonitorWaterLevelThreshold
{
    [Key]
    public Guid MonitorWaterLevelThresholdId { get; set; }

    [InverseProperty("MonitorWaterLevelThreshold")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
