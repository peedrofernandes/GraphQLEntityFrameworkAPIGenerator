using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class OpenDoorHeatingCyclesConfiguration
{
    [Key]
    public Guid OpenDoorHeatingCyclesConfigId { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

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

    [InverseProperty("OpenDoorHeatingCyclesConfig")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();

    [InverseProperty("OpenDoorHeatingCyclesConfig")]
    public virtual ICollection<OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail> OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetails { get; set; } = new List<OpenDoorHeatingCyclesConfigurationsOpenDoorHeatingCyclesDetail>();
}
