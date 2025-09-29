using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

public partial class AppConfigCompartmentDetail
{
    [Key]
    [Column("AppConfigCompartmentDetailsID")]
    public Guid AppConfigCompartmentDetailsId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public byte CompartmentType { get; set; }

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

    [Column("OvenMWCompartmentId")]
    public Guid? OvenMwcompartmentId { get; set; }

    public Guid? OvenCoolingFanCompId { get; set; }

    public bool HallEffectSensorPresent { get; set; }

    public byte BackupRestore { get; set; }

    [InverseProperty("AppConfigCompartmentDetails")]
    public virtual ICollection<ApplianceConfigurationAppConfigCompartmentDetail> ApplianceConfigurationAppConfigCompartmentDetails { get; set; } = new List<ApplianceConfigurationAppConfigCompartmentDetail>();

    [ForeignKey("OvenCoolingFanCompId")]
    [InverseProperty("AppConfigCompartmentDetails")]
    public virtual AppConfigCoolingFanCompartment? OvenCoolingFanComp { get; set; }

    [ForeignKey("OvenMwcompartmentId")]
    [InverseProperty("AppConfigCompartmentDetails")]
    public virtual AppConfigOvenMwcompartment? OvenMwcompartment { get; set; }
}
