using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorCoil")]
public partial class MonitorCoil
{
    [Key]
    public Guid MonitorCoilId { get; set; }

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

    public bool GlobalMainRelay { get; set; }

    public byte StructureVersion { get; set; }

    public byte CoilPanPresentDebounceTime { get; set; }

    public byte CoilHotSurfaceDebounceTime { get; set; }

    public byte MainRelayOpenDelayTime { get; set; }

    public byte CoilPanDetectionTimeout { get; set; }

    public float CoilHotSurfaceRaise { get; set; }

    public float CoilHotSurfaceClear { get; set; }

    public float CoilOvertemperatureRaise { get; set; }

    public float CoilOvertemperatureClear { get; set; }

    public float HeatsinkOvertemperatureRaise { get; set; }

    public float HeatsinkOvertemperatureClear { get; set; }

    [InverseProperty("MonitorCoil")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
