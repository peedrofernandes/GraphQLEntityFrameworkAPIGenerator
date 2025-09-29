using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("PrmGII2CInfraredToIRTemperature")]
public partial class PrmGii2cinfraredToIrtemperature
{
    [Key]
    public Guid Id { get; set; }

    public float Emissivity { get; set; }

    public float RemoveThresholdVdd { get; set; }

    public short DebounceThresholdVdd { get; set; }

    [Required]
    public bool? DissociateInputVdd { get; set; }

    public float RemoveThresholdTa { get; set; }

    public short DebounceThresholdTa { get; set; }

    [Required]
    public bool? DissociateInputTa { get; set; }

    public float RemoveThresholdTo { get; set; }

    public short DebounceThresholdTo { get; set; }

    [Required]
    public bool? DissociateInputTo { get; set; }

    public float IrCompensationCoefficient0 { get; set; }

    public float IrCompensationCoefficient1 { get; set; }

    public float IrCompensationCoefficient2 { get; set; }

    public float IrCompensationCoefficient3 { get; set; }

    public float IrCompensationCoefficient4 { get; set; }

    public float IrCompensationCoefficient5 { get; set; }

    public float IrCompensationCoefficient6 { get; set; }
}
