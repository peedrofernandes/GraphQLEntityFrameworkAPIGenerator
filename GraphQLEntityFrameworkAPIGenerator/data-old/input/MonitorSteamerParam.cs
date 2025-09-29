using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class MonitorSteamerParam
{
    [Key]
    public Guid MonitorSteamerParamsId { get; set; }

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

    [Column(TypeName = "decimal(4, 1)")]
    public decimal FillPumpOnTime { get; set; }

    [Column(TypeName = "decimal(4, 1)")]
    public decimal FillPumpOffTime { get; set; }

    public int FillPumpOnTemp { get; set; }

    public int FillPumpDeltaTemp { get; set; }

    [Column(TypeName = "decimal(4, 1)")]
    public decimal DrainPumpOnTime { get; set; }

    public int SteamerTempUpperThreshold { get; set; }

    public int SteamerTempLowerThreshold { get; set; }

    [Column(TypeName = "decimal(4, 1)")]
    public decimal FillPumpOnTimeDescale { get; set; }

    public int DescaleTempUpperThreshold { get; set; }

    public int DescaleTempLowerThreshold { get; set; }

    [InverseProperty("MonitorSteamerParams")]
    public virtual ICollection<MonitorSteam> MonitorSteams { get; set; } = new List<MonitorSteam>();
}
