using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class TimeEstimationConfiguration
{
    [Key]
    public Guid TimeEstimationConfigurationId { get; set; }

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

    [InverseProperty("TimeEstimationConfiguration")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();

    [InverseProperty("TimeEstimationConfiguration")]
    public virtual ICollection<TimeEstimationConfigurationsTimeEstimationDetail> TimeEstimationConfigurationsTimeEstimationDetails { get; set; } = new List<TimeEstimationConfigurationsTimeEstimationDetail>();
}
