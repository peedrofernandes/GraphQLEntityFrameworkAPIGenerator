using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorIRTemperature")]
public partial class MonitorIrtemperature
{
    [Key]
    [Column("IRTemperatureMonitorId")]
    public Guid IrtemperatureMonitorId { get; set; }

    [StringLength(50)]
    public string Description { get; set; } = null!;

    public byte Status { get; set; }

    [StringLength(100)]
    public string Owner { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public Guid RevisionGroup { get; set; }

    public int Revision { get; set; }

    public byte TableTarget { get; set; }

    [Unicode(false)]
    public string? Notes { get; set; }

    public int MinimumObjectSize { get; set; }

    public float CavityTempCompSlope { get; set; }

    public float CavityTempCompBias { get; set; }

    public float ClassificationMargin { get; set; }

    public float MinimumTemperatureThold { get; set; }

    public byte Section { get; set; }

    [InverseProperty("IrtemperatureMonitor")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
