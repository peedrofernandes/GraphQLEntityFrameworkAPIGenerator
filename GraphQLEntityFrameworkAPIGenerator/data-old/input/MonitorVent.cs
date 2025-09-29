using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorVent")]
public partial class MonitorVent
{
    [Key]
    public Guid MonitorVentId { get; set; }

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

    public byte NumberOfFans { get; set; }

    public int VentOffDelay { get; set; }

    public byte? FanLoad1 { get; set; }

    public byte? FanLoad2 { get; set; }

    public byte? FanLoad3 { get; set; }

    public byte? FanLoad4 { get; set; }

    [InverseProperty("MonitorVent")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
