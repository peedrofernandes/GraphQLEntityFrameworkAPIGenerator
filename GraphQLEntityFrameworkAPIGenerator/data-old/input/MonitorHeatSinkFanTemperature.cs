using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorHeatSinkFanTemperature")]
public partial class MonitorHeatSinkFanTemperature
{
    [Key]
    public Guid MonitorHeatSinkFanTemperatureId { get; set; }

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

    public byte StructureVersion { get; set; }

    public byte PostMinimum { get; set; }

    public short PostTimeout { get; set; }

    public float Hysteresis { get; set; }

    public float SoftThreshold0 { get; set; }

    public float SoftThreshold1 { get; set; }

    public float SoftThreshold2 { get; set; }

    public float SoftThreshold3 { get; set; }

    public float SoftThreshold4 { get; set; }

    public float HardThreshold0 { get; set; }

    public float HardThreshold1 { get; set; }

    public float HardThreshold2 { get; set; }

    public float HardThreshold3 { get; set; }

    public float HardThreshold4 { get; set; }

    public float PostThreshold { get; set; }

    [InverseProperty("TemperatureDsp00ldNavigation")]
    public virtual ICollection<MonitorHeatSinkFan> MonitorHeatSinkFanTemperatureDsp00ldNavigations { get; set; } = new List<MonitorHeatSinkFan>();

    [InverseProperty("TemperatureDsp01ldNavigation")]
    public virtual ICollection<MonitorHeatSinkFan> MonitorHeatSinkFanTemperatureDsp01ldNavigations { get; set; } = new List<MonitorHeatSinkFan>();

    [InverseProperty("TemperatureDsp02ldNavigation")]
    public virtual ICollection<MonitorHeatSinkFan> MonitorHeatSinkFanTemperatureDsp02ldNavigations { get; set; } = new List<MonitorHeatSinkFan>();

    [InverseProperty("TemperatureDsp03ldNavigation")]
    public virtual ICollection<MonitorHeatSinkFan> MonitorHeatSinkFanTemperatureDsp03ldNavigations { get; set; } = new List<MonitorHeatSinkFan>();

    [InverseProperty("TemperatureDsp04ldNavigation")]
    public virtual ICollection<MonitorHeatSinkFan> MonitorHeatSinkFanTemperatureDsp04ldNavigations { get; set; } = new List<MonitorHeatSinkFan>();

    [InverseProperty("TemperatureDsp05ldNavigation")]
    public virtual ICollection<MonitorHeatSinkFan> MonitorHeatSinkFanTemperatureDsp05ldNavigations { get; set; } = new List<MonitorHeatSinkFan>();

    [InverseProperty("TemperatureDsp06ldNavigation")]
    public virtual ICollection<MonitorHeatSinkFan> MonitorHeatSinkFanTemperatureDsp06ldNavigations { get; set; } = new List<MonitorHeatSinkFan>();

    [InverseProperty("TemperatureDsp07ldNavigation")]
    public virtual ICollection<MonitorHeatSinkFan> MonitorHeatSinkFanTemperatureDsp07ldNavigations { get; set; } = new List<MonitorHeatSinkFan>();

    [InverseProperty("TemperatureDsp08ldNavigation")]
    public virtual ICollection<MonitorHeatSinkFan> MonitorHeatSinkFanTemperatureDsp08ldNavigations { get; set; } = new List<MonitorHeatSinkFan>();
}
