using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorPowerReductionV2Configuration")]
public partial class MonitorPowerReductionV2configuration
{
    [Key]
    [Column("MonitorPowerReductionV2ConfigurationId")]
    public Guid MonitorPowerReductionV2configurationId { get; set; }

    public byte Version { get; set; }

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

    public byte NumberOfFanSpeeds { get; set; }

    public byte NumberOfEstimatedNodes { get; set; }

    public byte Load0 { get; set; }

    public byte Load1 { get; set; }

    public byte Load2 { get; set; }

    public byte Load3 { get; set; }

    public byte Load4 { get; set; }

    public byte Load5 { get; set; }

    public byte Compartment { get; set; }

    public byte NumberOfMeasuredNodes { get; set; }

    public byte NumberOfLoads { get; set; }

    public byte NumberOfOutputLoads { get; set; }

    public byte OutputLoad0 { get; set; }

    public byte OutputLoad1 { get; set; }

    public byte OutputLoad2 { get; set; }

    public byte OutputLoad3 { get; set; }

    public byte OutputLoad4 { get; set; }

    public byte CoolingFanId { get; set; }

    public bool EnableEmptyCrispPanDetection { get; set; }

    public bool UseDifferentTempThreshold { get; set; }

    public int CrispMaxTime { get; set; }

    [InverseProperty("MonitorPowerReductionV2configuration")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();

    [InverseProperty("MonitorPowerReductionV2configuration")]
    public virtual ICollection<MonitorPowerReductionV2configurationMonitorPowerReductionV2detail> MonitorPowerReductionV2configurationMonitorPowerReductionV2details { get; set; } = new List<MonitorPowerReductionV2configurationMonitorPowerReductionV2detail>();
}
