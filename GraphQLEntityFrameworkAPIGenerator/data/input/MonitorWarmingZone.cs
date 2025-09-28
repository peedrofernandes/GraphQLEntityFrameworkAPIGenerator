using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorWarmingZone")]
public partial class MonitorWarmingZone
{
    [Key]
    public Guid WarmingZoneParamsId { get; set; }

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

    public byte Version { get; set; }

    public byte DutyPeriod { get; set; }

    public byte StartTime { get; set; }

    public byte StopTime { get; set; }

    [InverseProperty("WarmingZoneParams")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
