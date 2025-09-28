using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class MonitorCoilDeratingDetail
{
    [Key]
    public Guid MonitorCoilDeratingDetailsId { get; set; }

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

    [Required]
    public bool? EnableHeatsink { get; set; }

    [Required]
    public bool? EnableCoil { get; set; }

    public bool MonoGlobal { get; set; }

    [Required]
    public bool? MonoLocal { get; set; }

    public byte Version { get; set; }

    public byte PhaseTime { get; set; }

    public float TemperatureMinCoil { get; set; }

    public float TemperatureRefCoil { get; set; }

    public float TemperatureMaxCoil { get; set; }

    public float ControlDpCoil { get; set; }

    public float ControlDiCoil { get; set; }

    public byte MaxPercentSoft { get; set; }

    public byte MaxPercentHard { get; set; }

    public float TemperatureMinHeatsinkSoft { get; set; }

    public float TemperatureRefHeatsinkSoft { get; set; }

    public float TemperatureMaxHeatsinkSoft { get; set; }

    public float TemperatureMinHeatsinkHard { get; set; }

    public float TemperatureRefHeatsinkHard { get; set; }

    public float TemperatureMaxHeatsinkHard { get; set; }

    public float ControlDpHeatsinkSoft { get; set; }

    public float ControlDiHeatsinkHard { get; set; }

    public float ControlDpHeatsinkHard { get; set; }

    public float ControlDiHeatsinkSoft { get; set; }

    [InverseProperty("MonitorCoilDeratingDetails")]
    public virtual ICollection<MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail> MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetails { get; set; } = new List<MonitorCoilDeratingConfigurationsMonitorCoilDeratingDetail>();
}
