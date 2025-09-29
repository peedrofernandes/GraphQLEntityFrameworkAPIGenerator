using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WP.Cooking.GESE.WebAPI.Models;

[Table("AppConfigMicrowaveCompartment")]
public partial class AppConfigMicrowaveCompartment
{
    [Key]
    public Guid Id { get; set; }

    public byte RelayEnable { get; set; }

    public byte Dlb { get; set; }

    public byte TurnTable { get; set; }

    public byte Light { get; set; }

    public byte Grill1 { get; set; }

    public byte Bake { get; set; }

    public byte ForcedConvElement1 { get; set; }

    public byte ForcedConvFan1 { get; set; }

    public byte ForcedConvValve { get; set; }

    public byte Magnetron { get; set; }

    public byte CoolingFan1 { get; set; }

    public byte Temperature1 { get; set; }

    public byte HumiditySensor { get; set; }

    [Column("IRSensor")]
    public byte Irsensor { get; set; }
}
