using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("CycleOptionsPrmTemperature")]
public partial class CycleOptionsPrmTemperature
{
    [Key]
    public Guid TemperatureOptionsId { get; set; }

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

    public string? Notes { get; set; }

    public byte TemperatureSelectionBehavior { get; set; }

    [Column("UPO")]
    public bool Upo { get; set; }

    public float TemperatureSelectionCelsiusMinimum { get; set; }

    public float TemperatureSelectionCelsiusDefault { get; set; }

    public float TemperatureSelectionCelsiusMaximum { get; set; }

    public double MaximumStartTemperature { get; set; }

    public byte StepCelsius { get; set; }

    public byte StepFahrenheit { get; set; }

    public byte NumberOfSelections { get; set; }

    public float TemperatureSelection4 { get; set; }

    public float TemperatureSelection5 { get; set; }

    public float TemperatureSelection6 { get; set; }

    public byte Units { get; set; }

    public byte TemperatureSelectionName1 { get; set; }

    public byte TemperatureSelectionName2 { get; set; }

    public byte TemperatureSelectionName3 { get; set; }

    public byte TemperatureSelectionName4 { get; set; }

    public byte TemperatureSelectionName5 { get; set; }

    public byte TemperatureSelectionName6 { get; set; }

    [Required]
    public bool? ConfigureMaxTemp { get; set; }

    public byte TemperatureSelectionDefaultName { get; set; }

    [ForeignKey("TemperatureSelectionBehavior")]
    [InverseProperty("CycleOptionsPrmTemperatures")]
    public virtual CycleTemperatureOptionsBehaviorLabel TemperatureSelectionBehaviorNavigation { get; set; } = null!;
}
