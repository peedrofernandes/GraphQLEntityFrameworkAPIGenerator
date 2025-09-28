using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("ApplianceConfiguration")]
public partial class ApplianceConfiguration
{
    [Key]
    [Column("ApplianceConfigurationID")]
    public Guid ApplianceConfigurationId { get; set; }

    public byte MinimumOnTime { get; set; }

    public byte MinimumOffTime { get; set; }

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

    [InverseProperty("ApplianceConfiguration")]
    public virtual ICollection<ApplianceConfigurationAppConfigCompartmentDetail> ApplianceConfigurationAppConfigCompartmentDetails { get; set; } = new List<ApplianceConfigurationAppConfigCompartmentDetail>();

    [InverseProperty("ApplianceConfiguration")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
