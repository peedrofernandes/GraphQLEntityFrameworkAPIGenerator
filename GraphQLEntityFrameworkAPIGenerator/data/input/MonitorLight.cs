using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("MonitorLight")]
public partial class MonitorLight
{
    [Key]
    public Guid LightConfigurationId { get; set; }

    public byte Version { get; set; }

    public bool NoFadingNeeded { get; set; }

    [Column("HMIDriverPresent")]
    public bool HmidriverPresent { get; set; }

    public bool DoorDriverPresent { get; set; }

    public bool CycleDriverPresent { get; set; }

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

    [Column("HMIFadeOn")]
    public float? HmifadeOn { get; set; }

    [Column("HMIFadeOff")]
    public float? HmifadeOff { get; set; }

    [Column("HMIMaximumIntensity")]
    public byte? HmimaximumIntensity { get; set; }

    [Column("HMIMinimumIntensity")]
    public byte? HmiminimumIntensity { get; set; }

    public float? DoorFadeOn { get; set; }

    public float? DoorFadeOff { get; set; }

    public byte? DoorMaximumIntensity { get; set; }

    public byte? DoorMinimumIntensity { get; set; }

    public float? CycleFadeOn { get; set; }

    public float? CycleFadeOff { get; set; }

    public byte? CycleMaximumIntensity { get; set; }

    public byte? CycleMinimumIntensity { get; set; }

    public int AutoOffTime { get; set; }

    public bool HmiToggleControl { get; set; }

    [InverseProperty("LightConfiguration")]
    public virtual ICollection<MachineConfiguration> MachineConfigurations { get; set; } = new List<MachineConfiguration>();
}
